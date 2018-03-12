using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementController : MonoBehaviour {

  public float MaxMovementSpeed;
  public Vector2 MovementDelta;

  private Rigidbody2D _rigidBody;

  private void Start() {
    _rigidBody = gameObject.GetComponent<Rigidbody2D>();
  }

  private void Update() {
    if (_rigidBody.velocity.magnitude < MaxMovementSpeed) {
      _rigidBody.velocity += MovementDelta;
    }
    else {
      _rigidBody.velocity = MaximumVelocity(MovementDelta);
    }
  }

  private Vector2 MaximumVelocity(Vector2 movementDelta) {
    return movementDelta.x > 0.0f
      ? new Vector2(MaxMovementSpeed, 0.0f)
      : new Vector2(-MaxMovementSpeed, 0.0f);
  }
}