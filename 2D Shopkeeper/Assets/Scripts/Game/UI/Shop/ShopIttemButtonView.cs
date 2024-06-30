/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;



namespace Game.UI.Shop {
    public class ShopIttemButtonView : MonoBehaviour {
        #region Variables
        [SerializeField]
        private TMP_Text itemNameText;
        [SerializeField]
        private TMP_Text itemPriceText;
        [SerializeField]
        private Image itemIconImage;
        #endregion

        #region Public methods
        public void Configure( Sprite _newIcon, string _itemName, string _itemPrice ) {
            itemIconImage.sprite = _newIcon;
            itemNameText.text = _itemName;
            itemPriceText.text = _itemPrice;
        }

        public void AddActionToButtonEvent( UnityAction _action ) {
            GetComponentInChildren<Button>().onClick.AddListener( _action );
        }
        #endregion

        #region Private methods
        #endregion
    }
}