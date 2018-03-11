using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevelController : MonoBehaviour {

  public float MaximumWaterLevel;
  private float _waterLevel;
  public float WaterLevelDelta;
  public float BaseWaterLevelDelta; //todo refactor

  private void Start() {
    _waterLevel = MaximumWaterLevel;
    BaseWaterLevelDelta = -0.1f;

    UpdateWaterLevelDelta(BaseWaterLevelDelta);
	}
	
	private void Update() {
		//todo refactor
    _waterLevel += WaterLevelDelta;
	}

  public float WaterLevel() {
    return _waterLevel;
  }

  public void UpdateWaterLevelDelta(float waterLevelDelta) {
    WaterLevelDelta = waterLevelDelta;
  }
}
