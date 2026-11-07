using Il2CppDummyDll;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Token(Token = "0x200000A")]
	public class RuntimeBuildSetup : ScriptableObject
	{
		[Token(Token = "0x400001B")]
		public const string ASSET_PATH = "Assets/Settings/RuntimeBuildSetup.asset";

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ConfigurablesList _configurables;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildInfo _buildInfo;

		[Token(Token = "0x17000008")]
		public ConfigurablesList configurables
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x29F7808", Offset = "0x29F7808", VA = "0x29F7808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public BuildInfo buildInfo
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x29F7810", Offset = "0x29F7810", VA = "0x29F7810")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000011")]
		public static T LoadRuntimeBuildSetup<T>() where T : RuntimeBuildSetup
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x29F7818", Offset = "0x29F7818", VA = "0x29F7818")]
		public RuntimeBuildSetup()
		{
		}
	}
}
