using UnityEngine;

//[RequireComponent(typeof(MovementController))]
public class InputController : MonoBehaviour {

  private MovementController _movementController;

  private void Awake() {
    _movementController = GetComponent<MovementController>();
  }

  private void Update() {
    ProcessMovementInputEvents();
  }

  private void ProcessMovementInputEvents() {
    var horizontalInputValue = Input.GetAxis("Horizontal");
    _movementController.MovementDelta = new Vector2(horizontalInputValue, 0.0f); //todo refactor?
  }
}