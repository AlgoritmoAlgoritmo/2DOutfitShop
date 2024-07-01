/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/01
*/


using Game.Gameplay.Items;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game.Gameplay.Inventory {
    [System.Serializable]
    public class InventoryView {
        #region Variables
        [SerializeField]
        private GameObject inventoryPanel;
        [SerializeField]
        private GameObject itemButtonPrefab;
        [SerializeField]
        private Transform inventoryButtonsParent;

        private List<GameObject> buttonsInstances = new List<GameObject>();
        #endregion


        #region Public methods
        public void DisplayInventory() {
            inventoryPanel.SetActive( true );
        }

        public void HideInventory() {
            inventoryPanel.SetActive( false );
        }

        public void Refresh( List<ItemScriptableObject> _items) {
            DeleteAllInstances();
            InstantiateNewButtons( _items );
        }
        #endregion


        #region Private methods
        private void DeleteAllInstances() {
            foreach( var auxButton in buttonsInstances ) {
                auxButton.SetActive( false );
                GameObject.Destroy( auxButton, .05f );
            }

            buttonsInstances.Clear();
        }

        private void InstantiateNewButtons( List<ItemScriptableObject> _itemList ) {
            foreach( var auxItem in _itemList ) {
                buttonsInstances.Add( InstantiateNewButton( auxItem ) );
            }
        }

        private GameObject InstantiateNewButton( ItemScriptableObject _item ) {
            GameObject instance = GameObject.Instantiate( itemButtonPrefab, inventoryButtonsParent );

            return instance.gameObject;
        }
        #endregion
    }
}