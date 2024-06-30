/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/29
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


namespace Game.Player {
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(PlayerInput))]
    public class Player2DPhysicsBasedMovement : MonoBehaviour {
        #region Variables
        [SerializeField]
        private float speed = 1f;
        public float Speed { get; set; }

        [SerializeField]
        private string actionName = "Move";

        private Rigidbody2D rigidBody;
        private PlayerInput playerInput;
        #endregion


        #region MonoBehavour methods
        private void Awake() {
            rigidBody = GetComponent<Rigidbody2D>();
            playerInput = GetComponent<PlayerInput>();
        }


        private void FixedUpdate() {
            Move( playerInput.actions[actionName].ReadValue<Vector2>() );
        }
        #endregion


        #region Public methods
        public void Move( Vector2 _direction ) {
            rigidBody.velocity = _direction * speed;
        }
        #endregion
    }
}