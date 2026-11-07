using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		public enum Mode
		{
			Colliders = 0,
			Joints = 1
		}

		public Rigidbody selectedRigidbody;

		public Collider selectedCollider;

		public bool symmetry;

		public Mode mode;

		private void OpenUserManual()
		{
		}

		private void OpenScriptReference()
		{
		}

		private void OpenTutorial()
		{
		}
	}
}
