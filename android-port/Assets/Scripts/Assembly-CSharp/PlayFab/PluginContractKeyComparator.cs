using System.Collections.Generic;
using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x2001194")]
	public class PluginContractKeyComparator : EqualityComparer<PluginContractKey>
	{
		[Token(Token = "0x6005044")]
		[Address(RVA = "0x15FF0AC", Offset = "0x15FF0AC", VA = "0x15FF0AC", Slot = "8")]
		public override bool Equals(PluginContractKey x, PluginContractKey y)
		{
			return default;
		}

		[Token(Token = "0x6005045")]
		[Address(RVA = "0x15FF0DC", Offset = "0x15FF0DC", VA = "0x15FF0DC", Slot = "9")]
		public override int GetHashCode(PluginContractKey obj)
		{
			return default;
		}

		[Token(Token = "0x6005046")]
		[Address(RVA = "0x15FF114", Offset = "0x15FF114", VA = "0x15FF114")]
		public PluginContractKeyComparator()
		{
		}
	}
}
