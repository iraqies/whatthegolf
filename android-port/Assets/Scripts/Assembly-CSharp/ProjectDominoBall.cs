using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006D5")]
public class ProjectDominoBall : MonoBehaviour
{
	[Token(Token = "0x40023CC")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	[Token(Token = "0x40023CD")]
	[FieldOffset(Offset = "0x20")]
	private Collider col;

	[Token(Token = "0x40023CE")]
	[FieldOffset(Offset = "0x28")]
	public Transform destination;

	[Token(Token = "0x40023CF")]
	[FieldOffset(Offset = "0x30")]
	private bool slung;

	[Token(Token = "0x6001F8C")]
	[Address(RVA = "0x16275D8", Offset = "0x16275D8", VA = "0x16275D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001F8D")]
	[Address(RVA = "0x1627658", Offset = "0x1627658", VA = "0x1627658")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0x16277E4", Offset = "0x16277E4", VA = "0x16277E4")]
	private Vector3 CalculateTrajectoryVelocity(Vector3 origin, Vector3 target)
	{
		return default;
	}

	[Token(Token = "0x6001F8F")]
	[Address(RVA = "0x1627894", Offset = "0x1627894", VA = "0x1627894")]
	public ProjectDominoBall()
	{
	}
}
