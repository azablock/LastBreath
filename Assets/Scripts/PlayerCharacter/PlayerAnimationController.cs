using Spine.Unity;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour {

  private Animator _animator;
  private MovementController _movementController;
  private SkeletonAnimation _skeletonAnimation;
  
  private void Start() {
    _animator = GetComponent<Animator>();
    _movementController = GetComponent<MovementController>();
    _skeletonAnimation = GetComponent<SkeletonAnimation>();
  }

  private void Update() {
    UpdateIsRunning();
    UpdateIsAttacking();
    UpdateSpriteSide();
  }

  private void UpdateIsRunning() {
    _animator.SetBool("isRunning", _movementController.MovementDelta.magnitude > 0.0f);
  }
  
  //todo
  private void UpdateIsAttacking() {
//    _animator.SetTrigger("isAttacking");
  }
  
  private void UpdateSpriteSide() {
    _skeletonAnimation.skeleton.flipX = _movementController.MovementDelta.x < 0.0f;
  }
}