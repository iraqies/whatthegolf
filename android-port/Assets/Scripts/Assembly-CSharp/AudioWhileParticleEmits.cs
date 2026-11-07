using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002D3")]
public class AudioWhileParticleEmits : MonoBehaviour
{
	[Token(Token = "0x4000F6F")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem particles;

	[Token(Token = "0x4000F70")]
	[FieldOffset(Offset = "0x20")]
	public float maxVol;

	[Token(Token = "0x4000F71")]
	[FieldOffset(Offset = "0x24")]
	public float minVol;

	[Token(Token = "0x4000F72")]
	[FieldOffset(Offset = "0x28")]
	public float smoothTime;

	[Token(Token = "0x4000F73")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource source;

	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x1513A30", Offset = "0x1513A30", VA = "0x1513A30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x1513A34", Offset = "0x1513A34", VA = "0x1513A34")]
	private void Update()
	{
	}

	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0x1513AF0", Offset = "0x1513AF0", VA = "0x1513AF0")]
	public AudioWhileParticleEmits()
	{
	}
}
