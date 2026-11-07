using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x20012ED")]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		[Token(Token = "0x40065DB")]
		[FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x17000A0A")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60057CA")]
			[Address(RVA = "0x1503BB8", Offset = "0x1503BB8", VA = "0x1503BB8", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60057CB")]
			[Address(RVA = "0x1503BC0", Offset = "0x1503BC0", VA = "0x1503BC0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60057CC")]
		[Address(RVA = "0x1503BC8", Offset = "0x1503BC8", VA = "0x1503BC8")]
		public LanguageSourceAsset()
		{
		}
	}
}
