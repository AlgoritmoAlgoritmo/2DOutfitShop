/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/03
*/


using UnityEngine;


namespace Game.Gameplay.Equipment.Data {
    [System.Serializable]
    public class EquipableObjectPieceData {
        #region Variables
        [SerializeField]
        private string bodyPartName;
        public string BodyPartName {
            get => bodyPartName;
            set => bodyPartName = value;
        }

        [SerializeField]
        private Sprite itemSprite;
        public Sprite ItemSprite {
            get => itemSprite;
            set => itemSprite = value;
        }
        #endregion

        #region Public methods
        public EquipableObjectPieceData() {
        }
        #endregion
    }
}