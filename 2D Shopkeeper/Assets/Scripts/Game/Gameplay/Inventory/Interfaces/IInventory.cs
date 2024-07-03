/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using Game.Gameplay.Items;
using System.Collections.Generic;


namespace Game.Gameplay.Inventory.Interfaces {
    public interface IInventory {
        #region Public methods
        public void OpenInventory();
        public void CloseInventory();

        public void AddItem( ItemScriptableObject _item );
        public void RemoveItem( ItemScriptableObject _item );
        public List<ItemScriptableObject> GetItemsList();
        #endregion
    }
}