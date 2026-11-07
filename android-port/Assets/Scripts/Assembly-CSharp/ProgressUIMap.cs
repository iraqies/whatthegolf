using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000170")]
public class ProgressUIMap : MonoBehaviour
{
	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x18")]
	public bool AutoDistributeFlags;

	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> MapPoints;

	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x28")]
	public ProgressUIFlag FlagTemplate;

	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x30")]
	public List<ProgressUIFlag> Flags;

	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x38")]
	public ArenaCharacters AssociatedArenaVista;

	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x40")]
	public AmbientAudio mapAmbience;

	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x48")]
	private float totalDistance;

	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0x50")]
	private List<Transform> travelPathPoints;

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x1627374", Offset = "0x1627374", VA = "0x1627374")]
	private void Awake()
	{
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x16246F4", Offset = "0x16246F4", VA = "0x16246F4")]
	public void CreateMapPoints(int points)
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x1627498", Offset = "0x1627498", VA = "0x1627498")]
	public void CompleteFlag(int flagIndex, Color winnerColor)
	{
	}

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x1624D7C", Offset = "0x1624D7C", VA = "0x1624D7C")]
	public Transform GetPathPointForFlagIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x16244F4", Offset = "0x16244F4", VA = "0x16244F4")]
	public void ResetMap()
	{
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x16275C8", Offset = "0x16275C8", VA = "0x16275C8")]
	public ProgressUIMap()
	{
	}
}
