using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009D9")]
public class MovingCarArea : MonoBehaviour
{
	[Token(Token = "0x4003618")]
	[FieldOffset(Offset = "0x18")]
	public InvisibleCullingObject cullingRect;

	[Token(Token = "0x4003619")]
	[FieldOffset(Offset = "0x20")]
	public MovingCar[] movingCars;

	[Token(Token = "0x400361A")]
	[FieldOffset(Offset = "0x28")]
	private float time;

	[Token(Token = "0x6002E58")]
	[Address(RVA = "0x1576230", Offset = "0x1576230", VA = "0x1576230")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002E59")]
	[Address(RVA = "0x1576374", Offset = "0x1576374", VA = "0x1576374")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x6002E5A")]
	[Address(RVA = "0x15763FC", Offset = "0x15763FC", VA = "0x15763FC")]
	public MovingCarArea()
	{
	}

	[Token(Token = "0x6002E5B")]
	[Address(RVA = "0x1576404", Offset = "0x1576404", VA = "0x1576404")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x689D8", Offset = "0x689D8")]
	private void _003CAwake_003Eb__3_0()
	{
	}

	[Token(Token = "0x6002E5C")]
	[Address(RVA = "0x1576410", Offset = "0x1576410", VA = "0x1576410")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x689E8", Offset = "0x689E8")]
	private void _003CAwake_003Eb__3_1()
	{
	}
}
