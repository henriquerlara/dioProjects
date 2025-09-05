# 🛡️ YOLO Helmet Detection Training

This project trains a **YOLOv8** detector to identify three classes: `head`, `helmet`, and `person`, using the Kaggle dataset "Hard Hat Detection". The notebook downloads the dataset via Kaggle API, converts VOC XML annotations to YOLO format, builds train/val splits, generates `data.yaml`, and runs training.

## 📋 Dependencies
```bash
pip install ultralytics kaggle
```

Note: The notebook installs these automatically in the first cell.

## 🚀 Usage
```bash
jupyter notebook main.ipynb
```

## 🔧 How it works

The notebook performs the following steps:

1. **Dataset download**: Authenticates with Kaggle using `kaggle.json` and downloads "Hard Hat Detection"
2. **Annotation conversion**: Converts PASCAL VOC XML annotations to YOLO TXT format
3. **Split**: Random 80/20 split into `train` and `val`
4. **Config**: Generates `data.yaml` with dataset paths, class names and count
5. **Training**: Trains `yolov8n.pt` on the prepared dataset
6. **Inference**: Runs a quick prediction on a validation image

### Technical details
- **Classes**: `head`, `helmet`, `person` (nc = 3)
- **Image size**: 640
- **Batch size**: 16
- **Epochs**: 10
- **Dataset structure**: `dataset_yolo/images/{train,val}` and `dataset_yolo/labels/{train,val}`
- **Config file**: `data.yaml` points to the prepared dataset

## 📊 Output

Training artifacts (plots, logs, and weights like `best.pt`) are saved under the `results` folder specified in the notebook.

Quick prediction example (after training):
```python
from ultralytics import YOLO

model = YOLO('results/train/weights/best.pt')
model.predict('dataset_yolo/images/val/hard_hat_workers11.png', show=True)
```

## 🛠️ Customization

- **Model size**: swap to `yolov8s.pt`, `yolov8m.pt`, etc.
- **Hyperparameters**: adjust `epochs`, `batch`, `imgsz` in the training cell
- **Dataset**: replace with your own and update `data.yaml`
- **Kaggle credentials**: place `kaggle.json` in this folder; the notebook copies it to `~/.kaggle/`


