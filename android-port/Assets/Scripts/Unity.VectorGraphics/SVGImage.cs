using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000002")]
public class SVGImage : MaskableGraphic
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Sprite m_Sprite;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private bool m_PreserveAspect;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x0")]
	private static NativeSlice<Color32> s_SpriteColor;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x10")]
	private static NativeSlice<Vector2> s_TextCord2;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	private static UIVertex s_TempVertex;

	[Token(Token = "0x17000001")]
	public bool preserveAspect
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2AFB090", Offset = "0x2AFB090", VA = "0x2AFB090")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2AFB098", Offset = "0x2AFB098", VA = "0x2AFB098")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Sprite sprite
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2AFB0BC", Offset = "0x2AFB0BC", VA = "0x2AFB0BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2AFB0C4", Offset = "0x2AFB0C4", VA = "0x2AFB0C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public override Texture mainTexture
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2AFB170", Offset = "0x2AFB170", VA = "0x2AFB170", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2AFB358", Offset = "0x2AFB358", VA = "0x2AFB358", Slot = "43")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2AFB404", Offset = "0x2AFB404", VA = "0x2AFB404")]
	private void GenerateSprite(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2AFBA28", Offset = "0x2AFBA28", VA = "0x2AFBA28")]
	private Vector2 GetDrawingDimensions(bool shouldPreserveAspect)
	{
		return default;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2AFBB74", Offset = "0x2AFBB74", VA = "0x2AFBB74")]
	public SVGImage()
	{
	}
}
