using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200021C")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000E0F")]
		[FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000E10")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36D40", Offset = "0x36D40")]
		public float weight;

		[Token(Token = "0x6000E7F")]
		[Address(RVA = "0x1300464", Offset = "0x1300464", VA = "0x1300464")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E80")]
		[Address(RVA = "0x13004D8", Offset = "0x13004D8", VA = "0x13004D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x13005A4", Offset = "0x13005A4", VA = "0x13005A4")]
		public BendGoal()
		{
		}
	}
}
