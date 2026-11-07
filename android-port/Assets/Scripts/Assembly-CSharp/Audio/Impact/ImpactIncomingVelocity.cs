using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Impact
{
	[Token(Token = "0x200140A")]
	public class ImpactIncomingVelocity : ImpactConditionBase
	{
		[Token(Token = "0x4006B8E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 direction;

		[Token(Token = "0x4006B8F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool localAxis;

		[Token(Token = "0x4006B90")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float directionThreshold;

		[Token(Token = "0x6005D47")]
		[Address(RVA = "0x14E72F4", Offset = "0x14E72F4", VA = "0x14E72F4", Slot = "4")]
		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return default;
		}

		[Token(Token = "0x6005D48")]
		[Address(RVA = "0x14E73A0", Offset = "0x14E73A0", VA = "0x14E73A0")]
		public ImpactIncomingVelocity()
		{
		}
	}
}
