using UnityEngine;

namespace Elements {
    public struct Combination
    {
        public Element[] tiles;
        public Bonus bonus;

        public bool CheckTiles(Element[] tiles) {
            if(tiles.Length != this.tiles.Length) return false;

            bool standard = true, reverse = true;
            for(int i = 0; i < tiles.Length; i++) if(tiles[i] != this.tiles[i]) { standard = false; break; }
            for(int i = 0; i < tiles.Length; i++) if(tiles[tiles.Length - i - 1] != this.tiles[i]) { reverse = false; break; }

            return standard || reverse;
        }
    }
}