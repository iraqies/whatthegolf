using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E80")]
public class DynaicTargetSoccerdog : MonoBehaviour
{
	[Token(Token = "0x4004E62")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SoccerPlayer soccerplayer;

	[Token(Token = "0x4004E63")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TennisCannon tennisCannon;

	[Token(Token = "0x60043C4")]
	[Address(RVA = "0x143935C", Offset = "0x143935C", VA = "0x143935C")]
	private void Start()
	{
	}

	[Token(Token = "0x60043C5")]
	[Address(RVA = "0x1439440", Offset = "0x1439440", VA = "0x1439440")]
	public void SetTarget(Rigidbody t)
	{
	}

	[Token(Token = "0x60043C6")]
	[Address(RVA = "0x143945C", Offset = "0x143945C", VA = "0x143945C")]
	public DynaicTargetSoccerdog()
	{
	}
}
