 /*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/04
*/


using UnityEngine;
using TMPro;
using Game.Gameplay.Wallet.Interfaces;


namespace Game.Gameplay.Wallet {
    [System.Serializable]
    public class WalletView : IWalletView {
        #region Variables
        [SerializeField]
        private TMP_Text moneyAmountDisplayText;
        #endregion


        #region Public methods
        public void RefreshWalletView( int _amount ) {
            moneyAmountDisplayText.text = _amount.ToString();
        }
        #endregion
    }
}