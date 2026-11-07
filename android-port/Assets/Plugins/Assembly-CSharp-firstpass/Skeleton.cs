using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class Skeleton : MonoBehaviour
	{
		public Animator animator;
		public PuppetMaster puppetMaster;
		public ConfigurableJoint[] leftLeg;
		public ConfigurableJoint[] rightLeg;
		private bool leftLegRemoved;
		private bool rightLegRemoved;

		private void Start() { }
		public void OnRebuild() { }
		private void OnMuscleDisconnected(Muscle m) { }
		private bool IsLegMuscle(Muscle m, out bool isLeft)
		{
			isLeft = false;
			return false;
		}
	}
}
