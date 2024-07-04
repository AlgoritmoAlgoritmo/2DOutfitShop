/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/



using UnityEngine;
using Game.Gameplay.Items;
using Game.Gameplay.Wallet.Interfaces;
using Game.Gameplay.Inventory.Interfaces;
using Game.Gameplay.Wallet;



namespace Game.Gameplay.Shop {
    public class OutfitShopController : MonoBehaviour {
        #region Variables
        [SerializeField]
        private ItemDatabaseScriptableObject itemDatabase;
        [SerializeField]
        private OutfitShopView outfitShopView;
        [SerializeField]
        private ShopInventoryView shopInventoryView;
        [SerializeField]
        private WalletView walletView;

        private IWallet currentWallet;
        private IInventory currentInventory;
        #endregion


        #region MonoBehaviour methods
        private void Start() {
            Configure();
            outfitShopView.Close();
        }
        #endregion


        #region Public methods
        public void SetCustomerData( GameObject _gameObject ) {
            currentWallet = _gameObject.GetComponent<IWallet>();
            currentInventory = _gameObject.GetComponent<IInventory>();

            RefreshView();
        }

        public void DisplayView() {
            outfitShopView.Display();
        }

        public void CloseView() {
            outfitShopView.Close();
        }

        public void SellItemToPlayer( ItemScriptableObject _item ) {
            try {
                currentWallet.RemoveMoney( _item.ItemPrice );

                try {
                    currentInventory.AddItem( _item );
                    RefreshView();

                // if _item cannot be added, return money to player
                } catch ( System.IndexOutOfRangeException ) {
                    currentWallet.AddMoney( _item.ItemPrice );
                    // TO DO: Display error message
                    Debug.Log( "_item cannot be added, return money to player" );
                }

            // if player doesn't have enough money
            } catch (System.InvalidOperationException) {
                // TO DO: Display error message
                Debug.Log( "player doesn't have enough money" );
            }
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

        private void RefreshView() {
            shopInventoryView.Refresh( currentInventory.GetItemsList() );
            walletView.RefreshWalletView( currentWallet.GetCurrentAmount() );
        }
        #endregion
    }
}