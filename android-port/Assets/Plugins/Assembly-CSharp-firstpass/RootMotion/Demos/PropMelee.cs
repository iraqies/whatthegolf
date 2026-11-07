using System.Collections;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class PropMelee : Prop
	{
		public CapsuleCollider capsuleCollider;

		public BoxCollider boxCollider;

		public float actionColliderRadiusMlp;

		public float actionAdditionalPinWeight;

		public float actionMassMlp;

		public Vector3 COMOffset;

		private float defaultColliderRadius;

		private float defaultMass;

		private float defaultAddMass;

		private Rigidbody r;

		public void StartAction(float duration)
		{
		}

		public IEnumerator Action(float duration)
		{
			return null;
		}

		protected override void OnStart()
		{
		}

		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		protected override void OnDrop()
		{
		}
	}
}
