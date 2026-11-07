using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000204")]
public class AddForceInArea : MonoBehaviour
{
	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool executeOnStart;

	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float radius;

	[Token(Token = "0x40009DE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float force;

	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 forceDirection;

	[Token(Token = "0x40009E0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ForceMode forceMode;

	[Token(Token = "0x40009E1")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int maxOthersAffected;

	[Token(Token = "0x40009E2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private LayerMask acceptedLayers;

	[Token(Token = "0x40009E3")]
	[FieldOffset(Offset = "0x40")]
	private Collider[] colliders;

	[Token(Token = "0x6000908")]
	[Address(RVA = "0x1406ACC", Offset = "0x1406ACC", VA = "0x1406ACC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000909")]
	[Address(RVA = "0x1406B48", Offset = "0x1406B48", VA = "0x1406B48")]
	public void Execute()
	{
	}

	[Token(Token = "0x600090A")]
	[Address(RVA = "0x1406CE0", Offset = "0x1406CE0", VA = "0x1406CE0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600090B")]
	[Address(RVA = "0x1406D30", Offset = "0x1406D30", VA = "0x1406D30")]
	public AddForceInArea()
	{
	}
}
