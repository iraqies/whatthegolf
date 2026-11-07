using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

[Token(Token = "0x200020F")]
public class DoubleThrowPuppet : MonoBehaviour
{
	[Token(Token = "0x4000A31")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FakeGolferRoot;

	[Token(Token = "0x4000A33")]
	[FieldOffset(Offset = "0x28")]
	public List<FixedJoint> JointsToDestroy;

	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x30")]
	public float ThrowSpeed;

	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x38")]
	public ThrownPuppet ThrownPuppet;

	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x40")]
	public Animator CameraAnimator;

	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x48")]
	public HammerThrowingCamera Camera;

	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody[] rigidbodiesToThrow;

	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x58")]
	private PuppetMaster puppet;

	[Token(Token = "0x6000936")]
	[Address(RVA = "0x1434064", Offset = "0x1434064", VA = "0x1434064")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000937")]
	[Address(RVA = "0x1434168", Offset = "0x1434168", VA = "0x1434168")]
	private void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000938")]
	[Address(RVA = "0x1434390", Offset = "0x1434390", VA = "0x1434390")]
	public void DollHasGottenUp()
	{
	}

	[Token(Token = "0x6000939")]
	[Address(RVA = "0x14343D0", Offset = "0x14343D0", VA = "0x14343D0")]
	public DoubleThrowPuppet()
	{
	}
}
