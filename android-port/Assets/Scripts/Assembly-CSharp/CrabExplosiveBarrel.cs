using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000FB")]
public class CrabExplosiveBarrel : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DAC0", Offset = "0x3DAC0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x8")]
		public static Action<GameObject> _003C_003E9__3_0;

		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x10")]
		public static Action<GameObject> _003C_003E9__4_0;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x179151C", Offset = "0x179151C", VA = "0x179151C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1791524", Offset = "0x1791524", VA = "0x1791524")]
		internal void _003CReset_003Eb__3_0(GameObject p)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1791544", Offset = "0x1791544", VA = "0x1791544")]
		internal void _003CExplode_003Eb__4_0(GameObject p)
		{
		}
	}

	[Token(Token = "0x4000449")]
	[FieldOffset(Offset = "0x18")]
	public bool HasExploded;

	[Token(Token = "0x400044A")]
	[FieldOffset(Offset = "0x20")]
	public MeshRenderer Renderer;

	[Token(Token = "0x400044B")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> Particles;

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x18BB138", Offset = "0x18BB138", VA = "0x18BB138")]
	public void Reset()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x18BB284", Offset = "0x18BB284", VA = "0x18BB284")]
	public void Explode()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x18BB3D4", Offset = "0x18BB3D4", VA = "0x18BB3D4")]
	public CrabExplosiveBarrel()
	{
	}
}
