using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour {

  public GameObject PlayerCharacter;
  public GameObject DebugInfoPanel;
  public Text DebugInfoText; //todo jak mozna dostac sie do tego z panelu?

  private void Start() {
    DebugInfoPanel.SetActive(true);
	}
	
	private void Update() {
    if (Input.GetKeyDown(KeyCode.F12)) {
      DebugInfoPanel.SetActive(!DebugInfoPanel.activeSelf);
    }

    UpdateDebugInfoText();
	}

  private void UpdateDebugInfoText() {
    DebugInfoText.text = "Position: " + PlayerCharacter.transform.position;
  }
}
