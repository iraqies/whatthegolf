using System;
using Il2CppDummyDll;

[Token(Token = "0x2000B3A")]
public class GenericPlatform : SingletonBehaviour<GenericPlatform>, IPlatform
{
	[Token(Token = "0x4003EA5")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x508F8", Offset = "0x508F8")]
	private readonly bool Initialized__BackingField;

	[Token(Token = "0x17000571")]
	public bool Initialized
	{
		[Token(Token = "0x6003571")]
		[Address(RVA = "0x1484A70", Offset = "0x1484A70", VA = "0x1484A70", Slot = "6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A9A8", Offset = "0x6A9A8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6003572")]
	[Address(RVA = "0x1484A78", Offset = "0x1484A78", VA = "0x1484A78", Slot = "5")]
	public void RunAfterInitialization(Action act)
	{
	}

	[Token(Token = "0x6003573")]
	[Address(RVA = "0x1484A8C", Offset = "0x1484A8C", VA = "0x1484A8C", Slot = "8")]
	public void UnlockAchievement(string achievementId, Action<bool> callback)
	{
	}

	[Token(Token = "0x6003574")]
	[Address(RVA = "0x1484AEC", Offset = "0x1484AEC", VA = "0x1484AEC", Slot = "7")]
	public void ShowTrophies(Action<bool> callback)
	{
	}

	[Token(Token = "0x6003575")]
	[Address(RVA = "0x1484BA4", Offset = "0x1484BA4", VA = "0x1484BA4")]
	public GenericPlatform()
	{
	}
}
