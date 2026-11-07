using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200007F")]
public class AAScreens : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000080")]
	public class VideoDef
	{
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x18")]
		public int width;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x1C")]
		public int height;

		[Token(Token = "0x17000059")]
		public float aspect
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1766F38", Offset = "0x1766F38", VA = "0x1766F38")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x176701C", Offset = "0x176701C", VA = "0x176701C")]
		public VideoDef()
		{
		}
	}

	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D5F8", Offset = "0x3D5F8")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x10")]
		public float aspect;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x14")]
		public int w;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x18")]
		public IVideoPathProvider videoPathProvider;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1766ECC", Offset = "0x1766ECC", VA = "0x1766ECC")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1766ED4", Offset = "0x1766ED4", VA = "0x1766ED4")]
		internal float _003CGetSplashVideoPath_003Eb__0(VideoDef d)
		{
			return default;
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1766F4C", Offset = "0x1766F4C", VA = "0x1766F4C")]
		internal bool _003CGetSplashVideoPath_003Eb__1(VideoDef d)
		{
			return default;
		}
	}

	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<VideoDef> splashVideos;

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x1402B24", Offset = "0x1402B24", VA = "0x1402B24")]
	public string GetSplashVideoPath(IVideoPathProvider videoPathProvider)
	{
		return null;
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1402DD0", Offset = "0x1402DD0", VA = "0x1402DD0")]
	public AAScreens()
	{
	}
}
