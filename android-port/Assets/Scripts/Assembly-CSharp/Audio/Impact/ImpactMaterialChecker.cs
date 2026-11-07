using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Impact
{
	[Token(Token = "0x200140C")]
	public class ImpactMaterialChecker : ImpactConditionBase
	{
		[Token(Token = "0x4006B95")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool affectIncomingObjectSize;

		[Token(Token = "0x4006B96")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool includeNonMaterial;

		[Token(Token = "0x4006B97")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AudioMaterial> mustIncludeMaterial;

		[Token(Token = "0x4006B98")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<AudioMaterial> cannotIncludeMaterial;

		[Token(Token = "0x6005D4B")]
		[Address(RVA = "0x14E747C", Offset = "0x14E747C", VA = "0x14E747C", Slot = "4")]
		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return default;
		}

		[Token(Token = "0x6005D4C")]
		[Address(RVA = "0x14E7610", Offset = "0x14E7610", VA = "0x14E7610")]
		public ImpactMaterialChecker()
		{
		}
	}
}
