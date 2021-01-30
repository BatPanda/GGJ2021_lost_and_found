using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GridPos
{
    public int x;
    public int y;

    public GridPos(int _x, int _y)
    {
        x = _x;
        y = _y;
    }

    public GridPos(Vector2 position, float x_scale, float y_scale)
    {
        float temporary_x = (position.x / x_scale);
        float temporary_y = (position.y / y_scale);
        x = (int)temporary_x;
        y = (int)temporary_y;

    }

    public Vector2 convertToVector2(float x_scale, float y_scale)
    {
        return new Vector2((float)x * x_scale, (float)y * y_scale);
    }

    public Vector3 convertToVector3(float x_scale, float y_scale)
    {
        return new Vector3((float)x * x_scale, (float)y * y_scale, 0);
    }

    public bool isEqual(GridPos other)
    {
        return (other.x == x && other.y == y);
    }

    public string toString()
    {
        return x.ToString() + ":" + y.ToString();
    }
}
