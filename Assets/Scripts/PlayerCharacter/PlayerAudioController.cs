using UnityEngine;

public class PlayerAudioController : MonoBehaviour {

  //todo refactor
  private MovementController _movementController;
  private float _nextStepTime;
  private float _interval;

  private void Start() {
    _movementController = GetComponent<MovementController>();
    _nextStepTime = 0.0f;
    _interval = 0.4f;
  }

  private void Update() {
    if (Time.time > _nextStepTime && _movementController.MovementDelta.magnitude > 0.0f) {
      _nextStepTime += _interval;
      AkSoundEngine.PostEvent("Play_Footstep", gameObject);
    }
  }
}