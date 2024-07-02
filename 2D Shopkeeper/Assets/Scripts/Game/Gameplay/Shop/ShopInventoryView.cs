/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using System.Collections.Generic;
using UnityEngine;
using Game.Gameplay.Items;
using Game.Gameplay.UI.Shop;


namespace Game.Gameplay.Shop {
    [System.Serializable]
    public class ShopInventoryView {
        #region Variables
        [SerializeField]
        private Transform buttonParent;
        [SerializeField]
        private InventoryButtonView buttonPrefab;

        private List<GameObject> buttonsInstances = new List<GameObject>();
        #endregion


        #region Public methods
        public void Refresh( List<ItemScriptableObject> _itemList ) {
            DeleteAllInstances();
            InstantiateNewButtons( _itemList );
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

            return instance.gameObject;
        }
        #endregion
    }
}