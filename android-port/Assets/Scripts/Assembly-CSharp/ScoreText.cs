using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005E7")]
public class ScoreText : MonoBehaviour
{
	[Token(Token = "0x4001E1E")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve scaleCurve;

	[Token(Token = "0x4001E1F")]
	[FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x4001E20")]
	[FieldOffset(Offset = "0x24")]
	public float randomOffsetRange;

	[Token(Token = "0x4001E21")]
	[FieldOffset(Offset = "0x28")]
	public Transform target;

	[Token(Token = "0x4001E22")]
	[FieldOffset(Offset = "0x30")]
	private float startTime;

	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x167CA28", Offset = "0x167CA28", VA = "0x167CA28")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AE3")]
	[Address(RVA = "0x167CAC0", Offset = "0x167CAC0", VA = "0x167CAC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001AE4")]
	[Address(RVA = "0x167CB8C", Offset = "0x167CB8C", VA = "0x167CB8C")]
	public ScoreText()
	{
	}
}
