# 🧠 Transfer Learning for Binary Image Classification

This project implements **Transfer Learning** to classify images into two categories using a pre-trained model. The dataset used is **"Horse or Human"**, which is downloaded automatically within the notebook.

## 📋 Dependencies
```bash
pip install tensorflow keras numpy pandas matplotlib scipy
```

*Note: Dependencies are automatically installed in the first cell of the notebook.*

## 🚀 Usage
```bash
jupyter notebook main.ipynb
```

## 🔧 How it works

The notebook performs three key steps:

1. **Data preparation**: Downloads and preprocesses horse/human images with data augmentation
2. **Model setup**: Uses pre-trained VGG16 as feature extractor with custom classification layers
3. **Training**: Fine-tunes the model for binary classification (horse vs human)

### Technical details
- **Base model**: VGG16 pre-trained on ImageNet (frozen layers)
- **Custom layers**: Flatten + Dense(256) + Dropout(0.5) + Dense(1, sigmoid)
- **Data augmentation**: Rotation, shifts, zoom, horizontal flip
- **Training**: 10 epochs with binary crossentropy loss

## 📊 Output

- **Training plots**: Accuracy and loss curves for training/validation
- **Model evaluation**: Final accuracy metrics
- **Prediction function**: Test custom images (horse.jpg included)

## 🛠️ Customization

Uses `horse.jpg` as example. Replace with your own image:
```python
predict_image('your_image.jpg')
```
