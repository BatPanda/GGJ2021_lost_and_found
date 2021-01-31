using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemStruct item_data;
    public SpriteRenderer sprite_renderer;

    private void Start() {
        sprite_renderer = GetComponent<SpriteRenderer>();
        sprite_renderer.sprite = item_data.typeSprite;
    }
}

