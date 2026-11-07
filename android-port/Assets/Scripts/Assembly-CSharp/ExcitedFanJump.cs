using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001EF")]
public class ExcitedFanJump : MonoBehaviour
{
	[Token(Token = "0x4000956")]
	[FieldOffset(Offset = "0x18")]
	public GameObject mesh;

	[Token(Token = "0x4000957")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 boost;

	[Token(Token = "0x4000958")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody[] rigidbodies;

	[Token(Token = "0x4000959")]
	[FieldOffset(Offset = "0x38")]
	private bool jumped;

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x144E0B0", Offset = "0x144E0B0", VA = "0x144E0B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x144E15C", Offset = "0x144E15C", VA = "0x144E15C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x144E2B0", Offset = "0x144E2B0", VA = "0x144E2B0")]
	public ExcitedFanJump()
	{
	}
}
