using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001FF")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000D76")]
		[FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000D77")]
		[FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000D78")]
		[FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000E0A")]
		[Address(RVA = "0x139D71C", Offset = "0x139D71C", VA = "0x139D71C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000E0B")]
		[Address(RVA = "0x139D96C", Offset = "0x139D96C", VA = "0x139D96C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x139DA78", Offset = "0x139DA78", VA = "0x139DA78")]
		public InteractionC2CDemo()
		{
		}
	}
}
