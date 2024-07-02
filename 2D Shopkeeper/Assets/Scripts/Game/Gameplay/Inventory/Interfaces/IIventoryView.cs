/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/02
*/



using System.Collections.Generic;
using Game.Gameplay.Items;


namespace Game.Gameplay.Inventory.Interfaces {
    public interface IIventoryView {
        #region Public methods
        public void DisplayInventory();
        public void HideInventory();
        public void Refresh( List<ItemScriptableObject> _itemList );
        #endregion
    }
}