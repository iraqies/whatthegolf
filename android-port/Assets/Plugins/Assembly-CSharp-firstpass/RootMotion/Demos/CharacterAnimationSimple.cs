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
		public float jumpDuration;

		[SerializeField]
		private AnimationCurve jumpLayerWeight;

		[SerializeField]
		private AnimationCurve jumpSpeedCurve;

		[SerializeField]
		private float jumpVel;

		private float jumptStartTime;

		private const string groundedDirectional = "Grounded Directional";

		private const string groundedStrafe = "Grounded Strafe";

		private int jumpLayerIndex;

		public override bool animationGrounded => false;

		protected override void Start()
		{
		}

		public override Vector3 GetPivotPoint()
		{
			return default;
		}

		private void Update()
		{
		}

		public void Jump()
		{
		}
	}
}
