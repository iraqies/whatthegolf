using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class CharacterPuppet : CharacterThirdPerson
	{
		public PropMuscle propMuscle;

		public BehaviourPuppet puppet { get; private set; }

		public BehaviourPuppet propeller => puppet;

		protected override void Start()
		{
			base.Start();
			if (base.transform.parent != null)
			{
				puppet = base.transform.parent.GetComponentInChildren<BehaviourPuppet>();
			}
		}

		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
			if (puppet != null && puppet.state != BehaviourPuppet.State.Puppet)
			{
				if (userControl != null)
				{
					userControl.state.move = Vector3.zero;
				}
			}
			else
			{
				base.Move(deltaPosition, deltaRotation);
			}
		}

		protected override void Rotate()
		{
			if (puppet != null && puppet.state != BehaviourPuppet.State.Puppet)
			{
				if (gravityTarget != null)
				{
					base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - gravityTarget.position) * base.transform.rotation;
				}
			}
			else
			{
				base.Rotate();
			}
		}

		protected override bool Jump()
		{
			if (puppet != null && puppet.state != BehaviourPuppet.State.Puppet)
			{
				return false;
			}
			return base.Jump();
		}
	}
}
