using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[ExecuteInEditMode]
public class LightGenerator : MonoBehaviour
{
    [SerializeField] private MapShapesCollection m_shapes = default;

    private List<Transform> m_visibleNodes = new List<Transform>();
    private List<Vector3> m_cameraNodes = new List<Vector3>();
    private List<MapShape.Line> m_visibleLines = new List<MapShape.Line>();
    private List<Vector3> m_lightPolygonLines = new List<Vector3>();

    private void Update()
    {
        m_visibleNodes = new List<Transform>();
        m_cameraNodes = new List<Vector3>();
        m_visibleLines = new List<MapShape.Line>();
        m_lightPolygonLines = new List<Vector3>();

        foreach (MapShape shape in m_shapes.Shapes)
        {
            foreach(Transform node in shape.Nodes)
            {
                Vector3 viewport = Camera.main.WorldToViewportPoint(node.position);
                if (viewport.x > 0 && viewport.x < 1 && viewport.y > 0 && viewport.y < 1)
                {
                    m_visibleNodes.Add(node);

                    foreach(var line in shape.GetNodeLines(node))
                    {
                        m_visibleLines.Add(line);
                    }
                }
            }
        }

        // Screens coordinate corner location
        var upperLeftScreen = new Vector3(0, Screen.height, 0);
        var upperRightScreen = new Vector3(Screen.width, Screen.height, 0);
        var lowerLeftScreen = new Vector3(0, 0, 0);
        var lowerRightScreen = new Vector3(Screen.width, 0, 0);

        //Corner locations in world coordinates
        var upperLeft = Camera.main.ScreenToWorldPoint(upperLeftScreen);
        var upperRight = Camera.main.ScreenToWorldPoint(upperRightScreen);
        var lowerLeft = Camera.main.ScreenToWorldPoint(lowerLeftScreen);
        var lowerRight = Camera.main.ScreenToWorldPoint(lowerRightScreen);

        m_cameraNodes.Add(upperLeft);
        m_cameraNodes.Add(upperRight);
        m_cameraNodes.Add(lowerLeft);
        m_cameraNodes.Add(lowerRight);

        foreach (MapShape.Line line in m_visibleLines)
        {
            Vector2 intersection = Vector2.zero;
            if (IsIntersecting(line.Start.position, line.End.position, upperLeft, upperRight, out intersection))
            {
                m_cameraNodes.Add(intersection);
                intersection = Vector2.zero;
            }

            if (IsIntersecting(line.Start.position, line.End.position, upperLeft, lowerLeft, out intersection))
            {
                m_cameraNodes.Add(intersection);
                intersection = Vector2.zero;
            }

            if (IsIntersecting(line.Start.position, line.End.position, lowerRight, upperRight, out intersection))
            {
                m_cameraNodes.Add(intersection);
                intersection = Vector2.zero;
            }

            if (IsIntersecting(line.Start.position, line.End.position, lowerRight, lowerLeft, out intersection))
            {
                m_cameraNodes.Add(intersection);
                intersection = Vector2.zero;
            }
        }

        foreach (Transform node in m_visibleNodes)
        {
            bool intersected = false;
            Vector2 intersectionPoint = Vector2.zero;
            foreach (MapShape.Line line in m_visibleLines)
            {
                if (line.Start == node || line.End == node)
                {
                    continue;
                }

                Vector2 intersection;
                if (IsIntersecting(transform.position, node.position, line.Start.position, line.End.position, out intersection))
                {
                    if (intersectionPoint == Vector2.zero)
                    {
                        intersectionPoint = intersection;
                        intersected = true;
                    }
                    else
                    {
                        if (Vector2.Distance(transform.position, intersection) < Vector2.Distance(transform.position, intersectionPoint))
                        {
                            intersectionPoint = intersection;
                        }
                    }
                }
            }

            if (intersected)
            {
                m_lightPolygonLines.Add(intersectionPoint);
                continue;
            }
            
            m_lightPolygonLines.Add(node.position);
        }

        foreach (Vector3 node in m_cameraNodes)
        {
            bool intersected = false;
            Vector2 intersectionPoint = Vector2.zero;
            foreach (MapShape.Line line in m_visibleLines)
            {
                Vector2 intersection;
                if (IsIntersecting(transform.position, node, line.Start.position, line.End.position, out intersection))
                {
                    if (intersectionPoint == Vector2.zero)
                    {
                        intersectionPoint = intersection;
                        intersected = true;
                    }
                    else
                    {
                        if (Vector2.Distance(transform.position, intersection) < Vector2.Distance(transform.position, intersectionPoint))
                        {
                            intersectionPoint = intersection;
                        }
                    }
                }
            }

            if (intersected)
            {
                m_lightPolygonLines.Add(intersectionPoint);
                continue;
            }

            m_lightPolygonLines.Add(node);
        }
    }

    private void OnDrawGizmos()
    {
        foreach (Transform node in m_visibleNodes)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(node.position, 0.05f);
        }

        foreach(Vector3 node in m_cameraNodes)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(node, 0.05f);
        }

        foreach (MapShape.Line line in m_visibleLines)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(line.Start.position, line.End.position);
        }

        foreach (Vector3 node in m_lightPolygonLines)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, node);
        }

    }

    private bool IsIntersecting(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, out Vector2 intersection)
    {
        intersection = Vector2.zero;

        var d = (p2.x - p1.x) * (p4.y - p3.y) - (p2.y - p1.y) * (p4.x - p3.x);

        if (d == 0.0f)
        {
            return false;
        }

        var u = ((p3.x - p1.x) * (p4.y - p3.y) - (p3.y - p1.y) * (p4.x - p3.x)) / d;
        var v = ((p3.x - p1.x) * (p2.y - p1.y) - (p3.y - p1.y) * (p2.x - p1.x)) / d;

        if (u < 0.0f || u > 1.0f || v < 0.0f || v > 1.0f)
        {
            return false;
        }

        intersection.x = p1.x + u * (p2.x - p1.x);
        intersection.y = p1.y + u * (p2.y - p1.y);

        return true;
    }
}
