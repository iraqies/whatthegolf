using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002C7")]
public class RepeatRumbleTest : MonoBehaviour, IAudioEvent
{
	[Token(Token = "0x4000F35")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B76C", Offset = "0x4B76C")]
	private Action<Vector3> OnAudioEvent__BackingField;

	[Token(Token = "0x17000187")]
	public Action<Vector3> OnAudioEvent
	{
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x1649224", Offset = "0x1649224", VA = "0x1649224", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6063C", Offset = "0x6063C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x164922C", Offset = "0x164922C", VA = "0x164922C", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6064C", Offset = "0x6064C")]
		set
		{
		}
	}

	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x1649234", Offset = "0x1649234", VA = "0x1649234")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x1649298", Offset = "0x1649298", VA = "0x1649298")]
	public void Test()
	{
	}

	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x1649318", Offset = "0x1649318", VA = "0x1649318")]
	public RepeatRumbleTest()
	{
	}
}
