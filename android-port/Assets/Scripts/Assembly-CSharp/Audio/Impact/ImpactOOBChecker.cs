using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Impact
{
	[Token(Token = "0x200140E")]
	public class ImpactOOBChecker : ScriptableObject
	{
		[Token(Token = "0x6005D50")]
		[Address(RVA = "0x14E7624", Offset = "0x14E7624", VA = "0x14E7624")]
		public bool CheckCondition(TriggerInfo info, ImpactUser impacter)
		{
			return default;
		}

		[Token(Token = "0x6005D51")]
		[Address(RVA = "0x14E7750", Offset = "0x14E7750", VA = "0x14E7750")]
		public ImpactOOBChecker()
		{
		}
	}
}
