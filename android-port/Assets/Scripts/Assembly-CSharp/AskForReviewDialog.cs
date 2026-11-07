using Core;
using Il2CppDummyDll;
using UnityEngine.Events;

[Token(Token = "0x2000C80")]
public class AskForReviewDialog : AddressableSingleton<AskForReviewDialog>
{
	[Token(Token = "0x4004465")]
	[FieldOffset(Offset = "0x0")]
	public static AskForReviewDialog s_instance;

	[Token(Token = "0x4004466")]
	private const string REVIEW_LINK = "itms-apps://itunes.apple.com/app/id1415190483?action=write-review";

	[Token(Token = "0x4004467")]
	[FieldOffset(Offset = "0x18")]
	private UnityAction<bool> _onDone;

	[Token(Token = "0x6003B47")]
	[Address(RVA = "0x142A3BC", Offset = "0x142A3BC", VA = "0x142A3BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003B48")]
	[Address(RVA = "0x142A4E0", Offset = "0x142A4E0", VA = "0x142A4E0")]
	public void AskForReview(UnityAction<bool> onDone)
	{
	}

	[Token(Token = "0x6003B49")]
	[Address(RVA = "0x142A594", Offset = "0x142A594", VA = "0x142A594")]
	[Attribute(Name = "ContextMenu", RVA = "0x6B71C", Offset = "0x6B71C")]
	private void DebugShow()
	{
	}

	[Token(Token = "0x6003B4A")]
	[Address(RVA = "0x142A58C", Offset = "0x142A58C", VA = "0x142A58C")]
	private void AskForReviewInternal(UnityAction<bool> onDone)
	{
	}

	[Token(Token = "0x6003B4B")]
	[Address(RVA = "0x142A59C", Offset = "0x142A59C", VA = "0x142A59C")]
	private void Show()
	{
	}

	[Token(Token = "0x6003B4C")]
	[Address(RVA = "0x142A6F4", Offset = "0x142A6F4", VA = "0x142A6F4")]
	private void RedirectToReview()
	{
	}

	[Token(Token = "0x6003B4D")]
	[Address(RVA = "0x142A86C", Offset = "0x142A86C", VA = "0x142A86C")]
	public void Close(bool positiveAnswer)
	{
	}

	[Token(Token = "0x6003B4E")]
	[Address(RVA = "0x142A754", Offset = "0x142A754", VA = "0x142A754")]
	private void Closing(bool accepted)
	{
	}

	[Token(Token = "0x6003B4F")]
	[Address(RVA = "0x142A920", Offset = "0x142A920", VA = "0x142A920")]
	public AskForReviewDialog()
	{
	}

	[Token(Token = "0x6003B50")]
	[Address(RVA = "0x142A978", Offset = "0x142A978", VA = "0x142A978")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B754", Offset = "0x6B754")]
	private void _003CShow_003Eb__7_0()
	{
	}

	[Token(Token = "0x6003B51")]
	[Address(RVA = "0x142A9E4", Offset = "0x142A9E4", VA = "0x142A9E4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B764", Offset = "0x6B764")]
	private void _003CShow_003Eb__7_1()
	{
	}
}
