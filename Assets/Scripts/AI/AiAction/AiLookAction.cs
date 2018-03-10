using UnityEngine;
using System.Collections;

[CreateAssetMenu (menuName = "AI/Actions/Look")]
public class AiLookAction : AiAction {

  public override void Act(AiStateController controller) {
    Debug.Log("Looking");
  }
}