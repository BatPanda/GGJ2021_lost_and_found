using System.Collections.Generic;
using UnityEngine;

public class MapShapesCollection : MonoBehaviour
{
    [SerializeField] private MapShape[] m_shapes = default;
    
    public IEnumerable<MapShape> Shapes
    {
        get { return m_shapes; }
    }
}
