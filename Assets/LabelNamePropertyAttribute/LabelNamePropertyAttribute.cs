using UnityEngine;

public class LabelNamePropertyAttribute : PropertyAttribute
{
    public string propertyName;
    public LabelNamePropertyAttribute(string propertyName) { this.propertyName = propertyName; }
}