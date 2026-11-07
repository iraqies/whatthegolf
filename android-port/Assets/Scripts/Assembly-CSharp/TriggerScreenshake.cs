using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000306")]
public class TriggerScreenshake : MonoBehaviour
{
	[Token(Token = "0x40010C2")]
	[FieldOffset(Offset = "0x18")]
	public float HitShakeDuration;

	[Token(Token = "0x40010C3")]
	[FieldOffset(Offset = "0x1C")]
	public float HitShakeSpeed;

	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x20")]
	public float HitShakeMagnitude;

	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x172F138", Offset = "0x172F138", VA = "0x172F138")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x172F1CC", Offset = "0x172F1CC", VA = "0x172F1CC")]
	public TriggerScreenshake()
	{
	}
}
