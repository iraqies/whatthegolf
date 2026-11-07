using System.Collections.Generic;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000172")]
[ExecuteAlways]
public class CreateObjectsOnCinemachineSmoothPath : MonoBehaviour
{
	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x18")]
	public CinemachineSmoothPath Path;

	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> ObjectsToPlace;

	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 RotationOffsetEuler;

	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x34")]
	public float OffsetAlongUpVector;

	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x38")]
	public float DistanceInterval;

	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 ObjectScale;

	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x48")]
	public bool ObjectHasPhysics;

	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x49")]
	public bool Place;

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x18BD8AC", Offset = "0x18BD8AC", VA = "0x18BD8AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x18BD8DC", Offset = "0x18BD8DC", VA = "0x18BD8DC")]
	private void PlaceObjects()
	{
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x18BDDC4", Offset = "0x18BDDC4", VA = "0x18BDDC4")]
	public CreateObjectsOnCinemachineSmoothPath()
	{
	}
}
