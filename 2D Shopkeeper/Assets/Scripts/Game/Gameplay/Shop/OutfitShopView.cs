/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/



using Game.UI.Shop;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



namespace Game.Gameplay.Shop {
    [System.Serializable]
    public class OutfitShopView  {
        #region Variables
        [SerializeField]
        private GameObject uiParentObject;
        [SerializeField]
        private Transform itemButtonsParent;
        [SerializeField]
        private ShopIttemButtonView itemButtonPrefab;
        #endregion



        #region Public methods
        public void Display() {
            uiParentObject.SetActive( true );
        }

        public void Close() {
            uiParentObject.SetActive( false );
        }

        public void AddNewButton( Sprite _newIcon, string _itemName,
                                    string _itemPrice, UnityAction _action ) {
            ShopIttemButtonView itemButtonInstance = GameObject.Instantiate( itemButtonPrefab,
                                                                             itemButtonsParent );
            itemButtonInstance.Configure( _newIcon, _itemName, _itemPrice  );
            itemButtonInstance.AddActionToButtonEvent( _action );
        }
        #endregion



        #region Private methods
        #endregion
    }
}