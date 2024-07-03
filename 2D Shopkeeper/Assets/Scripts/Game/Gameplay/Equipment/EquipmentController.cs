/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/02
*/


using UnityEngine;
using Game.Gameplay.Items;
using Game.Gameplay.Equipment.Data;
using Game.Gameplay.Equipment.Interfaces;


namespace Game.Gameplay.Equipment {
    [System.Serializable]
    public class EquipmentController : IEquipment {
        #region Variables
        [SerializeField]
        private string equipmentType = "PANTS";
        [SerializeField]
        private BodyPartData[] bodyPartsData;

        private EquipableItemScriptableObject equippedItem;
        #endregion


        #region Public methods
        public void EquipItem( EquipableItemScriptableObject _equipableItem ) {
            UnequipItem();
            equippedItem = _equipableItem;

            foreach( var auxEquipableObjectPieceData in equippedItem.EquipableObjectPieceData ) {
                foreach( var auxBodyPartData in bodyPartsData ) {
                    if( auxEquipableObjectPieceData.BodyPartName.Equals( auxBodyPartData.BodyPartName ) ) {
                        auxBodyPartData.BodyPartSpriteRenderer.sprite = auxEquipableObjectPieceData
                                                                                        .ItemSprite;
                        continue;
                    }
                }
            }
        }

        public void UnequipItem() {
            foreach( var auxBodyPartData in bodyPartsData ) {
                auxBodyPartData.BodyPartSpriteRenderer.sprite = null;
            }
        }
        #endregion
    }
}