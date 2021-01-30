using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[ExecuteInEditMode]
public class MapShape : MonoBehaviour
{
    public struct Line
    {
        public Transform Start;
        public Transform End;
    }

    public struct VectorLine
    {
        public Vector3 Start;
        public Vector3 End;
    }

    private List<Transform> m_nodes = default;

    public IEnumerable<Transform> Nodes { get { return m_nodes; } }

    public IEnumerable<Line> GetNodeLines(Transform node)
    {
        int index = m_nodes.IndexOf(node);

        int prevIndex = index == 0 ? m_nodes.Count - 1 : index - 1;
        yield return new Line() { Start = node, End = m_nodes[prevIndex] };

        int nextIndex = index >= m_nodes.Count - 1 ? 0 : index + 1;
        yield return new Line() { Start = node, End = m_nodes[nextIndex] };
    }

    private void Update()
    {
        m_nodes = GetComponentsInChildren<Transform>().ToList();
        m_nodes.Remove(transform);
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < m_nodes.Count; i++)
        {
            Transform currentNode = m_nodes[i];
            Transform nextNode = i >= m_nodes.Count - 1 ? m_nodes[0] : m_nodes[i + 1];

            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(currentNode.position, nextNode.position);
        }
    }
}
