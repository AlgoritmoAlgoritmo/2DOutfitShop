/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/01
*/


using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Game.Gameplay.Items;
using Game.Gameplay.Inventory.Interfaces;


namespace Game.Gameplay.Inventory {
    [System.Serializable]
    public class InventoryView : IIventoryView {
        #region Variables
        [SerializeField]
        private GameObject inventoryPanel;
        [SerializeField]
        private GameObject itemButtonPrefab;
        [SerializeField]
        private string icongObjectName = "Icon";

        [SerializeField]
        private Transform inventoryButtonsParent;

        public UnityEvent<ItemScriptableObject> OnItemButtonClicked 
                                    = new UnityEvent<ItemScriptableObject>();

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
            GameObject instance = GameObject.Instantiate( itemButtonPrefab,
                                                            inventoryButtonsParent );
            
            try {
                instance.transform.Find( icongObjectName ).GetComponent<Image>()
                                                            .sprite = _item.ItemSprite;
            } catch {
                Debug.Log($"Make sure there is an {icongObjectName} child object in the button prefab.");
            }

            try {
                instance.GetComponent<Button>().onClick.AddListener( delegate {
                                                                 OnItemButtonClicked.Invoke(_item); });
            } catch {
                Debug.Log($"Make sure there is a UnityEngine.UI.Button component in the button prefab.");
            }

            return instance.gameObject;
        }

        #endregion
    }
}