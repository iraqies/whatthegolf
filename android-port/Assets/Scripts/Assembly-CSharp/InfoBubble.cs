using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F3C")]
public class InfoBubble : MonoBehaviour
{
	[Token(Token = "0x400523B")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 WobbleAxis;

	[Token(Token = "0x400523C")]
	[FieldOffset(Offset = "0x24")]
	public float WobbleFrequency;

	[Token(Token = "0x400523D")]
	[FieldOffset(Offset = "0x28")]
	public float WobbleAmplitude;

	[Token(Token = "0x400523E")]
	[FieldOffset(Offset = "0x30")]
	public Transform TrackTarget;

	[Token(Token = "0x400523F")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 startOffsetTarget;

	[Token(Token = "0x6004731")]
	[Address(RVA = "0x14ECF54", Offset = "0x14ECF54", VA = "0x14ECF54")]
	private void Start()
	{
	}

	[Token(Token = "0x6004732")]
	[Address(RVA = "0x14ECFC8", Offset = "0x14ECFC8", VA = "0x14ECFC8")]
	private void Update()
	{
	}

	[Token(Token = "0x6004733")]
	[Address(RVA = "0x14ED09C", Offset = "0x14ED09C", VA = "0x14ED09C")]
	public InfoBubble()
	{
	}
}
