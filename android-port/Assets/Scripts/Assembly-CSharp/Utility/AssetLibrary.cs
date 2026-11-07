using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Utility
{
	[Token(Token = "0x2001020")]
	public class AssetLibrary<T> : ScriptableObject where T : Object
	{
		[Token(Token = "0x2001021")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4754C", Offset = "0x4754C")]
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			[Token(Token = "0x400551E")]
			[FieldOffset(Offset = "0x0")]
			public string fileName;

			[Token(Token = "0x6004821")]
			public _003C_003Ec__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6004822")]
			internal bool _003CGetAssetByName_003Eb__0(T a)
			{
				return default;
			}
		}

		[Token(Token = "0x400551D")]
		[FieldOffset(Offset = "0x0")]
		public List<T> Assets;

		[Token(Token = "0x600481F")]
		public T GetAssetByName(string fileName)
		{
			return null;
		}

		[Token(Token = "0x6004820")]
		public AssetLibrary()
		{
		}
	}
}
