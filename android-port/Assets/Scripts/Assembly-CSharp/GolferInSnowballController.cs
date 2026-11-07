using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D01")]
public class GolferInSnowballController : MonoBehaviour
{
	[Token(Token = "0x40046A3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController GolferController;

	[Token(Token = "0x40046A4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GolfBallController SnowballController;

	[Token(Token = "0x40046A5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody SnowballRigid;

	[Token(Token = "0x40046A6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Collider SnowballCollider;

	[Token(Token = "0x40046A7")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ParticleSystem HitParticles;

	[Token(Token = "0x40046A8")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Animator CameraController;

	[Token(Token = "0x40046A9")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float ConnectedMassScale;

	[Token(Token = "0x40046AA")]
	[FieldOffset(Offset = "0x4C")]
	private float timer;

	[Token(Token = "0x6003D70")]
	[Address(RVA = "0x14A5284", Offset = "0x14A5284", VA = "0x14A5284")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003D71")]
	[Address(RVA = "0x14A5334", Offset = "0x14A5334", VA = "0x14A5334")]
	private void ControllerOnShoot(Vector3 dir)
	{
	}

	[Token(Token = "0x6003D72")]
	[Address(RVA = "0x14A537C", Offset = "0x14A537C", VA = "0x14A537C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003D73")]
	[Address(RVA = "0x14A5450", Offset = "0x14A5450", VA = "0x14A5450")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003D74")]
	[Address(RVA = "0x14A567C", Offset = "0x14A567C", VA = "0x14A567C")]
	public GolferInSnowballController()
	{
	}
}
