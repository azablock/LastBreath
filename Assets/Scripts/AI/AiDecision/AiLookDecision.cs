using UnityEngine;
using System.Collections;

[CreateAssetMenu (menuName = "AI/Decisions/Look")]
public class AiLookDecision : AiDecision {

  //todo refactor
  public float lookDistance;

  public override bool Decide(AiStateController controller) {
    var distance = Vector3.Distance(
      controller.Position(),
      controller.PlayerCharacter.transform.position
    );

    return distance < lookDistance;
  }
}

