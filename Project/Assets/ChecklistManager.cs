using System.Collections.Generic;
using UnityEngine;

public class ChecklistManager : MonoBehaviour
{
    public ItemHandler m_itemHandler;
    public int numberOfItems = 8;
    public ListItem listItemPrefab;

    private Dictionary<string, ListItem> m_items = new Dictionary<string, ListItem>();

    private void Start()
    {
        List<int> current = new List<int>();
        for(int i = 0; i < numberOfItems; i++)
        {
            int index = Random.Range(0, m_itemHandler.items.Count);
            while (current.Contains(index))
            {
                index = Random.Range(0, m_itemHandler.items.Count);
            }
            current.Add(index);

            ListItem item = Instantiate(listItemPrefab, transform);
            item.CompletedToggle.isOn = false;
            item.Text.text = m_itemHandler.items[index].name;
            m_items.Add(m_itemHandler.items[index].name, item);
        }
    }

    public void CompleteItem(string item)
    {
        if (m_items.ContainsKey(item))
        {
            m_items[item].CompletedToggle.isOn = true;
        }
    }
}
