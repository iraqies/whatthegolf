using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002AE")]
[ExecuteInEditMode]
public class CarnivalRopesGenerator : MonoBehaviour
{
	[Token(Token = "0x20002AF")]
	public enum FlagDistributionTypeEnum
	{
		[Token(Token = "0x4000E69")]
		PerSegment = 0,
		[Token(Token = "0x4000E6A")]
		EvenlyDistributed = 1
	}

	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MastTemplate;

	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LineSegment;

	[Token(Token = "0x4000E5B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject FlagTemplate;

	[Token(Token = "0x4000E5C")]
	[FieldOffset(Offset = "0x30")]
	public List<Transform> MastPositions;

	[Token(Token = "0x4000E5D")]
	[FieldOffset(Offset = "0x38")]
	public float SegmentsLength;

	[Token(Token = "0x4000E5E")]
	[FieldOffset(Offset = "0x3C")]
	public float MassPerLine;

	[Token(Token = "0x4000E5F")]
	[FieldOffset(Offset = "0x40")]
	public List<Material> FlagMaterials;

	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x48")]
	public FlagDistributionTypeEnum FlagDistributionType;

	[Token(Token = "0x4000E61")]
	[FieldOffset(Offset = "0x4C")]
	public int FlagsPerSegment;

	[Token(Token = "0x4000E62")]
	[FieldOffset(Offset = "0x50")]
	public float FlagSpacing;

	[Token(Token = "0x4000E63")]
	[FieldOffset(Offset = "0x54")]
	public bool ContinuousUpdate;

	[Token(Token = "0x4000E64")]
	[FieldOffset(Offset = "0x55")]
	public bool DoUpdate;

	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0x58")]
	private List<GameObject> SpawnedMasts;

	[Token(Token = "0x4000E66")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<GameObject, List<GameObject>> lines;

	[Token(Token = "0x4000E67")]
	[FieldOffset(Offset = "0x68")]
	private int currentMaterialIndex;

	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x188B598", Offset = "0x188B598", VA = "0x188B598")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x188CBEC", Offset = "0x188CBEC", VA = "0x188CBEC")]
	private void PlaceFlagsPerSegment(Transform previousMast, Transform currentMast)
	{
	}

	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x188D0C8", Offset = "0x188D0C8", VA = "0x188D0C8")]
	private float PlaceFlagsEvenly(Transform previousMast, Transform currentMast, float lastAccumulated)
	{
		return default;
	}

	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x188D58C", Offset = "0x188D58C", VA = "0x188D58C")]
	private Material GetNextFlagMaterial()
	{
		return null;
	}

	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x188C4BC", Offset = "0x188C4BC", VA = "0x188C4BC")]
	private void BuildLines(Transform previousMast, Transform currentMast)
	{
	}

	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x188D638", Offset = "0x188D638", VA = "0x188D638")]
	public CarnivalRopesGenerator()
	{
	}
}
