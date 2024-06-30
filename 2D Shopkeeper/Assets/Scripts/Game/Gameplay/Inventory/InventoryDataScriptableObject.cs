/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using UnityEngine;
using Game.Gameplay.Items;


namespace Game.Gameplay.Inventory {
    [CreateAssetMenu( fileName = "New Inventory ScriptableObject",
                menuName = "BGSTask/Inventory/Inventory ScriptableObject" )]
    public class InventoryDataScriptableObject : ScriptableObject {
        #region Variables
        [SerializeField]
        private ItemDatabaseScriptableObject itemDatabase;
        [SerializeField]
        private short slotsAmount;
        #endregion

        #region Public methods
        public void AddItem( ItemScriptableObject item ) {
            if( itemDatabase.Items.Count >= slotsAmount )
                throw new System.IndexOutOfRangeException("Inventory is already full");

            itemDatabase.AddItem( item );
        }

        public void RemoveItem( ItemScriptableObject item ) {
            if( itemDatabase.Items.Count <= 0 )
                throw new System.IndexOutOfRangeException( "Inventory is already empty." );

            itemDatabase.RemoveItem( item );
        }
        #endregion
    }
}