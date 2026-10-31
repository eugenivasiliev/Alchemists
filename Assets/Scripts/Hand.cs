using UnityEngine;
using Tiles;

public class Hand : MonoBehaviour
{
    [SerializeField] private int[] tileCounts = new int[(int)Tile.COUNT];
    [SerializeField] private Tile? selectedTile = null;
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private GameObject[] cards;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
