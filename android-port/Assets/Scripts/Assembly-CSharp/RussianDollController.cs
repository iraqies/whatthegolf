using System;
using System.Collections.Generic;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D0D")]
public class RussianDollController : GolfBallController
{
	[Serializable]
	[Token(Token = "0x2000D0E")]
	public class Controllers
	{
		[Token(Token = "0x40046E8")]
		[FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x40046E9")]
		[FieldOffset(Offset = "0x18")]
		public GolfBallShooterBase shooter;

		[Token(Token = "0x40046EA")]
		[FieldOffset(Offset = "0x20")]
		public Collider collider;

		[Token(Token = "0x40046EB")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody rb;

		[Token(Token = "0x40046EC")]
		[FieldOffset(Offset = "0x30")]
		public int hits;

		[Token(Token = "0x6003DAB")]
		[Address(RVA = "0x183757C", Offset = "0x183757C", VA = "0x183757C")]
		public Controllers()
		{
		}
	}

	[Token(Token = "0x40046DB")]
	[FieldOffset(Offset = "0x218")]
	public Controllers[] controllerList;

	[Token(Token = "0x40046DC")]
	[FieldOffset(Offset = "0x220")]
	public Transform cameraTransform;

	[Token(Token = "0x40046DD")]
	[FieldOffset(Offset = "0x228")]
	public CBFollow cbFollow;

	[Token(Token = "0x40046DE")]
	[FieldOffset(Offset = "0x230")]
	public bool blockIfMoving;

	[Token(Token = "0x40046DF")]
	[FieldOffset(Offset = "0x234")]
	public float maxVelocitySqr;

	[Token(Token = "0x40046E0")]
	[FieldOffset(Offset = "0x238")]
	private Rigidbody movingRB;

	[Token(Token = "0x40046E1")]
	[FieldOffset(Offset = "0x240")]
	private float shootCooldown;

	[Token(Token = "0x40046E2")]
	[FieldOffset(Offset = "0x244")]
	private float nextShotTime;

	[Token(Token = "0x40046E3")]
	[FieldOffset(Offset = "0x248")]
	private List<GolfBallController> golfballControllerList;

	[Token(Token = "0x40046E4")]
	[FieldOffset(Offset = "0x250")]
	private GolfBallShooterBase currentShooter;

	[Token(Token = "0x40046E5")]
	[FieldOffset(Offset = "0x258")]
	private int shooterIndex;

	[Token(Token = "0x40046E6")]
	[FieldOffset(Offset = "0x25C")]
	private int strokes;

	[Token(Token = "0x40046E7")]
	[FieldOffset(Offset = "0x260")]
	private int totalStrokes;

	[Token(Token = "0x6003DA3")]
	[Address(RVA = "0x1665E0C", Offset = "0x1665E0C", VA = "0x1665E0C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6003DA4")]
	[Address(RVA = "0x16661DC", Offset = "0x16661DC", VA = "0x16661DC")]
	public void CheckOutOfBoundsFromColliders(Collider other)
	{
	}

	[Token(Token = "0x6003DA5")]
	[Address(RVA = "0x166621C", Offset = "0x166621C", VA = "0x166621C")]
	private void AddStroke(Vector3 unused)
	{
	}

	[Token(Token = "0x6003DA6")]
	[Address(RVA = "0x1666270", Offset = "0x1666270", VA = "0x1666270")]
	private void SwitchControllers(Vector3 unused)
	{
	}

	[Token(Token = "0x6003DA7")]
	[Address(RVA = "0x1666188", Offset = "0x1666188", VA = "0x1666188")]
	private void ActivatePhysics()
	{
	}

	[Token(Token = "0x6003DA8")]
	[Address(RVA = "0x166669C", Offset = "0x166669C", VA = "0x166669C", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6003DA9")]
	[Address(RVA = "0x1666840", Offset = "0x1666840", VA = "0x1666840")]
	private bool BlockIfMoving()
	{
		return default;
	}

	[Token(Token = "0x6003DAA")]
	[Address(RVA = "0x16668BC", Offset = "0x16668BC", VA = "0x16668BC")]
	public RussianDollController()
	{
	}
}
