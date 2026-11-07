using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Impact
{
	[Token(Token = "0x2001408")]
	public class ImpactDirectionChecker : ImpactConditionBase
	{
		[Token(Token = "0x4006B88")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 direction;

		[Token(Token = "0x4006B89")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool localAxis;

		[Token(Token = "0x4006B8A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float directionThreshold;

		[Token(Token = "0x6005D43")]
		[Address(RVA = "0x14E7140", Offset = "0x14E7140", VA = "0x14E7140", Slot = "4")]
		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return default;
		}

		[Token(Token = "0x6005D44")]
		[Address(RVA = "0x14E723C", Offset = "0x14E723C", VA = "0x14E723C")]
		public ImpactDirectionChecker()
		{
		}
	}
}
