/*
* Author: Iris Bermudez
* GitHub: https://github.com/AlgoritmoAlgoritmo
* Date: 2024/06/29
*/



using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Game.Gameplay.Player;



namespace Tests.Player {
    public class Player2DPhysicsBasedMovementTest {
        #region Variables
        private Player2DPhysicsBasedMovement playerMovement;
        private Rigidbody2D playerRigidBody;

        private const string PLAYER_PREFAB_PATH = "Assets/Prefabs/Player/PlayerCharacter.prefab";
        private GameObject playerGameObject;
        #endregion


        #region Tests setup
        [SetUp]
        public void SetUp() {
            playerGameObject = GameObject.Instantiate( UnityEditor.AssetDatabase
                                    .LoadAssetAtPath<GameObject>( PLAYER_PREFAB_PATH ) );
            if( !playerGameObject )
                throw new System.NullReferenceException( $"Make sure {PLAYER_PREFAB_PATH} path is corret." );


            playerMovement = playerGameObject.GetComponent<Player2DPhysicsBasedMovement>();
            if( !playerMovement )
                throw new System.NullReferenceException( "Make sure playerGameObject has a "
                                        + "Player2DPhysicsBasedMovement component attached." );

            playerRigidBody = playerGameObject.GetComponent<Rigidbody2D>();
            if( !playerRigidBody )
                throw new System.NullReferenceException( "Make sure playerGameObject has a "
                                        + "Rigidbody2D component attached." );
        }
        #endregion


        #region Tests
        [Test]
        public void WhenPlayerMovesLeft_PlayerRigidbodyVelocityXDecreases() {
            Vector2 initialVelocity = playerRigidBody.velocity;
            playerMovement.Speed = 10f;


            playerMovement.Move( Vector2.left );


            // Asserting the GameObject moved to the left
            Assert.Greater( initialVelocity.x,
                            playerRigidBody.velocity.x,
                            "Expected playerRigidBody.velocity.x to be greater than "
                                    + "initialVelocity.x." );

            // Asserting only initialVelocity.x changed
            Assert.AreEqual( initialVelocity.y,
                            playerRigidBody.velocity.y,
                            "playerRigidBody.velocity.y shouldn't have changed." );
        }


        [Test]
        public void WhenPlayerMovesRight_PlayerRigidbodyVelocityXIncreases() {
            Vector2 initialVelocity = playerRigidBody.velocity;
            playerMovement.Speed = 10f;


            playerMovement.Move( Vector2.right );


            // Asserting the GameObject moved to the right
            Assert.Greater( playerRigidBody.velocity.x,
                            initialVelocity.x,
                            "Expected playerRigidBody.velocity.x to be greater than "
                                    + "initialVelocity.x." );

            // Asserting only initialVelocity.x changed
            Assert.AreEqual( initialVelocity.y,
                            playerRigidBody.velocity.y,
                            "playerRigidBody.velocity.y shouldn't have changed." );
        }

        [Test]
        public void WhenPlayerMovesUp_PlayerRigidbodyVelocityYIncreases() {
            Vector2 initialVelocity = playerRigidBody.velocity;
            playerMovement.Speed = 10f;


            playerMovement.Move( Vector2.up );


            // Asserting the GameObject moved up
            Assert.Greater( playerRigidBody.velocity.y,
                            initialVelocity.y,
                            "Expected playerRigidBody.velocity.y to be greater than "
                                    + "initialVelocity.y." );

            // Asserting only initialVelocity.y changed
            Assert.AreEqual( initialVelocity.x,
                            playerRigidBody.velocity.x,
                            "playerRigidBody.velocity.x shouldn't have changed." );
        }

        [Test]
        public void WhenPlayerMovesDown_PlayerRigidbodyVelocityYDecreases() {
            Vector2 initialVelocity = playerRigidBody.velocity;
            playerMovement.Speed = 10f;


            playerMovement.Move( Vector2.down );


            // Asserting the GameObject moved down
            Assert.Greater( initialVelocity.y, 
                            playerRigidBody.velocity.y,
                            "Expected playerRigidBody.velocity.y to be greater than "
                                    + "initialVelocity.y." );

            // Asserting only initialVelocity.y changed
            Assert.AreEqual( initialVelocity.x,
                            playerRigidBody.velocity.x,
                            "playerRigidBody.velocity.x shouldn't have changed." );
        }
        #endregion
    }
}