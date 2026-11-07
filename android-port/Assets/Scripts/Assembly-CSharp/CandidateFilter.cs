using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using ch.sycoforge.Decal;

[Token(Token = "0x2000F3B")]
[Attribute(Name = "RequireComponent", RVA = "0x457F0", Offset = "0x457F0")]
public class CandidateFilter : MonoBehaviour
{
	[Token(Token = "0x4005239")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ExclusiveReceiver;

	[Token(Token = "0x400523A")]
	[FieldOffset(Offset = "0x20")]
	private EasyDecal decal;

	[Token(Token = "0x600472E")]
	[Address(RVA = "0x1885F9C", Offset = "0x1885F9C", VA = "0x1885F9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600472F")]
	[Address(RVA = "0x18860E0", Offset = "0x18860E0", VA = "0x18860E0")]
	private void bp_OnCandidatesProcessed(List<Collider> colliders)
	{
	}

	[Token(Token = "0x6004730")]
	[Address(RVA = "0x18863CC", Offset = "0x18863CC", VA = "0x18863CC")]
	public CandidateFilter()
	{
	}
}
