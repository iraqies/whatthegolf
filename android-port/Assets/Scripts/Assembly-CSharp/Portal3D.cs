using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002E3")]
public class Portal3D : MonoBehaviour
{
	[Token(Token = "0x4000FD8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Portal3D ConnectedPortal;

	[Token(Token = "0x4000FD9")]
	[FieldOffset(Offset = "0x20")]
	public Animation PortalAnimation;

	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0x28")]
	private bool used;

	[Token(Token = "0x4000FDB")]
	[FieldOffset(Offset = "0x2C")]
	private readonly float cooldown;

	[Token(Token = "0x4000FDC")]
	[FieldOffset(Offset = "0x30")]
	private float cooldownTimer;

	[Token(Token = "0x6000D45")]
	[Address(RVA = "0x161B4B8", Offset = "0x161B4B8", VA = "0x161B4B8")]
	private void OnTriggerEnter(Collider collision)
	{
	}

	[Token(Token = "0x6000D46")]
	[Address(RVA = "0x161B5E8", Offset = "0x161B5E8", VA = "0x161B5E8")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000D47")]
	[Address(RVA = "0x161B5F8", Offset = "0x161B5F8", VA = "0x161B5F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000D48")]
	[Address(RVA = "0x161B650", Offset = "0x161B650", VA = "0x161B650")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000D49")]
	[Address(RVA = "0x161B6D8", Offset = "0x161B6D8", VA = "0x161B6D8")]
	public Portal3D()
	{
	}
}
