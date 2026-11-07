using System.Collections;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class Dying : MonoBehaviour
	{
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
