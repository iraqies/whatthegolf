using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D22")]
public class VacuumableObjectBehaviour : MonoBehaviour
{
	[Token(Token = "0x4004739")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ClipSettingsCollection OnDestroyAudio;

	[Token(Token = "0x400473A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ParticleSystem OnDestroyParticles;

	[Token(Token = "0x400473B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float ChangeScale;

	[Token(Token = "0x400473C")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float InDuraction;

	[Token(Token = "0x400473D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float OutDuration;

	[Token(Token = "0x400473E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AnimationCurve curve;

	[Token(Token = "0x400473F")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 OrgSize;

	[Token(Token = "0x4004740")]
	[FieldOffset(Offset = "0x50")]
	private List<Collider> colliders;

	[Token(Token = "0x6003DF5")]
	[Address(RVA = "0x1747F9C", Offset = "0x1747F9C", VA = "0x1747F9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003DF6")]
	[Address(RVA = "0x1748168", Offset = "0x1748168", VA = "0x1748168")]
	private void BeforeDestroy()
	{
	}

	[Token(Token = "0x6003DF7")]
	[Address(RVA = "0x17482CC", Offset = "0x17482CC", VA = "0x17482CC")]
	private void DisableAllColliders()
	{
	}

	[Token(Token = "0x6003DF8")]
	[Address(RVA = "0x174836C", Offset = "0x174836C", VA = "0x174836C")]
	public VacuumableObjectBehaviour()
	{
	}

	[Token(Token = "0x6003DF9")]
	[Address(RVA = "0x1748390", Offset = "0x1748390", VA = "0x1748390")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C318", Offset = "0x6C318")]
	private void _003CBeforeDestroy_003Eb__9_0(float t)
	{
	}
}
