using UnityEngine;
using Tiles;
using UnityEngine.InputSystem;

public class BoardManager : MonoBehaviour
{
    public Board board;
    public RecipeList recipeList;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(InputAction.CallbackContext ctx) 
    {

        Camera cam = Camera.main;
        Vector2 mousePos = ctx.ReadValue<Vector2>();

        Vector3 clickPos = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.transform.position.y));
        if(ctx.performed) Destroy(board.tileObjects[Mathf.FloorToInt(clickPos.x), Mathf.FloorToInt(clickPos.z)]);
    }

    public void RefreshBoard(int x, int y, Tile t) 
    {
        foreach(Combination c in recipeList.combinations) {
            Tile[] tiles = {};
            for(int i = -c.tiles.Length; i < 0; i++) {
                if(board.GetTilesX(x + i + 1, y, c.tiles.Length, out tiles)) {
                    if(c.CheckTiles(tiles)) {
                        //Horizontal true
                    }
                }

                if(board.GetTilesY(x, y + i + 1, c.tiles.Length, out tiles)) {
                    if(c.CheckTiles(tiles)) {
                        //Vertical true
                    }
                }
            }
        }
    }
}
