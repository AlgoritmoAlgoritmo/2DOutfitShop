/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Gameplay.Items;
using Game.Gameplay.Wallet.Interfaces;

namespace Game.Gameplay.Shop {
    public class OutfitShopController : MonoBehaviour {
        #region Variables
        [SerializeField]
        private OutfitShopView outfitShopView;
        [SerializeField]
        private ItemDatabaseScriptableObject itemDatabase;

        private IWallet currentWallet;
        #endregion

        #region MonoBehaviour methods
        private void Start() {
            Configure();
            outfitShopView.Close();
        }
        #endregion

        #region Public methods
        public void SetWallet( GameObject _gameObject ) {
            currentWallet = _gameObject.GetComponent<IWallet>();
        }

        public void DisplayView() {
            outfitShopView.Display();
        }

        public void CloseView() {
            outfitShopView.Close();
        }

        public void SellItemToPlayer( ItemScriptableObject _item ) {
            currentWallet.RemoveMoney( _item.ItemPrice );
        }
        #endregion

        #region Private methods
        private void Configure() {
            foreach( var auxItem in itemDatabase.Items ) {
                outfitShopView.AddNewButton( auxItem.ItemSprite,
                                            auxItem.ItemName,
                                            auxItem.ItemPrice.ToString(),
                                            delegate { SellItemToPlayer( auxItem ); } );
            }
        }
        #endregion
    }
}