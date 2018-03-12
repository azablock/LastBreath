using UnityEngine;

public class RadiusIndicator : MonoBehaviour {
  public float Radius;
  private DebugController _debugController;
  private MeshRenderer _meshRenderer;

  private void Start() {
    _debugController = GameObject.FindGameObjectWithTag("DebugController").GetComponent<DebugController>();
    _meshRenderer = gameObject.GetComponentInParent<MeshRenderer>();
    transform.localScale = Vector3.one * Radius * 2; //todo refactor
  }

  private void Update() {
    _meshRenderer.enabled = _debugController.IsInDebugMode();
  }
}