using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200003F")]
public class CameraSnowTrail : MonoBehaviour
{
	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x18")]
	public Material Mat;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x20")]
	private Camera cam;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture tex;

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1884818", Offset = "0x1884818", VA = "0x1884818")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1884924", Offset = "0x1884924", VA = "0x1884924")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x18849B4", Offset = "0x18849B4", VA = "0x18849B4")]
	public CameraSnowTrail()
	{
	}
}
