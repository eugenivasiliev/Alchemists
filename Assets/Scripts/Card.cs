using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Tiles;

public class Card : MonoBehaviour
{
    public Button button;
    public Image image;
    public ElementsDB db;
    private Tile tile;
    public Tile Tile { 
        get { return tile; }
        set 
        { 
            tile = value;
            image.sprite = db.Sprites[(int)tile];
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
