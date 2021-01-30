using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ItemHandler : MonoBehaviour
{
    public List<ItemStruct> items;

    public List<GameObject> spawn_locations;

    public GameObject item_prefab; 

    private void Start() {
        foreach(GameObject element in spawn_locations) {
            Instantiate(item_prefab, element.transform.position, Quaternion.identity);
        }
    }
}

