# Requirements:
# pip install matplotlib numpy seaborn

import math
import matplotlib.pyplot as plt
import numpy as np
import seaborn as sns


def plot_confusion_matrix(tp, tn, fp, fn, title="Confusion Matrix"):
    """
    Plots a confusion matrix heatmap.

    Args:
        tp (int): True Positives
        tn (int): True Negatives
        fp (int): False Positives
        fn (int): False Negatives
        title (str): Title for the plot
    """
    cm = np.array([[tn, fp], [fn, tp]])

    plt.figure(figsize=(8, 6))

    sns.heatmap(
        cm,
        annot=True,
        fmt="d",
        cmap="Blues",
        xticklabels=["Predicted Negative", "Predicted Positive"],
        yticklabels=["Actual Negative", "Actual Positive"],
    )

    plt.title(title)
    plt.ylabel("Actual")
    plt.xlabel("Predicted")
    plt.tight_layout()
    plt.show()


def calculate_metrics(tp, tn, fp, fn):
    """
    Calculates classification model evaluation metrics
    from a confusion matrix.

    Args:
        tp (int): True Positives
        tn (int): True Negatives
        fp (int): False Positives
        fn (int): False Negatives

    Returns:
        dict: A dictionary containing the calculated metric values.
    """

    total = tp + tn + fp + fn
    if total == 0:
        print("Error: Total elements is zero, cannot calculate metrics.")
        return {}

    # Accuracy
    accuracy = (tp + tn) / total

    # Sensitivity (Recall)
    sensitivity_denominator = tp + fn
    sensitivity = tp / sensitivity_denominator if sensitivity_denominator != 0 else 0.0

    # Specificity
    specificity_denominator = tn + fp
    specificity = tn / specificity_denominator if specificity_denominator != 0 else 0.0

    # Precision
    precision_denominator = tp + fp
    precision = tp / precision_denominator if precision_denominator != 0 else 0.0

    # F1-Score
    # F1-Score can only be calculated if Precision and Sensitivity are valid
    f1_score = 0.0
    if precision + sensitivity != 0:
        f1_score = 2 * (precision * sensitivity) / (precision + sensitivity)

    metrics = {
        "Accuracy": accuracy,
        "Sensitivity (Recall)": sensitivity,
        "Specificity": specificity,
        "Precision": precision,
        "F1-Score": f1_score,
    }

    return metrics


# Example Usage
print("--- Classification Metrics Calculator ---")

# Example 1: A good scenario
tp_example1 = 90
tn_example1 = 80
fp_example1 = 10
fn_example1 = 5

print("\nCalculating for Example 1 (Arbitrary Scenario 1):")
print(f"TP: {tp_example1}, TN: {tn_example1}, FP: {fp_example1}, FN: {fn_example1}")
results_example1 = calculate_metrics(tp_example1, tn_example1, fp_example1, fn_example1)

if results_example1:
    for metric, value in results_example1.items():
        print(f"- {metric}: {value:.4f}")

plot_confusion_matrix(
    tp_example1,
    tn_example1,
    fp_example1,
    fn_example1,
    "Example 1: Good Performance Scenario",
)

print("-" * 50)

# Example 2: A scenario with few actual positives (high FN)
tp_example2 = 5
tn_example2 = 90
fp_example2 = 3
fn_example2 = 20

print("\nCalculating for Example 2 (Arbitrary Scenario 2 - More False Negatives):")
print(f"TP: {tp_example2}, TN: {tn_example2}, FP: {fp_example2}, FN: {fn_example2}")
results_example2 = calculate_metrics(tp_example2, tn_example2, fp_example2, fn_example2)

if results_example2:
    for metric, value in results_example2.items():
        print(f"- {metric}: {value:.4f}")

plot_confusion_matrix(
    tp_example2,
    tn_example2,
    fp_example2,
    fn_example2,
    "Example 2: High False Negatives Scenario",
)

print("-" * 50)

# Example 3: A scenario with few actual negatives (high FP)
tp_example3 = 80
tn_example3 = 10
fp_example3 = 30
fn_example3 = 5

print("\nCalculating for Example 3 (Arbitrary Scenario 3 - More False Positives):")
print(f"TP: {tp_example3}, TN: {tn_example3}, FP: {fp_example3}, FN: {fn_example3}")
results_example3 = calculate_metrics(tp_example3, tn_example3, fp_example3, fn_example3)

if results_example3:
    for metric, value in results_example3.items():
        print(f"- {metric}: {value:.4f}")

plot_confusion_matrix(
    tp_example3,
    tn_example3,
    fp_example3,
    fn_example3,
    "Example 3: High False Positives Scenario",
)