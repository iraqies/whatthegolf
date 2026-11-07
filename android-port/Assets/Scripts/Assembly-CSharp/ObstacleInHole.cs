using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002E1")]
public class ObstacleInHole : MonoBehaviour
{
	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody rigid;

	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ConfigurableJoint joint;

	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float force;

	[Token(Token = "0x6000D40")]
	[Address(RVA = "0x159485C", Offset = "0x159485C", VA = "0x159485C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000D41")]
	[Address(RVA = "0x159495C", Offset = "0x159495C", VA = "0x159495C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000D42")]
	[Address(RVA = "0x1594A60", Offset = "0x1594A60", VA = "0x1594A60")]
	public ObstacleInHole()
	{
	}
}
