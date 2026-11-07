using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BB8")]
public class AudioOnlyWhenGrounded : MonoBehaviour
{
	[Token(Token = "0x4004142")]
	[FieldOffset(Offset = "0x18")]
	public bool use2D;

	[Token(Token = "0x4004143")]
	[FieldOffset(Offset = "0x1C")]
	public float minVolume;

	[Token(Token = "0x4004144")]
	[FieldOffset(Offset = "0x20")]
	public float maxVolume;

	[Token(Token = "0x4004145")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask layer;

	[Token(Token = "0x4004146")]
	[FieldOffset(Offset = "0x28")]
	public float distanceToGroundThreshold;

	[Token(Token = "0x4004147")]
	[FieldOffset(Offset = "0x30")]
	private AudioSource audioSource;

	[Token(Token = "0x6003879")]
	[Address(RVA = "0x150ACBC", Offset = "0x150ACBC", VA = "0x150ACBC")]
	private void Start()
	{
	}

	[Token(Token = "0x600387A")]
	[Address(RVA = "0x150AD18", Offset = "0x150AD18", VA = "0x150AD18")]
	private void Update()
	{
	}

	[Token(Token = "0x600387B")]
	[Address(RVA = "0x150AD2C", Offset = "0x150AD2C", VA = "0x150AD2C")]
	private void Check2DGround()
	{
	}

	[Token(Token = "0x600387C")]
	[Address(RVA = "0x150AEE8", Offset = "0x150AEE8", VA = "0x150AEE8")]
	private void Check3DGround()
	{
	}

	[Token(Token = "0x600387D")]
	[Address(RVA = "0x150B000", Offset = "0x150B000", VA = "0x150B000")]
	private void SetVolume(bool shouldPlay)
	{
	}

	[Token(Token = "0x600387E")]
	[Address(RVA = "0x150B078", Offset = "0x150B078", VA = "0x150B078")]
	public AudioOnlyWhenGrounded()
	{
	}
}
