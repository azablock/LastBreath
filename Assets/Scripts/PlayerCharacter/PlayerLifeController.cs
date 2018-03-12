using UnityEngine;

public class PlayerLifeController : MonoBehaviour {

  private WaterLevelController _waterLevelController;
  private bool _isAlive;

	private void Start() {
    _waterLevelController = gameObject.GetComponent<WaterLevelController>();
    _isAlive = true;
	}
	
  //todo refactor
  private void Update() {
    _isAlive = _waterLevelController.WaterLevel() > 0.0f;
    gameObject.SetActive(_isAlive);
	}

  public bool isAlive() {
    return _isAlive;
  }
}
