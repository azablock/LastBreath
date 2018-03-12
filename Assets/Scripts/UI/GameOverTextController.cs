using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverTextController : MonoBehaviour {

  private PlayerLifeController _playerLifeController;
  private Text _gameOverText;

	private void Start() {
    var playerCharacter = GameObject.FindGameObjectWithTag("PlayerCharacter");
    _playerLifeController = playerCharacter.GetComponent<PlayerLifeController>();

    _gameOverText = gameObject.GetComponent<Text>();
	}
	
  private void Update() {
    _gameOverText.enabled = !_playerLifeController.isAlive();
	}
}
