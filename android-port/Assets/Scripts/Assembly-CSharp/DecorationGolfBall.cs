using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000707")]
public class DecorationGolfBall : MonoBehaviour
{
	[Token(Token = "0x40024EF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<AudioClip> clips;

	[Token(Token = "0x40024F0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float baseVolume;

	[Token(Token = "0x40024F1")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float volumeDeviance;

	[Token(Token = "0x40024F2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float basePitch;

	[Token(Token = "0x40024F3")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float pitchDeviance;

	[Token(Token = "0x40024F4")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float force;

	[Token(Token = "0x40024F5")]
	[FieldOffset(Offset = "0x34")]
	public bool useLocalY;

	[Token(Token = "0x40024F6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector2 upwardsForceRange;

	[Token(Token = "0x40024F7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<string> otherTags;

	[Token(Token = "0x40024F8")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LayerMask otherLayers;

	[Token(Token = "0x40024F9")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float minForce;

	[Token(Token = "0x40024FA")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4E7BC", Offset = "0x4E7BC")]
	[SerializeField]
	private float useImpactVelocity;

	[Token(Token = "0x40024FB")]
	[FieldOffset(Offset = "0x58")]
	private Rigidbody rigid;

	[Token(Token = "0x40024FC")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody2D rigid2D;

	[Token(Token = "0x40024FD")]
	[FieldOffset(Offset = "0x68")]
	private float nextPush;

	[Token(Token = "0x600206F")]
	[Address(RVA = "0x18D7818", Offset = "0x18D7818", VA = "0x18D7818")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002070")]
	[Address(RVA = "0x18D7898", Offset = "0x18D7898", VA = "0x18D7898")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002071")]
	[Address(RVA = "0x18D7E10", Offset = "0x18D7E10", VA = "0x18D7E10")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x6002072")]
	[Address(RVA = "0x18D7B50", Offset = "0x18D7B50", VA = "0x18D7B50")]
	private void TryKick(Vector3 magnitude, Vector3 point, Vector3 normal)
	{
	}

	[Token(Token = "0x6002073")]
	[Address(RVA = "0x18D80A4", Offset = "0x18D80A4", VA = "0x18D80A4")]
	private void PlaySfx()
	{
	}

	[Token(Token = "0x6002074")]
	[Address(RVA = "0x18D8174", Offset = "0x18D8174", VA = "0x18D8174")]
	public DecorationGolfBall()
	{
	}

	[Token(Token = "0x6002075")]
	[Address(RVA = "0x18D81B4", Offset = "0x18D81B4", VA = "0x18D81B4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65930", Offset = "0x65930")]
	private void _003CPlaySfx_003Eb__19_0(AudioSource s)
	{
	}
}
