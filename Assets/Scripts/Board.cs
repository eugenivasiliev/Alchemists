using UnityEngine;
using Elements;

public class Board : MonoBehaviour
{
    public int SIZE_X;
    public int SIZE_Y;
    public Tile[,] tiles;
    public GameObject[,] tileObjects;
    public GameObject tilePrefab;

    void Start()
    {
        tiles = new Tile[SIZE_X, SIZE_Y];
        for(int x = 0; x < SIZE_X; x++) {
            for(int y = 0; y < SIZE_Y; y++) {
                tiles[x, y] = Instantiate(tilePrefab, this.transform.position + new Vector3(x, 0, y), Quaternion.identity, this.transform).GetComponent<Tile>();
            }
        }
    }

    void Update()
    {
        
    }

    public bool GetTilesX(int startX, int startY, int length, out Element[] tiles) 
    {
        tiles = new Element[length];
        return false;
        // try {
        //     for(int i = 0; i < length; ++i) tiles[i] = this.tiles[startX + i, startY];
        //     return true;
        // } catch {
        //     return false;
        // }
    }

    public bool GetTilesY(int startX, int startY, int length, out Element[] tiles) 
    {
        tiles = new Element[length];
        return false;
        // try {
        //     for(int i = 0; i < length; ++i) tiles[i] = this.tiles[startX, startY + i];
        //     return true;
        // } catch {
        //     return false;
        // }
    }

    public bool SetTileAt(int x, int y, Element tile) 
    {
        if(0 > x || x >= SIZE_X || 0 > y || y >= SIZE_Y) return false;
        tiles[x, y].Element = tile;
        RefreshTiles();
        return true;
    }

    private void RefreshTiles() 
    {
        for(int x = 0; x < SIZE_X; x++) {
            for(int y = 0; y < SIZE_Y; y++) {
                //tileObjects[x, y].tile = tiles[x, y];
            }
        }
    }
}
