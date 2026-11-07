using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20003A9")]
public class ODRDownloadView : MonoBehaviour
{
	[Token(Token = "0x4001442")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button cancelButton;

	[Token(Token = "0x4001443")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image progressBar;

	[Token(Token = "0x4001444")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimateRectTransform animator;

	[Token(Token = "0x4001445")]
	[FieldOffset(Offset = "0x30")]
	private Action onCancel;

	[Token(Token = "0x600115E")]
	[Address(RVA = "0x159113C", Offset = "0x159113C", VA = "0x159113C")]
	public void Show(Action onCancel)
	{
	}

	[Token(Token = "0x600115F")]
	[Address(RVA = "0x15911F0", Offset = "0x15911F0", VA = "0x15911F0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6001160")]
	[Address(RVA = "0x1591210", Offset = "0x1591210", VA = "0x1591210")]
	public void UpdateProgress(float progress)
	{
	}

	[Token(Token = "0x6001161")]
	[Address(RVA = "0x159122C", Offset = "0x159122C", VA = "0x159122C")]
	public void OnCancelClicked()
	{
	}

	[Token(Token = "0x6001162")]
	[Address(RVA = "0x1591240", Offset = "0x1591240", VA = "0x1591240")]
	public ODRDownloadView()
	{
	}
}
