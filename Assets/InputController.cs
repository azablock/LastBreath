using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Boundary {
  public float xMin, xMax, zMin, zMax;
}

public class InputController : MonoBehaviour {

  public Boundary boundary;

  private Dictionary<KeyCode, Vector3> _movementVectors;
  private Rigidbody2D _playerCharacterRigidBody;
  private float _movementSpeed = 0.1f;


  private bool moveNow;

  private void Awake() {
    _movementVectors = new Dictionary<KeyCode, Vector3>();

    _movementVectors.Add(KeyCode.W, Vector3.up);
    _movementVectors.Add(KeyCode.D, Vector3.right);
    _movementVectors.Add(KeyCode.S, Vector3.down);
    _movementVectors.Add(KeyCode.A, Vector3.left);

    _playerCharacterRigidBody = GetComponent<Rigidbody2D>();
  }
	
  private void FixedUpdate() {
    /*_movementVectors
      .Where(entry => Input.GetKey(entry.Key))
      .ToList()
      .ForEach(entry => transform.position += movementDelta(entry.Value));
*/
    var horizontalDelta = Input.GetAxis("Horizontal");
    var verticalDelta = Input.GetAxis("Vertical");

    if (horizontalDelta != 0.0f && verticalDelta != 0.0f)
      Debug.Log("horizontal: " + horizontalDelta + ", vertical: " + verticalDelta);

    var magnitude = 50.0f;

    var movement = new Vector2(horizontalDelta * magnitude, verticalDelta * magnitude);
    _playerCharacterRigidBody.AddForce(movement);
  }



  private Vector3 movementDelta(Vector3 movementVector) {
    return movementVector * _movementSpeed;
  }
}
