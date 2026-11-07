using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E87")]
public class IncrementShooterStrength : MonoBehaviour
{
	[Token(Token = "0x4004E7F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallShooterExperimental m_shoooter;

	[Token(Token = "0x4004E80")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float m_value;

	[Token(Token = "0x4004E81")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool m_minEqualMax;

	[Token(Token = "0x60043DD")]
	[Address(RVA = "0x14EC994", Offset = "0x14EC994", VA = "0x14EC994")]
	public void Increment()
	{
	}

	[Token(Token = "0x60043DE")]
	[Address(RVA = "0x14EC9CC", Offset = "0x14EC9CC", VA = "0x14EC9CC")]
	public IncrementShooterStrength()
	{
	}
}
