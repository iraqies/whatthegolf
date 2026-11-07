using Audio;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A71")]
public class TunnelToOverworld : MonoBehaviour
{
	[Token(Token = "0x40039CC")]
	[FieldOffset(Offset = "0x18")]
	public CBFollow followCamera;

	[Token(Token = "0x40039CD")]
	[FieldOffset(Offset = "0x20")]
	public GolfGoal goal;

	[Token(Token = "0x40039CE")]
	[FieldOffset(Offset = "0x28")]
	public AudioSource piperollSource;

	[Token(Token = "0x40039CF")]
	[FieldOffset(Offset = "0x30")]
	public AudioClip sfxOnEnteringTunnel;

	[Token(Token = "0x40039D0")]
	[FieldOffset(Offset = "0x38")]
	public AudioClipSettings catSfxOnEnter;

	[Token(Token = "0x40039D1")]
	[FieldOffset(Offset = "0x40")]
	public FollowTransform BallFollower;

	[Token(Token = "0x40039D2")]
	[FieldOffset(Offset = "0x48")]
	private bool didActivate;

	[Token(Token = "0x40039D3")]
	[FieldOffset(Offset = "0x49")]
	private bool isStaticFollow;

	[Token(Token = "0x40039D4")]
	[FieldOffset(Offset = "0x4A")]
	private bool didWin;

	[Token(Token = "0x40039D5")]
	[FieldOffset(Offset = "0x4C")]
	public Vector3 offset;

	[Token(Token = "0x40039D6")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 currentOffset;

	[Token(Token = "0x40039D7")]
	[FieldOffset(Offset = "0x68")]
	private Transform ballTransform;

	[Token(Token = "0x40039D8")]
	[FieldOffset(Offset = "0x70")]
	private float timeSinceStatic;

	[Token(Token = "0x60031CE")]
	[Address(RVA = "0x1730344", Offset = "0x1730344", VA = "0x1730344")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60031CF")]
	[Address(RVA = "0x1730580", Offset = "0x1730580", VA = "0x1730580")]
	private void Update()
	{
	}

	[Token(Token = "0x60031D0")]
	[Address(RVA = "0x173060C", Offset = "0x173060C", VA = "0x173060C")]
	public TunnelToOverworld()
	{
	}

	[Token(Token = "0x60031D1")]
	[Address(RVA = "0x1730614", Offset = "0x1730614", VA = "0x1730614")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x69B54", Offset = "0x69B54")]
	private void _003COnTriggerEnter_003Eb__13_0(float t2)
	{
	}
}
