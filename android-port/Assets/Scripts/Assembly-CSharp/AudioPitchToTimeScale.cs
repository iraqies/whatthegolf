using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000388")]
[Attribute(Name = "RequireComponent", RVA = "0x3F554", Offset = "0x3F554")]
public class AudioPitchToTimeScale : MonoBehaviour
{
	[Token(Token = "0x4001360")]
	[FieldOffset(Offset = "0x18")]
	public GlobalClock clock;

	[Token(Token = "0x4001361")]
	[FieldOffset(Offset = "0x20")]
	public float amount;

	[Token(Token = "0x4001362")]
	[FieldOffset(Offset = "0x28")]
	private AudioSource audioSrc;

	[Token(Token = "0x4001363")]
	[FieldOffset(Offset = "0x30")]
	public float basePitch;

	[Token(Token = "0x4001364")]
	[FieldOffset(Offset = "0x34")]
	private bool didSetBasePitch;

	[Token(Token = "0x170001FC")]
	private float timeScale
	{
		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x150B4D8", Offset = "0x150B4D8", VA = "0x150B4D8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x150B580", Offset = "0x150B580", VA = "0x150B580")]
	private void Awake()
	{
	}

	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x150B5DC", Offset = "0x150B5DC", VA = "0x150B5DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x150B680", Offset = "0x150B680", VA = "0x150B680")]
	public AudioPitchToTimeScale()
	{
	}
}
