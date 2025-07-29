# Classification Metrics Calculator

This project calculates and visualizes classification model evaluation metrics from confusion matrices, providing comprehensive analysis tools for machine learning model performance.

## 📋 Dependencies
```bash
pip install matplotlib numpy seaborn
```

## 🚀 Usage
```bash
python main.py
```

## 🔧 How it works

### Technical details
- **Accuracy**: (TP + TN) / (TP + TN + FP + FN) - Overall correctness
- **Sensitivity**: TP / (TP + FN) - Ability to identify positive cases
- **Specificity**: TN / (TN + FP) - Ability to identify negative cases  
- **Precision**: TP / (TP + FP) - Accuracy of positive predictions
- **F1-Score**: 2 × (Precision × Sensitivity) / (Precision + Sensitivity) - Harmonic mean

## 📊 Output

Displays three scenarios with metrics and visualizations:
- **Example 1**: Good performance scenario (TP:90, TN:80, FP:10, FN:5)
- **Example 2**: High false negatives scenario (TP:5, TN:90, FP:3, FN:20)
- **Example 3**: High false positives scenario (TP:80, TN:10, FP:30, FN:5)

Each scenario shows:
- Console output with calculated metrics
- Interactive confusion matrix heatmap