using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001FD")]
[Attribute(Name = "RequireComponent", RVA = "0x3E350", Offset = "0x3E350")]
public class ParticleSystemDistanceEmissionCurve : MonoBehaviour
{
	[Token(Token = "0x40009BA")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve EmissionCurve;

	[Token(Token = "0x40009BB")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem particles;

	[Token(Token = "0x40009BC")]
	[FieldOffset(Offset = "0x28")]
	private float timer;

	[Token(Token = "0x40009BD")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem.EmissionModule emission;

	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x38")]
	private float maxTime;

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x15DBD8C", Offset = "0x15DBD8C", VA = "0x15DBD8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x15DBDFC", Offset = "0x15DBDFC", VA = "0x15DBDFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x15DBEA4", Offset = "0x15DBEA4", VA = "0x15DBEA4")]
	private void Update()
	{
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x15DBF28", Offset = "0x15DBF28", VA = "0x15DBF28")]
	public ParticleSystemDistanceEmissionCurve()
	{
	}
}
