/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/02
*/


using UnityEngine;


namespace Game.Gameplay.Equipment.Data {
    [System.Serializable]
    public class BodyPartData {
        #region Variables
        [SerializeField]
        private string bodyPartName;
        public string BodyPartName {
            get => bodyPartName;
            set => bodyPartName = value;
        }

        [SerializeField]
        private SpriteRenderer bodyPartSpriteRenderer;
        public SpriteRenderer BodyPartSpriteRenderer {
            get => bodyPartSpriteRenderer;
            set => bodyPartSpriteRenderer = value;
        }
        #endregion


        #region Public methods
        public BodyPartData () {
        }
        #endregion
    }
}