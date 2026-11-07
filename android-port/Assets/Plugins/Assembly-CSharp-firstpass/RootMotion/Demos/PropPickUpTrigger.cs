using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000240")]
	public class PropPickUpTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0x18")]
		public PuppetMasterProp prop;

		[Token(Token = "0x4000EAF")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask characterLayers;

		[Token(Token = "0x4000EB0")]
		[FieldOffset(Offset = "0x28")]
		private CharacterPuppet characterPuppet;

		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x13C3390", Offset = "0x13C3390", VA = "0x13C3390")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x13C3530", Offset = "0x13C3530", VA = "0x13C3530")]
		public PropPickUpTrigger()
		{
		}
	}
}
