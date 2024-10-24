/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Game.Gameplay.Items;
using Game.Gameplay.Inventory.Interfaces;


namespace Game.Gameplay.Inventory {
    [System.Serializable]
    public class InventoryController : IInventory {
        #region Variables
        [SerializeField]
        private InventoryDataScriptableObject inventoryDataScriptableObject;
        [SerializeField]
        private InventoryView inventoryView;
        #endregion

        #region Public methods
        public void OpenInventory() {
            inventoryView.DisplayInventory();
            inventoryView.Refresh( inventoryDataScriptableObject.GetItems() );
        }

        public void CloseInventory() {
            inventoryView.HideInventory();
        }

        public void AddItem( ItemScriptableObject _item ) {
            inventoryDataScriptableObject.AddItem(_item);
        }

        public void RemoveItem( ItemScriptableObject _item ) {
            inventoryDataScriptableObject.RemoveItem( _item );
        }

        public List<ItemScriptableObject> GetItemsList() {
            return inventoryDataScriptableObject.GetItems();
        }

        public void SubscribeToOnItemButtonClickedEvent( 
                                    UnityAction<ItemScriptableObject> _action ) {
            inventoryView.OnItemButtonClicked.AddListener(_action);
        }
        #endregion
    }
}