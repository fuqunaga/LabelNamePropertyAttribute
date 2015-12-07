using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomPropertyDrawer(typeof(LabelNamePropertyAttribute))]
public class LabelNamePropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty prop, GUIContent label)
    {
        var attr = (LabelNamePropertyAttribute)attribute;

        var prefabProp = prop.FindPropertyRelative(attr.propertyName);
        var name = prefabProp.objectReferenceValue ? prefabProp.objectReferenceValue.name : "None";

        EditorGUI.PropertyField(position, prop, new GUIContent(name), true);
    }

    public override float GetPropertyHeight(SerializedProperty prop, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(prop, label, true);
    }
}
