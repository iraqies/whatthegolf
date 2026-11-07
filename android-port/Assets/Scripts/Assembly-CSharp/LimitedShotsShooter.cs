using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000792")]
public class LimitedShotsShooter : GolfBallShooterExperimental
{
	[Token(Token = "0x40027F5")]
	[FieldOffset(Offset = "0x88")]
	public int NumberOfShots;

	[Token(Token = "0x40027F6")]
	[FieldOffset(Offset = "0x8C")]
	public float MinimumVelocityBeforeForfeit;

	[Token(Token = "0x40027F7")]
	[FieldOffset(Offset = "0x90")]
	private int shotsTaken;

	[Token(Token = "0x40027F8")]
	[FieldOffset(Offset = "0x94")]
	private float waitTime;

	[Token(Token = "0x40027F9")]
	[FieldOffset(Offset = "0x98")]
	private float belowSpeedTimer;

	[Token(Token = "0x40027FA")]
	[FieldOffset(Offset = "0x9C")]
	private bool gameWon;

	[Token(Token = "0x60022B5")]
	[Address(RVA = "0x153256C", Offset = "0x153256C", VA = "0x153256C", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60022B6")]
	[Address(RVA = "0x15327E4", Offset = "0x15327E4", VA = "0x15327E4")]
	private void InstanceOnOnGoal(Level.CompletedState s)
	{
	}

	[Token(Token = "0x60022B7")]
	[Address(RVA = "0x15327F0", Offset = "0x15327F0", VA = "0x15327F0")]
	private void GoalOnOnGoalProgress(int playerIndex, string s)
	{
	}

	[Token(Token = "0x60022B8")]
	[Address(RVA = "0x153281C", Offset = "0x153281C", VA = "0x153281C")]
	private void InstanceOnReset()
	{
	}

	[Token(Token = "0x60022B9")]
	[Address(RVA = "0x1532858", Offset = "0x1532858", VA = "0x1532858", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60022BA")]
	[Address(RVA = "0x153290C", Offset = "0x153290C", VA = "0x153290C", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60022BB")]
	[Address(RVA = "0x1532A50", Offset = "0x1532A50", VA = "0x1532A50")]
	public LimitedShotsShooter()
	{
	}
}
