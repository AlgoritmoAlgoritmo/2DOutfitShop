/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using UnityEngine;


namespace Game.Gameplay.Items {
    [CreateAssetMenu( fileName = "New Item ScriptableObject", menuName = "BGSTask/Items/Item ScriptableObject" )]
    public class ItemScriptableObject : ScriptableObject {
        #region Variables
        [SerializeField]
        private string itemName;
        public string ItemName => itemName;

        [SerializeField]
        private int itemPrice;
        public int ItemPrice => itemPrice;
        [SerializeField]
        private Sprite itemSprite;
        public Sprite ItemSprite => itemSprite;
        #endregion
    }
}