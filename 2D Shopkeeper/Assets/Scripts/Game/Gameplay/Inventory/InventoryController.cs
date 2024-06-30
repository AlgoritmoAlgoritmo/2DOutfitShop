/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using Game.Gameplay.Inventory.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Gameplay.Items;



namespace Game.Gameplay.Inventory {
    public class InventoryController : MonoBehaviour, IInventory {
        #region Variables
        [SerializeField]
        private InventoryView inventoryView;
        [SerializeField]
        private InventoryDataScriptableObject inventoryDataScriptableObject;
        #endregion

        #region Public methods
        public void AddItem( ItemScriptableObject _item ) {
            inventoryDataScriptableObject.AddItem(_item);
        }

        public void RemoveItem( ItemScriptableObject _item ) {
            inventoryDataScriptableObject.RemoveItem( _item );
        }
        #endregion

        #region Private methods
        #endregion
    }
}