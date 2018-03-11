using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRegainController : MonoBehaviour {

  //todo refactor
  public RadiusIndicator WaterRegainRadiusIndicator;
  public float WaterRegainDelta;
  public float WaterRegainRadius;

  private void Start() {
    var collider = gameObject.GetComponent<CircleCollider2D>();
    collider.radius = WaterRegainRadius;

    //todo to nie dziala
    //WaterRegainRadiusIndicator.Radius = WaterRegainRadius;
  }

  private void OnTriggerEnter2D(Collider2D other) {
    var waterLevelController = other.gameObject.GetComponent<WaterLevelController>();
    RegainWater(waterLevelController);
  }

  private void OnTriggerExit2D(Collider2D other) {
    var waterLevelController = other.gameObject.GetComponent<WaterLevelController>();
    waterLevelController.UpdateWaterLevelDelta(waterLevelController.BaseWaterLevelDelta);
  }

  private void RegainWater(WaterLevelController waterLevelController) {
    waterLevelController.UpdateWaterLevelDelta(WaterRegainDelta);
  }
}
