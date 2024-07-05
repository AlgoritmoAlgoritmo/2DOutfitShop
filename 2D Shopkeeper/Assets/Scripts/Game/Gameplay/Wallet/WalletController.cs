/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using UnityEngine;
using Game.Gameplay.Wallet.Interfaces;


namespace Game.Gameplay.Wallet {
    [System.Serializable]
    public class WalletController : IWallet {
        #region Variables
        [SerializeField]
        private WalletDataScriptableObject walletDataScriptableObject;
        [SerializeField]
        private WalletView walletView;
        #endregion


        #region Public methods
        public void Initialize() {
            walletView.RefreshWalletView( walletDataScriptableObject.MoneyAmount );
        }

        public int GetCurrentAmount() {
            return walletDataScriptableObject.MoneyAmount;
        }

        public void AddMoney( int _amount ) {
            walletDataScriptableObject.AddMoney(_amount);
            walletView.RefreshWalletView( walletDataScriptableObject.MoneyAmount );
        }

        public void RemoveMoney( int _amount ) {
            if( walletDataScriptableObject.MoneyAmount < _amount )
                throw new System.InvalidOperationException( "Thre's not enough enough "
                                                                + "money in the wallet");
            walletDataScriptableObject.RemoveMoney( _amount );
            walletView.RefreshWalletView( walletDataScriptableObject.MoneyAmount );
        }
        #endregion
    }
}