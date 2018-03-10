using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "AI/Transition")]
public class AiTransition : ScriptableObject {
  public AiDecision decision;
  public AiState trueState;
  public AiState falseState;
}