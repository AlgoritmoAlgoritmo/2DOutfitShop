/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/01
*/


using UnityEngine;


namespace Game.Other {
    public class ApplicationController : MonoBehaviour {
        #region Public methods
        public void CloseGame() {
            Application.Quit();
        }
        #endregion
    }
}