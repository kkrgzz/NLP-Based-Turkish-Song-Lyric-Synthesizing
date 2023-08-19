# Turkish Folk Song Text Generator

This is a simple GUI app to generate text in the style of Turkish folk songs using a neural network model. 

## Overview

The app has a simple interface with a textbox for entering a prompt, a button to generate text, and a textbox to display the generated output.

Behind the scenes, it uses a recurrent neural network model trained on a dataset of Turkish folk song lyrics. The model learns the patterns and style of the lyrics during training. 

When the user enters a prompt, the app feeds it into the trained model to predict the next words and generate new lyrics inspired by the original dataset.

## Getting Started

### Prerequisites

- Python 3
- TensorFlow, Keras
- PyQt5

### Usage

- Clone the repo
- Install requirements
- Run `python main.py` to launch the app

### Model Training

The model code and training process is in `Trainer.py`. It tokenizes the text data, trains a LSTM model on sequence data, and saves the trained model.

Key parameters:

- `dataset_directory`: Path to dataset text file
- `model_export_name`: Name for saved model
- `epoch_count`: Number of training epochs 

## Customizing

- The prompt fed to the model can be customized by changing the `promptTextBox` in `main.py`
- The generated output length can be changed by modifying `word_count` in `Controller.py`
- New datasets can be used by changing `dataset_directory` in `Trainer.py`

## Future Improvements

- Add more datasets to training for more variety
- Experiment with model architectures like GRU, CNN 
- Implement beam search for better quality text generation
- Add a web interface instead of desktop app
