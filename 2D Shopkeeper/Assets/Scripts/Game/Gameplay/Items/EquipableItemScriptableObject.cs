/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/01
*/


using Game.Gameplay.Equipment.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game.Gameplay.Items {
    [CreateAssetMenu( fileName = "New EquipableItem ScriptableObject",
                menuName = "BGSTask/Items/EquipableItem ScriptableObject" )]
    public class EquipableItemScriptableObject : ItemScriptableObject {
        #region Variables
        [SerializeField]
        private List<EquipableObjectPieceData> equipableObjectPieceData;
        public List<EquipableObjectPieceData> EquipableObjectPieceData => equipableObjectPieceData;
        #endregion
    }
}