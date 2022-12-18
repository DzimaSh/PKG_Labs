import cv2 as cv
from tkinter import *
from PIL import ImageTk, Image


class MainSolution():
    def __init__(self):
        self.image = cv.imread("imageee.jpg")
        self.imgray = None
        self.trsh1 = None
        self.trsh2 = None

    def original(self):
        img = Image.fromarray(self.image)
        img = img.resize((300, 300))
        return ImageTk.PhotoImage(img)


    def filt(self):
        self.imgray = cv.cvtColor(cv.pyrMeanShiftFiltering(
            self.image, 15, 50), cv.COLOR_BGR2GRAY)
        img = Image.fromarray(self.imgray)
        img = img.resize((300, 300))
        return ImageTk.PhotoImage(img)

    def morph(self):
        self.imgray = cv.cvtColor(cv.pyrMeanShiftFiltering(
            self.image, 15, 50), cv.COLOR_BGR2GRAY)
        img = Image.fromarray(cv.morphologyEx(self.imgray, cv.MORPH_OPEN, cv.getStructuringElement(cv.MORPH_ELLIPSE, (5, 5))))
        img = img.resize((300, 300))
        return ImageTk.PhotoImage(img)

    def binary(self):
        self.imgray = cv.cvtColor(cv.pyrMeanShiftFiltering(
            self.image, 15, 50), cv.COLOR_BGR2GRAY)
        self.trsh1 = cv.adaptiveThreshold(self.imgray, 255, cv.ADAPTIVE_THRESH_MEAN_C, cv.THRESH_BINARY, 11, 2)
        img = Image.fromarray(self.trsh1)
        img = img.resize((300, 300))
        return ImageTk.PhotoImage(img)

    def prewitt(self):
        self.imgray = cv.cvtColor(cv.pyrMeanShiftFiltering(
            self.image, 15, 50), cv.COLOR_BGR2GRAY)
        self.trsh1 = cv.adaptiveThreshold(self.imgray, 255, cv.ADAPTIVE_THRESH_MEAN_C, cv.THRESH_BINARY, 11, 2)
        img = Image.fromarray(cv.Sobel(self.trsh1, cv.CV_64F, 1, 0, ksize=5))
        img = img.resize((300, 300))
        return ImageTk.PhotoImage(img)

    def sobel(self):
        self.imgray = cv.cvtColor(cv.pyrMeanShiftFiltering(
            self.image, 15, 50), cv.COLOR_BGR2GRAY)
        self.trsh1 = cv.adaptiveThreshold(self.imgray, 255, cv.ADAPTIVE_THRESH_MEAN_C, cv.THRESH_BINARY, 11, 2)
        img = Image.fromarray(cv.Sobel(self.trsh1, cv.CV_64F, 1, 1, ksize=5))
        img = img.resize((300, 300))
        return ImageTk.PhotoImage(img)

    def canny(self):
        self.imgray = cv.cvtColor(cv.pyrMeanShiftFiltering(
            self.image, 15, 50), cv.COLOR_BGR2GRAY)
        self.trsh1 = cv.adaptiveThreshold(self.imgray, 255, cv.ADAPTIVE_THRESH_MEAN_C, cv.THRESH_BINARY, 11, 2)
        img = Image.fromarray(cv.Canny(self.trsh1, 100, 200))
        img = img.resize((300, 300))
        return ImageTk.PhotoImage(img)

class Gui:
    def __init__(self, master):
        self.master = master
        self.master.title("Image Processing")
        self.master.geometry("1440x820")
        self.master.resizable(False, False)
        self.master.configure(background="silver")

        self.solution = MainSolution()

        self.frame = Frame(self.master, bg="white")
        self.frame.pack()

        self.label = Label(self.frame, text="Image Processing", font=("Arial", 20), bg="silver")
        self.label.grid(row=0, column=0, columnspan=2, pady=10)

        self.button1 = Button(self.frame, text="Original Image", font=("Arial", 12), bg="white",
                              command=self.original_image)
        self.button1.grid(row=1, column=0, pady=10)

        self.button2 = Button(self.frame, text="Filter", font=("Arial", 12), bg="white",
                                command=self.filter_image)
        self.button2.grid(row=1, column=1, pady=10)

        self.button3 = Button(self.frame, text="Morphology", font=("Arial", 12), bg="white",
                                command=self.morph_image)
        self.button3.grid(row=1, column=2, pady=10)

        self.button4 = Button(self.frame, text="Binary", font=("Arial", 12), bg="white",
                                command=self.binary_image)
        self.button4.grid(row=1, column=3, pady=10)

        self.button5 = Button(self.frame, text="Prewitt", font=("Arial", 12), bg="white",
                                command=self.prewitt_image)
        self.button5.grid(row=1, column=4, pady=10)

        self.button6 = Button(self.frame, text="Sobel", font=("Arial", 12), bg="white",
                                command=self.sobel_image)
        self.button6.grid(row=1, column=5, pady=10)

        self.button7 = Button(self.frame, text="Canny", font=("Arial", 12), bg="white",
                                command=self.canny_image)
        self.button7.grid(row=1, column=6, pady=10)

        self.button8 = Button(self.frame, text="Exit", font=("Arial", 12), bg="white",
                                command=self.exit)
        self.button8.grid(row=1, column=7, pady=10)

        self.label1 = Label(self.frame, text="Original Image", font=("Arial", 12), bg="white")
        self.label1.grid(row=10, column=0, pady=10)

        self.label2 = Label(self.frame, text="Processed Image", font=("Arial", 12), bg="white")
        self.label2.grid(row=10, column=0, pady=10)

        self.image1 = self.solution.original()
        self.label3 = Label(self.frame, image=self.image1, bg="white")
        self.label3.grid(row=8, column=0, pady=10)

        self.image2 = self.solution.original()
        self.label4 = Label(self.frame, image=self.image2, bg="white")
        self.label4.grid(row=8, column=1, pady=10)

    def original_image(self):
        self.image1 = self.solution.original()
        self.label3.configure(image=self.image1)
        self.label3.image = self.image1

    def filter_image(self):
        self.image2 = self.solution.filt()
        self.label4.configure(image=self.image2)
        self.label4.image = self.image2

    def morph_image(self):
        self.image2 = self.solution.morph()
        self.label4.configure(image=self.image2)
        self.label4.image = self.image2

    def binary_image(self):
        self.image2 = self.solution.binary()
        self.label4.configure(image=self.image2)
        self.label4.image = self.image2

    def prewitt_image(self):
        self.image2 = self.solution.prewitt()
        self.label4.configure(image=self.image2)
        self.label4.image = self.image2

    def sobel_image(self):
        self.image2 = self.solution.sobel()
        self.label4.configure(image=self.image2)
        self.label4.image = self.image2

    def canny_image(self):
        self.image2 = self.solution.canny()
        self.label4.configure(image=self.image2)
        self.label4.image = self.image2

    def exit(self):
        self.master.destroy()

if __name__ == "__main__":
    root = Tk()
    Gui(root)
    root.mainloop()

