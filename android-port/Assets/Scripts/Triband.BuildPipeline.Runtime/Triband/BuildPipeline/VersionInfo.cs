using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.BuildPipeline
{
	[Serializable]
	[Token(Token = "0x200000C")]
	public struct VersionInfo
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string _bundleVersion;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private string _buildNumber;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _buildNumberInteger;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _branchName;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _commit;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x29F7910", Offset = "0x29F7910", VA = "0x29F7910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
