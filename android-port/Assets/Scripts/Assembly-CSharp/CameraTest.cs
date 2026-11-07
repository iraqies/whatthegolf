using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000366")]
public class CameraTest : MonoBehaviour
{
	[Token(Token = "0x40012AD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform testPoint;

	[Token(Token = "0x40012AE")]
	[FieldOffset(Offset = "0x20")]
	private Plane[] planes;

	[Token(Token = "0x40012AF")]
	[FieldOffset(Offset = "0x28")]
	private Camera camera;

	[Token(Token = "0x40012B0")]
	[FieldOffset(Offset = "0x30")]
	private bool[] inside;

	[Token(Token = "0x6000FBD")]
	[Address(RVA = "0x1884CC4", Offset = "0x1884CC4", VA = "0x1884CC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0x1884D70", Offset = "0x1884D70", VA = "0x1884D70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000FBF")]
	[Address(RVA = "0x1885388", Offset = "0x1885388", VA = "0x1885388")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000FC0")]
	[Address(RVA = "0x18856F8", Offset = "0x18856F8", VA = "0x18856F8")]
	public CameraTest()
	{
	}
}
