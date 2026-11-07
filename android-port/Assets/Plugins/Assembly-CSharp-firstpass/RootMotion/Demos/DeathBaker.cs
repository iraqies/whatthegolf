using System.Collections;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class DeathBaker : MonoBehaviour
	{
		public HumanoidBaker baker;

		public float bakeTime;

		public PuppetMaster puppetMaster;

		public float fadeOutPinWeightSpeed;

		public float fadeOutMuscleWeightSpeed;

		public float deadMuscleWeight;

		private Animator animator;

		private Vector3 defaultPosition;

		private Quaternion defaultRotation;

		private bool isDead;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private IEnumerator Bake()
		{
			return null;
		}

		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}
	}
}
