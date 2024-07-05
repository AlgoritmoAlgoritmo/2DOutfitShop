/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


#if UNITY_EDITOR
using Game.Gameplay.Items;
using Game.Gameplay.Wallet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Other {
    public class DemoSetup : MonoBehaviour {
        #region Variables
        [SerializeField]
        private int starterAmountOfMoney = 400;
        [SerializeField]
        private WalletDataScriptableObject wallet;
        [SerializeField]
        private ItemDatabaseScriptableObject playerItems;
        [SerializeField]
        private ItemDatabaseScriptableObject starterPlayerInvenyotyData;
        #endregion

        #region MonoBehaviour methods
        private void Awake() {
            ResetData();
        }

        private void OnApplicationQuit() {
            ResetData();
        }
        #endregion

        #region Private methods
        private void ResetData() {
            wallet.MoneyAmount = starterAmountOfMoney;

            playerItems.Items.Clear();

            foreach( var auxItem in starterPlayerInvenyotyData.Items ) {
                playerItems.AddItem( auxItem );
            }
        }
        #endregion
    }
}
#endif