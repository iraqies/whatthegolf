using System.Collections;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class PuppetMasterPropMelee : PuppetMasterProp
	{
		public CapsuleCollider capsuleCollider;

		public BoxCollider boxCollider;

		public float actionColliderRadiusMlp;

		public float actionAdditionalPinWeight;

		public float actionMassMlp;

		public Vector3 COMOffset;

		private float defaultColliderRadius;

		private float defaultMass;

		private float defaultAdditionalPinWeight;

		public void StartAction(float duration)
		{
		}

		public IEnumerator Action(float duration)
		{
			return null;
		}

		protected override void Start()
		{
		}

		protected override void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		protected override void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}
	}
}
