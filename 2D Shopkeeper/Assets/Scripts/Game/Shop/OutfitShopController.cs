/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game.Shop {
    public class OutfitShopController : MonoBehaviour {
        #region Variables
        [SerializeField]
        private OutfitShopView outfitShopView;
        #endregion


        #region MonoBehaviour methods
        private void Start() {
            Configure();
            outfitShopView.Close();
        }
        #endregion

        #region Public methods
        public void DisplayView() {
            outfitShopView.Display();
        }

        public void CloseView() {
            outfitShopView.Close();
        }
        #endregion

        #region Private methods
        private void Configure() {
            
        }
        #endregion
    }
}