using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class SkeletonDisconnector : MonoBehaviour
	{
		public BehaviourPuppet puppet;

		public Skeleton skeleton;

		public MuscleDisconnectMode disconnectMuscleMode;

		public LayerMask layers;

		public float unpin;

		public float force;

		public ParticleSystem particles;

		public PropMuscle propMuscle;

		public PuppetMasterProp prop;

		private void Update()
		{
		}
	}
}
