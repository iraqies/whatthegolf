using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Impact
{
	[Token(Token = "0x200140F")]
	public class ImpactTagChecker : ImpactConditionBase
	{
		[Token(Token = "0x4006B9E")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool useIncludeTags;

		[Token(Token = "0x4006B9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> includeTags;

		[Token(Token = "0x4006BA0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool useExcludeTags;

		[Token(Token = "0x4006BA1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> excludeTags;

		[Token(Token = "0x6005D52")]
		[Address(RVA = "0x14E7EB4", Offset = "0x14E7EB4", VA = "0x14E7EB4", Slot = "4")]
		public override bool CheckCondition(ImpactAsset asset, HitInfo info, float normalizedVelocity)
		{
			return default;
		}

		[Token(Token = "0x6005D53")]
		[Address(RVA = "0x14E7F78", Offset = "0x14E7F78", VA = "0x14E7F78")]
		public ImpactTagChecker()
		{
		}
	}
}
