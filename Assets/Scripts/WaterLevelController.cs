using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelController : MonoBehaviour {

  public float MaximumWaterLevel;
  public float _waterLevel;
  public float WaterLevelDelta;
  public float BaseWaterLevelDelta; //todo refactor

  private void Start() {
    _waterLevel = MaximumWaterLevel;
    BaseWaterLevelDelta = -0.1f;

    UpdateWaterLevelDelta(BaseWaterLevelDelta);
	}
	
	private void Update() {
		//todo refactor
    if(_waterLevel <= MaximumWaterLevel && _waterLevel > 0.0f)
      _waterLevel += WaterLevelDelta;

    if (_waterLevel > MaximumWaterLevel)
      _waterLevel = MaximumWaterLevel;
	}

  public float WaterLevel() {
    return _waterLevel;
  }

  public void UpdateWaterLevelDelta(float waterLevelDelta) {
    WaterLevelDelta = waterLevelDelta;
  }
}
