using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000618")]
public class BossBehaviourGoToPosition : BossBehaviour
{
	[Token(Token = "0x4001F70")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 EndPosition;

	[Token(Token = "0x4001F71")]
	[FieldOffset(Offset = "0x34")]
	public float Speed;

	[Token(Token = "0x17000309")]
	public override Vector3 Position
	{
		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0x16FB40C", Offset = "0x16FB40C", VA = "0x16FB40C", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700030A")]
	public override Quaternion Rotation
	{
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x16FB494", Offset = "0x16FB494", VA = "0x16FB494", Slot = "6")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001BCD")]
	[Address(RVA = "0x16FB50C", Offset = "0x16FB50C", VA = "0x16FB50C")]
	public BossBehaviourGoToPosition()
	{
	}
}
