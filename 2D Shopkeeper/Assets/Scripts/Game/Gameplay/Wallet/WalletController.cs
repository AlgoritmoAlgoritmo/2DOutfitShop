/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Gameplay.Wallet.Interfaces;


namespace Game.Gameplay.Wallet {
    public class WalletController : MonoBehaviour, IWallet {
        #region Variables
        [SerializeField]
        private WalletDataScriptableObject walletDataScriptableObject;
        #endregion


        #region Public methods
        public int GetCurrentAmount() {
            return walletDataScriptableObject.MoneyAmount;
        }

        public void AddMoney( int _amount ) {
            walletDataScriptableObject.AddMoney(_amount);
        }

        public void RemoveMoney( int _amount ) {
            if( walletDataScriptableObject.MoneyAmount < _amount )
                throw new System.InvalidOperationException(
                        "Thre's not enough enough money in the wallet");

            walletDataScriptableObject.RemoveMoney( _amount );
        }
        #endregion
    }
}