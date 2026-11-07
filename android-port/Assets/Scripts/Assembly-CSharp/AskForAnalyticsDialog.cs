using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using UnityEngine.Events;

[Token(Token = "0x2000C7F")]
public class AskForAnalyticsDialog : AddressableSingleton<AskForAnalyticsDialog>
{
	[Token(Token = "0x4004464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UnityAction<bool> _onDone;

	[Token(Token = "0x6003B40")]
	[Address(RVA = "0x142A000", Offset = "0x142A000", VA = "0x142A000")]
	public void AskForAnalytics(UnityAction<bool> onDone, [Optional] UnityAction onCancel)
	{
	}

	[Token(Token = "0x6003B41")]
	[Address(RVA = "0x142A204", Offset = "0x142A204", VA = "0x142A204")]
	[Attribute(Name = "ContextMenu", RVA = "0x6B6E4", Offset = "0x6B6E4")]
	private void DebugShow()
	{
	}

	[Token(Token = "0x6003B42")]
	[Address(RVA = "0x142A0A0", Offset = "0x142A0A0", VA = "0x142A0A0")]
	private void ShowDialog(UnityAction<bool> onDone)
	{
	}

	[Token(Token = "0x6003B43")]
	[Address(RVA = "0x142A20C", Offset = "0x142A20C", VA = "0x142A20C")]
	private void Agree()
	{
	}

	[Token(Token = "0x6003B44")]
	[Address(RVA = "0x142A2F4", Offset = "0x142A2F4", VA = "0x142A2F4")]
	private void Disagree()
	{
	}

	[Token(Token = "0x6003B45")]
	[Address(RVA = "0x142A284", Offset = "0x142A284", VA = "0x142A284")]
	private void Closing(bool result)
	{
	}

	[Token(Token = "0x6003B46")]
	[Address(RVA = "0x142A364", Offset = "0x142A364", VA = "0x142A364")]
	public AskForAnalyticsDialog()
	{
	}
}
