/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/01
*/


using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Gameplay.Player {
    public class PlayerAnimations : MonoBehaviour {
        #region Variables
        [SerializeField]
        private Animator animator;
        [SerializeField]
        private string actionName = "Move";

        [SerializeField]
        private string leftTriggerName = "leftTrigger";
        [SerializeField]
        private string rightTriggerName = "rightTrigger";
        [SerializeField]
        private string idleTrigger = "idleTrigger";

        private PlayerInput playerInput;
        private Vector2 inputValue;
        #endregion

        #region Public methods
        private void Awake() {
            playerInput = GetComponent<PlayerInput>();
        }

        private void FixedUpdate() {
            ManageAnimations();
        }
        #endregion

        #region Private methods
        private void ManageAnimations() {
            inputValue = playerInput.actions["Move"].ReadValue<Vector2>();

            if( inputValue == Vector2.zero ) {
                animator.SetTrigger( idleTrigger );

            } else if( inputValue == Vector2.left ) {
                animator.SetTrigger( leftTriggerName );

            } else if( inputValue == Vector2.right ) {
                animator.SetTrigger( rightTriggerName );

            } else {
                animator.SetTrigger( rightTriggerName );
            }
        }
        #endregion
    }
}