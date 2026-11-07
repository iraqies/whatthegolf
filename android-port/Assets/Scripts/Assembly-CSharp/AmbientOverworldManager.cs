using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

[Token(Token = "0x200037B")]
public class AmbientOverworldManager : MonoBehaviour
{
	[Token(Token = "0x4001310")]
	[FieldOffset(Offset = "0x18")]
	public OverworldManager2d overworldManager;

	[Token(Token = "0x4001311")]
	[FieldOffset(Offset = "0x20")]
	public OverworldBall2D ball;

	[Token(Token = "0x4001312")]
	[FieldOffset(Offset = "0x28")]
	public List<AmbientAudio> defaultAmbientOutsideZones;

	[Token(Token = "0x4001313")]
	[FieldOffset(Offset = "0x30")]
	public AudioMixerSnapshot defaultSnapshot;

	[Token(Token = "0x4001314")]
	[FieldOffset(Offset = "0x38")]
	private OverworldZoneAmbience currentZone;

	[Token(Token = "0x4001315")]
	[FieldOffset(Offset = "0x40")]
	private AmbientAudioPlayer ambient;

	[Token(Token = "0x4001316")]
	[FieldOffset(Offset = "0x48")]
	private bool applicationIsQuitting;

	[Token(Token = "0x600106E")]
	[Address(RVA = "0x140E1D4", Offset = "0x140E1D4", VA = "0x140E1D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600106F")]
	[Address(RVA = "0x140E794", Offset = "0x140E794", VA = "0x140E794")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001070")]
	[Address(RVA = "0x140E8F8", Offset = "0x140E8F8", VA = "0x140E8F8")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6001071")]
	[Address(RVA = "0x140E904", Offset = "0x140E904", VA = "0x140E904")]
	private void OnZoneEnter(OverworldZoneAmbience zone)
	{
	}

	[Token(Token = "0x6001072")]
	[Address(RVA = "0x140E7A8", Offset = "0x140E7A8", VA = "0x140E7A8")]
	private void OnZoneExit(OverworldZoneAmbience zone)
	{
	}

	[Token(Token = "0x6001073")]
	[Address(RVA = "0x140E47C", Offset = "0x140E47C", VA = "0x140E47C")]
	private void OnZoneChange()
	{
	}

	[Token(Token = "0x6001074")]
	[Address(RVA = "0x140EAFC", Offset = "0x140EAFC", VA = "0x140EAFC")]
	private void OverworldManager_OnEnableOverworld()
	{
	}

	[Token(Token = "0x6001075")]
	[Address(RVA = "0x140EB80", Offset = "0x140EB80", VA = "0x140EB80")]
	public AmbientOverworldManager()
	{
	}

	[Token(Token = "0x6001076")]
	[Address(RVA = "0x140EB88", Offset = "0x140EB88", VA = "0x140EB88")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6162C", Offset = "0x6162C")]
	private void _003CStart_003Eb__7_0(Transmogrif.BALLSHAPES newShape)
	{
	}
}
