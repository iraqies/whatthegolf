using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000681")]
public class PushBoat : MonoBehaviour
{
	[Token(Token = "0x40021C9")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 PushForce;

	[Token(Token = "0x40021CA")]
	[FieldOffset(Offset = "0x28")]
	public SHMUPController Boat;

	[Token(Token = "0x40021CB")]
	[FieldOffset(Offset = "0x30")]
	public SHMUPFrogKing Frog;

	[Token(Token = "0x40021CC")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigid;

	[Token(Token = "0x40021CD")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 basePos;

	[Token(Token = "0x6001DC7")]
	[Address(RVA = "0x162D538", Offset = "0x162D538", VA = "0x162D538")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001DC8")]
	[Address(RVA = "0x162D5B8", Offset = "0x162D5B8", VA = "0x162D5B8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001DC9")]
	[Address(RVA = "0x162D63C", Offset = "0x162D63C", VA = "0x162D63C")]
	public PushBoat()
	{
	}
}
