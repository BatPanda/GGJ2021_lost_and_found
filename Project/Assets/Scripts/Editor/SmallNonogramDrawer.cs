using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SmallNonogramStruct))]
class SmallNonogramDrawer : PropertyDrawer
{
    private SerializedProperty p_00;
    private SerializedProperty p_01;
    private SerializedProperty p_02;
    private SerializedProperty p_03;
    private SerializedProperty p_04;

    private SerializedProperty p_10;
    private SerializedProperty p_11;
    private SerializedProperty p_12;
    private SerializedProperty p_13;
    private SerializedProperty p_14;

    private SerializedProperty p_20;
    private SerializedProperty p_21;
    private SerializedProperty p_22;
    private SerializedProperty p_23;
    private SerializedProperty p_24;

    private SerializedProperty p_30;
    private SerializedProperty p_31;
    private SerializedProperty p_32;
    private SerializedProperty p_33;
    private SerializedProperty p_34;

    private SerializedProperty p_40;
    private SerializedProperty p_41;
    private SerializedProperty p_42;
    private SerializedProperty p_43;
    private SerializedProperty p_44;

    private static string k_00 = "b00";
    private static string k_01 = "b01";
    private static string k_02 = "b02";
    private static string k_03 = "b03";
    private static string k_04 = "b04";
                                  
    private static string k_10 = "b10";
    private static string k_11 = "b11";
    private static string k_12 = "b12";
    private static string k_13 = "b13";
    private static string k_14 = "b14";
                                  
    private static string k_20 = "b20";
    private static string k_21 = "b21";
    private static string k_22 = "b22";
    private static string k_23 = "b23";
    private static string k_24 = "b24";
                                  
    private static string k_30 = "b30";
    private static string k_31 = "b31";
    private static string k_32 = "b32";
    private static string k_33 = "b33";
    private static string k_34 = "b34";
                                  
    private static string k_40 = "b40";
    private static string k_41 = "b41";
    private static string k_42 = "b42";
    private static string k_43 = "b43";
    private static string k_44 = "b44";

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
        return (EditorGUIUtility.singleLineHeight * 5);
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        EditorGUI.BeginProperty(position, label, property);

        p_00 = property.FindPropertyRelative(k_00);
        p_01 = property.FindPropertyRelative(k_01);
        p_02 = property.FindPropertyRelative(k_02);
        p_03 = property.FindPropertyRelative(k_03);
        p_04 = property.FindPropertyRelative(k_04);

        p_10 = property.FindPropertyRelative(k_10);
        p_11 = property.FindPropertyRelative(k_11);
        p_12 = property.FindPropertyRelative(k_12);
        p_13 = property.FindPropertyRelative(k_13);
        p_14 = property.FindPropertyRelative(k_14);

        p_20 = property.FindPropertyRelative(k_20);
        p_21 = property.FindPropertyRelative(k_21);
        p_22 = property.FindPropertyRelative(k_22);
        p_23 = property.FindPropertyRelative(k_23);
        p_24 = property.FindPropertyRelative(k_24);

        p_30 = property.FindPropertyRelative(k_30);
        p_31 = property.FindPropertyRelative(k_31);
        p_32 = property.FindPropertyRelative(k_32);
        p_33 = property.FindPropertyRelative(k_33);
        p_34 = property.FindPropertyRelative(k_34);

        p_40 = property.FindPropertyRelative(k_40);
        p_41 = property.FindPropertyRelative(k_41);
        p_42 = property.FindPropertyRelative(k_42);
        p_43 = property.FindPropertyRelative(k_43);
        p_44 = property.FindPropertyRelative(k_44);

        Rect r_fields = EditorGUI.PrefixLabel(position, label);
        Rect r_00 = new Rect(r_fields.xMin, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_01 = new Rect(r_00.xMin+15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_02 = new Rect(r_01.xMin+15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_03 = new Rect(r_02.xMin+15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_04 = new Rect(r_03.xMin+15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);

        Rect r_10 = new Rect(r_fields.xMin, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_11 = new Rect(r_00.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_12 = new Rect(r_01.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_13 = new Rect(r_02.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_14 = new Rect(r_03.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_20 = new Rect(r_fields.xMin, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_21 = new Rect(r_00.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_22 = new Rect(r_01.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_23 = new Rect(r_02.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_24 = new Rect(r_03.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_30 = new Rect(r_fields.xMin, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_31 = new Rect(r_00.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_32 = new Rect(r_01.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_33 = new Rect(r_02.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_34 = new Rect(r_03.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_40 = new Rect(r_fields.xMin, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_41 = new Rect(r_00.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_42 = new Rect(r_01.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_43 = new Rect(r_02.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_44 = new Rect(r_03.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        EditorGUI.BeginChangeCheck();

        p_00.boolValue = EditorGUI.Toggle(r_00, p_00.boolValue);
        p_01.boolValue = EditorGUI.Toggle(r_01, p_01.boolValue);
        p_02.boolValue = EditorGUI.Toggle(r_02, p_02.boolValue);
        p_03.boolValue = EditorGUI.Toggle(r_03, p_03.boolValue);
        p_04.boolValue = EditorGUI.Toggle(r_04, p_04.boolValue);

        p_10.boolValue = EditorGUI.Toggle(r_10, p_10.boolValue);
        p_11.boolValue = EditorGUI.Toggle(r_11, p_11.boolValue);
        p_12.boolValue = EditorGUI.Toggle(r_12, p_12.boolValue);
        p_13.boolValue = EditorGUI.Toggle(r_13, p_13.boolValue);
        p_14.boolValue = EditorGUI.Toggle(r_14, p_14.boolValue);

        p_20.boolValue = EditorGUI.Toggle(r_20, p_20.boolValue);
        p_21.boolValue = EditorGUI.Toggle(r_21, p_21.boolValue);
        p_22.boolValue = EditorGUI.Toggle(r_22, p_22.boolValue);
        p_23.boolValue = EditorGUI.Toggle(r_23, p_23.boolValue);
        p_24.boolValue = EditorGUI.Toggle(r_24, p_24.boolValue);

        p_30.boolValue = EditorGUI.Toggle(r_30, p_30.boolValue);
        p_31.boolValue = EditorGUI.Toggle(r_31, p_31.boolValue);
        p_32.boolValue = EditorGUI.Toggle(r_32, p_32.boolValue);
        p_33.boolValue = EditorGUI.Toggle(r_33, p_33.boolValue);
        p_34.boolValue = EditorGUI.Toggle(r_34, p_34.boolValue);

        p_40.boolValue = EditorGUI.Toggle(r_40, p_40.boolValue);
        p_41.boolValue = EditorGUI.Toggle(r_41, p_41.boolValue);
        p_42.boolValue = EditorGUI.Toggle(r_42, p_42.boolValue);
        p_43.boolValue = EditorGUI.Toggle(r_43, p_43.boolValue);
        p_44.boolValue = EditorGUI.Toggle(r_44, p_44.boolValue);

        if (EditorGUI.EndChangeCheck())
            property.serializedObject.ApplyModifiedProperties();

        EditorGUI.EndProperty();
    }
}
