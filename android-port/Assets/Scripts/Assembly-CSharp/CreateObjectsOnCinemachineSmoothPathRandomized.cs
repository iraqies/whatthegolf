using System.Collections.Generic;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E10")]
[ExecuteAlways]
public class CreateObjectsOnCinemachineSmoothPathRandomized : MonoBehaviour
{
	[Token(Token = "0x4004C70")]
	[FieldOffset(Offset = "0x18")]
	public CinemachineSmoothPath Path;

	[Token(Token = "0x4004C71")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> ObjectsToPlace;

	[Token(Token = "0x4004C72")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 RotationOffsetEuler;

	[Token(Token = "0x4004C73")]
	[FieldOffset(Offset = "0x34")]
	public float OffsetAlongUpVector;

	[Token(Token = "0x4004C74")]
	[FieldOffset(Offset = "0x38")]
	public float DistanceInterval;

	[Token(Token = "0x4004C75")]
	[FieldOffset(Offset = "0x3C")]
	public int NumberOfRows;

	[Token(Token = "0x4004C76")]
	[FieldOffset(Offset = "0x40")]
	public float RowsOffset;

	[Token(Token = "0x4004C77")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 PlacementRandomVector;

	[Token(Token = "0x4004C78")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 RotationRandomVector;

	[Token(Token = "0x4004C79")]
	[FieldOffset(Offset = "0x54")]
	public bool Place;

	[Token(Token = "0x600421A")]
	[Address(RVA = "0x18BDDDC", Offset = "0x18BDDDC", VA = "0x18BDDDC")]
	private void Update()
	{
	}

	[Token(Token = "0x600421B")]
	[Address(RVA = "0x18BDE0C", Offset = "0x18BDE0C", VA = "0x18BDE0C")]
	private void PlaceObjects()
	{
	}

	[Token(Token = "0x600421C")]
	[Address(RVA = "0x18BE394", Offset = "0x18BE394", VA = "0x18BE394")]
	public CreateObjectsOnCinemachineSmoothPathRandomized()
	{
	}
}
