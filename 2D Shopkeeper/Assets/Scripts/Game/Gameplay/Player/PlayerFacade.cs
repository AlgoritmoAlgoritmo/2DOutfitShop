/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/03
*/


using System.Collections.Generic;
using UnityEngine;
using Game.Gameplay.Items;
using Game.Gameplay.Inventory;
using Game.Gameplay.Inventory.Interfaces;
using Game.Gameplay.Equipment;
using Game.Gameplay.Equipment.Data;
using Game.Gameplay.Equipment.Interfaces;
using Game.Gameplay.Wallet;
using Game.Gameplay.Wallet.Interfaces;


namespace Game.Gameplay.Player {
    public class PlayerFacade : MonoBehaviour,  IEquipment,
                                                IInventory,
                                                IWallet {
        #region Variables
        [SerializeField]
        private InventoryController inventoryController = new InventoryController();
        [SerializeField]
        private EquipmentContainer equipmentContainer = new EquipmentContainer();
        [SerializeField]
        private WalletController walletController = new WalletController();
        #endregion


        #region MonoBehaviour methods
        private void Awake() {
            equipmentContainer.Initialize();
            walletController.Initialize();
            inventoryController.SubscribeToOnItemButtonClickedEvent( EquipItem );
        }
        #endregion


        #region Public methods
        public void EquipItem( ItemScriptableObject _item ) {
            if( _item is EquipableItemScriptableObject ) {
                EquipItem( _item as EquipableItemScriptableObject );
            }
        }
        #endregion


        #region IInventory methods
        public void OpenInventory() {
            inventoryController.OpenInventory();
        }

        public void CloseInventory() {
            inventoryController.CloseInventory();
        }

        public void AddItem( ItemScriptableObject _item ) {
            inventoryController.AddItem( _item );
        }
                
        public List<ItemScriptableObject> GetItemsList() {
            return inventoryController.GetItemsList();
        }

        public void RemoveItem( ItemScriptableObject _item ) {
            inventoryController.RemoveItem( _item );
        }
        #endregion


        #region IEquipment methods
        public void EquipItem( EquipableItemScriptableObject _equipableItem ) {
            equipmentContainer.EquipItem( _equipableItem );
        }

        public void UnequipItem() {
            equipmentContainer.UnequipItem();
        }
        #endregion


        #region IWallet methods
        public int GetCurrentAmount() {
            return walletController.GetCurrentAmount();
        }

        public void AddMoney( int _amount ) {
            walletController.AddMoney( _amount );
        }

        public void RemoveMoney( int _amount ) {
            walletController.RemoveMoney( _amount );
        }
        #endregion
    }
}