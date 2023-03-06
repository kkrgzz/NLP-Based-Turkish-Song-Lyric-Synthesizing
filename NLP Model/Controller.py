import os
import pickle
import json

import numpy as np
import tensorflow as tf
from tensorflow.keras.preprocessing.text import Tokenizer, tokenizer_from_json
from tensorflow.keras.preprocessing.sequence import pad_sequences

class Control:
    def __init__(self):
        self.dir_dataset = "./train-data.txt"

        # MODEL - EXPORT DECLERATIONS
        self.dir_model_export_name = "example"
        self.dir_default_model_path = "./saved_model"

        # MODEL - INPUT DECLERATIONS
        self.dir_model_path = "./saved_model/example"
        self.dir_tokenizer_path = "tokenizer.pickle"

        self.model = None
        self.model_existance_status = False
        self.is_model_loaded = False
    
    def _startTraining( self ):
        import Trainer
        self.train = Trainer.Train(
            dataset_directory = self.dir_dataset, 
            model_export_name= self.dir_model_export_name,
            epoch_count=100)
        self.train.Run()


    def _checkForModel( self ):
        if os.path.exists( self.dir_default_model_path ):
            return True
        else:
            return False


    def _getTokenizer( self ):
        with open( self.dir_tokenizer_path, 'rb' ) as handle:
            self.tokenizer = pickle.load(handle)

        return self.tokenizer


    def _loadModel( self, _path ):
        self.model = tf.keras.models.load_model( _path )
        print("Model Loaded")
        print(self.model.summary())
        return True


    def _prompt( self, prompt, word_count ):
        seed_text = prompt
        next_words = word_count
        for _ in range(next_words):
            token_list = self._getTokenizer().texts_to_sequences([seed_text])[0]
            token_list = pad_sequences([token_list], maxlen=14, padding='pre')
            predicted = np.argmax( self.model.predict(token_list), axis=-1 )

            output_word = ""
            for word, index in self._getTokenizer().word_index.items():
                if index == predicted:
                    output_word = word
                    break

            if output_word != "anlatıyor" and output_word != "söylüyor" and output_word != "vurguluyor":
                seed_text += " " + output_word

        return seed_text


    def Run( self, prompt, word_count ):
        model_existance_status = self._checkForModel()
            
        if model_existance_status:
            print("Model Already Exists!")
            print("Model Loading...")
            is_model_loaded = self._loadModel( self.dir_model_path )
        else:
            print("Model does not exists!")
            self._startTraining()

        if is_model_loaded:
            return self._prompt( prompt, word_count )
