using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200021F")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000E15")]
		[FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000E16")]
		[FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000E17")]
		[FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x1383598", Offset = "0x1383598", VA = "0x1383598")]
		private void Update()
		{
		}

		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x13836DC", Offset = "0x13836DC", VA = "0x13836DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x13838CC", Offset = "0x13838CC", VA = "0x13838CC")]
		public HitReactionVRIKTrigger()
		{
		}
	}
}
