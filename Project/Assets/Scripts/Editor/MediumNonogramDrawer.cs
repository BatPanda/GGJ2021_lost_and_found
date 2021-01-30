using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(MediumNonogramStruct))]
class MediumNonogramDrawer : PropertyDrawer
{
    private SerializedProperty p_00;
    private SerializedProperty p_01;
    private SerializedProperty p_02;
    private SerializedProperty p_03;
    private SerializedProperty p_04;
    private SerializedProperty p_05;
    private SerializedProperty p_06;
    private SerializedProperty p_07;
    private SerializedProperty p_08;
    private SerializedProperty p_09;

    private SerializedProperty p_10;
    private SerializedProperty p_11;
    private SerializedProperty p_12;
    private SerializedProperty p_13;
    private SerializedProperty p_14;
    private SerializedProperty p_15;
    private SerializedProperty p_16;
    private SerializedProperty p_17;
    private SerializedProperty p_18;
    private SerializedProperty p_19;

    private SerializedProperty p_20;
    private SerializedProperty p_21;
    private SerializedProperty p_22;
    private SerializedProperty p_23;
    private SerializedProperty p_24;
    private SerializedProperty p_25;
    private SerializedProperty p_26;
    private SerializedProperty p_27;
    private SerializedProperty p_28;
    private SerializedProperty p_29;

    private SerializedProperty p_30;
    private SerializedProperty p_31;
    private SerializedProperty p_32;
    private SerializedProperty p_33;
    private SerializedProperty p_34;
    private SerializedProperty p_35;
    private SerializedProperty p_36;
    private SerializedProperty p_37;
    private SerializedProperty p_38;
    private SerializedProperty p_39;

    private SerializedProperty p_40;
    private SerializedProperty p_41;
    private SerializedProperty p_42;
    private SerializedProperty p_43;
    private SerializedProperty p_44;
    private SerializedProperty p_45;
    private SerializedProperty p_46;
    private SerializedProperty p_47;
    private SerializedProperty p_48;
    private SerializedProperty p_49;

    private SerializedProperty p_50;
    private SerializedProperty p_51;
    private SerializedProperty p_52;
    private SerializedProperty p_53;
    private SerializedProperty p_54;
    private SerializedProperty p_55;
    private SerializedProperty p_56;
    private SerializedProperty p_57;
    private SerializedProperty p_58;
    private SerializedProperty p_59;

    private SerializedProperty p_60;
    private SerializedProperty p_61;
    private SerializedProperty p_62;
    private SerializedProperty p_63;
    private SerializedProperty p_64;
    private SerializedProperty p_65;
    private SerializedProperty p_66;
    private SerializedProperty p_67;
    private SerializedProperty p_68;
    private SerializedProperty p_69;

    private SerializedProperty p_70;
    private SerializedProperty p_71;
    private SerializedProperty p_72;
    private SerializedProperty p_73;
    private SerializedProperty p_74;
    private SerializedProperty p_75;
    private SerializedProperty p_76;
    private SerializedProperty p_77;
    private SerializedProperty p_78;
    private SerializedProperty p_79;

    private SerializedProperty p_80;
    private SerializedProperty p_81;
    private SerializedProperty p_82;
    private SerializedProperty p_83;
    private SerializedProperty p_84;
    private SerializedProperty p_85;
    private SerializedProperty p_86;
    private SerializedProperty p_87;
    private SerializedProperty p_88;
    private SerializedProperty p_89;

    private SerializedProperty p_90;
    private SerializedProperty p_91;
    private SerializedProperty p_92;
    private SerializedProperty p_93;
    private SerializedProperty p_94;
    private SerializedProperty p_95;
    private SerializedProperty p_96;
    private SerializedProperty p_97;
    private SerializedProperty p_98;
    private SerializedProperty p_99;

    private static string k_00 = "b00";
    private static string k_01 = "b01";
    private static string k_02 = "b02";
    private static string k_03 = "b03";
    private static string k_04 = "b04";
    private static string k_05 = "b05";
    private static string k_06 = "b06";
    private static string k_07 = "b07";
    private static string k_08 = "b08";
    private static string k_09 = "b09";

    private static string k_10 = "b10";
    private static string k_11 = "b11";
    private static string k_12 = "b12";
    private static string k_13 = "b13";
    private static string k_14 = "b14";
    private static string k_15 = "b15";
    private static string k_16 = "b16";
    private static string k_17 = "b17";
    private static string k_18 = "b18";
    private static string k_19 = "b19";

    private static string k_20 = "b20";
    private static string k_21 = "b21";
    private static string k_22 = "b22";
    private static string k_23 = "b23";
    private static string k_24 = "b24";
    private static string k_25 = "b25";
    private static string k_26 = "b26";
    private static string k_27 = "b27";
    private static string k_28 = "b28";
    private static string k_29 = "b29";

    private static string k_30 = "b30";
    private static string k_31 = "b31";
    private static string k_32 = "b32";
    private static string k_33 = "b33";
    private static string k_34 = "b34";
    private static string k_35 = "b35";
    private static string k_36 = "b36";
    private static string k_37 = "b37";
    private static string k_38 = "b38";
    private static string k_39 = "b39";

    private static string k_40 = "b40";
    private static string k_41 = "b41";
    private static string k_42 = "b42";
    private static string k_43 = "b43";
    private static string k_44 = "b44";
    private static string k_45 = "b45";
    private static string k_46 = "b46";
    private static string k_47 = "b47";
    private static string k_48 = "b48";
    private static string k_49 = "b49";

    private static string k_50 = "b50";
    private static string k_51 = "b51";
    private static string k_52 = "b52";
    private static string k_53 = "b53";
    private static string k_54 = "b54";
    private static string k_55 = "b55";
    private static string k_56 = "b56";
    private static string k_57 = "b57";
    private static string k_58 = "b58";
    private static string k_59 = "b59";

    private static string k_60 = "b60";
    private static string k_61 = "b61";
    private static string k_62 = "b62";
    private static string k_63 = "b63";
    private static string k_64 = "b64";
    private static string k_65 = "b65";
    private static string k_66 = "b66";
    private static string k_67 = "b67";
    private static string k_68 = "b68";
    private static string k_69 = "b69";

    private static string k_70 = "b70";
    private static string k_71 = "b71";
    private static string k_72 = "b72";
    private static string k_73 = "b73";
    private static string k_74 = "b74";
    private static string k_75 = "b75";
    private static string k_76 = "b76";
    private static string k_77 = "b77";
    private static string k_78 = "b78";
    private static string k_79 = "b79";

    private static string k_80 = "b80";
    private static string k_81 = "b81";
    private static string k_82 = "b82";
    private static string k_83 = "b83";
    private static string k_84 = "b84";
    private static string k_85 = "b85";
    private static string k_86 = "b86";
    private static string k_87 = "b87";
    private static string k_88 = "b88";
    private static string k_89 = "b89";

    private static string k_90 = "b90";
    private static string k_91 = "b91";
    private static string k_92 = "b92";
    private static string k_93 = "b93";
    private static string k_94 = "b94";
    private static string k_95 = "b95";
    private static string k_96 = "b96";
    private static string k_97 = "b97";
    private static string k_98 = "b98";
    private static string k_99 = "b99";

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
        return (EditorGUIUtility.singleLineHeight * 10);
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        EditorGUI.BeginProperty(position, label, property);

        p_00 = property.FindPropertyRelative(k_00);
        p_01 = property.FindPropertyRelative(k_01);
        p_02 = property.FindPropertyRelative(k_02);
        p_03 = property.FindPropertyRelative(k_03);
        p_04 = property.FindPropertyRelative(k_04);
        p_05 = property.FindPropertyRelative(k_05);
        p_06 = property.FindPropertyRelative(k_06);
        p_07 = property.FindPropertyRelative(k_07);
        p_08 = property.FindPropertyRelative(k_08);
        p_09 = property.FindPropertyRelative(k_09);

        p_10 = property.FindPropertyRelative(k_10);
        p_11 = property.FindPropertyRelative(k_11);
        p_12 = property.FindPropertyRelative(k_12);
        p_13 = property.FindPropertyRelative(k_13);
        p_14 = property.FindPropertyRelative(k_14);
        p_15 = property.FindPropertyRelative(k_15);
        p_16 = property.FindPropertyRelative(k_16);
        p_17 = property.FindPropertyRelative(k_17);
        p_18 = property.FindPropertyRelative(k_18);
        p_19 = property.FindPropertyRelative(k_19);

        p_20 = property.FindPropertyRelative(k_20);
        p_21 = property.FindPropertyRelative(k_21);
        p_22 = property.FindPropertyRelative(k_22);
        p_23 = property.FindPropertyRelative(k_23);
        p_24 = property.FindPropertyRelative(k_24);
        p_25 = property.FindPropertyRelative(k_25);
        p_26 = property.FindPropertyRelative(k_26);
        p_27 = property.FindPropertyRelative(k_27);
        p_28 = property.FindPropertyRelative(k_28);
        p_29 = property.FindPropertyRelative(k_29);

        p_30 = property.FindPropertyRelative(k_30);
        p_31 = property.FindPropertyRelative(k_31);
        p_32 = property.FindPropertyRelative(k_32);
        p_33 = property.FindPropertyRelative(k_33);
        p_34 = property.FindPropertyRelative(k_34);
        p_35 = property.FindPropertyRelative(k_35);
        p_36 = property.FindPropertyRelative(k_36);
        p_37 = property.FindPropertyRelative(k_37);
        p_38 = property.FindPropertyRelative(k_38);
        p_39 = property.FindPropertyRelative(k_39);

        p_40 = property.FindPropertyRelative(k_40);
        p_41 = property.FindPropertyRelative(k_41);
        p_42 = property.FindPropertyRelative(k_42);
        p_43 = property.FindPropertyRelative(k_43);
        p_44 = property.FindPropertyRelative(k_44);
        p_45 = property.FindPropertyRelative(k_45);
        p_46 = property.FindPropertyRelative(k_46);
        p_47 = property.FindPropertyRelative(k_47);
        p_48 = property.FindPropertyRelative(k_48);
        p_49 = property.FindPropertyRelative(k_49);

        p_50 = property.FindPropertyRelative(k_50);
        p_51 = property.FindPropertyRelative(k_51);
        p_52 = property.FindPropertyRelative(k_52);
        p_53 = property.FindPropertyRelative(k_53);
        p_54 = property.FindPropertyRelative(k_54);
        p_55 = property.FindPropertyRelative(k_55);
        p_56 = property.FindPropertyRelative(k_56);
        p_57 = property.FindPropertyRelative(k_57);
        p_58 = property.FindPropertyRelative(k_58);
        p_59 = property.FindPropertyRelative(k_59);

        p_60 = property.FindPropertyRelative(k_60);
        p_61 = property.FindPropertyRelative(k_61);
        p_62 = property.FindPropertyRelative(k_62);
        p_63 = property.FindPropertyRelative(k_63);
        p_64 = property.FindPropertyRelative(k_64);
        p_65 = property.FindPropertyRelative(k_65);
        p_66 = property.FindPropertyRelative(k_66);
        p_67 = property.FindPropertyRelative(k_67);
        p_68 = property.FindPropertyRelative(k_68);
        p_69 = property.FindPropertyRelative(k_69);

        p_70 = property.FindPropertyRelative(k_70);
        p_71 = property.FindPropertyRelative(k_71);
        p_72 = property.FindPropertyRelative(k_72);
        p_73 = property.FindPropertyRelative(k_73);
        p_74 = property.FindPropertyRelative(k_74);
        p_75 = property.FindPropertyRelative(k_75);
        p_76 = property.FindPropertyRelative(k_76);
        p_77 = property.FindPropertyRelative(k_77);
        p_78 = property.FindPropertyRelative(k_78);
        p_79 = property.FindPropertyRelative(k_79);

        p_80 = property.FindPropertyRelative(k_80);
        p_81 = property.FindPropertyRelative(k_81);
        p_82 = property.FindPropertyRelative(k_82);
        p_83 = property.FindPropertyRelative(k_83);
        p_84 = property.FindPropertyRelative(k_84);
        p_85 = property.FindPropertyRelative(k_85);
        p_86 = property.FindPropertyRelative(k_86);
        p_87 = property.FindPropertyRelative(k_87);
        p_88 = property.FindPropertyRelative(k_88);
        p_89 = property.FindPropertyRelative(k_89);

        p_90 = property.FindPropertyRelative(k_90);
        p_91 = property.FindPropertyRelative(k_91);
        p_92 = property.FindPropertyRelative(k_92);
        p_93 = property.FindPropertyRelative(k_93);
        p_94 = property.FindPropertyRelative(k_94);
        p_95 = property.FindPropertyRelative(k_95);
        p_96 = property.FindPropertyRelative(k_96);
        p_97 = property.FindPropertyRelative(k_97);
        p_98 = property.FindPropertyRelative(k_98);
        p_99 = property.FindPropertyRelative(k_99);

        Rect r_fields = EditorGUI.PrefixLabel(position, label);

        Rect r_00 = new Rect(r_fields.xMin, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_01 = new Rect(r_00.xMin + 15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_02 = new Rect(r_01.xMin + 15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_03 = new Rect(r_02.xMin + 15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_04 = new Rect(r_03.xMin + 15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_05 = new Rect(r_04.xMin + 15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_06 = new Rect(r_05.xMin + 15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_07 = new Rect(r_06.xMin + 15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_08 = new Rect(r_07.xMin + 15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);
        Rect r_09 = new Rect(r_08.xMin + 15, r_fields.yMin, 45, EditorGUIUtility.singleLineHeight);

        Rect r_10 = new Rect(r_fields.xMin, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_11 = new Rect(r_00.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_12 = new Rect(r_01.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_13 = new Rect(r_02.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_14 = new Rect(r_03.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_15 = new Rect(r_04.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_16 = new Rect(r_05.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_17 = new Rect(r_06.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_18 = new Rect(r_07.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_19 = new Rect(r_08.xMin + 15, r_fields.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_20 = new Rect(r_fields.xMin, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_21 = new Rect(r_00.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_22 = new Rect(r_01.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_23 = new Rect(r_02.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_24 = new Rect(r_03.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_25 = new Rect(r_04.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_26 = new Rect(r_05.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_27 = new Rect(r_06.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_28 = new Rect(r_07.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_29 = new Rect(r_08.xMin + 15, r_10.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_30 = new Rect(r_fields.xMin, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_31 = new Rect(r_00.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_32 = new Rect(r_01.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_33 = new Rect(r_02.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_34 = new Rect(r_03.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_35 = new Rect(r_04.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_36 = new Rect(r_05.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_37 = new Rect(r_06.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_38 = new Rect(r_07.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_39 = new Rect(r_08.xMin + 15, r_20.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_40 = new Rect(r_fields.xMin, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_41 = new Rect(r_00.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_42 = new Rect(r_01.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_43 = new Rect(r_02.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_44 = new Rect(r_03.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_45 = new Rect(r_04.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_46 = new Rect(r_05.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_47 = new Rect(r_06.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_48 = new Rect(r_07.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_49 = new Rect(r_08.xMin + 15, r_30.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_50 = new Rect(r_fields.xMin, r_40.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_51 = new Rect(r_00.xMin + 15, r_40.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_52 = new Rect(r_01.xMin + 15, r_40.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_53 = new Rect(r_02.xMin + 15, r_40.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_54 = new Rect(r_03.xMin + 15, r_40.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_55 = new Rect(r_04.xMin + 15, r_40.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_56 = new Rect(r_05.xMin + 15, r_40.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_57 = new Rect(r_06.xMin + 15, r_40.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_58 = new Rect(r_07.xMin + 15, r_40.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_59 = new Rect(r_08.xMin + 15, r_40.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_60 = new Rect(r_fields.xMin, r_50.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_61 = new Rect(r_00.xMin + 15, r_50.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_62 = new Rect(r_01.xMin + 15, r_50.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_63 = new Rect(r_02.xMin + 15, r_50.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_64 = new Rect(r_03.xMin + 15, r_50.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_65 = new Rect(r_04.xMin + 15, r_50.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_66 = new Rect(r_05.xMin + 15, r_50.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_67 = new Rect(r_06.xMin + 15, r_50.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_68 = new Rect(r_07.xMin + 15, r_50.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_69 = new Rect(r_08.xMin + 15, r_50.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_70 = new Rect(r_fields.xMin, r_60.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_71 = new Rect(r_00.xMin + 15, r_60.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_72 = new Rect(r_01.xMin + 15, r_60.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_73 = new Rect(r_02.xMin + 15, r_60.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_74 = new Rect(r_03.xMin + 15, r_60.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_75 = new Rect(r_04.xMin + 15, r_60.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_76 = new Rect(r_05.xMin + 15, r_60.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_77 = new Rect(r_06.xMin + 15, r_60.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_78 = new Rect(r_07.xMin + 15, r_60.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_79 = new Rect(r_08.xMin + 15, r_60.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_80 = new Rect(r_fields.xMin, r_70.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_81 = new Rect(r_00.xMin + 15, r_70.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_82 = new Rect(r_01.xMin + 15, r_70.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_83 = new Rect(r_02.xMin + 15, r_70.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_84 = new Rect(r_03.xMin + 15, r_70.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_85 = new Rect(r_04.xMin + 15, r_70.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_86 = new Rect(r_05.xMin + 15, r_70.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_87 = new Rect(r_06.xMin + 15, r_70.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_88 = new Rect(r_07.xMin + 15, r_70.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_89 = new Rect(r_08.xMin + 15, r_70.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        Rect r_90 = new Rect(r_fields.xMin, r_80.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_91 = new Rect(r_00.xMin + 15, r_80.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_92 = new Rect(r_01.xMin + 15, r_80.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_93 = new Rect(r_02.xMin + 15, r_80.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_94 = new Rect(r_03.xMin + 15, r_80.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_95 = new Rect(r_04.xMin + 15, r_80.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_96 = new Rect(r_05.xMin + 15, r_80.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_97 = new Rect(r_06.xMin + 15, r_80.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_98 = new Rect(r_07.xMin + 15, r_80.yMin + 15, 45, EditorGUIUtility.singleLineHeight);
        Rect r_99 = new Rect(r_08.xMin + 15, r_80.yMin + 15, 45, EditorGUIUtility.singleLineHeight);

        EditorGUI.BeginChangeCheck();

        p_00.boolValue = EditorGUI.Toggle(r_00, p_00.boolValue);
        p_01.boolValue = EditorGUI.Toggle(r_01, p_01.boolValue);
        p_02.boolValue = EditorGUI.Toggle(r_02, p_02.boolValue);
        p_03.boolValue = EditorGUI.Toggle(r_03, p_03.boolValue);
        p_04.boolValue = EditorGUI.Toggle(r_04, p_04.boolValue);
        p_05.boolValue = EditorGUI.Toggle(r_05, p_05.boolValue);
        p_06.boolValue = EditorGUI.Toggle(r_06, p_06.boolValue);
        p_07.boolValue = EditorGUI.Toggle(r_07, p_07.boolValue);
        p_08.boolValue = EditorGUI.Toggle(r_08, p_08.boolValue);
        p_09.boolValue = EditorGUI.Toggle(r_09, p_09.boolValue);

        p_10.boolValue = EditorGUI.Toggle(r_10, p_10.boolValue);
        p_11.boolValue = EditorGUI.Toggle(r_11, p_11.boolValue);
        p_12.boolValue = EditorGUI.Toggle(r_12, p_12.boolValue);
        p_13.boolValue = EditorGUI.Toggle(r_13, p_13.boolValue);
        p_14.boolValue = EditorGUI.Toggle(r_14, p_14.boolValue);
        p_15.boolValue = EditorGUI.Toggle(r_15, p_15.boolValue);
        p_16.boolValue = EditorGUI.Toggle(r_16, p_16.boolValue);
        p_17.boolValue = EditorGUI.Toggle(r_17, p_17.boolValue);
        p_18.boolValue = EditorGUI.Toggle(r_18, p_18.boolValue);
        p_19.boolValue = EditorGUI.Toggle(r_19, p_19.boolValue);

        p_20.boolValue = EditorGUI.Toggle(r_20, p_20.boolValue);
        p_21.boolValue = EditorGUI.Toggle(r_21, p_21.boolValue);
        p_22.boolValue = EditorGUI.Toggle(r_22, p_22.boolValue);
        p_23.boolValue = EditorGUI.Toggle(r_23, p_23.boolValue);
        p_24.boolValue = EditorGUI.Toggle(r_24, p_24.boolValue);
        p_25.boolValue = EditorGUI.Toggle(r_25, p_25.boolValue);
        p_26.boolValue = EditorGUI.Toggle(r_26, p_26.boolValue);
        p_27.boolValue = EditorGUI.Toggle(r_27, p_27.boolValue);
        p_28.boolValue = EditorGUI.Toggle(r_28, p_28.boolValue);
        p_29.boolValue = EditorGUI.Toggle(r_29, p_29.boolValue);

        p_30.boolValue = EditorGUI.Toggle(r_30, p_30.boolValue);
        p_31.boolValue = EditorGUI.Toggle(r_31, p_31.boolValue);
        p_32.boolValue = EditorGUI.Toggle(r_32, p_32.boolValue);
        p_33.boolValue = EditorGUI.Toggle(r_33, p_33.boolValue);
        p_34.boolValue = EditorGUI.Toggle(r_34, p_34.boolValue);
        p_35.boolValue = EditorGUI.Toggle(r_35, p_35.boolValue);
        p_36.boolValue = EditorGUI.Toggle(r_36, p_36.boolValue);
        p_37.boolValue = EditorGUI.Toggle(r_37, p_37.boolValue);
        p_38.boolValue = EditorGUI.Toggle(r_38, p_38.boolValue);
        p_39.boolValue = EditorGUI.Toggle(r_39, p_39.boolValue);

        p_40.boolValue = EditorGUI.Toggle(r_40, p_40.boolValue);
        p_41.boolValue = EditorGUI.Toggle(r_41, p_41.boolValue);
        p_42.boolValue = EditorGUI.Toggle(r_42, p_42.boolValue);
        p_43.boolValue = EditorGUI.Toggle(r_43, p_43.boolValue);
        p_44.boolValue = EditorGUI.Toggle(r_44, p_44.boolValue);
        p_45.boolValue = EditorGUI.Toggle(r_45, p_45.boolValue);
        p_46.boolValue = EditorGUI.Toggle(r_46, p_46.boolValue);
        p_47.boolValue = EditorGUI.Toggle(r_47, p_47.boolValue);
        p_48.boolValue = EditorGUI.Toggle(r_48, p_48.boolValue);
        p_49.boolValue = EditorGUI.Toggle(r_49, p_49.boolValue);

        p_50.boolValue = EditorGUI.Toggle(r_50, p_50.boolValue);
        p_51.boolValue = EditorGUI.Toggle(r_51, p_51.boolValue);
        p_52.boolValue = EditorGUI.Toggle(r_52, p_52.boolValue);
        p_53.boolValue = EditorGUI.Toggle(r_53, p_53.boolValue);
        p_54.boolValue = EditorGUI.Toggle(r_54, p_54.boolValue);
        p_55.boolValue = EditorGUI.Toggle(r_55, p_55.boolValue);
        p_56.boolValue = EditorGUI.Toggle(r_56, p_56.boolValue);
        p_57.boolValue = EditorGUI.Toggle(r_57, p_57.boolValue);
        p_58.boolValue = EditorGUI.Toggle(r_58, p_58.boolValue);
        p_59.boolValue = EditorGUI.Toggle(r_59, p_59.boolValue);

        p_60.boolValue = EditorGUI.Toggle(r_60, p_60.boolValue);
        p_61.boolValue = EditorGUI.Toggle(r_61, p_61.boolValue);
        p_62.boolValue = EditorGUI.Toggle(r_62, p_62.boolValue);
        p_63.boolValue = EditorGUI.Toggle(r_63, p_63.boolValue);
        p_64.boolValue = EditorGUI.Toggle(r_64, p_64.boolValue);
        p_65.boolValue = EditorGUI.Toggle(r_65, p_65.boolValue);
        p_66.boolValue = EditorGUI.Toggle(r_66, p_66.boolValue);
        p_67.boolValue = EditorGUI.Toggle(r_67, p_67.boolValue);
        p_68.boolValue = EditorGUI.Toggle(r_68, p_68.boolValue);
        p_69.boolValue = EditorGUI.Toggle(r_69, p_69.boolValue);

        p_70.boolValue = EditorGUI.Toggle(r_70, p_70.boolValue);
        p_71.boolValue = EditorGUI.Toggle(r_71, p_71.boolValue);
        p_72.boolValue = EditorGUI.Toggle(r_72, p_72.boolValue);
        p_73.boolValue = EditorGUI.Toggle(r_73, p_73.boolValue);
        p_74.boolValue = EditorGUI.Toggle(r_74, p_74.boolValue);
        p_75.boolValue = EditorGUI.Toggle(r_75, p_75.boolValue);
        p_76.boolValue = EditorGUI.Toggle(r_76, p_76.boolValue);
        p_77.boolValue = EditorGUI.Toggle(r_77, p_77.boolValue);
        p_78.boolValue = EditorGUI.Toggle(r_78, p_78.boolValue);
        p_79.boolValue = EditorGUI.Toggle(r_79, p_79.boolValue);

        p_80.boolValue = EditorGUI.Toggle(r_80, p_80.boolValue);
        p_81.boolValue = EditorGUI.Toggle(r_81, p_81.boolValue);
        p_82.boolValue = EditorGUI.Toggle(r_82, p_82.boolValue);
        p_83.boolValue = EditorGUI.Toggle(r_83, p_83.boolValue);
        p_84.boolValue = EditorGUI.Toggle(r_84, p_84.boolValue);
        p_85.boolValue = EditorGUI.Toggle(r_85, p_85.boolValue);
        p_86.boolValue = EditorGUI.Toggle(r_86, p_86.boolValue);
        p_87.boolValue = EditorGUI.Toggle(r_87, p_87.boolValue);
        p_88.boolValue = EditorGUI.Toggle(r_88, p_88.boolValue);
        p_89.boolValue = EditorGUI.Toggle(r_89, p_89.boolValue);

        p_90.boolValue = EditorGUI.Toggle(r_90, p_90.boolValue);
        p_91.boolValue = EditorGUI.Toggle(r_91, p_91.boolValue);
        p_92.boolValue = EditorGUI.Toggle(r_92, p_92.boolValue);
        p_93.boolValue = EditorGUI.Toggle(r_93, p_93.boolValue);
        p_94.boolValue = EditorGUI.Toggle(r_94, p_94.boolValue);
        p_95.boolValue = EditorGUI.Toggle(r_95, p_95.boolValue);
        p_96.boolValue = EditorGUI.Toggle(r_96, p_96.boolValue);
        p_97.boolValue = EditorGUI.Toggle(r_97, p_97.boolValue);
        p_98.boolValue = EditorGUI.Toggle(r_98, p_98.boolValue);
        p_99.boolValue = EditorGUI.Toggle(r_99, p_99.boolValue);

        if (EditorGUI.EndChangeCheck())
            property.serializedObject.ApplyModifiedProperties();

        EditorGUI.EndProperty();
    }
}

