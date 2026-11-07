using Il2CppDummyDll;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Token(Token = "0x200000B")]
	public static class RuntimeBundlingSupport
	{
		[Token(Token = "0x6000013")]
		public static T LoadAsset<T>(string assetPath) where T : Object
		{
			return null;
		}
	}
}
