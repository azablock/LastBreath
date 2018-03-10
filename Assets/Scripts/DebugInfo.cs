using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour {

  public GameObject PlayerCharacter;
  public GameObject DebugInfoPanel;

  public Text PlayerPositionText;
  public Text PlayerVelocityText;
  public Text InputHorizontalAxisText;

  private Rigidbody2D _playerCharacterRigidbody;

  private void Start() {
    _playerCharacterRigidbody = PlayerCharacter.GetComponent<Rigidbody2D>();

    DebugInfoPanel.SetActive(true);
	}
	
	private void Update() {
    if (Input.GetKeyDown(KeyCode.F12)) {
      DebugInfoPanel.SetActive(!DebugInfoPanel.activeSelf);
    }

    UpdateDebugInfoText();
	}

  private void UpdateDebugInfoText() {
    PlayerPositionText.text = "Position: " + PlayerCharacter.transform.position;
    PlayerVelocityText.text = "Velocity: " + _playerCharacterRigidbody.velocity.magnitude;
    InputHorizontalAxisText.text = "Input_H: " + Input.GetAxis("Horizontal");
  }
}
