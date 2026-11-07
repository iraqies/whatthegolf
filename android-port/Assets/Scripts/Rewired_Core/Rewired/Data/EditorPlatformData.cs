using System;
using Il2CppDummyDll;
using Rewired.Platforms;
using UnityEngine;

namespace Rewired.Data
{
	[Token(Token = "0x20001BE")]
	public class EditorPlatformData : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20001BF")]
		public class Platform
		{
			[Token(Token = "0x4000A17")]
			[FieldOffset(Offset = "0x10")]
			public TextAsset[] libraries;

			[Token(Token = "0x6000D0C")]
			[Address(RVA = "0x2465E28", Offset = "0x2465E28", VA = "0x2465E28")]
			public Platform()
			{
			}
		}

		[Token(Token = "0x4000A11")]
		[FieldOffset(Offset = "0x18")]
		public Platform windowsStandalone;

		[Token(Token = "0x4000A12")]
		[FieldOffset(Offset = "0x20")]
		public Platform windowsStore;

		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0x28")]
		public Platform osxStandalone;

		[Token(Token = "0x4000A14")]
		[FieldOffset(Offset = "0x30")]
		public Platform linuxStandalone;

		[Token(Token = "0x4000A15")]
		[FieldOffset(Offset = "0x38")]
		public Platform webplayer;

		[Token(Token = "0x4000A16")]
		[FieldOffset(Offset = "0x40")]
		public Platform fallback;

		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x23C931C", Offset = "0x23C931C", VA = "0x23C931C")]
		public TextAsset[] GetLibraries(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform)
		{
			return null;
		}

		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x23C9374", Offset = "0x23C9374", VA = "0x23C9374")]
		public Platform GetPlatform(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform)
		{
			return null;
		}

		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x23C93B8", Offset = "0x23C93B8", VA = "0x23C93B8")]
		public EditorPlatformData()
		{
		}
	}
}
