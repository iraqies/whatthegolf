using System.Collections.Generic;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000142")]
public class MultiplePlayerCameraFollow : MonoBehaviour
{
	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> objectsToFollow;

	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x20")]
	public float HeightMod;

	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x24")]
	public float HeightChangeSpeed;

	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x28")]
	public float PositionChangeSpeed;

	[Token(Token = "0x40005A2")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 ElevationRanges;

	[Token(Token = "0x40005A3")]
	[FieldOffset(Offset = "0x34")]
	public Vector2 HeightBounds;

	[Token(Token = "0x40005A4")]
	[FieldOffset(Offset = "0x3C")]
	public bool LockYAxis;

	[Token(Token = "0x40005A5")]
	[FieldOffset(Offset = "0x40")]
	public Transform GoalTransform;

	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0x48")]
	public float MaxFollowNumber;

	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0x50")]
	private CBFollow followCam;

	[Token(Token = "0x40005A8")]
	[FieldOffset(Offset = "0x58")]
	private List<Transform> toBeRemoved;

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x1584C94", Offset = "0x1584C94", VA = "0x1584C94")]
	private void Start()
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x1584D70", Offset = "0x1584D70", VA = "0x1584D70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x158566C", Offset = "0x158566C", VA = "0x158566C")]
	public MultiplePlayerCameraFollow()
	{
	}

	[Token(Token = "0x6000578")]
	[Address(RVA = "0x15856A0", Offset = "0x15856A0", VA = "0x15856A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E788", Offset = "0x5E788")]
	private float _003CUpdate_003Eb__12_0(Transform o)
	{
		return default;
	}
}
