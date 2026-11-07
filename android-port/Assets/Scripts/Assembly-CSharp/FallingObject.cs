using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200022D")]
public class FallingObject : MonoBehaviour
{
	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody[] rigidbodies;

	[Token(Token = "0x4000B18")]
	[FieldOffset(Offset = "0x20")]
	private MeshRenderer meshToHide;

	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0x28")]
	private SkinnedMeshRenderer skinToHide;

	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject gameObjectToHide;

	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x38")]
	public bool addRandomTorque;

	[Token(Token = "0x4000B1C")]
	[FieldOffset(Offset = "0x3C")]
	public float torqueAmount;

	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x145DD94", Offset = "0x145DD94", VA = "0x145DD94")]
	private void Awake()
	{
	}

	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x145DF74", Offset = "0x145DF74", VA = "0x145DF74")]
	public Rigidbody[] GetRigidbodies()
	{
		return null;
	}

	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x145DF7C", Offset = "0x145DF7C", VA = "0x145DF7C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x145E1BC", Offset = "0x145E1BC", VA = "0x145E1BC")]
	public FallingObject()
	{
	}
}
