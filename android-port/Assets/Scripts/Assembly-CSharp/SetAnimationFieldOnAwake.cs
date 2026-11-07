using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C35")]
public class SetAnimationFieldOnAwake : MonoBehaviour
{
	[Token(Token = "0x2000C36")]
	public enum TypeEnum
	{
		[Token(Token = "0x4004336")]
		Bool = 0,
		[Token(Token = "0x4004337")]
		Float = 1,
		[Token(Token = "0x4004338")]
		Trigger = 2
	}

	[Token(Token = "0x4004330")]
	[FieldOffset(Offset = "0x18")]
	public bool onAwake;

	[Token(Token = "0x4004331")]
	[FieldOffset(Offset = "0x20")]
	public string FieldName;

	[Token(Token = "0x4004332")]
	[FieldOffset(Offset = "0x28")]
	public TypeEnum FieldType;

	[Token(Token = "0x4004333")]
	[FieldOffset(Offset = "0x30")]
	public string Value;

	[Token(Token = "0x4004334")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 FloatValueRange;

	[Token(Token = "0x6003A4B")]
	[Address(RVA = "0x168B3FC", Offset = "0x168B3FC", VA = "0x168B3FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003A4C")]
	[Address(RVA = "0x168B410", Offset = "0x168B410", VA = "0x168B410")]
	public void SetValue()
	{
	}

	[Token(Token = "0x6003A4D")]
	[Address(RVA = "0x168B554", Offset = "0x168B554", VA = "0x168B554")]
	public SetAnimationFieldOnAwake()
	{
	}
}
