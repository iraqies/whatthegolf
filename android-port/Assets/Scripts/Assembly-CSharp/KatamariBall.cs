using Audio;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007BB")]
public class KatamariBall : MonoBehaviour
{
	[Token(Token = "0x40028D2")]
	[FieldOffset(Offset = "0x18")]
	public float CurrentSize;

	[Token(Token = "0x40028D3")]
	[FieldOffset(Offset = "0x1C")]
	public float BallCompression;

	[Token(Token = "0x40028D4")]
	[FieldOffset(Offset = "0x20")]
	public float GrowthMod;

	[Token(Token = "0x40028D5")]
	[FieldOffset(Offset = "0x24")]
	public float ElevationMod;

	[Token(Token = "0x40028D6")]
	[FieldOffset(Offset = "0x28")]
	public float MinCameraElevation;

	[Token(Token = "0x40028D7")]
	[FieldOffset(Offset = "0x2C")]
	public float ElevationChangeSpeed;

	[Token(Token = "0x40028D8")]
	[FieldOffset(Offset = "0x30")]
	public float RequiredSizeToWin;

	[Token(Token = "0x40028D9")]
	[FieldOffset(Offset = "0x34")]
	public float MinShotSpeed;

	[Token(Token = "0x40028DA")]
	[FieldOffset(Offset = "0x38")]
	public float ForceMod;

	[Token(Token = "0x40028DB")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 ArrowScaleRange;

	[Token(Token = "0x40028DC")]
	[FieldOffset(Offset = "0x44")]
	public bool IncreaseMass;

	[Token(Token = "0x40028DD")]
	[FieldOffset(Offset = "0x45")]
	public bool DestroyCollider;

	[Token(Token = "0x40028DE")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ClipSettingsCollection absorbClip;

	[Token(Token = "0x40028DF")]
	[FieldOffset(Offset = "0x50")]
	private CBFollow followCam;

	[Token(Token = "0x40028E0")]
	[FieldOffset(Offset = "0x58")]
	private float targetElevation;

	[Token(Token = "0x40028E1")]
	[FieldOffset(Offset = "0x5C")]
	private float currentElevation;

	[Token(Token = "0x40028E2")]
	[FieldOffset(Offset = "0x60")]
	private ConstantForce force;

	[Token(Token = "0x40028E3")]
	[FieldOffset(Offset = "0x68")]
	private GolfBallShooterExperimental shooter;

	[Token(Token = "0x40028E4")]
	[FieldOffset(Offset = "0x70")]
	private GolfBallController controller;

	[Token(Token = "0x40028E5")]
	[FieldOffset(Offset = "0x78")]
	private Rigidbody rigidbody;

	[Token(Token = "0x6002365")]
	[Address(RVA = "0x14FA7AC", Offset = "0x14FA7AC", VA = "0x14FA7AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002366")]
	[Address(RVA = "0x14FA918", Offset = "0x14FA918", VA = "0x14FA918")]
	private void Controller_OnReset()
	{
	}

	[Token(Token = "0x6002367")]
	[Address(RVA = "0x14FA9A8", Offset = "0x14FA9A8", VA = "0x14FA9A8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002368")]
	[Address(RVA = "0x14FAE74", Offset = "0x14FAE74", VA = "0x14FAE74")]
	private void Update()
	{
	}

	[Token(Token = "0x6002369")]
	[Address(RVA = "0x14FB040", Offset = "0x14FB040", VA = "0x14FB040")]
	public KatamariBall()
	{
	}
}
