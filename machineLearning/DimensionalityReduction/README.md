# Image Dimensionality Reduction

This project demonstrates basic image processing techniques for dimensionality reduction, converting colored images to grayscale and then to binary images.

## 📋 Dependencies
```bash
pip install opencv-python matplotlib numpy
```

## 🚀 Usage
```bash
python main.py
```

## 🔧 How it works

The script performs three key transformations:

1. **Grayscale conversion**: Converts colored image to grayscale using weighted RGB values
2. **Otsu thresholding**: Automatically finds optimal threshold for binarization
3. **Binary image**: Creates black and white version with reduced dimensionality

### Technical details
- **Grayscale formula**: `gray = 0.114*B + 0.587*G + 0.299*R`
- **Otsu method**: Calculates optimal threshold by maximizing inter-class variance
- **Dimensionality reduction**: From 3 channels (RGB) → 1 channel (grayscale) → binary

## 📊 Output

Displays three images side by side:
- **Original**: Colored input image
- **Grayscale**: Monochromatic version
- **Binary**: Black and white with optimal threshold

## 🛠️ Customization

Uses `lena.png` as example. Replace with your own image:
```python
image_file = 'your_image.jpg'
```