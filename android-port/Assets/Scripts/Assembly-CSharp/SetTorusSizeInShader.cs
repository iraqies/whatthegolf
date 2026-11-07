using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000201")]
public class SetTorusSizeInShader : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000202")]
	public class Shape
	{
		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x10")]
		public float Size;

		[Token(Token = "0x40009D8")]
		[FieldOffset(Offset = "0x18")]
		public Transform TestPosition;

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1843144", Offset = "0x1843144", VA = "0x1843144")]
		public Shape()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000203")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E3D8", Offset = "0x3E3D8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40009DA")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Shape, float> _003C_003E9__16_0;

		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Shape, float> _003C_003E9__18_2;

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x184310C", Offset = "0x184310C", VA = "0x184310C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1843114", Offset = "0x1843114", VA = "0x1843114")]
		internal float _003CAwake_003Eb__16_0(Shape s)
		{
			return default;
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x184312C", Offset = "0x184312C", VA = "0x184312C")]
		internal float _003CUpdate_003Eb__18_2(Shape s)
		{
			return default;
		}
	}

	[Token(Token = "0x40009C8")]
	[FieldOffset(Offset = "0x18")]
	public Material Mat;

	[Token(Token = "0x40009C9")]
	[FieldOffset(Offset = "0x20")]
	public List<Shape> Sizes;

	[Token(Token = "0x40009CA")]
	[FieldOffset(Offset = "0x28")]
	public Transform GiraffeHand;

	[Token(Token = "0x40009CB")]
	[FieldOffset(Offset = "0x30")]
	public GolfBallController Controller;

	[Token(Token = "0x40009CC")]
	[FieldOffset(Offset = "0x38")]
	public float DistanceThreshold;

	[Token(Token = "0x40009CD")]
	[FieldOffset(Offset = "0x3C")]
	public float RotateSpeed;

	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0x40")]
	public float SculptSpeed;

	[Token(Token = "0x40009CF")]
	[FieldOffset(Offset = "0x44")]
	public float WinFat;

	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem Particles;

	[Token(Token = "0x40009D1")]
	[FieldOffset(Offset = "0x50")]
	public Transform Bottom;

	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x58")]
	public float TestPositionSpacing;

	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x5C")]
	public float TestSize;

	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x60")]
	public AudioSource clayAudioSource;

	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0x68")]
	private bool hasShot;

	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x6C")]
	private float targetVolume;

	[Token(Token = "0x60008FC")]
	[Address(RVA = "0x16902DC", Offset = "0x16902DC", VA = "0x16902DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0x169068C", Offset = "0x169068C", VA = "0x169068C")]
	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0x1690698", Offset = "0x1690698", VA = "0x1690698")]
	private void Update()
	{
	}

	[Token(Token = "0x60008FF")]
	[Address(RVA = "0x1690B50", Offset = "0x1690B50", VA = "0x1690B50")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000900")]
	[Address(RVA = "0x1690CE4", Offset = "0x1690CE4", VA = "0x1690CE4")]
	public SetTorusSizeInShader()
	{
	}

	[Token(Token = "0x6000901")]
	[Address(RVA = "0x1690D14", Offset = "0x1690D14", VA = "0x1690D14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F6EC", Offset = "0x5F6EC")]
	private bool _003CUpdate_003Eb__18_0(Shape s)
	{
		return default;
	}

	[Token(Token = "0x6000902")]
	[Address(RVA = "0x1690DA0", Offset = "0x1690DA0", VA = "0x1690DA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F6FC", Offset = "0x5F6FC")]
	private float _003CUpdate_003Eb__18_1(Shape s)
	{
		return default;
	}
}
