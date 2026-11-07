using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C39")]
public class SetAnimationFieldOnShoot : MonoBehaviour
{
	[Token(Token = "0x2000C3A")]
	public enum TypeEnum
	{
		[Token(Token = "0x4004348")]
		Bool = 0,
		[Token(Token = "0x4004349")]
		Float = 1,
		[Token(Token = "0x400434A")]
		Trigger = 2
	}

	[Token(Token = "0x4004342")]
	[FieldOffset(Offset = "0x18")]
	public string FieldName;

	[Token(Token = "0x4004343")]
	[FieldOffset(Offset = "0x20")]
	public TypeEnum FieldType;

	[Token(Token = "0x4004344")]
	[FieldOffset(Offset = "0x28")]
	public string Value;

	[Token(Token = "0x4004345")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 FloatValueRange;

	[Token(Token = "0x4004346")]
	[FieldOffset(Offset = "0x38")]
	private Animator animator;

	[Token(Token = "0x6003A51")]
	[Address(RVA = "0x168B760", Offset = "0x168B760", VA = "0x168B760")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A52")]
	[Address(RVA = "0x168B848", Offset = "0x168B848", VA = "0x168B848")]
	private void BallOnOnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x6003A53")]
	[Address(RVA = "0x168B970", Offset = "0x168B970", VA = "0x168B970")]
	public SetAnimationFieldOnShoot()
	{
	}
}
