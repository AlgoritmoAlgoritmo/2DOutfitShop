/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using System.Collections.Generic;
using UnityEngine;


namespace Game.Gameplay.Items {
    [CreateAssetMenu( fileName = "New ItemDatabase ScriptableObject",
                    menuName = "BGSTask/Items/ItemDatabase ScriptableObject" )]
    public class ItemDatabaseScriptableObject : ScriptableObject {
        #region Variables
        [SerializeField]
        private List<ItemScriptableObject> items;
        public List<ItemScriptableObject> Items => items;
        #endregion

        #region Public methods
        #endregion
    }
}