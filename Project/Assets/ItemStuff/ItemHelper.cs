using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public enum ItemTypes
{
    PAINTING,
    VASE,
    INSTRUMENT,
    JEWELLERY,
    CLOTHING,
    WEAPON,
    ODDITY
}

public enum NonogramSizes
{
    BIG,
    MEDIUM,
    SMALL
}

public struct NonogramStruct
{
    public List<List<int>> rows;

    public NonogramStruct(List<List<int>> _rows) {
        rows = _rows;
    }

    public NonogramStruct(BigNonogramStruct _bns) {
        rows = _bns.getBoolData().makeUsefulDataFromBoolList(14);
    }

    public NonogramStruct(MediumNonogramStruct _mns) {
        rows = _mns.getBoolData().makeUsefulDataFromBoolList(9);
    }

    public NonogramStruct(SmallNonogramStruct _sns) {
        rows = _sns.getBoolData().makeUsefulDataFromBoolList(4);
    }
}

[Serializable]
public struct BigNonogramStruct
{
    private List<bool> values;
    public bool b0_0;
    public bool b0_1;
    public bool b0_2;
    public bool b0_3;
    public bool b0_4;
    public bool b0_5;
    public bool b0_6;
    public bool b0_7;
    public bool b0_8;
    public bool b0_9;
    public bool b0_10;
    public bool b0_11;
    public bool b0_12;
    public bool b0_13;
    public bool b0_14;

    public bool b1_0;
    public bool b1_1;
    public bool b1_2;
    public bool b1_3;
    public bool b1_4;
    public bool b1_5;
    public bool b1_6;
    public bool b1_7;
    public bool b1_8;
    public bool b1_9;
    public bool b1_10;
    public bool b1_11;
    public bool b1_12;
    public bool b1_13;
    public bool b1_14;

    public bool b2_0;
    public bool b2_1;
    public bool b2_2;
    public bool b2_3;
    public bool b2_4;
    public bool b2_5;
    public bool b2_6;
    public bool b2_7;
    public bool b2_8;
    public bool b2_9;
    public bool b2_10;
    public bool b2_11;
    public bool b2_12;
    public bool b2_13;
    public bool b2_14;

    public bool b3_0;
    public bool b3_1;
    public bool b3_2;
    public bool b3_3;
    public bool b3_4;
    public bool b3_5;
    public bool b3_6;
    public bool b3_7;
    public bool b3_8;
    public bool b3_9;
    public bool b3_10;
    public bool b3_11;
    public bool b3_12;
    public bool b3_13;
    public bool b3_14;

    public bool b4_0;
    public bool b4_1;
    public bool b4_2;
    public bool b4_3;
    public bool b4_4;
    public bool b4_5;
    public bool b4_6;
    public bool b4_7;
    public bool b4_8;
    public bool b4_9;
    public bool b4_10;
    public bool b4_11;
    public bool b4_12;
    public bool b4_13;
    public bool b4_14;

    public bool b5_0;
    public bool b5_1;
    public bool b5_2;
    public bool b5_3;
    public bool b5_4;
    public bool b5_5;
    public bool b5_6;
    public bool b5_7;
    public bool b5_8;
    public bool b5_9;
    public bool b5_10;
    public bool b5_11;
    public bool b5_12;
    public bool b5_13;
    public bool b5_14;

    public bool b6_0;
    public bool b6_1;
    public bool b6_2;
    public bool b6_3;
    public bool b6_4;
    public bool b6_5;
    public bool b6_6;
    public bool b6_7;
    public bool b6_8;
    public bool b6_9;
    public bool b6_10;
    public bool b6_11;
    public bool b6_12;
    public bool b6_13;
    public bool b6_14;

    public bool b7_0;
    public bool b7_1;
    public bool b7_2;
    public bool b7_3;
    public bool b7_4;
    public bool b7_5;
    public bool b7_6;
    public bool b7_7;
    public bool b7_8;
    public bool b7_9;
    public bool b7_10;
    public bool b7_11;
    public bool b7_12;
    public bool b7_13;
    public bool b7_14;

    public bool b8_0;
    public bool b8_1;
    public bool b8_2;
    public bool b8_3;
    public bool b8_4;
    public bool b8_5;
    public bool b8_6;
    public bool b8_7;
    public bool b8_8;
    public bool b8_9;
    public bool b8_10;
    public bool b8_11;
    public bool b8_12;
    public bool b8_13;
    public bool b8_14;

    public bool b9_0;
    public bool b9_1;
    public bool b9_2;
    public bool b9_3;
    public bool b9_4;
    public bool b9_5;
    public bool b9_6;
    public bool b9_7;
    public bool b9_8;
    public bool b9_9;
    public bool b9_10;
    public bool b9_11;
    public bool b9_12;
    public bool b9_13;
    public bool b9_14;

    public bool b10_0;
    public bool b10_1;
    public bool b10_2;
    public bool b10_3;
    public bool b10_4;
    public bool b10_5;
    public bool b10_6;
    public bool b10_7;
    public bool b10_8;
    public bool b10_9;
    public bool b10_10;
    public bool b10_11;
    public bool b10_12;
    public bool b10_13;
    public bool b10_14;

    public bool b11_0;
    public bool b11_1;
    public bool b11_2;
    public bool b11_3;
    public bool b11_4;
    public bool b11_5;
    public bool b11_6;
    public bool b11_7;
    public bool b11_8;
    public bool b11_9;
    public bool b11_10;
    public bool b11_11;
    public bool b11_12;
    public bool b11_13;
    public bool b11_14;

    public bool b12_0;
    public bool b12_1;
    public bool b12_2;
    public bool b12_3;
    public bool b12_4;
    public bool b12_5;
    public bool b12_6;
    public bool b12_7;
    public bool b12_8;
    public bool b12_9;
    public bool b12_10;
    public bool b12_11;
    public bool b12_12;
    public bool b12_13;
    public bool b12_14;

    public bool b13_0;
    public bool b13_1;
    public bool b13_2;
    public bool b13_3;
    public bool b13_4;
    public bool b13_5;
    public bool b13_6;
    public bool b13_7;
    public bool b13_8;
    public bool b13_9;
    public bool b13_10;
    public bool b13_11;
    public bool b13_12;
    public bool b13_13;
    public bool b13_14;

    public bool b14_0;
    public bool b14_1;
    public bool b14_2;
    public bool b14_3;
    public bool b14_4;
    public bool b14_5;
    public bool b14_6;
    public bool b14_7;
    public bool b14_8;
    public bool b14_9;
    public bool b14_10;
    public bool b14_11;
    public bool b14_12;
    public bool b14_13;
    public bool b14_14;

    public List<bool> getBoolData() => new List<bool> {
        b0_0,
        b0_1,
        b0_2,
        b0_3,
        b0_4,
        b0_5,
        b0_6,
        b0_7,
        b0_8,
        b0_9,
        b0_10,
        b0_11,
        b0_12,
        b0_13,
        b0_14,

        b1_0,
        b1_1,
        b1_2,
        b1_3,
        b1_4,
        b1_5,
        b1_6,
        b1_7,
        b1_8,
        b1_9,
        b1_10,
        b1_11,
        b1_12,
        b1_13,
        b1_14,

        b2_0,
        b2_1,
        b2_2,
        b2_3,
        b2_4,
        b2_5,
        b2_6,
        b2_7,
        b2_8,
        b2_9,
        b2_10,
        b2_11,
        b2_12,
        b2_13,
        b2_14,

        b3_0,
        b3_1,
        b3_2,
        b3_3,
        b3_4,
        b3_5,
        b3_6,
        b3_7,
        b3_8,
        b3_9,
        b3_10,
        b3_11,
        b3_12,
        b3_13,
        b3_14,

        b4_0,
        b4_1,
        b4_2,
        b4_3,
        b4_4,
        b4_5,
        b4_6,
        b4_7,
        b4_8,
        b4_9,
        b4_10,
        b4_11,
        b4_12,
        b4_13,
        b4_14,

        b5_0,
        b5_1,
        b5_2,
        b5_3,
        b5_4,
        b5_5,
        b5_6,
        b5_7,
        b5_8,
        b5_9,
        b5_10,
        b5_11,
        b5_12,
        b5_13,
        b5_14,


        b6_0,
        b6_1,
        b6_2,
        b6_3,
        b6_4,
        b6_5,
        b6_6,
        b6_7,
        b6_8,
        b6_9,
        b6_10,
        b6_11,
        b6_12,
        b6_13,
        b6_14,

        b7_0,
        b7_1,
        b7_2,
        b7_3,
        b7_4,
        b7_5,
        b7_6,
        b7_7,
        b7_8,
        b7_9,
        b7_10,
        b7_11,
        b7_12,
        b7_13,
        b7_14,

        b8_0,
        b8_1,
        b8_2,
        b8_3,
        b8_4,
        b8_5,
        b8_6,
        b8_7,
        b8_8,
        b8_9,
        b8_10,
        b8_11,
        b8_12,
        b8_13,
        b8_14,

        b9_0,
        b9_1,
        b9_2,
        b9_3,
        b9_4,
        b9_5,
        b9_6,
        b9_7,
        b9_8,
        b9_9,
        b9_10,
        b9_11,
        b9_12,
        b9_13,
        b9_14,

        b10_0,
        b10_1,
        b10_2,
        b10_3,
        b10_4,
        b10_5,
        b10_6,
        b10_7,
        b10_8,
        b10_9,
        b10_10,
        b10_11,
        b10_12,
        b10_13,
        b10_14,


        b11_0,
        b11_1,
        b11_2,
        b11_3,
        b11_4,
        b11_5,
        b11_6,
        b11_7,
        b11_8,
        b11_9,
        b11_10,
        b11_11,
        b11_12,
        b11_13,
        b11_14,


        b12_0,
        b12_1,
        b12_2,
        b12_3,
        b12_4,
        b12_5,
        b12_6,
        b12_7,
        b12_8,
        b12_9,
        b12_10,
        b12_11,
        b12_12,
        b12_13,
        b12_14,


        b13_0,
        b13_1,
        b13_2,
        b13_3,
        b13_4,
        b13_5,
        b13_6,
        b13_7,
        b13_8,
        b13_9,
        b13_10,
        b13_11,
        b13_12,
        b13_13,
        b13_14,


        b14_0,
        b14_1,
        b14_2,
        b14_3,
        b14_4,
        b14_5,
        b14_6,
        b14_7,
        b14_8,
        b14_9,
        b14_10,
        b14_11,
        b14_12,
        b14_13,
        b14_14
    };
}

[Serializable]
public struct MediumNonogramStruct
{
    private List<bool> values;
    public bool b00;
    public bool b01;
    public bool b02;
    public bool b03;
    public bool b04;
    public bool b05;
    public bool b06;
    public bool b07;
    public bool b08;
    public bool b09;
                   
    public bool b10;
    public bool b11;
    public bool b12;
    public bool b13;
    public bool b14;
    public bool b15;
    public bool b16;
    public bool b17;
    public bool b18;
    public bool b19;
                   
    public bool b20;
    public bool b21;
    public bool b22;
    public bool b23;
    public bool b24;
    public bool b25;
    public bool b26;
    public bool b27;
    public bool b28;
    public bool b29;
                   
    public bool b30;
    public bool b31;
    public bool b32;
    public bool b33;
    public bool b34;
    public bool b35;
    public bool b36;
    public bool b37;
    public bool b38;
    public bool b39;
                   
    public bool b40;
    public bool b41;
    public bool b42;
    public bool b43;
    public bool b44;
    public bool b45;
    public bool b46;
    public bool b47;
    public bool b48;
    public bool b49;
                   
    public bool b50;
    public bool b51;
    public bool b52;
    public bool b53;
    public bool b54;
    public bool b55;
    public bool b56;
    public bool b57;
    public bool b58;
    public bool b59;
                   
    public bool b60;
    public bool b61;
    public bool b62;
    public bool b63;
    public bool b64;
    public bool b65;
    public bool b66;
    public bool b67;
    public bool b68;
    public bool b69;
                   
    public bool b70;
    public bool b71;
    public bool b72;
    public bool b73;
    public bool b74;
    public bool b75;
    public bool b76;
    public bool b77;
    public bool b78;
    public bool b79;
                   
    public bool b80;
    public bool b81;
    public bool b82;
    public bool b83;
    public bool b84;
    public bool b85;
    public bool b86;
    public bool b87;
    public bool b88;
    public bool b89;
                   
    public bool b90;
    public bool b91;
    public bool b92;
    public bool b93;
    public bool b94;
    public bool b95;
    public bool b96;
    public bool b97;
    public bool b98;
    public bool b99;

    public List<bool> getBoolData() => new List<bool>
    {
        b00,
        b01,
        b02,
        b03,
        b04,
        b05,
        b06,
        b07,
        b08,
        b09,
           
        b10,
        b11,
        b12,
        b13,
        b14,
        b15,
        b16,
        b17,
        b18,
        b19,
           
        b20,
        b21,
        b22,
        b23,
        b24,
        b25,
        b26,
        b27,
        b28,
        b29,
           
        b30,
        b31,
        b32,
        b33,
        b34,
        b35,
        b36,
        b37,
        b38,
        b39,

        b40,
        b41,
        b42,
        b43,
        b44,
        b45,
        b46,
        b47,
        b48,
        b49,

        b50,
        b51,
        b52,
        b53,
        b54,
        b55,
        b56,
        b57,
        b58,
        b59,

        b60,
        b61,
        b62,
        b63,
        b64,
        b65,
        b66,
        b67,
        b68,
        b69,

        b70,
        b71,
        b72,
        b73,
        b74,
        b75,
        b76,
        b77,
        b78,
        b79,

        b80,
        b81,
        b82,
        b83,
        b84,
        b85,
        b86,
        b87,
        b88,
        b89,

        b90,
        b91,
        b92,
        b93,
        b94,
        b95,
        b96,
        b97,
        b98,
        b99
    };
}

[Serializable]
public struct SmallNonogramStruct
{
    private List<bool> values;
    public bool b00;
    public bool b01;
    public bool b02;
    public bool b03;
    public bool b04;

    public bool b10;
    public bool b11;
    public bool b12;
    public bool b13;
    public bool b14;

    public bool b20;
    public bool b21;
    public bool b22;
    public bool b23;
    public bool b24;

    public bool b30;
    public bool b31;
    public bool b32;
    public bool b33;
    public bool b34;

    public bool b40;
    public bool b41;
    public bool b42;
    public bool b43;
    public bool b44;

    public List<bool> getBoolData() => new List<bool>
    {
        b00,
        b01,
        b02,
        b03,
        b04,

        b10,
        b11,
        b12,
        b13,
        b14,

        b20,
        b21,
        b22,
        b23,
        b24,

        b30,
        b31,
        b32,
        b33,
        b34,

        b40,
        b41,
        b42,
        b43,
        b44,
    };
}

[Serializable]
public struct ItemStruct
{
    public string name;
    public string description;
    public Sprite typeSprite;
    public Sprite sprite;
    public ItemTypes type;
    public NonogramSizes nonogram_size;
    public SmallNonogramStruct small_nonogram;
    public MediumNonogramStruct medium_nonogram;
    public BigNonogramStruct big_nonogram;



    public ItemStruct(string _name, string _description, Sprite _typeSprite, Sprite _sprite, ItemTypes _type, NonogramSizes _nonogram_size, SmallNonogramStruct _small, MediumNonogramStruct _medium, BigNonogramStruct _big) { 
        name = _name; description = _description; typeSprite = _typeSprite; sprite = _sprite; type = _type; nonogram_size = _nonogram_size;  small_nonogram = _small; medium_nonogram = _medium; big_nonogram = _big;
    }

    public NonogramStruct getNonogramData(SmallNonogramStruct _small) => new NonogramStruct(_small);
    public NonogramStruct getNonogramData(MediumNonogramStruct _medium) => new NonogramStruct(_medium);
    public NonogramStruct getNonogramData(BigNonogramStruct _big) => new NonogramStruct(_big);


}

public static class ItemHelper
{
    public static List<List<int>> makeUsefulDataFromBoolList(this List<bool> _bool_list, int _size) {
        int iter = 0;
        List<List<int>> return_rows = new List<List<int>>();
        List<int> row = new List<int>();
        foreach (bool element in _bool_list) {
            row.Insert(iter, element ? 1 : 0);
            if (iter == _size) {
                iter = 0;
                return_rows.Add(row);
                row = new List<int>();
            } else {
                iter++;
            }
        }
        return return_rows;
    }
}
