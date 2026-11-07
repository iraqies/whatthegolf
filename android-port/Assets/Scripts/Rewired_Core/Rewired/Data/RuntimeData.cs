using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Platforms;
using UnityEngine;

namespace Rewired.Data
{
	[Token(Token = "0x20001BD")]
	public class RuntimeData : ScriptableObject
	{
		[Token(Token = "0x4000A0D")]
		[FieldOffset(Offset = "0x18")]
		public Platform platform;

		[Token(Token = "0x4000A0E")]
		[FieldOffset(Offset = "0x1C")]
		public WebplayerPlatform webplayerPlatform;

		[Token(Token = "0x4000A0F")]
		[FieldOffset(Offset = "0x20")]
		public EditorPlatform editorPlatform;

		[Token(Token = "0x4000A10")]
		[FieldOffset(Offset = "0x28")]
		public List<TextAsset> libraries;

		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x24090D4", Offset = "0x24090D4", VA = "0x24090D4")]
		public void SetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform, List<TextAsset> libraries)
		{
		}

		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x24090E4", Offset = "0x24090E4", VA = "0x24090E4")]
		public RuntimeData()
		{
		}
	}
}
