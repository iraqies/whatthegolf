using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000017")]
[ExecuteInEditMode]
public class PostProcessExample : MonoBehaviour
{
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x18")]
	public Material PostProcessMat;

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x161DD80", Offset = "0x161DD80", VA = "0x161DD80")]
	private void Awake()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x161DE44", Offset = "0x161DE44", VA = "0x161DE44")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x161DED0", Offset = "0x161DED0", VA = "0x161DED0")]
	public PostProcessExample()
	{
	}
}
