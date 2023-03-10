# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'main.ui'
#
# Created by: PyQt5 UI code generator 5.15.7
#
# WARNING: Any manual changes made to this file will be lost when pyuic5 is
# run again.  Do not edit this file unless you know what you are doing.


from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_MainWindow(object):
    def setupUi(self, MainWindow):
        MainWindow.setObjectName("MainWindow")
        MainWindow.resize(418, 640)
        icon = QtGui.QIcon()
        icon.addPixmap(QtGui.QPixmap(":/icon/ai.ico"), QtGui.QIcon.Normal, QtGui.QIcon.Off)
        MainWindow.setWindowIcon(icon)
        MainWindow.setStyleSheet("background-color: #3D3657;")
        self.centralwidget = QtWidgets.QWidget(MainWindow)
        self.centralwidget.setObjectName("centralwidget")
        self.verticalLayoutWidget = QtWidgets.QWidget(self.centralwidget)
        self.verticalLayoutWidget.setGeometry(QtCore.QRect(10, 10, 401, 561))
        self.verticalLayoutWidget.setObjectName("verticalLayoutWidget")
        self.verticalLayout = QtWidgets.QVBoxLayout(self.verticalLayoutWidget)
        self.verticalLayout.setContentsMargins(0, 0, 0, 0)
        self.verticalLayout.setObjectName("verticalLayout")
        self.label = QtWidgets.QLabel(self.verticalLayoutWidget)
        self.label.setMaximumSize(QtCore.QSize(16777215, 30))
        self.label.setStyleSheet("color:#ffffff;")
        self.label.setObjectName("label")
        self.verticalLayout.addWidget(self.label)
        self.promptTextBox = QtWidgets.QLineEdit(self.verticalLayoutWidget)
        self.promptTextBox.setMinimumSize(QtCore.QSize(0, 30))
        self.promptTextBox.setStyleSheet("background-color: #fcf7f4;")
        self.promptTextBox.setObjectName("promptTextBox")
        self.verticalLayout.addWidget(self.promptTextBox)
        self.confirmButton = QtWidgets.QPushButton(self.verticalLayoutWidget)
        self.confirmButton.setMinimumSize(QtCore.QSize(0, 30))
        font = QtGui.QFont()
        font.setFamily("Arial")
        font.setPointSize(9)
        font.setBold(False)
        font.setItalic(False)
        font.setWeight(50)
        font.setKerning(True)
        self.confirmButton.setFont(font)
        self.confirmButton.setStyleSheet("background-color: #C7B4EC;\n"
"color: #121212;\n"
"")
        self.confirmButton.setObjectName("confirmButton")
        self.verticalLayout.addWidget(self.confirmButton)
        self.line = QtWidgets.QFrame(self.verticalLayoutWidget)
        self.line.setFrameShape(QtWidgets.QFrame.HLine)
        self.line.setFrameShadow(QtWidgets.QFrame.Sunken)
        self.line.setObjectName("line")
        self.verticalLayout.addWidget(self.line)
        self.label_2 = QtWidgets.QLabel(self.verticalLayoutWidget)
        self.label_2.setMaximumSize(QtCore.QSize(16777215, 30))
        self.label_2.setStyleSheet("color:#ffffff;")
        self.label_2.setObjectName("label_2")
        self.verticalLayout.addWidget(self.label_2)
        self.resultTextBox = QtWidgets.QPlainTextEdit(self.verticalLayoutWidget)
        self.resultTextBox.setStyleSheet("background-color: #fcf7f4;")
        self.resultTextBox.setObjectName("resultTextBox")
        self.verticalLayout.addWidget(self.resultTextBox)
        MainWindow.setCentralWidget(self.centralwidget)
        self.menubar = QtWidgets.QMenuBar(MainWindow)
        self.menubar.setGeometry(QtCore.QRect(0, 0, 418, 21))
        self.menubar.setObjectName("menubar")
        MainWindow.setMenuBar(self.menubar)
        self.statusbar = QtWidgets.QStatusBar(MainWindow)
        self.statusbar.setObjectName("statusbar")
        MainWindow.setStatusBar(self.statusbar)

        self.retranslateUi(MainWindow)
        QtCore.QMetaObject.connectSlotsByName(MainWindow)

    def retranslateUi(self, MainWindow):
        _translate = QtCore.QCoreApplication.translate
        MainWindow.setWindowTitle(_translate("MainWindow", "Song Generator"))
        self.label.setText(_translate("MainWindow", "Enter your prompt:"))
        self.promptTextBox.setPlaceholderText(_translate("MainWindow", "Imagine something"))
        self.confirmButton.setText(_translate("MainWindow", "Confirm"))
        self.label_2.setText(_translate("MainWindow", "Result:"))
import resc_rc
