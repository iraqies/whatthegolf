using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005C5")]
public class GifObjectOverEdge : MonoBehaviour
{
	[Token(Token = "0x4001D80")]
	[FieldOffset(Offset = "0x18")]
	public OutOfBoundsTrigger target;

	[Token(Token = "0x4001D81")]
	[FieldOffset(Offset = "0x20")]
	private GifMomentTrigger moment;

	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x1488A3C", Offset = "0x1488A3C", VA = "0x1488A3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001A44")]
	[Address(RVA = "0x1488B14", Offset = "0x1488B14", VA = "0x1488B14")]
	private void Target_OnOutOfBounds(OutOfBoundsTrigger obj)
	{
	}

	[Token(Token = "0x6001A45")]
	[Address(RVA = "0x1488B2C", Offset = "0x1488B2C", VA = "0x1488B2C")]
	public GifObjectOverEdge()
	{
	}
}
