using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E73")]
public class CatLaserFollowAddon : MonoBehaviour
{
	[Token(Token = "0x4004E2E")]
	[FieldOffset(Offset = "0x18")]
	public Transform rayTransform;

	[Token(Token = "0x4004E2F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject laserGO;

	[Token(Token = "0x4004E30")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ballGO;

	[Token(Token = "0x4004E31")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody catRb;

	[Token(Token = "0x4004E32")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 lastBallPos;

	[Token(Token = "0x4004E33")]
	[FieldOffset(Offset = "0x44")]
	private float laserDefaultY;

	[Token(Token = "0x4004E34")]
	[FieldOffset(Offset = "0x48")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x600438C")]
	[Address(RVA = "0x1890B88", Offset = "0x1890B88", VA = "0x1890B88")]
	private void Start()
	{
	}

	[Token(Token = "0x600438D")]
	[Address(RVA = "0x1890BF8", Offset = "0x1890BF8", VA = "0x1890BF8")]
	private void Update()
	{
	}

	[Token(Token = "0x600438E")]
	[Address(RVA = "0x1890F6C", Offset = "0x1890F6C", VA = "0x1890F6C")]
	public CatLaserFollowAddon()
	{
	}
}
