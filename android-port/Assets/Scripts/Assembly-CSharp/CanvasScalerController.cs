using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20008DD")]
[Attribute(Name = "RequireComponent", RVA = "0x41D50", Offset = "0x41D50")]
public class CanvasScalerController : MonoBehaviour
{
	[Token(Token = "0x400307B")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 landscapeReferenceResolution;

	[Token(Token = "0x400307C")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 portraitReferenceResolution;

	[Token(Token = "0x400307D")]
	[FieldOffset(Offset = "0x28")]
	private CanvasScaler canvasScaler;

	[Token(Token = "0x60028FF")]
	[Address(RVA = "0x1886EE4", Offset = "0x1886EE4", VA = "0x1886EE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002900")]
	[Address(RVA = "0x1886F44", Offset = "0x1886F44", VA = "0x1886F44")]
	private void UpdateScalerReferenceResolution()
	{
	}

	[Token(Token = "0x6002901")]
	[Address(RVA = "0x1886FF8", Offset = "0x1886FF8", VA = "0x1886FF8")]
	public CanvasScalerController()
	{
	}
}
