using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x2000521")]
[Attribute(Name = "RequireComponent", RVA = "0x401FC", Offset = "0x401FC")]
public class RenderOpaqueTexture : MonoBehaviour
{
	[Token(Token = "0x4001A70")]
	[FieldOffset(Offset = "0x18")]
	private Camera m_Camera;

	[Token(Token = "0x4001A71")]
	[FieldOffset(Offset = "0x20")]
	private CommandBuffer m_CommandBuffer;

	[Token(Token = "0x17000296")]
	public Camera camera
	{
		[Token(Token = "0x600176D")]
		[Address(RVA = "0x16489B4", Offset = "0x16489B4", VA = "0x16489B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600176E")]
	[Address(RVA = "0x1648A60", Offset = "0x1648A60", VA = "0x1648A60")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600176F")]
	[Address(RVA = "0x1648BF8", Offset = "0x1648BF8", VA = "0x1648BF8")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6001770")]
	[Address(RVA = "0x1648C2C", Offset = "0x1648C2C", VA = "0x1648C2C")]
	public RenderOpaqueTexture()
	{
	}
}
