using UnityEngine;
using System.Collections.Generic;
using Tiles;

public class RecipeList : MonoBehaviour
{
    public List<Combination> combinations;
    public int maxCombination { get; private set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxCombination = 0;
        foreach (Combination c in combinations)
            maxCombination = Mathf.Max(c.tiles.Length, maxCombination);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
