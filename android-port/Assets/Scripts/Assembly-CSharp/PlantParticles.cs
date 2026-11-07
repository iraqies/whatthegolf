using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ACE")]
public class PlantParticles : MonoBehaviour
{
	[Token(Token = "0x2000ACF")]
	public enum PlantType
	{
		[Token(Token = "0x4003C34")]
		office = 0,
		[Token(Token = "0x4003C35")]
		sawable = 1,
		[Token(Token = "0x4003C36")]
		door = 2
	}

	[Token(Token = "0x4003C31")]
	[FieldOffset(Offset = "0x18")]
	public PlantType type;

	[Token(Token = "0x4003C32")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x506A8", Offset = "0x506A8")]
	private Action<PlantParticles, int> m_OnParticles;

	[Token(Token = "0x1400006D")]
	public event Action<PlantParticles, int> OnParticles
	{
		[Token(Token = "0x60033B2")]
		[Address(RVA = "0x15E4CF0", Offset = "0x15E4CF0", VA = "0x15E4CF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A568", Offset = "0x6A568")]
		add
		{
		}
		[Token(Token = "0x60033B3")]
		[Address(RVA = "0x15E4D94", Offset = "0x15E4D94", VA = "0x15E4D94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A578", Offset = "0x6A578")]
		remove
		{
		}
	}

	[Token(Token = "0x60033B4")]
	[Address(RVA = "0x15E4E38", Offset = "0x15E4E38", VA = "0x15E4E38")]
	public void Emit(int amount)
	{
	}

	[Token(Token = "0x60033B5")]
	[Address(RVA = "0x15E4EAC", Offset = "0x15E4EAC", VA = "0x15E4EAC")]
	public PlantParticles()
	{
	}
}
