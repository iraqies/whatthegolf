using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C4C")]
public class SphereCastGroundCheck : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000C4D")]
	public struct CheckOverlap
	{
		[Token(Token = "0x4004395")]
		[FieldOffset(Offset = "0x0")]
		public Transform checkPoint;

		[Token(Token = "0x4004396")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 offset;

		[Token(Token = "0x4004397")]
		[FieldOffset(Offset = "0x14")]
		public float radius;

		[Token(Token = "0x4004398")]
		[FieldOffset(Offset = "0x18")]
		public float distance;
	}

	[Token(Token = "0x400438C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform baseTransform;

	[Token(Token = "0x400438D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool setSizeMultiplierFromScale;

	[Token(Token = "0x400438E")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 defaultScale;

	[Token(Token = "0x400438F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float sizeMultiplier;

	[Token(Token = "0x4004390")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<CheckOverlap> overlapPoints;

	[Token(Token = "0x4004391")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private LayerMask groundMask;

	[Token(Token = "0x4004392")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool addToControllerBlockingFunctions;

	[Token(Token = "0x4004393")]
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	private bool is2D;

	[Token(Token = "0x4004394")]
	[FieldOffset(Offset = "0x48")]
	private GolfBallController controller;

	[Token(Token = "0x6003A85")]
	[Address(RVA = "0x16D0DB8", Offset = "0x16D0DB8", VA = "0x16D0DB8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003A86")]
	[Address(RVA = "0x16D0F74", Offset = "0x16D0F74", VA = "0x16D0F74")]
	public bool IsGrounded()
	{
		return default;
	}

	[Token(Token = "0x6003A87")]
	[Address(RVA = "0x16D0F8C", Offset = "0x16D0F8C", VA = "0x16D0F8C")]
	private bool IsBlocking()
	{
		return default;
	}

	[Token(Token = "0x6003A88")]
	[Address(RVA = "0x16D1210", Offset = "0x16D1210", VA = "0x16D1210")]
	private bool CheckPoint2D(CheckOverlap overlap)
	{
		return default;
	}

	[Token(Token = "0x6003A89")]
	[Address(RVA = "0x16D13C4", Offset = "0x16D13C4", VA = "0x16D13C4")]
	private bool CheckPoint3D(CheckOverlap overlap)
	{
		return default;
	}

	[Token(Token = "0x6003A8A")]
	[Address(RVA = "0x16D1568", Offset = "0x16D1568", VA = "0x16D1568")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6003A8B")]
	[Address(RVA = "0x16D1A48", Offset = "0x16D1A48", VA = "0x16D1A48")]
	public SphereCastGroundCheck()
	{
	}
}
