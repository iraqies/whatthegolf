using UnityEngine;

namespace RootMotion.Demos
{
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		public CharacterThirdPerson characterController;

		[SerializeField]
		private float turnSensitivity;

		[SerializeField]
		private float turnSpeed;

		[SerializeField]
		private float runCycleLegOffset;

		[SerializeField]
		private float animSpeedMultiplier;

		protected Animator animator;

		private Vector3 lastForward;

		private const string groundedDirectional = "Grounded Directional";

		private const string groundedStrafe = "Grounded Strafe";

		private float deltaAngle;

		public override bool animationGrounded => false;

		protected override void Start()
		{
		}

		public override Vector3 GetPivotPoint()
		{
			return default;
		}

		protected virtual void Update()
		{
		}

		private void OnAnimatorMove()
		{
		}

		public void SetAnimSpeedMultiplier(float val)
		{
		}
	}
}
