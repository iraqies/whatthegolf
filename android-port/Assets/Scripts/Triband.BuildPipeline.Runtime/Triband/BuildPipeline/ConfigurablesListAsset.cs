using Il2CppDummyDll;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Token(Token = "0x2000009")]
	public class ConfigurablesListAsset : ScriptableObject
	{
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ConfigurablesList _configurables;

		[Token(Token = "0x17000007")]
		public ConfigurablesList configurables
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x29F7734", Offset = "0x29F7734", VA = "0x29F7734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x29F773C", Offset = "0x29F773C", VA = "0x29F773C")]
		public ConfigurablesListAsset()
		{
		}
	}
}
