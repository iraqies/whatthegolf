using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001FA")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000D54")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000D55")]
		[FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x136ECF8", Offset = "0x136ECF8", VA = "0x136ECF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x136EDC8", Offset = "0x136EDC8", VA = "0x136EDC8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x136EE68", Offset = "0x136EE68", VA = "0x136EE68")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x136F258", Offset = "0x136F258", VA = "0x136F258")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x136F374", Offset = "0x136F374", VA = "0x136F374")]
		public FBIKHandsOnProp()
		{
		}
	}
}
