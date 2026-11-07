using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B0B")]
public class Gravity : MonoBehaviour
{
	[Token(Token = "0x4003DBB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool twoD;

	[Token(Token = "0x4003DBC")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float gravity;

	[Token(Token = "0x4003DBD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 extraGravity;

	[Token(Token = "0x60034C0")]
	[Address(RVA = "0x14B87A0", Offset = "0x14B87A0", VA = "0x14B87A0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60034C1")]
	[Address(RVA = "0x14B87A4", Offset = "0x14B87A4", VA = "0x14B87A4")]
	public void UpdateGravity()
	{
	}

	[Token(Token = "0x60034C2")]
	[Address(RVA = "0x14B886C", Offset = "0x14B886C", VA = "0x14B886C")]
	public bool IsFake2D()
	{
		return default;
	}

	[Token(Token = "0x60034C3")]
	[Address(RVA = "0x14B8874", Offset = "0x14B8874", VA = "0x14B8874")]
	public Gravity()
	{
	}
}
