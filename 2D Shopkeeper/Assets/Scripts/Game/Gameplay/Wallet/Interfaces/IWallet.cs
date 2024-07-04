/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


namespace Game.Gameplay.Wallet.Interfaces {
    public interface IWallet {
        #region Public methods
        public int GetCurrentAmount();
        public void AddMoney( int _amount );
        public void RemoveMoney( int _amount );
        #endregion
    }
}