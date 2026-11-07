using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Conditions
{
	[Token(Token = "0x20013F0")]
	public class VelocityCondition2D : AudioCondition
	{
		[Token(Token = "0x4006B34")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody2D _Rigidbody;

		[Token(Token = "0x4006B35")]
		[FieldOffset(Offset = "0x20")]
		public bool overThreshold;

		[Token(Token = "0x4006B36")]
		[FieldOffset(Offset = "0x24")]
		public float threshold;

		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0x174A464", Offset = "0x174A464", VA = "0x174A464", Slot = "4")]
		public override bool CheckCondition()
		{
			return default;
		}

		[Token(Token = "0x6005CE6")]
		[Address(RVA = "0x174A4CC", Offset = "0x174A4CC", VA = "0x174A4CC")]
		public VelocityCondition2D()
		{
		}
	}
}
