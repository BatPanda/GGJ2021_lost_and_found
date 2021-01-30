using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemStruct item_data;
    public SpriteRenderer sprite_renderer;

    private void Start() {
        sprite_renderer.sprite = item_data.sprite;
    }
}

