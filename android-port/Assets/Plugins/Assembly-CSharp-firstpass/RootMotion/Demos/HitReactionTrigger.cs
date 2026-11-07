using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001FD")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000D6B")]
		[FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000D6C")]
		[FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000D6D")]
		[FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x1382EEC", Offset = "0x1382EEC", VA = "0x1382EEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x1383030", Offset = "0x1383030", VA = "0x1383030")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x1383220", Offset = "0x1383220", VA = "0x1383220")]
		public HitReactionTrigger()
		{
		}
	}
}
