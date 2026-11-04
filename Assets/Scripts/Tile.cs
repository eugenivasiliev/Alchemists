using UnityEngine;
using Elements;

public class Tile : MonoBehaviour
{
    [SerializeField] private Element element;
    public Element Element 
    { 
        get { return element;}
        set 
        {
            element = value;
            ChangeElement(element);
        }
    }

    [SerializeField] private ElementsDB db;
    [SerializeField] private MeshRenderer mr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeElement(Element e) 
    {
        mr.material = db.Materials[(int)e];
    }
}
