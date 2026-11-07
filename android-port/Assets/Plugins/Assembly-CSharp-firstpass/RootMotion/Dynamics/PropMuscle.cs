using UnityEngine;

namespace RootMotion.Dynamics
{
	public class PropMuscle : MonoBehaviour
	{
		public delegate void PropDelegate(PuppetMasterProp prop);

		[SerializeField]
		public PuppetMaster puppetMaster;

		public PuppetMasterProp currentProp;

		public Vector3 additionalPinOffset;

		public PropDelegate OnPickUpProp;

		public PropDelegate OnDropProp;

		private Muscle _muscle;

		private PuppetMasterProp lastProp;

		private Vector3 targetDefaultLocalPos;

		private Vector3 lastAdditionalPinOffset;

		public Muscle muscle => null;

		public PuppetMasterProp activeProp { get; private set; }

		public bool AddAdditionalPin()
		{
			return false;
		}

		public bool RemoveAdditionalPin()
		{
			return false;
		}

		public void OnInitiate()
		{
		}

		public void TakeOver()
		{
		}

		public void OnUpdate()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
