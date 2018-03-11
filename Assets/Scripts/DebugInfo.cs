using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour {

  public GameObject PlayerCharacter;
  public Text PlayerDataText;

  private Rigidbody2D _playerCharacterRigidbody;

  private void Start() {
    _playerCharacterRigidbody = PlayerCharacter.GetComponent<Rigidbody2D>();
    gameObject.SetActive(true);
	}
	
	private void Update() {
    if (Input.GetKeyDown(KeyCode.F12)) {
      gameObject.SetActive(!gameObject.activeSelf);
    }

    UpdateDebugInfoText();
	}

  private void UpdateDebugInfoText() {
    PlayerDataText.text = "Position: " + PlayerCharacter.transform.position;
    PlayerDataText.text += "Velocity: " + _playerCharacterRigidbody.velocity.magnitude;
    PlayerDataText.text = "Input_H: " + Input.GetAxis("Horizontal");
  }
}
