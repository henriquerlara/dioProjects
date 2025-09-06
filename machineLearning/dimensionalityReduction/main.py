# Requirements:
# pip install opencv-python matplotlib numpy

import cv2
import numpy as np
import matplotlib.pyplot as plt

def process_image(image_path):
    try:
        img_original = cv2.imread(image_path)
        if img_original is None:
            raise FileNotFoundError(f"Could not load the image from: {image_path}")

        # cv2.COLOR_BGR2GRAY converts from BGR to grayscale using a weighted average: 
        # gray = 0.114*B + 0.587*G + 0.299*R (human eye is more sensitive to green)
        img_gray = cv2.cvtColor(img_original, cv2.COLOR_BGR2GRAY)

        # cv2.threshold returns two values: ret (threshold used) and the thresholded image (img_binary)
        # THRESH_BINARY creates a binary image: pixels above the threshold are 255, below are 0
        # THRESH_OTSU automatically calculates the best threshold
        ret, img_binary = cv2.threshold(img_gray, 0, 255, cv2.THRESH_BINARY + cv2.THRESH_OTSU)

        plt.figure(figsize=(15, 5))

        plt.subplot(1, 3, 1)
        plt.imshow(cv2.cvtColor(img_original, cv2.COLOR_BGR2RGB))  # Convert BGR to RGB for Matplotlib
        plt.title('Original Image')
        plt.axis('off')

        plt.subplot(1, 3, 2)
        plt.imshow(img_gray, cmap='gray')
        plt.title('Grayscale Image')
        plt.axis('off')

        plt.subplot(1, 3, 3)
        plt.imshow(img_binary, cmap='gray')
        plt.title('Binary Image')
        plt.axis('off')

        plt.tight_layout()
        plt.show()

    except Exception as e:
        print(f"Erro: {e}")

image_file = 'lena.png'
process_image(image_file)
