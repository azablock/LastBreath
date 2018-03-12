using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterLevelSliderController : MonoBehaviour {

  private WaterLevelController _waterLevelController;
  private Slider _waterLevelSlider;

	void Start () {
    var playerCharacter = GameObject.FindGameObjectWithTag("PlayerCharacter");
    _waterLevelController = playerCharacter.GetComponent<WaterLevelController>();

    _waterLevelSlider = gameObject.GetComponent<Slider>();
    _waterLevelSlider.minValue = 0.0f;
    _waterLevelSlider.maxValue = _waterLevelController.MaximumWaterLevel;
	}
	
	void Update() {
    UpdateWaterLevelSliderValue();
	}

  private void UpdateWaterLevelSliderValue() {
    _waterLevelSlider.value = _waterLevelController.WaterLevel();
  }
}
