using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C37")]
public class SetAnimationFieldOnCancel : MonoBehaviour
{
	[Token(Token = "0x2000C38")]
	public enum TypeEnum
	{
		[Token(Token = "0x400433F")]
		Bool = 0,
		[Token(Token = "0x4004340")]
		Float = 1,
		[Token(Token = "0x4004341")]
		Trigger = 2
	}

	[Token(Token = "0x4004339")]
	[FieldOffset(Offset = "0x18")]
	public string FieldName;

	[Token(Token = "0x400433A")]
	[FieldOffset(Offset = "0x20")]
	public TypeEnum FieldType;

	[Token(Token = "0x400433B")]
	[FieldOffset(Offset = "0x28")]
	public string Value;

	[Token(Token = "0x400433C")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 FloatValueRange;

	[Token(Token = "0x400433D")]
	[FieldOffset(Offset = "0x38")]
	private Animator animator;

	[Token(Token = "0x6003A4E")]
	[Address(RVA = "0x168B564", Offset = "0x168B564", VA = "0x168B564")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A4F")]
	[Address(RVA = "0x168B630", Offset = "0x168B630", VA = "0x168B630")]
	private void BallOnCancel()
	{
	}

	[Token(Token = "0x6003A50")]
	[Address(RVA = "0x168B758", Offset = "0x168B758", VA = "0x168B758")]
	public SetAnimationFieldOnCancel()
	{
	}
}
