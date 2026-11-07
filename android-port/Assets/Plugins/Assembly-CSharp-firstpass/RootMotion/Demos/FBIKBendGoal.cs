using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001F8")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000D4B")]
		[FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x136C87C", Offset = "0x136C87C", VA = "0x136C87C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x136C8F0", Offset = "0x136C8F0", VA = "0x136C8F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x136C9D4", Offset = "0x136C9D4", VA = "0x136C9D4")]
		public FBIKBendGoal()
		{
		}
	}
}
