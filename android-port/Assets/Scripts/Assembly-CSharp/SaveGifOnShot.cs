using Core;
using Il2CppDummyDll;

[Token(Token = "0x2000BF6")]
public class SaveGifOnShot : BaseSaveGif
{
	[Token(Token = "0x400424A")]
	[FieldOffset(Offset = "0x34")]
	[Attribute(Name = "MinAttribute", RVA = "0x50E88", Offset = "0x50E88")]
	public int RecordOnShotNumber;

	[Token(Token = "0x400424B")]
	[FieldOffset(Offset = "0x38")]
	private bool hasSaved;

	[Token(Token = "0x600396B")]
	[Address(RVA = "0x16764D0", Offset = "0x16764D0", VA = "0x16764D0", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600396C")]
	[Address(RVA = "0x16765A0", Offset = "0x16765A0", VA = "0x16765A0")]
	private void InstanceOnOnGolfStroke(GolfBallController controller, int strokes)
	{
	}

	[Token(Token = "0x600396D")]
	[Address(RVA = "0x16765E0", Offset = "0x16765E0", VA = "0x16765E0")]
	public SaveGifOnShot()
	{
	}
}
