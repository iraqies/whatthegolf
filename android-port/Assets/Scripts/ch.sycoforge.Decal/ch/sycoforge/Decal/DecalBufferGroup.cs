using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x200000B")]
	internal class DecalBufferGroup
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x10")]
		public RenderTargetIdentifier[] RenderTargets;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x18")]
		public RenderTargetIdentifier[] RenderTargetsHDR;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x20")]
		public HashSet<EasyDecal> Decals;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x28")]
		public DeferredFlags Flags;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x2C")]
		public int PassIndex;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B8FC", Offset = "0x20B8FC")]
		private static Comparison<BuiltinRenderTextureType> CS_0024_003C_003E9__CachedAnonymousMethodDelegate1;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2C5BBE4", Offset = "0x2C5BBE4", VA = "0x2C5BBE4")]
		public RenderTargetIdentifier[] GetTargets(Camera camera)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2C5BC28", Offset = "0x2C5BC28", VA = "0x2C5BC28")]
		public static int GetPassIndex(DeferredFlags flags)
		{
			return default;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2C5BC60", Offset = "0x2C5BC60", VA = "0x2C5BC60")]
		public static RenderTargetIdentifier[] GetRenderTargets(DeferredFlags flags, bool hdr)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2C5C118", Offset = "0x2C5C118", VA = "0x2C5C118")]
		private static BuiltinRenderTextureType FlagToTarget(DeferredFlags flag)
		{
			return default;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2C5C148", Offset = "0x2C5C148", VA = "0x2C5C148")]
		public DecalBufferGroup()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2C5C150", Offset = "0x2C5C150", VA = "0x2C5C150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x20BD5C", Offset = "0x20BD5C")]
		private static int _003CGetRenderTargets_003Eb__0(BuiltinRenderTextureType x, BuiltinRenderTextureType y)
		{
			return default;
		}
	}
}
