using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BEC")]
public class FollowDelayed : MonoBehaviour
{
	[Token(Token = "0x400420D")]
	[FieldOffset(Offset = "0x18")]
	public Transform follow;

	[Token(Token = "0x400420E")]
	[FieldOffset(Offset = "0x20")]
	public bool moveOtherTransform;

	[Token(Token = "0x400420F")]
	[FieldOffset(Offset = "0x28")]
	public Transform move;

	[Token(Token = "0x4004210")]
	[FieldOffset(Offset = "0x30")]
	public float delay;

	[Token(Token = "0x4004211")]
	[FieldOffset(Offset = "0x34")]
	private int maxSamples;

	[Token(Token = "0x4004212")]
	[FieldOffset(Offset = "0x38")]
	private Transform moveTransform;

	[Token(Token = "0x4004213")]
	[FieldOffset(Offset = "0x40")]
	private float m_lastSampleTime;

	[Token(Token = "0x4004214")]
	[FieldOffset(Offset = "0x44")]
	private float sampleDelay;

	[Token(Token = "0x4004215")]
	[FieldOffset(Offset = "0x48")]
	private Queue<Vector3> positions;

	[Token(Token = "0x6003926")]
	[Address(RVA = "0x146F4B0", Offset = "0x146F4B0", VA = "0x146F4B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003927")]
	[Address(RVA = "0x146F58C", Offset = "0x146F58C", VA = "0x146F58C")]
	private void CalculateMaxSamples()
	{
	}

	[Token(Token = "0x6003928")]
	[Address(RVA = "0x146F5C0", Offset = "0x146F5C0", VA = "0x146F5C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6003929")]
	[Address(RVA = "0x146F76C", Offset = "0x146F76C", VA = "0x146F76C")]
	public FollowDelayed()
	{
	}
}
