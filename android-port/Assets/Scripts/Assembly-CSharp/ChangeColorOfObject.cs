using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E0E")]
public class ChangeColorOfObject : MonoBehaviour
{
	[Token(Token = "0x4004C6A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Renderer m_rendererToChange;

	[Token(Token = "0x4004C6B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color m_activeColor;

	[Token(Token = "0x4004C6C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Color m_inactiveColor;

	[Token(Token = "0x6004213")]
	[Address(RVA = "0x18966C0", Offset = "0x18966C0", VA = "0x18966C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6004214")]
	[Address(RVA = "0x189673C", Offset = "0x189673C", VA = "0x189673C")]
	public void SetActiveColor()
	{
	}

	[Token(Token = "0x6004215")]
	[Address(RVA = "0x18967A8", Offset = "0x18967A8", VA = "0x18967A8")]
	public void SetInactiveColor()
	{
	}

	[Token(Token = "0x6004216")]
	[Address(RVA = "0x1896814", Offset = "0x1896814", VA = "0x1896814")]
	public ChangeColorOfObject()
	{
	}
}
