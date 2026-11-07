using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000349")]
public class HotdogHole : MonoBehaviour
{
	[Token(Token = "0x4001227")]
	private const string IgnoreGround = "IgnoreGround";

	[Token(Token = "0x4001228")]
	[FieldOffset(Offset = "0x18")]
	public string Default;

	[Token(Token = "0x4001229")]
	[FieldOffset(Offset = "0x20")]
	public float upForceForRagdoll;

	[Token(Token = "0x400122A")]
	[FieldOffset(Offset = "0x24")]
	public bool ShouldCheckForRagdoll;

	[Token(Token = "0x400122B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string TagToCheckForRoot;

	[Token(Token = "0x400122C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string TagToCheckForRagdoll;

	[Token(Token = "0x400122D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private LayerMask BlacklistLayers;

	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0x40")]
	private List<Transform> ToAddForceTo;

	[Token(Token = "0x400122F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool ObjectsCanEscape;

	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0x14DBEF4", Offset = "0x14DBEF4", VA = "0x14DBEF4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0x14DC0F0", Offset = "0x14DC0F0", VA = "0x14DC0F0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x14DC314", Offset = "0x14DC314", VA = "0x14DC314")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x14DC37C", Offset = "0x14DC37C", VA = "0x14DC37C")]
	private void MoveRagdoll()
	{
	}

	[Token(Token = "0x6000F42")]
	[Address(RVA = "0x14DC7F4", Offset = "0x14DC7F4", VA = "0x14DC7F4")]
	private Vector3 getCenterOfMass(Rigidbody[] assembly)
	{
		return default;
	}

	[Token(Token = "0x6000F43")]
	[Address(RVA = "0x14DC024", Offset = "0x14DC024", VA = "0x14DC024")]
	public static void SetLayerRecursively(GameObject go, int layerNumber)
	{
	}

	[Token(Token = "0x6000F44")]
	[Address(RVA = "0x14DC8F8", Offset = "0x14DC8F8", VA = "0x14DC8F8")]
	public HotdogHole()
	{
	}
}
