using Il2CppDummyDll;
using Kilt.EasyRopes2D;

[Token(Token = "0x20003C2")]
public class SetRTPCOnRopeCut : BaseRTPCSetter
{
	[Token(Token = "0x40014AE")]
	[FieldOffset(Offset = "0x28")]
	public Rope2D rope;

	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x168EF50", Offset = "0x168EF50", VA = "0x168EF50")]
	private void Awake()
	{
	}

	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x168F034", Offset = "0x168F034", VA = "0x168F034")]
	private void Rope_OnRopeCut(Rope2D arg1, int arg2)
	{
	}

	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x168F03C", Offset = "0x168F03C", VA = "0x168F03C")]
	public SetRTPCOnRopeCut()
	{
	}
}
