using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007BE")]
public class ChampagneBottle : MonoBehaviour
{
	[Token(Token = "0x40028EE")]
	[FieldOffset(Offset = "0x18")]
	public int BurstInterval;

	[Token(Token = "0x40028EF")]
	[FieldOffset(Offset = "0x1C")]
	public float Burstduration;

	[Token(Token = "0x40028F0")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController Controller;

	[Token(Token = "0x40028F1")]
	[FieldOffset(Offset = "0x28")]
	public RandomAudioClips BurstClip;

	[Token(Token = "0x40028F2")]
	[FieldOffset(Offset = "0x30")]
	public AudioEnvelopeSettings FlowEnvelope;

	[Token(Token = "0x40028F3")]
	[FieldOffset(Offset = "0x38")]
	public SimpleEnvelope simpleEnvelope;

	[Token(Token = "0x40028F4")]
	[FieldOffset(Offset = "0x40")]
	public AudioSource FlowSource;

	[Token(Token = "0x40028F5")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem particles;

	[Token(Token = "0x40028F6")]
	[FieldOffset(Offset = "0x50")]
	private ConstantForce force;

	[Token(Token = "0x40028F7")]
	[FieldOffset(Offset = "0x58")]
	private int strokeCounter;

	[Token(Token = "0x40028F8")]
	[FieldOffset(Offset = "0x5C")]
	private bool hasBurst;

	[Token(Token = "0x40028F9")]
	[FieldOffset(Offset = "0x60")]
	private float burstTimer;

	[Token(Token = "0x6002370")]
	[Address(RVA = "0x18959F4", Offset = "0x18959F4", VA = "0x18959F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002371")]
	[Address(RVA = "0x1895B6C", Offset = "0x1895B6C", VA = "0x1895B6C")]
	private void ControllerOnOnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x6002372")]
	[Address(RVA = "0x1895D78", Offset = "0x1895D78", VA = "0x1895D78")]
	private void Update()
	{
	}

	[Token(Token = "0x6002373")]
	[Address(RVA = "0x1895EC8", Offset = "0x1895EC8", VA = "0x1895EC8")]
	public ChampagneBottle()
	{
	}
}
