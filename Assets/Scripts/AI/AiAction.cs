using UnityEngine;
using System.Collections;

public abstract class AiAction : ScriptableObject {

  public abstract void Act(AiStateController controller);
}