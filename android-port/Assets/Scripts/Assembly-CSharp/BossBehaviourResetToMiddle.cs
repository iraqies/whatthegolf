using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000619")]
public class BossBehaviourResetToMiddle : BossBehaviour
{
	[Token(Token = "0x4001F72")]
	[FieldOffset(Offset = "0x28")]
	public float MiddlePositionX;

	[Token(Token = "0x4001F73")]
	[FieldOffset(Offset = "0x2C")]
	public float Speed;

	[Token(Token = "0x4001F74")]
	[FieldOffset(Offset = "0x30")]
	public float ForwardSpeed;

	[Token(Token = "0x1700030B")]
	public override Vector3 Position
	{
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x16FB51C", Offset = "0x16FB51C", VA = "0x16FB51C", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700030C")]
	public override Quaternion Rotation
	{
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x16FB5EC", Offset = "0x16FB5EC", VA = "0x16FB5EC", Slot = "6")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001BD0")]
	[Address(RVA = "0x16FB790", Offset = "0x16FB790", VA = "0x16FB790")]
	public BossBehaviourResetToMiddle()
	{
	}
}
