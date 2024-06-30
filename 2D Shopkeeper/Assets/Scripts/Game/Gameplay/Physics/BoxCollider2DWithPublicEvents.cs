/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/30
*/


using UnityEngine;
using UnityEngine.Events;


namespace Game.Gameplay.Physics {
    public class BoxCollider2DWithPublicEvents : MonoBehaviour {
        #region Variables
        public UnityEvent<GameObject> OnTriggerEnter2DEvent = new UnityEvent<GameObject>();
        public UnityEvent<GameObject> OnTriggerExit2DEvent = new UnityEvent<GameObject>();
        public UnityEvent<GameObject> OnCollisionEnter2DEvent = new UnityEvent<GameObject>();
        public UnityEvent<GameObject> OnCollisionExit2DEvent = new UnityEvent<GameObject>();
        #endregion


        #region MonoBehaviour methods
        private void OnTriggerEnter2D( Collider2D collision ) {
            OnTriggerEnter2DEvent.Invoke( collision.gameObject );
        }

        private void OnTriggerExit2D( Collider2D collision ) {
            OnTriggerExit2DEvent.Invoke( collision.gameObject );
        }

        private void OnCollisionEnter2D( Collision2D collision ) {
            OnCollisionEnter2DEvent.Invoke( collision.gameObject );
        }

        private void OnCollisionExit2D( Collision2D collision ) {
            OnCollisionExit2DEvent.Invoke( collision.gameObject );
        }
        #endregion
    }
}
