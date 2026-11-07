using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006F6")]
public class FPGHideCursor : MonoBehaviour
{
	[Token(Token = "0x400248B")]
	[FieldOffset(Offset = "0x18")]
	public bool ShowWhenAiming;

	[Token(Token = "0x400248C")]
	[FieldOffset(Offset = "0x19")]
	private bool cursorState;

	[Token(Token = "0x400248D")]
	[FieldOffset(Offset = "0x20")]
	private GolfBallController controller;

	[Token(Token = "0x400248E")]
	[FieldOffset(Offset = "0x28")]
	private bool origState;

	[Token(Token = "0x600201D")]
	[Address(RVA = "0x1459450", Offset = "0x1459450", VA = "0x1459450")]
	private void Start()
	{
	}

	[Token(Token = "0x600201E")]
	[Address(RVA = "0x1459704", Offset = "0x1459704", VA = "0x1459704")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600201F")]
	[Address(RVA = "0x1459710", Offset = "0x1459710", VA = "0x1459710")]
	private void Instance_OnComplete(Level.CompletedState obj)
	{
	}

	[Token(Token = "0x6002020")]
	[Address(RVA = "0x1459744", Offset = "0x1459744", VA = "0x1459744")]
	private void ControllerOnAimUpdate(Vector3 vector3, bool b)
	{
	}

	[Token(Token = "0x6002021")]
	[Address(RVA = "0x14597B8", Offset = "0x14597B8", VA = "0x14597B8")]
	private void ControllerOnAimStart()
	{
	}

	[Token(Token = "0x6002022")]
	[Address(RVA = "0x14597CC", Offset = "0x14597CC", VA = "0x14597CC")]
	private void ControllerOnCancel()
	{
	}

	[Token(Token = "0x6002023")]
	[Address(RVA = "0x14597D4", Offset = "0x14597D4", VA = "0x14597D4")]
	private void ControllerOnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x6002024")]
	[Address(RVA = "0x14597DC", Offset = "0x14597DC", VA = "0x14597DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6002025")]
	[Address(RVA = "0x14598A8", Offset = "0x14598A8", VA = "0x14598A8")]
	public FPGHideCursor()
	{
	}
}
