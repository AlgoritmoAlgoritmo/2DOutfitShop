/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/



using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


namespace Game.Gameplay.UI.Shop {
    public class InventoryButtonView : MonoBehaviour {
        #region Variables
        [SerializeField]
        private Image icon;
        #endregion

        #region Public methods
        public void Configure( Sprite _newSprite ) {
            icon.sprite = _newSprite;
        }
        #endregion

    }
}