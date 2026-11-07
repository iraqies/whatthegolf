using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Wwise2;
using WwiseXMLRTPCData;

[Token(Token = "0x2000D3A")]
public class RTPC : MonoBehaviour
{
	[Token(Token = "0x4004802")]
	[FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4004803")]
	[FieldOffset(Offset = "0x20")]
	public float value;

	[Token(Token = "0x4004804")]
	[FieldOffset(Offset = "0x24")]
	public float InitialValue;

	[Token(Token = "0x4004805")]
	[FieldOffset(Offset = "0x28")]
	public float min;

	[Token(Token = "0x4004806")]
	[FieldOffset(Offset = "0x2C")]
	public float max;

	[Token(Token = "0x4004807")]
	[FieldOffset(Offset = "0x30")]
	public List<MusicTrack> tracks;

	[Token(Token = "0x4004808")]
	[FieldOffset(Offset = "0x38")]
	public uint shortID;

	[Token(Token = "0x4004809")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine currentRTPCOverTime;

	[Token(Token = "0x6003E64")]
	[Address(RVA = "0x1639088", Offset = "0x1639088", VA = "0x1639088")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003E65")]
	[Address(RVA = "0x1639094", Offset = "0x1639094", VA = "0x1639094")]
	private void Start()
	{
	}

	[Token(Token = "0x6003E66")]
	[Address(RVA = "0x1639098", Offset = "0x1639098", VA = "0x1639098")]
	private void UpdateTracks()
	{
	}

	[Token(Token = "0x6003E67")]
	[Address(RVA = "0x16391E4", Offset = "0x16391E4", VA = "0x16391E4")]
	public void SetRTPCOverTime(float newValue, int ms)
	{
	}

	[Token(Token = "0x6003E68")]
	[Address(RVA = "0x16392F0", Offset = "0x16392F0", VA = "0x16392F0")]
	public void SetRTPC(float newValue)
	{
	}

	[Token(Token = "0x6003E69")]
	[Address(RVA = "0x1639350", Offset = "0x1639350", VA = "0x1639350")]
	public void Init(GameParameter parameter, List<MusicPlaylist> playlists)
	{
	}

	[Token(Token = "0x6003E6A")]
	[Address(RVA = "0x1639DD8", Offset = "0x1639DD8", VA = "0x1639DD8")]
	public void Init(WwiseDocumentGameParametersWorkUnitChildrenListGameParameter parameter, List<MusicPlaylist> playlists)
	{
	}

	[Token(Token = "0x6003E6B")]
	[Address(RVA = "0x1639BC8", Offset = "0x1639BC8", VA = "0x1639BC8")]
	private void ParseProp(PropertyElement prop)
	{
	}

	[Token(Token = "0x6003E6C")]
	[Address(RVA = "0x163A570", Offset = "0x163A570", VA = "0x163A570")]
	private void ParseProp(WwiseDocumentGameParametersWorkUnitChildrenListGameParameterProperty prop)
	{
	}

	[Token(Token = "0x6003E6D")]
	[Address(RVA = "0x163A6DC", Offset = "0x163A6DC", VA = "0x163A6DC")]
	public RTPC()
	{
	}

	[Token(Token = "0x6003E6E")]
	[Address(RVA = "0x163A6E4", Offset = "0x163A6E4", VA = "0x163A6E4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C4F8", Offset = "0x6C4F8")]
	private void _003CSetRTPCOverTime_003Eb__11_0(float v)
	{
	}
}
