using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour {

  public GameObject Target;

  private void Update() {
    var targetPosition = TargetPosition();

    var newPosition = new Vector3(
      targetPosition.x,
      targetPosition.y,
      transform.position.z
    );

    transform.position = newPosition;
	}

  private Vector3 TargetPosition() {
    return Target.transform.position;
  }
}
