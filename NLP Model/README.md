# Text Generation Project NLP Model

This project trains a neural network model to generate text in the style of Turkish folk songs.

## Getting Started

These instructions will help you set up and train the text generation model on your local machine.

### Prerequisites

You will need to have Python 3 and the following Python libraries installed:

- TensorFlow 
- Keras
- Numpy
- Matplotlib

### Data

The model is trained on a dataset of Turkish folk song lyrics in the `train-data.txt` file. Each line contains one lyric.

### Preprocessing

The lyrics are preprocessed by:

- Converting to lowercase
- Tokenizing into sequences of words/tokens using `Tokenizer` from Keras
- Padding sequences to a max length
- Creating input and target sequences

### Model

The model is defined in `Trainer.py` and has the following architecture:

- Embedding layer 
- Bidirectional LSTM layer
- Fully connected output layer with softmax activation

It is trained for a defined number of epochs with the Adam optimizer and categorical crossentropy loss.

### Training

To train the model:

1. Update the parameters in `Controller.py` (dataset path, model name etc.)

2. Run `python Controller.py`

This will tokenize the data, build and train the model, and save it to the `saved_model` folder. 

 ### Generating Text
 
 To generate text using the trained model:
 
 1. Pass a seed text prompt to the `_prompt` method in the `Controller` class 
 2. Specify the number of words to generate
 3. The model will predict the next word and add it to the seed text

### Improvements

Some ways to improve the model:

- Try different model architectures like GRU or convolutional layers
- Experiment with different hyperparameters like layer sizes, learning rate etc.  
- Use a larger or more varied dataset
- Implement beam search for generating text
- Add attention mechanism

## Authors

- [Kemal Karagöz]
