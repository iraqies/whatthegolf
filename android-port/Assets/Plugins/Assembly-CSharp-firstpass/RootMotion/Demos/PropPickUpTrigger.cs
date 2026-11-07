using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	public class PropPickUpTrigger : MonoBehaviour
	{
		public PuppetMasterProp prop;

		public LayerMask characterLayers;

		private CharacterPuppet characterPuppet;

		private void OnTriggerEnter(Collider collider)
		{
		}
	}
}
