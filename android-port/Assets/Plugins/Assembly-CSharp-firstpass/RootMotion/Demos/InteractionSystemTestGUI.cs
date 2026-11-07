using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000201")]
	[Attribute(Name = "RequireComponent", RVA = "0x33BFC", Offset = "0x33BFC")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000D82")]
		[FieldOffset(Offset = "0x18")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000D83")]
		[FieldOffset(Offset = "0x20")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000D84")]
		[FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x13A5E20", Offset = "0x13A5E20", VA = "0x13A5E20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x13A5E7C", Offset = "0x13A5E7C", VA = "0x13A5E7C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x13A61C0", Offset = "0x13A61C0", VA = "0x13A61C0")]
		public InteractionSystemTestGUI()
		{
		}
	}
}
