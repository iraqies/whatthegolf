using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000064")]
public class CameraPreRenderHook : MonoBehaviour
{
	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x18")]
	public UnityAction onPrerender;

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1884294", Offset = "0x1884294", VA = "0x1884294")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x18842A8", Offset = "0x18842A8", VA = "0x18842A8")]
	public CameraPreRenderHook()
	{
	}
}
