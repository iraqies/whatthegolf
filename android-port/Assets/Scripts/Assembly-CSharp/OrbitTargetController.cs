using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000746")]
public class OrbitTargetController : MonoBehaviour
{
	[Token(Token = "0x400267A")]
	[FieldOffset(Offset = "0x18")]
	public OrbitTargetAreaPair[] areas;

	[Token(Token = "0x400267B")]
	[FieldOffset(Offset = "0x20")]
	public Transform cameraOrbitTarget;

	[Token(Token = "0x400267C")]
	[FieldOffset(Offset = "0x28")]
	public float velocity;

	[Token(Token = "0x400267D")]
	[FieldOffset(Offset = "0x30")]
	private OrbitTargetAreaPair current;

	[Token(Token = "0x6002184")]
	[Address(RVA = "0x159D5C0", Offset = "0x159D5C0", VA = "0x159D5C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002185")]
	[Address(RVA = "0x159D6E0", Offset = "0x159D6E0", VA = "0x159D6E0")]
	public void CheckAreaChange(Collider other)
	{
	}

	[Token(Token = "0x6002186")]
	[Address(RVA = "0x159D7CC", Offset = "0x159D7CC", VA = "0x159D7CC")]
	public OrbitTargetController()
	{
	}
}
