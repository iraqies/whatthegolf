using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Impact
{
	[Token(Token = "0x2001406")]
	public class ImpactChanceToPlay : ImpactConditionBase
	{
		[Token(Token = "0x4006B86")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x5AD74", Offset = "0x5AD74")]
		[SerializeField]
		private float chance;

		[Token(Token = "0x6005D3F")]
		[Address(RVA = "0x14E70E8", Offset = "0x14E70E8", VA = "0x14E70E8", Slot = "4")]
		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return default;
		}

		[Token(Token = "0x6005D40")]
		[Address(RVA = "0x14E7118", Offset = "0x14E7118", VA = "0x14E7118")]
		public ImpactChanceToPlay()
		{
		}
	}
}
