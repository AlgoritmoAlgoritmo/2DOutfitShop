/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/01
*/


using System.Collections.Generic;
using UnityEngine;
using Game.Gameplay.Equipment.Data;


namespace Game.Gameplay.Items {
    [CreateAssetMenu( fileName = "New EquipableItem ScriptableObject",
                menuName = "BGSTask/Items/EquipableItem ScriptableObject" )]
    public class EquipableItemScriptableObject : ItemScriptableObject {
        #region Variables
        [SerializeField]
        private string equipmentType = "Pants";
        public string EquipmentType => equipmentType;

        [SerializeField]
        private List<EquipableObjectPieceData> equipableObjectPieceData;
        public List<EquipableObjectPieceData> EquipableObjectPieceData => equipableObjectPieceData;
        #endregion
    }
}