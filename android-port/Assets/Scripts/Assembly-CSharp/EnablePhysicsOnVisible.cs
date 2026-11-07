using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009AF")]
public class EnablePhysicsOnVisible : GolfBehaviour
{
	[Token(Token = "0x4003540")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody2D target;

	[Token(Token = "0x4003541")]
	[FieldOffset(Offset = "0x28")]
	public InvisibleCullingObject cullingObject;

	[Token(Token = "0x4003542")]
	[FieldOffset(Offset = "0x30")]
	public bool forceSleep;

	[Token(Token = "0x6002D8A")]
	[Address(RVA = "0x1443604", Offset = "0x1443604", VA = "0x1443604", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002D8B")]
	[Address(RVA = "0x144363C", Offset = "0x144363C", VA = "0x144363C")]
	public void Sleep()
	{
	}

	[Token(Token = "0x6002D8C")]
	[Address(RVA = "0x1443668", Offset = "0x1443668", VA = "0x1443668")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002D8D")]
	[Address(RVA = "0x1443694", Offset = "0x1443694", VA = "0x1443694")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002D8E")]
	[Address(RVA = "0x1443724", Offset = "0x1443724", VA = "0x1443724")]
	public EnablePhysicsOnVisible()
	{
	}
}
