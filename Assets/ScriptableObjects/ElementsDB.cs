using UnityEngine;
using Tiles;

[CreateAssetMenu(fileName = "ElementsDB", menuName = "Scriptable Objects/ElementsDB")]
public class ElementsDB : ScriptableObject
{
    [SerializeField] private Sprite[] sprites = new Sprite[(int)Tile.COUNT];
    public Sprite[] Sprites { get { return sprites; } }
}
