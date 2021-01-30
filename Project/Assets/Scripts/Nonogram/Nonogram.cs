﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nonogram : MonoBehaviour
{
    public bool completed = false;

    public GameObject sampleObject;
    public GameObject sampleSide;
    public string jsonFileName;
    private Dictionary<GridPos, GameObject> grid = new Dictionary<GridPos, GameObject>();

    private List<GridPos> rightValues = new List<GridPos>();

    private float xScale = 0.32f;
    private float yScale = 0.32f;
    private GridPos maxPos = new GridPos(-1, -1);

    // Start is called before the first frame update
    void Start()
    {
        string json = getJsonFromFile(jsonFileName);
        if (json != "")
        {
            
        }

        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        for (int i = 0; i < 5; i++)
        {
            map[i] = new List<int>();
            map[i].Add(Random.Range(0, 2));
            map[i].Add(Random.Range(0, 2));
            map[i].Add(Random.Range(0, 2));
            map[i].Add(Random.Range(0, 2));
            map[i].Add(Random.Range(0, 2));
        }

        createGrid(map);
    }

    private string getFilePath(string name)
    {
        return Application.persistentDataPath + "/" + name;
    }

    private string getJsonFromFile(string name)
    {
        Debug.Log(name);
        
        var sr = Resources.Load<TextAsset>(name);

        //var sr = new StreamReader(Application.dataPath + "/" + fileName);
        string fileContents = sr.text;

        return fileContents;
    }

    private void loadNonogramFromJson(string json)
    {
        List<int> map = JsonUtility.FromJson<List<int>>(json);
        foreach(var m in map)
        {
            Debug.Log(m);
        }
        Debug.Log("FINISHED");
        //createGrid(map);
    }

    private void createGrid(Dictionary<int, List<int>> map)
    {
        foreach (KeyValuePair<int, List<int>> hori in map)
        {
            if (hori.Key > maxPos.y)
            {
                maxPos.y = hori.Key;
                maxPos.x = hori.Value.Count-1;
            }
            List<int> numbers = new List<int>();
            int last = -2;
            for(int i = 0; i < hori.Value.Count; i++)
            {
                GridPos pos = new GridPos(i, hori.Key);
                GameObject g = Instantiate(sampleObject);
                g.GetComponent<NongramTile>().setGridPos(pos);
                g.transform.position = pos.convertToVector3(xScale, yScale);
                grid[pos] = g;
                if (hori.Value[i] == 1)
                {
                    if (last == i-1)
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

            for (int i = 0; i < numbers.Count; i++)
            {
                GameObject side = Instantiate(sampleSide);
                side.GetComponent<SideBar>().setText(numbers[i]);
                side.transform.position = new Vector3(-xScale * numbers.Count + xScale * i, hori.Key * yScale, 0);
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

            for (int i = 0; i < numbers.Count; i++)
            {
                GameObject side = Instantiate(sampleSide);
                side.GetComponent<SideBar>().setText(numbers[i]);
                side.transform.position = new Vector3(x * xScale, yScale * (maxPos.y+1) + yScale * i, 0);
            }
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
