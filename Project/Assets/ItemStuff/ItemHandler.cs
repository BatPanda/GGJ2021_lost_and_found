using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemHandler : MonoBehaviour
{
    public List<ItemStruct> items;

    public List<GameObject> spawn_locations;

    public GameObject item_prefab;

    private System.Random rng = new System.Random(Guid.NewGuid().GetHashCode());

    public void Shuffle<T>(IList<T> list) {
        int n = list.Count;
        while (n > 1) {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    private void Start() {

        List < ItemStruct > shuffled_items = items;

        Shuffle(shuffled_items);

        int iter = 0;

        foreach(GameObject element in spawn_locations) {
            GameObject go = Instantiate(item_prefab, element.transform.position, Quaternion.identity);
            go.GetComponent<Item>().item_data = shuffled_items[iter];

            iter++;
        }
    }
}

