import tensorflow as tf
from tensorflow.keras.preprocessing.sequence import pad_sequences
from tensorflow.keras.layers import Embedding, LSTM, Dense, Bidirectional
from tensorflow.keras.preprocessing.text import Tokenizer
from tensorflow.keras.models import Sequential
from tensorflow.keras.optimizers import Adam

import pickle

import json
import os
import numpy as np
import matplotlib.pyplot as plt

class Train:

    def __init__( self, dataset_directory=None, model_export_name=None, epoch_count = 100 ):

        self.epoch_count = epoch_count
        self.dataset_directory = dataset_directory
        self.model_export_name = model_export_name
        self.encoding = "utf8"

        # DECLERATIONS
        self.tokenizer = Tokenizer()
        self.model = Sequential()

        # TRAINING
        self.token_list = None
        self.tokenized_word_count = None
        self.xs = None
        self.labels = None
        self.ys = None
        self.max_sequence_len = None

    def _logger(self, message):
        print("-------")
        print(message)


    def _loadTrainingData( self ):
        data = open( self.dataset_directory, encoding= self.encoding ).read() #Read dataset from txt file.
        self._logger(f"Loading of training data: DONE!")
        return data.lower().split("\n") #Prepare data line by line


    def _tokenization( self ):
        
        self.tokenizer.fit_on_texts(self._loadTrainingData())

        self.tokenized_word_count = len(self.tokenizer.word_index) + 1
        self._logger(f"Tokenization: DONE with count: {self.tokenized_word_count}")
        
        # saving
        with open('tokenizer.pickle', 'wb') as handle:
            pickle.dump(self.tokenizer, handle, protocol=pickle.HIGHEST_PROTOCOL)
        #print(tokenizer.word_index)
        #print(total_words)


    def _sequenceBuilder( self ):
        input_sequences = []

        for line in self._loadTrainingData():
            self.token_list = self.tokenizer.texts_to_sequences([line])[0]
            for i in range(1, len(self.token_list)):
                n_gram_sequence = self.token_list[:i+1]
                input_sequences.append(n_gram_sequence)

        # pad sequences
        self.max_sequence_len = max([len(x) for x in input_sequences])
        print("max sequence len",self.max_sequence_len)
        input_sequences = np.array(pad_sequences(input_sequences, maxlen=self.max_sequence_len, padding='pre'))

        # create predictors and label
        self.xs, self.labels = input_sequences[:,:-1],input_sequences[:,-1]


    def _startTraining( self ):
        self.ys = tf.keras.utils.to_categorical(self.labels, num_classes=self.tokenized_word_count)

        self.model.add(Embedding(self.tokenized_word_count, 200, input_length=self.max_sequence_len-1))
        self.model.add(Bidirectional(LSTM(300)))
        self.model.add(Dense(self.tokenized_word_count, activation='softmax'))
        adam = Adam(learning_rate=0.01)
        self.model.compile(loss='categorical_crossentropy', optimizer=adam, metrics=['accuracy'])
        #earlystop = EarlyStopping(monitor='val_loss', min_delta=0, patience=5, verbose=0, mode='auto')
        history = self.model.fit(self.xs, self.ys, epochs=self.epoch_count, verbose=1)
        self._logger("---TRAINING DONE---")
        print(self.model.summary())

        self._plot_graphs(history=history, string="accuracy")
        #self.model.save('path')
    
    def _saveModel( self ):
        _prep_model_name = "saved_model/" + self.model_export_name
        self._logger("Model export status: RUNNING")
        self.model.save(_prep_model_name)
        self._logger("Model export status: DONE")

    def _plot_graphs(self, history, string):
        plt.plot(history.history[string])
        plt.xlabel("Epochs")
        plt.ylabel(string)
        plt.show()

    
    def Run( self ):
        self._tokenization()
        self._sequenceBuilder()
        self._startTraining()
        self._saveModel()
