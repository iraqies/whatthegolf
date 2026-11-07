using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Conditions
{
	[Token(Token = "0x20013EF")]
	public class VelocityCondition : AudioCondition
	{
		[Token(Token = "0x4006B31")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody _Rigidbody;

		[Token(Token = "0x4006B32")]
		[FieldOffset(Offset = "0x20")]
		public bool overThreshold;

		[Token(Token = "0x4006B33")]
		[FieldOffset(Offset = "0x24")]
		public float threshold;

		[Token(Token = "0x6005CE3")]
		[Address(RVA = "0x174A3EC", Offset = "0x174A3EC", VA = "0x174A3EC", Slot = "4")]
		public override bool CheckCondition()
		{
			return default;
		}

		[Token(Token = "0x6005CE4")]
		[Address(RVA = "0x174A45C", Offset = "0x174A45C", VA = "0x174A45C")]
		public VelocityCondition()
		{
		}
	}
}
