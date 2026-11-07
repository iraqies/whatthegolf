using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F2B")]
public class StopRotationWhenLanding : MonoBehaviour
{
	[Token(Token = "0x40051CB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody r;

	[Token(Token = "0x40051CC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float adjustForce;

	[Token(Token = "0x40051CD")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float threshold;

	[Token(Token = "0x60046E3")]
	[Address(RVA = "0x16E2650", Offset = "0x16E2650", VA = "0x16E2650")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60046E4")]
	[Address(RVA = "0x16E273C", Offset = "0x16E273C", VA = "0x16E273C")]
	public StopRotationWhenLanding()
	{
	}
}
