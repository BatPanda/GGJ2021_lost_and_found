using UnityEngine;

public class Item : MonoBehaviour
{
    public TextMesh text;
    public GameObject keep;
    public GameObject trash;


    public ItemStruct item_data;
    public SpriteRenderer sprite_renderer;

    public Nonogram nonoGramHandler;
    private bool nonoStarted = false;
    private bool completed = false;

    private void Start() {
        GameObject[] n = GameObject.FindGameObjectsWithTag("NonogramHandler");
        nonoGramHandler = n[0].GetComponent<Nonogram>();

        sprite_renderer = GetComponent<SpriteRenderer>();
        sprite_renderer.sprite = item_data.sprite;
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0) && !nonoStarted && !completed)
        {
            if (item_data.nonogram_size == NonogramSizes.BIG)
            {
                nonoGramHandler.createGrid(item_data.getNonogramData(item_data.big_nonogram).rows);
            }
            else if (item_data.nonogram_size == NonogramSizes.MEDIUM)
            {
                nonoGramHandler.createGrid(item_data.getNonogramData(item_data.medium_nonogram).rows);
            }
            else
            {
                nonoGramHandler.createGrid(item_data.getNonogramData(item_data.small_nonogram).rows);
            }
            GameObject nonogram = nonoGramHandler.getNonogram();
            nonogram.transform.position = transform.position;
            Debug.Log(transform.position);
            nonoStarted = true;
        }
    }

    void Update()
    {
        if (nonoStarted && !completed)
        {
            if (nonoGramHandler.completed)
            {
                completed = true;
                keep.GetComponent<ButtonScript>().setCanClick();
                trash.GetComponent<ButtonScript>().setCanClick();
                nonoGramHandler.completed = false;
                text.text = "Item: " + item_data.name + ":\nKeep Item?";
            }
        }
    }

    public void takeItem(bool take)
    {
        Debug.Log("DELETING ITEM");
        nonoGramHandler.deleteGrid();
        if (take)
        {
            GameObject[] n = GameObject.FindGameObjectsWithTag("Player");
            GameObject player = n[0];
            player.GetComponent<PlayerItems>().addItem(item_data.name);
        }
        Destroy(text);
        Destroy(trash);
        Destroy(keep);
        sprite_renderer.enabled = false;
    }
}

