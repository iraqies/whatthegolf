using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000209")]
public class SpringBoardSimple : MonoBehaviour
{
	[Token(Token = "0x40009EB")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 ForceDirection;

	[Token(Token = "0x40009EC")]
	[FieldOffset(Offset = "0x24")]
	public float SpeedBoost;

	[Token(Token = "0x40009ED")]
	[FieldOffset(Offset = "0x28")]
	public ForceMode Mode;

	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection sfxOnBounce;

	[Token(Token = "0x40009EF")]
	[FieldOffset(Offset = "0x38")]
	private List<Rigidbody> affectedRigidbodies;

	[Token(Token = "0x40009F0")]
	[FieldOffset(Offset = "0x40")]
	private float lastSfxTime;

	[Token(Token = "0x6000918")]
	[Address(RVA = "0x16D9890", Offset = "0x16D9890", VA = "0x16D9890")]
	private void Start()
	{
	}

	[Token(Token = "0x6000919")]
	[Address(RVA = "0x16D9908", Offset = "0x16D9908", VA = "0x16D9908")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600091A")]
	[Address(RVA = "0x16D9AB8", Offset = "0x16D9AB8", VA = "0x16D9AB8")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600091B")]
	[Address(RVA = "0x16D9B50", Offset = "0x16D9B50", VA = "0x16D9B50")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600091C")]
	[Address(RVA = "0x16D9C24", Offset = "0x16D9C24", VA = "0x16D9C24")]
	public SpringBoardSimple()
	{
	}
}
