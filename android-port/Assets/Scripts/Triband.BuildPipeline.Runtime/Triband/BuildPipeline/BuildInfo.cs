using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Serializable]
	[Token(Token = "0x2000002")]
	public class BuildInfo
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BuildType _buildType;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private VersionInfo _versionInfo;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _buildConfigAssetName;

		[Token(Token = "0x17000001")]
		public BuildType buildType
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x29F74E4", Offset = "0x29F74E4", VA = "0x29F74E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000002")]
		public VersionInfo versionInfo
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x29F74EC", Offset = "0x29F74EC", VA = "0x29F74EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000003")]
		public string buildConfigAssetName
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x29F7504", Offset = "0x29F7504", VA = "0x29F7504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x29F750C", Offset = "0x29F750C", VA = "0x29F750C")]
		public BuildInfo()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x29F7514", Offset = "0x29F7514", VA = "0x29F7514", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
