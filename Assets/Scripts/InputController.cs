using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputController : MonoBehaviour {

  public float movementSpeedFactor;
  public float maximumMovementSpeed;

  private Rigidbody2D _playerCharacterRigidBody;

  private void Awake() {
    _playerCharacterRigidBody = GetComponent<Rigidbody2D>();
  }
	
  private void Update() {
    Move();
  }

  private void Move() {
    var movementDelta = MovementDelta();

    if (_playerCharacterRigidBody.velocity.magnitude < maximumMovementSpeed) {
      var velocityDelta = VelocityDelta(movementDelta);
      _playerCharacterRigidBody.velocity += velocityDelta;
    } else {
      _playerCharacterRigidBody.velocity = MaximumVelocity(movementDelta);
    }
  }

  private Vector2 VelocityDelta(Vector2 movementDelta) {
    return movementDelta * movementSpeedFactor;
  }

  private Vector2 MovementDelta() {
    var horizontalDelta = Input.GetAxis("Horizontal");
    return new Vector2(horizontalDelta, 0.0f);
  }

  private Vector2 MaximumVelocity(Vector2 movementDelta) {
    return movementDelta.x > 0.0f
        ? new Vector2(maximumMovementSpeed, 0.0f)
        : new Vector2(-maximumMovementSpeed, 0.0f);
  }
}
