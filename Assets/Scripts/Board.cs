using UnityEngine;
using Tiles;

public class Board : MonoBehaviour
{
    public int SIZE_X;
    public int SIZE_Y;
    public Tile[,] tiles;
    public GameObject[,] tileObjects;
    public GameObject tilePrefab;

    void Start()
    {
        tileObjects = new GameObject[SIZE_X, SIZE_Y];
        for(int x = 0; x < SIZE_X; x++) {
            for(int y = 0; y < SIZE_Y; y++) {
                tileObjects[x, y] = Instantiate(tilePrefab, this.transform.position + new Vector3(x, 0, y), Quaternion.identity, this.transform);
            }
        }
    }

    void Update()
    {
        
    }

    public bool GetTilesX(int startX, int startY, int length, out Tile[] tiles) 
    {
        tiles = new Tile[length];
        try {
            for(int i = 0; i < length; ++i) tiles[i] = this.tiles[startX + i, startY];
            return true;
        } catch {
            return false;
        }
    }

    public bool GetTilesY(int startX, int startY, int length, out Tile[] tiles) 
    {
        tiles = new Tile[length];
        try {
            for(int i = 0; i < length; ++i) tiles[i] = this.tiles[startX, startY + i];
            return true;
        } catch {
            return false;
        }
    }
}
