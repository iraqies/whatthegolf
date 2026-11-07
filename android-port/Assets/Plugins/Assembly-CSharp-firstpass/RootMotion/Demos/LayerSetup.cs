using System.Collections.Generic;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class LayerSetup : MonoBehaviour
	{
		public Transform characterController;

		public int characterControllerLayer;

		public int ragdollLayer;

		public LayerMask ignoreCollisionWithCharacterController;

		public LayerMask ignoreCollisionWithRagdoll;

		private PuppetMaster puppetMaster;

		private bool oldRagdollToCharacterControllerValue;

		private bool oldCharacterControllerToCharacterControllerValue;

		private Dictionary<int, bool> oldCharacterControllerLayers;

		private Dictionary<int, bool> oldRagdollLayers;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
