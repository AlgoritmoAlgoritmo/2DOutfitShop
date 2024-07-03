/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/07/02
*/


using UnityEngine;
using UnityEngine.InputSystem;


namespace Game.Gameplay.Player {
    public class PlayerAnimationsPlayedByNameController : MonoBehaviour {
        #region Variables
        [SerializeField]
        private Animator animator;
        [SerializeField]
        private string actionName = "Move";

        [SerializeField]
        private string moveLeftAnimationName = "Run_Left";
        [SerializeField]
        private string moveRighttAnimationName = "Run_Right";
        [SerializeField]
        private string idleAnimationName = "Rogue_idle_01";

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
                animator.Play( idleAnimationName );

            } else if( inputValue == Vector2.left ) {
                animator.Play( moveLeftAnimationName );

            } else if( inputValue == Vector2.right ) {
                animator.Play( moveRighttAnimationName );

            } else {
                animator.Play( moveRighttAnimationName );
            }
        }
        #endregion
    }
}