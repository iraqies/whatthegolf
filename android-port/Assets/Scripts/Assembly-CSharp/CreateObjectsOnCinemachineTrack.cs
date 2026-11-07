using System.Collections.Generic;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BD0")]
[ExecuteAlways]
public class CreateObjectsOnCinemachineTrack : MonoBehaviour
{
	[Token(Token = "0x40041C0")]
	[FieldOffset(Offset = "0x18")]
	public CinemachineSmoothPath Path;

	[Token(Token = "0x40041C1")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> ObjectsToPlace;

	[Token(Token = "0x40041C2")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 RotationOffsetEuler;

	[Token(Token = "0x40041C3")]
	[FieldOffset(Offset = "0x34")]
	public float OffsetAlongUpVector;

	[Token(Token = "0x40041C4")]
	[FieldOffset(Offset = "0x38")]
	public float Resolution;

	[Token(Token = "0x40041C5")]
	[FieldOffset(Offset = "0x3C")]
	public bool Place;

	[Token(Token = "0x60038D4")]
	[Address(RVA = "0x18BE3B0", Offset = "0x18BE3B0", VA = "0x18BE3B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60038D5")]
	[Address(RVA = "0x18BE3E0", Offset = "0x18BE3E0", VA = "0x18BE3E0")]
	private void PlaceObjects()
	{
	}

	[Token(Token = "0x60038D6")]
	[Address(RVA = "0x18BE778", Offset = "0x18BE778", VA = "0x18BE778")]
	public CreateObjectsOnCinemachineTrack()
	{
	}
}
