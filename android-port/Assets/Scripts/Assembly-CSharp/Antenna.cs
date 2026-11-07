using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005E9")]
public class Antenna : MonoBehaviour
{
	[Token(Token = "0x4001E32")]
	[FieldOffset(Offset = "0x18")]
	public Renderer rend;

	[Token(Token = "0x4001E33")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4001E34")]
	[FieldOffset(Offset = "0x28")]
	public Transform golfBall;

	[Token(Token = "0x4001E35")]
	[FieldOffset(Offset = "0x30")]
	public string materialName;

	[Token(Token = "0x4001E36")]
	[FieldOffset(Offset = "0x38")]
	public string propertyName;

	[Token(Token = "0x4001E37")]
	[FieldOffset(Offset = "0x40")]
	public float maxDist;

	[Token(Token = "0x4001E38")]
	[FieldOffset(Offset = "0x44")]
	public float winDist;

	[Token(Token = "0x4001E39")]
	[FieldOffset(Offset = "0x48")]
	public GolfGoal goal;

	[Token(Token = "0x4001E3A")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve distanceToNoiseCurve;

	[Token(Token = "0x4001E3B")]
	[FieldOffset(Offset = "0x58")]
	public Rigidbody[] antennaParts;

	[Token(Token = "0x4001E3C")]
	[FieldOffset(Offset = "0x60")]
	private Material screenMaterial;

	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x1418570", Offset = "0x1418570", VA = "0x1418570")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AEC")]
	[Address(RVA = "0x1418620", Offset = "0x1418620", VA = "0x1418620")]
	private void Update()
	{
	}

	[Token(Token = "0x6001AED")]
	[Address(RVA = "0x141887C", Offset = "0x141887C", VA = "0x141887C")]
	public Antenna()
	{
	}
}
