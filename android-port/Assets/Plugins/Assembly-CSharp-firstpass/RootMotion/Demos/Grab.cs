using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class Grab : MonoBehaviour
	{
		public PuppetMaster puppetMaster;

		public UserControlMelee userControl;

		public int grabLayer;

		private bool grabbed;

		private Rigidbody r;

		private Collider c;

		private BehaviourPuppet otherPuppet;

		private Collider otherCollider;

		private ConfigurableJoint joint;

		private float nextGrabTime;

		private const float massMlp = 5f;

		private const int solverIterationMlp = 10;

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void Update()
		{
		}
	}
}
