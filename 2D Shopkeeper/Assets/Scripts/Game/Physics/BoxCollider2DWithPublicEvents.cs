/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using UnityEngine;
using UnityEngine.Events;


namespace Game.Physics {
    public class BoxCollider2DWithPublicEvents : MonoBehaviour {
        #region Variables
        public UnityEvent OnTriggerEnter2DEvent = new UnityEvent();
        public UnityEvent OnTriggerExit2DEvent = new UnityEvent();
        public UnityEvent OnCollisionEnter2DEvent = new UnityEvent();
        public UnityEvent OnCollisionExit2DEvent = new UnityEvent();
        #endregion


        #region MonoBehaviour methods
        private void OnTriggerEnter2D( Collider2D collision ) {
            OnTriggerEnter2DEvent.Invoke();
        }

        private void OnTriggerExit2D( Collider2D collision ) {
            OnTriggerExit2DEvent.Invoke();
        }

        private void OnCollisionEnter2D( Collision2D collision ) {
            OnCollisionEnter2DEvent.Invoke();
        }

        private void OnCollisionExit2D( Collision2D collision ) {
            OnCollisionExit2DEvent.Invoke();
        }
        #endregion
    }
}
