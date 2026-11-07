using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class CharacterPuppet : CharacterThirdPerson
	{
		public PropMuscle propMuscle;

		public BehaviourPuppet puppet { get; private set; }

		protected override void Start()
		{
		}

		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		protected override void Rotate()
		{
		}

		protected override bool Jump()
		{
			return false;
		}
	}
}
