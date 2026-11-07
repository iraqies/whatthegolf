using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005AD")]
public class MenuGoalPin : MonoBehaviour
{
	[Token(Token = "0x4001CF2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject next;

	[Token(Token = "0x4001CF3")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 nextStart;

	[Token(Token = "0x4001CF4")]
	[FieldOffset(Offset = "0x30")]
	private GolfGoal pin;

	[Token(Token = "0x4001CF5")]
	[FieldOffset(Offset = "0x38")]
	private bool didEnable;

	[Token(Token = "0x60019CA")]
	[Address(RVA = "0x1564D44", Offset = "0x1564D44", VA = "0x1564D44")]
	private void Start()
	{
	}

	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x1564EF4", Offset = "0x1564EF4", VA = "0x1564EF4")]
	private void Pin_OnGoal(string obj)
	{
	}

	[Token(Token = "0x60019CC")]
	[Address(RVA = "0x1564FCC", Offset = "0x1564FCC", VA = "0x1564FCC")]
	public MenuGoalPin()
	{
	}

	[Token(Token = "0x60019CD")]
	[Address(RVA = "0x1564FD4", Offset = "0x1564FD4", VA = "0x1564FD4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x63594", Offset = "0x63594")]
	private void _003CPin_OnGoal_003Eb__5_0(float t)
	{
	}
}
