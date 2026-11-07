using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200074B")]
public class ChangeNumberOfHooksOnAwake : MonoBehaviour
{
	[Token(Token = "0x4002699")]
	[FieldOffset(Offset = "0x18")]
	public GrapplingHookShooter2D Shooter;

	[Token(Token = "0x400269A")]
	[FieldOffset(Offset = "0x20")]
	public int NumberOfHooks;

	[Token(Token = "0x600219B")]
	[Address(RVA = "0x18976B0", Offset = "0x18976B0", VA = "0x18976B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600219C")]
	[Address(RVA = "0x1897758", Offset = "0x1897758", VA = "0x1897758")]
	public ChangeNumberOfHooksOnAwake()
	{
	}
}
