using UnityEngine;
using Elements;
using UnityEngine.UI;

public class Hand : MonoBehaviour
{
    [SerializeField] private int[] tileCounts = new int[(int)Element.COUNT];
    [SerializeField] private Element? selectedTile = Element.ELEMENT1;
    public Element? SelectedTile => selectedTile;
    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private Card[] cards = new Card[(int)Element.COUNT];
    [SerializeField] private Transform layout;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < (int)Element.COUNT; i++) {
            cards[i] = Instantiate(cardPrefab, layout).GetComponent<Card>();
            Element tile = (Element)i;
            cards[i].Tile = tile;
            HookUpButton(cards[i].button, tile, OnClick);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HookUpButton(Button button, Element tile, System.Action<Element> callback) {
        button.onClick.AddListener( () => callback(tile) );
    }

    void OnClick(Element tile) {
        selectedTile = tile;
    }
}
