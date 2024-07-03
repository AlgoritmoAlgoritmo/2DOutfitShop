/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/02
*/


using Game.Gameplay.Items;


namespace Game.Gameplay.Equipment.Interfaces {
    public interface IEquipment {
        #region Public methods
        public void EquipItem( EquipableItemScriptableObject _equipableItem );
        public void UnequipItem();
        #endregion
    }
}