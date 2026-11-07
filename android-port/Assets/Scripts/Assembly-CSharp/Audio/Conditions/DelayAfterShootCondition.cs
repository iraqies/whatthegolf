using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Conditions
{
	[Token(Token = "0x20013EE")]
	public class DelayAfterShootCondition : AudioDelayCondition
	{
		[Token(Token = "0x4006B30")]
		[FieldOffset(Offset = "0x20")]
		public GolfBallController golfBallController;

		[Token(Token = "0x6005CDF")]
		[Address(RVA = "0x18D91AC", Offset = "0x18D91AC", VA = "0x18D91AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005CE0")]
		[Address(RVA = "0x18D925C", Offset = "0x18D925C", VA = "0x18D925C", Slot = "4")]
		public override bool CheckCondition()
		{
			return default;
		}

		[Token(Token = "0x6005CE1")]
		[Address(RVA = "0x18D928C", Offset = "0x18D928C", VA = "0x18D928C")]
		public DelayAfterShootCondition()
		{
		}

		[Token(Token = "0x6005CE2")]
		[Address(RVA = "0x18D9294", Offset = "0x18D9294", VA = "0x18D9294")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72860", Offset = "0x72860")]
		private void _003CAwake_003Eb__1_0(Vector3 v)
		{
		}
	}
}
