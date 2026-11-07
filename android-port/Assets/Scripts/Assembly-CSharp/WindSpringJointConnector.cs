using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DEE")]
public class WindSpringJointConnector : MonoBehaviour
{
	[Token(Token = "0x4004BDE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject golfBall;

	[Token(Token = "0x4004BDF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x4004BE0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject fan;

	[Token(Token = "0x4004BE1")]
	[FieldOffset(Offset = "0x30")]
	public Animator animator;

	[Token(Token = "0x4004BE2")]
	[FieldOffset(Offset = "0x38")]
	public float speed;

	[Token(Token = "0x4004BE3")]
	[FieldOffset(Offset = "0x3C")]
	private float targetYPosition;

	[Token(Token = "0x4004BE4")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 targetStartPosition;

	[Token(Token = "0x4004BE5")]
	[FieldOffset(Offset = "0x4C")]
	private float defaultShootingThreshold;

	[Token(Token = "0x4004BE6")]
	[FieldOffset(Offset = "0x50")]
	private bool followWindTarget;

	[Token(Token = "0x4004BE7")]
	[FieldOffset(Offset = "0x54")]
	private float originalDrag;

	[Token(Token = "0x4004BE8")]
	[FieldOffset(Offset = "0x58")]
	private Rigidbody golfBallRigidbody;

	[Token(Token = "0x4004BE9")]
	[FieldOffset(Offset = "0x60")]
	private GolfBallShooterExperimental golfBallShooter;

	[Token(Token = "0x4004BEA")]
	[FieldOffset(Offset = "0x68")]
	private GolfBallController golfBallController;

	[Token(Token = "0x4004BEB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int IsVibrating;

	[Token(Token = "0x6004197")]
	[Address(RVA = "0x1758664", Offset = "0x1758664", VA = "0x1758664")]
	private void Start()
	{
	}

	[Token(Token = "0x6004198")]
	[Address(RVA = "0x1758828", Offset = "0x1758828", VA = "0x1758828")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6004199")]
	[Address(RVA = "0x1758AD0", Offset = "0x1758AD0", VA = "0x1758AD0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600419A")]
	[Address(RVA = "0x1758C10", Offset = "0x1758C10", VA = "0x1758C10")]
	public void CloseWind()
	{
	}

	[Token(Token = "0x600419B")]
	[Address(RVA = "0x1758D00", Offset = "0x1758D00", VA = "0x1758D00")]
	private void ShootOutOfWind(Vector3 shoot)
	{
	}

	[Token(Token = "0x600419C")]
	[Address(RVA = "0x1758D30", Offset = "0x1758D30", VA = "0x1758D30")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600419D")]
	[Address(RVA = "0x1758DE0", Offset = "0x1758DE0", VA = "0x1758DE0")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600419E")]
	[Address(RVA = "0x1758F20", Offset = "0x1758F20", VA = "0x1758F20")]
	public WindSpringJointConnector()
	{
	}
}
