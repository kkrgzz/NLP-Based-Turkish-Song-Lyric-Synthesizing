import sys
from PyQt5 import QtWidgets
from PyQt5.QtWidgets import *
from theme import *
import random


from Controller import Control


application = QApplication(sys.argv)
window = QMainWindow()
ui = Ui_MainWindow()

ui.setupUi(window)
window.show()

def prompt():
    getPredict()

def getPredict():
    predict = Control().Run(ui.promptTextBox.text(), 100)
    
    predict.replace("vurgulanmıştır", " ")
    predict.replace("vurgulamaktadır", " ")
    predict = predict.split()
    
    temp_sentence = ""
    word_in_line_counter = 0
    for word in predict:
        temp_sentence = temp_sentence + " " + word
        if (word_in_line_counter >= random.randint(3,12)):
            temp_sentence = temp_sentence + "\n"
            word_in_line_counter = 0
        
        word_in_line_counter += 1

    ui.resultTextBox.setPlainText(temp_sentence)

ui.confirmButton.clicked.connect(prompt)



sys.exit(application.exec_())