using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EA3")]
public class S22SpawnedObjectBehaviour : MonoBehaviour
{
	[Token(Token = "0x4004F12")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ClipSettingsCollection OnEnableAudio;

	[Token(Token = "0x4004F13")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ClipSettingsCollection OnDestroyAudio;

	[Token(Token = "0x4004F14")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ParticleSystem OnDestroyParticles;

	[Token(Token = "0x4004F15")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float ChangeScale;

	[Token(Token = "0x4004F16")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float InDuraction;

	[Token(Token = "0x4004F17")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float OutDuration;

	[Token(Token = "0x4004F18")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve curve;

	[Token(Token = "0x4004F19")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 OrgSize;

	[Token(Token = "0x600445A")]
	[Address(RVA = "0x166699C", Offset = "0x166699C", VA = "0x166699C")]
	private void Start()
	{
	}

	[Token(Token = "0x600445B")]
	[Address(RVA = "0x1666BC4", Offset = "0x1666BC4", VA = "0x1666BC4")]
	private void BeforeDestry()
	{
	}

	[Token(Token = "0x600445C")]
	[Address(RVA = "0x1666D20", Offset = "0x1666D20", VA = "0x1666D20")]
	public S22SpawnedObjectBehaviour()
	{
	}

	[Token(Token = "0x600445D")]
	[Address(RVA = "0x1666D44", Offset = "0x1666D44", VA = "0x1666D44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E014", Offset = "0x6E014")]
	private void _003CStart_003Eb__8_0(float t)
	{
	}

	[Token(Token = "0x600445E")]
	[Address(RVA = "0x1666DF4", Offset = "0x1666DF4", VA = "0x1666DF4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E024", Offset = "0x6E024")]
	private void _003CBeforeDestry_003Eb__9_0(float t)
	{
	}
}
