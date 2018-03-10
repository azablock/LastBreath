using UnityEngine;
using System.Collections;

public class AiStateController : MonoBehaviour {

  public AiState CurrentState;
  public GameObject PlayerCharacter;

  private void Update() {
    CurrentState.UpdateSelf(this);
  }

  public void TransitionToState(AiState nextState) {
    CurrentState = nextState;
  }

  public Vector3 Position() {
    return transform.position;
  }
}