using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007ED")]
public class RaceManager : MonoBehaviour
{
	[Token(Token = "0x4002A80")]
	[FieldOffset(Offset = "0x18")]
	public TrafficLight[] trafficLights;

	[Token(Token = "0x4002A81")]
	[FieldOffset(Offset = "0x20")]
	public CarDriver[] opponents;

	[Token(Token = "0x4002A82")]
	[FieldOffset(Offset = "0x28")]
	public GolfBallController player;

	[Token(Token = "0x4002A83")]
	[FieldOffset(Offset = "0x30")]
	public GolfGoal goal;

	[Token(Token = "0x4002A84")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip sound1;

	[Token(Token = "0x4002A85")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip sound2;

	[Token(Token = "0x4002A86")]
	[FieldOffset(Offset = "0x48")]
	private AudioSource source;

	[Token(Token = "0x4002A87")]
	[FieldOffset(Offset = "0x50")]
	private bool done;

	[Token(Token = "0x6002467")]
	[Address(RVA = "0x163AA3C", Offset = "0x163AA3C", VA = "0x163AA3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002468")]
	[Address(RVA = "0x163AC24", Offset = "0x163AC24", VA = "0x163AC24")]
	private void Player_OnAimStart()
	{
	}

	[Token(Token = "0x6002469")]
	[Address(RVA = "0x163ACB4", Offset = "0x163ACB4", VA = "0x163ACB4")]
	private void Player_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600246A")]
	[Address(RVA = "0x163AEAC", Offset = "0x163AEAC", VA = "0x163AEAC")]
	private void Player_OnCancel()
	{
	}

	[Token(Token = "0x600246B")]
	[Address(RVA = "0x163AF38", Offset = "0x163AF38", VA = "0x163AF38")]
	public void OpponentTouchedFlag(CarDriver opponent)
	{
	}

	[Token(Token = "0x600246C")]
	[Address(RVA = "0x163AFBC", Offset = "0x163AFBC", VA = "0x163AFBC")]
	private void Goal_OnGoal(string obj)
	{
	}

	[Token(Token = "0x600246D")]
	[Address(RVA = "0x163AFC8", Offset = "0x163AFC8", VA = "0x163AFC8")]
	public RaceManager()
	{
	}
}
