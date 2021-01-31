using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nonogram : MonoBehaviour
{
    public bool completed = false;

    private Item thisItem;

    public GameObject parent;

    private Dictionary<(bool, int), List<GameObject>> sides = new Dictionary<(bool, int), List<GameObject>>();

    public GameObject sampleObject;
    public GameObject sampleSide;
    private Dictionary<GridPos, GameObject> grid = new Dictionary<GridPos, GameObject>();

    private List<GridPos> rightValues = new List<GridPos>();

    private float xScale = 0.32f;
    private float yScale = 0.32f;
    private GridPos maxPos = new GridPos(-1, -1);

    // Start is called before the first frame update
    void Start()
    {
    }

    public GameObject getNonogram()
    {
        return parent;
    }

    public void deleteGrid()
    {
        if (thisItem != null)
        {
            thisItem.setNonoStarted(false);
        }

        foreach(var g in grid)
        {
            Destroy(g.Value);
        }
        grid.Clear();

        foreach(var side in sides)
        {
            foreach(var s in side.Value)
            {
                Destroy(s);
            }
        }
        sides.Clear();

        rightValues.Clear();
    }
    public void createGrid(List<List<int>> map, Item item)
    {
        parent.transform.position = new Vector3(0, 0, 0);
        deleteGrid();
        thisItem = item;

        maxPos = new GridPos(-1, -1);

        Debug.Log("CREATING GRID");
        for (int row = 0; row < map.Count; row++)
        {
            if (row > maxPos.y)
            {
                maxPos.y = row;
                maxPos.x = map[row].Count - 1;
            }
            List<int> numbers = new List<int>();
            int last = -2;
            for (int i = 0; i < map[row].Count; i++)
            {
                GridPos pos = new GridPos(i, row);
                GameObject g = Instantiate(sampleObject);
                g.GetComponent<NongramTile>().setGridPos(pos);
                g.transform.position = pos.convertToVector3(xScale, yScale);
                g.transform.position = new Vector3(g.transform.position.x, g.transform.position.y, -1);
                grid[pos] = g;
                g.transform.SetParent(parent.transform);

                if (map[row][i] == 1)
                {
                    if (last == i - 1)
                    {
                        numbers[numbers.Count - 1]++;
                    }
                    else
                    {
                        numbers.Add(1);
                    }
                    last = i;
                    rightValues.Add(pos);
                }
            }

            if (numbers.Count != 0)
            {
                List<GameObject> thisSide = new List<GameObject>(); 
                for (int i = 0; i < numbers.Count; i++)
                {
                    GameObject side = Instantiate(sampleSide);
                    side.GetComponent<SideBar>().setText(numbers[i]);
                    side.transform.position = new Vector3(-xScale * numbers.Count + xScale * i, row * yScale, 0);
                    side.transform.SetParent(parent.transform);
                    thisSide.Add(side);
                }
                sides[(true, row)] = thisSide;
            }
            
        }

        for (int x = 0; x <= maxPos.x; x++)
        {
            List<int> numbers = new List<int>();
            int last = -2;
            for (int y = 0; y <= maxPos.y; y++)
            {
                if (rightValues.Contains(new GridPos(x, y)))
                {
                    if (last == y-1)
                    {
                        numbers[numbers.Count - 1]++;
                    }
                    else
                    {
                        numbers.Add(1);
                    }
                    last = y;
                }
            }

            List<GameObject> thisSide = new List<GameObject>();
            for (int i = 0; i < numbers.Count; i++)
            {
                GameObject side = Instantiate(sampleSide);
                side.GetComponent<SideBar>().setText(numbers[i]);
                side.transform.position = new Vector3(x * xScale, yScale * (maxPos.y+1) + yScale * i, 0);
                side.transform.SetParent(parent.transform);
                thisSide.Add(side);
            }
            sides[(false, x)] = thisSide;
        }
    }

    public bool checkCompletion(GridPos pos)
    {
        bool won = true;
        for (int iteration = 0; iteration < 2; iteration++)
        {
            bool lineWon = true;
            for (int i = 0; i <= (iteration == 0 ? maxPos.x : maxPos.y) && lineWon; i++)
            {
                GridPos thisPos = new GridPos((iteration == 0 ? i : pos.x), (iteration == 0 ? pos.y : i));
                NongramTile gtile = grid[thisPos].GetComponent<NongramTile>();
                bool contained = rightValues.Contains(thisPos);
                if ((gtile.activated && !contained) || (!gtile.activated && contained))
                {
                    lineWon = false;
                    won = false;
                }
            }
            if (lineWon) crossLine((iteration == 0 ? pos.y : pos.x), iteration == 0);
        }
        if (!won) return false;
        foreach (var tile in grid)
        {
            NongramTile gtile = tile.Value.GetComponent<NongramTile>();
            bool contained = rightValues.Contains(tile.Key);
            if ((gtile.activated && !contained) || (!gtile.activated && contained))
            {
                return false;
            }
        }
        completed = true;
        uncrossAllTiles();
        return true;
    }

    private void crossLine(int val, bool hori)
    {
        for (int i = 0; i <= (hori ? maxPos.x : maxPos.y); i++)
        {
            GridPos thisPos = new GridPos((hori ? i : val), (!hori ? i : val));
            NongramTile gtile = grid[thisPos].GetComponent<NongramTile>();
            if (!gtile.activated)
            {
                gtile.setTileCross();
            }
        }

        if (sides.ContainsKey((hori, val)))
        {
            for (int i = 0; i < sides[(hori, val)].Count; i++)
            {
                sides[(hori, val)][i].GetComponent<SideBar>().crossOut(true);
            }
        }
    }

    private void uncrossAllTiles()
    {
        foreach(var tile in grid)
        {
            tile.Value.GetComponent<NongramTile>().uncrossTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
