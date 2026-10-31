using UnityEngine;
using Tiles;

public class Hand : MonoBehaviour
{
    [SerializeField] private int[] tileCounts = new int[(int)Tile.COUNT];
    [SerializeField] private Tile? selectedTile = null;
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Card[] cards = new Card[(int)Tile.COUNT];
    [SerializeField] private Transform layout;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < (int)Tile.COUNT; i++) {
            cards[i] = Instantiate(cardPrefab, layout).GetComponent<Card>();
            cards[i].Tile = (Tile)i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
