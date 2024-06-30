/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using Game.Gameplay.Items;


namespace Game.Gameplay.Inventory.Interfaces {
    public interface IInventory {
        #region Public methods
        public void AddItem( ItemScriptableObject _item );
        public void RemoveItem( ItemScriptableObject _item );
        #endregion
    }
}