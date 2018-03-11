using UnityEngine;
using System.Collections;

[CreateAssetMenu (menuName = "AI/Actions/Chase")]
public class AiChaseAction : AiAction {

  public override void Act(AiStateController controller) {
    var newPosition = Vector3.MoveTowards(
      controller.transform.position,
      controller.PlayerCharacter.transform.position,
      0.05f //refactor - NPC speed
    );

    controller.transform.position = newPosition;
  }
}