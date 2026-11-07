using Chronos;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200084A")]
public class VelocityAffectsTime : MonoBehaviour
{
	[Token(Token = "0x4002CEB")]
	[FieldOffset(Offset = "0x18")]
	public float MaxVelocity;

	[Token(Token = "0x4002CEC")]
	[FieldOffset(Offset = "0x1C")]
	public float MinVelocity;

	[Token(Token = "0x4002CED")]
	[FieldOffset(Offset = "0x20")]
	public Clock GlobalClock;

	[Token(Token = "0x4002CEE")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigidbodyC;

	[Token(Token = "0x4002CEF")]
	[FieldOffset(Offset = "0x30")]
	private bool gameHasEnded;

	[Token(Token = "0x600263F")]
	[Address(RVA = "0x1749C24", Offset = "0x1749C24", VA = "0x1749C24")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002640")]
	[Address(RVA = "0x1749C80", Offset = "0x1749C80", VA = "0x1749C80")]
	private void Start()
	{
	}

	[Token(Token = "0x6002641")]
	[Address(RVA = "0x1749D38", Offset = "0x1749D38", VA = "0x1749D38")]
	private void InstanceOnOnLevelComplete(Level.CompletedState state)
	{
	}

	[Token(Token = "0x6002642")]
	[Address(RVA = "0x1749D44", Offset = "0x1749D44", VA = "0x1749D44")]
	private void Update()
	{
	}

	[Token(Token = "0x6002643")]
	[Address(RVA = "0x1749DE4", Offset = "0x1749DE4", VA = "0x1749DE4")]
	public VelocityAffectsTime()
	{
	}
}
