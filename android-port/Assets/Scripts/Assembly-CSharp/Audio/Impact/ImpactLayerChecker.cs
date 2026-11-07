using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Impact
{
	[Token(Token = "0x200140B")]
	public class ImpactLayerChecker : ImpactConditionBase
	{
		[Token(Token = "0x4006B91")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool useIncludedLayers;

		[Token(Token = "0x4006B92")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private LayerMask includeLayers;

		[Token(Token = "0x4006B93")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool useExcludeLayers;

		[Token(Token = "0x4006B94")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LayerMask excludeLayers;

		[Token(Token = "0x6005D49")]
		[Address(RVA = "0x14E73C4", Offset = "0x14E73C4", VA = "0x14E73C4", Slot = "4")]
		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return default;
		}

		[Token(Token = "0x6005D4A")]
		[Address(RVA = "0x14E746C", Offset = "0x14E746C", VA = "0x14E746C")]
		public ImpactLayerChecker()
		{
		}
	}
}
