/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Game.Gameplay.Items;
using Game.Gameplay.UI.Shop;
using Game.Gameplay.Inventory.Interfaces;
using UnityEngine.Events;

namespace Game.Gameplay.Shop {
    [System.Serializable]
    public class ShopInventoryView : IIventoryView{
        #region Variables
        [SerializeField]
        private Transform buttonParent;
        [SerializeField]
        private InventoryButtonView buttonPrefab;

        public UnityEvent<ItemScriptableObject> OnButtonPressed 
                                = new UnityEvent<ItemScriptableObject>();


        private List<GameObject> buttonsInstances = new List<GameObject>();
        #endregion


        #region Public methods
        public void Refresh( List<ItemScriptableObject> _itemList ) {
            DeleteAllInstances();
            InstantiateNewButtons( _itemList );
        }

        public void DisplayInventory() {
            // Not implemented due to a lack of use
            throw new System.NotImplementedException();
        }

        public void HideInventory() {
            // Intentionally not implemented due to a lack of use
            throw new System.NotImplementedException();
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
            InventoryButtonView instance = GameObject.Instantiate( buttonPrefab, buttonParent );

            instance.Configure( _item.ItemSprite );

            try {
                instance.GetComponent<Button>().onClick.AddListener( delegate { 
                                                            OnButtonPressed.Invoke( _item ); } );

            } catch ( System.NullReferenceException ) {
                Debug.Log( "Make sure there is a Button cumponent in the inventory button prefab." );
            }

            return instance.gameObject;
        }        
        #endregion
    }
}