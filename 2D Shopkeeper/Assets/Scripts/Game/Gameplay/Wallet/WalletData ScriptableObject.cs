/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game.Gameplay.Wallet {
    [CreateAssetMenu( fileName = "New Wallet ScriptableObject",
                menuName = "BGSTask/Wallet/Wallet ScriptableObject" )]
    public class WalletDataScriptableObject : ScriptableObject {
        #region Variables
        [SerializeField]
        private int moneyAmount;
        public int MoneyAmount {
            get => moneyAmount;
            set => moneyAmount = value; }
        #endregion

            #region Public methods
        public void AddMoney( int _amount) {
            moneyAmount += _amount;
        }

        public void RemoveMoney( int _amount ) {
            moneyAmount -= _amount;
        }
        #endregion
    }
}