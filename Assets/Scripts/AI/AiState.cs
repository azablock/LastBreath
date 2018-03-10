using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "AI/AiState")]
public class AiState : ScriptableObject {

  public AiAction[] actions;
  public AiTransition[] transitions;

  public void UpdateSelf(AiStateController controller) {
    DoActions(controller);
    CheckTransitions(controller);
  }

  private void DoActions(AiStateController controller) {
    for (int i = 0; i < actions.Length; i++) {
      actions[i].Act(controller);
    }
  }

  private void CheckTransitions(AiStateController controller) {
    for (int i = 0; i < transitions.Length; i++) {
      bool decisionSucceeded = transitions[i].decision.Decide(controller);

      if (decisionSucceeded) {
        controller.TransitionToState(transitions[i].trueState);
      } else {
        controller.TransitionToState(transitions[i].falseState);
      }
    }
  }
}