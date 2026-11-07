using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007FE")]
public class GolfPortal : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007FF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41730", Offset = "0x41730")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002ADC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__10_0;

		[Token(Token = "0x60024B6")]
		[Address(RVA = "0x17B5E48", Offset = "0x17B5E48", VA = "0x17B5E48")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60024B7")]
		[Address(RVA = "0x17B5E50", Offset = "0x17B5E50", VA = "0x17B5E50")]
		internal void _003COnTriggerEnter_003Eb__10_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x4002AD4")]
	[FieldOffset(Offset = "0x18")]
	public GolfPortal LinkedPortal;

	[Token(Token = "0x4002AD5")]
	[FieldOffset(Offset = "0x20")]
	public List<string> AllowedTags;

	[Token(Token = "0x4002AD6")]
	[FieldOffset(Offset = "0x28")]
	private GameObject entryPoint;

	[Token(Token = "0x4002AD7")]
	[FieldOffset(Offset = "0x30")]
	public List<GameObject> waitForExits;

	[Token(Token = "0x4002AD8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioClip sfxPortal;

	[Token(Token = "0x4002AD9")]
	[FieldOffset(Offset = "0x40")]
	private Color baseColor;

	[Token(Token = "0x4002ADA")]
	[FieldOffset(Offset = "0x50")]
	private SpriteRenderer render;

	[Token(Token = "0x4002ADB")]
	[FieldOffset(Offset = "0x58")]
	private float colorValue;

	[Token(Token = "0x60024AE")]
	[Address(RVA = "0x14A2200", Offset = "0x14A2200", VA = "0x14A2200")]
	private void Awake()
	{
	}

	[Token(Token = "0x60024AF")]
	[Address(RVA = "0x14A238C", Offset = "0x14A238C", VA = "0x14A238C")]
	private void Update()
	{
	}

	[Token(Token = "0x60024B0")]
	[Address(RVA = "0x14A243C", Offset = "0x14A243C", VA = "0x14A243C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60024B1")]
	[Address(RVA = "0x14A2B9C", Offset = "0x14A2B9C", VA = "0x14A2B9C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60024B2")]
	[Address(RVA = "0x14A28BC", Offset = "0x14A28BC", VA = "0x14A28BC")]
	public void RecieveObject(Rigidbody go, Vector3 relativeOffset)
	{
	}

	[Token(Token = "0x60024B3")]
	[Address(RVA = "0x14A2C60", Offset = "0x14A2C60", VA = "0x14A2C60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60024B4")]
	[Address(RVA = "0x14A2CFC", Offset = "0x14A2CFC", VA = "0x14A2CFC")]
	public GolfPortal()
	{
	}
}
