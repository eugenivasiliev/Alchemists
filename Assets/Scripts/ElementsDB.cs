using UnityEngine;
using Elements;

[CreateAssetMenu(fileName = "ElementsDB", menuName = "Scriptable Objects/ElementsDB")]
public class ElementsDB : ScriptableObject
{
    [SerializeField] private Sprite[] sprites = new Sprite[(int)Element.COUNT];
    public Sprite[] Sprites { get { return sprites; } }

    [SerializeField] private Material[] materials = new Material[(int)Element.COUNT];
    public Material[] Materials { get { return materials; } }
}
