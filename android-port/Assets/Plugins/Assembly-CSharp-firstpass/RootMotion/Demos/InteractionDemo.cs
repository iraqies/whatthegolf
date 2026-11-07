using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000200")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000D79")]
		[FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000D7A")]
		[FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000D7B")]
		[FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000D7C")]
		[FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000D7D")]
		[FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000D7E")]
		[FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000D7F")]
		[FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000D80")]
		[FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000D81")]
		[FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x139DA80", Offset = "0x139DA80", VA = "0x139DA80")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x139E30C", Offset = "0x139E30C", VA = "0x139E30C")]
		public InteractionDemo()
		{
		}
	}
}
