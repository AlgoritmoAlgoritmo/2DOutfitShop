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
using Game.Player;



namespace Tests.Player {
    public class Player2DPhysicsBasedMovementTest {
        #region Variables
        private Player2DPhysicsBasedMovement playerMovement;
        #endregion


        #region Tests setup
        [SetUp]
        public void SetUp() {
            playerMovement = GameObject.Instantiate(
                    new GameObject()).AddComponent<Player2DPhysicsBasedMovement>();
        }
        #endregion


        #region Tests
        [Test]
        public void WhenPlayerMovesLeft_PlayerPositionXDecreases() {
            Vector3 initialPosition = playerMovement.gameObject.transform.position;

            // playerMovement.MoveLeft();

            // Asserting the GameObject moved to the left
            Assert.Greater( initialPosition.x,
                            playerMovement.gameObject.transform.position.x,
                            "Expected initialPosition.x to be greater than "
                            + "playerMovement.gameObject.transform.position.x.");


        }
        #endregion
    }
}