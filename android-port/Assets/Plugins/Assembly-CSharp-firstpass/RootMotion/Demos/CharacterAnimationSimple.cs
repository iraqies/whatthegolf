using UnityEngine;

namespace RootMotion.Demos
{
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		public CharacterThirdPerson characterController;

		public float pivotOffset;

		public AnimationCurve moveSpeed;

		public UserControlThirdPerson userController;

		private Animator animator;

		[SerializeField]
		public float jumpDuration = 0.7f;

		[SerializeField]
		private AnimationCurve jumpLayerWeight = AnimationCurve.Linear(0f, 0f, 1f, 0f);

		[SerializeField]
		private AnimationCurve jumpSpeedCurve = AnimationCurve.Linear(0f, 0f, 1f, 0f);

		[SerializeField]
		private float jumpVel = 10f;

		private float jumptStartTime;

		private const string groundedDirectional = "Grounded Directional";

		private const string groundedStrafe = "Grounded Strafe";

		private int jumpLayerIndex;

		public override bool animationGrounded => animator == null || animator.GetLayerWeight(jumpLayerIndex) < 0.0001f;

		protected override void Start()
		{
			base.Start();
			animator = GetComponentInChildren<Animator>();
			if (animator != null)
			{
				jumpLayerIndex = animator.GetLayerIndex("Jump");
			}
			jumptStartTime = 0f - jumpDuration;
		}

		public override Vector3 GetPivotPoint()
		{
			if (pivotOffset == 0f)
			{
				return base.transform.position;
			}
			return base.transform.position + base.transform.forward * pivotOffset;
		}

		private void Update()
		{
			if (characterController == null || moveSpeed == null || userController == null || animator == null)
			{
				return;
			}
			float num = moveSpeed.Evaluate(characterController.animState.moveDirection.z) * smoothFollowSpeed;
			Vector3 move = userController.state.move;
			animator.SetFloat("Speed", num);
			float num2 = ((jumpSpeedCurve != null && jumpDuration > 0.0001f) ? jumpSpeedCurve.Evaluate((Time.time - jumptStartTime) / jumpDuration) : 0f);
			Vector3 deltaPosition = (move * num + Vector3.up * num2 * jumpVel) * Time.deltaTime;
			characterController.Move(deltaPosition, Quaternion.identity);
		}

		public void Jump()
		{
			jumptStartTime = Time.time;
		}
	}
}
