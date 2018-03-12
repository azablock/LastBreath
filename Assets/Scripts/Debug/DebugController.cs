using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugController : MonoBehaviour {

  private bool _debugMode;

	private void Start() {
    _debugMode = false;
	}
	
  //todo refactor
	private void Update() {
    if (Input.GetKeyDown(KeyCode.F12) || Input.GetKeyDown(KeyCode.Joystick1Button3)) {
      _debugMode = !_debugMode;
    }
	}

  public bool IsInDebugMode() {
    return _debugMode;
  }
}
