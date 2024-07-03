/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/03
*/


using UnityEngine;
using UnityEngine.Events;
using Game.Gameplay.Items;
using Game.Gameplay.Equipment.Interfaces;


namespace Game.Gameplay.Equipment {
    public class EquipmentContainer : MonoBehaviour, IEquipment {
        #region Variables
        [SerializeField]
        private EquipmentController[] equipmentControllers;

        public UnityEvent<EquipableItemScriptableObject> OnEquipItem 
                                = new UnityEvent<EquipableItemScriptableObject>();
        #endregion


        #region MonoBehaviour methods
        private void Awake() {
            foreach( var auxEquipmentController in equipmentControllers ) {
                OnEquipItem.AddListener( auxEquipmentController.EquipItem );
            }
        }
        #endregion


        #region Public methods
        public void EquipItem( EquipableItemScriptableObject _equipableItem ) {
            OnEquipItem.Invoke( _equipableItem );
        }

        public void UnequipItem() {
            // Intentionally does nothing, since it won't be called
            throw new System.NotImplementedException();
        }
        #endregion
    }
}