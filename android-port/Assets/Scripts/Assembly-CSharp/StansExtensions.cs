using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x200053B")]
public static class StansExtensions
{
	[Token(Token = "0x60017DA")]
	[Address(RVA = "0x16DB200", Offset = "0x16DB200", VA = "0x16DB200")]
	public static void SetLayerRecursively(this GameObject go, int layerNumber)
	{
	}

	[Token(Token = "0x60017DB")]
	public static T GetComponentInScene<T>(this Scene scene)
	{
		return (T)null;
	}

	[Token(Token = "0x60017DC")]
	[Address(RVA = "0x16DB2CC", Offset = "0x16DB2CC", VA = "0x16DB2CC")]
	public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
	{
		return default;
	}

	[Token(Token = "0x60017DD")]
	[Address(RVA = "0x16DB328", Offset = "0x16DB328", VA = "0x16DB328")]
	public static byte[] ToBytesUTF8(this string source)
	{
		return null;
	}
}
