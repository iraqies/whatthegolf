using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200076D")]
public class FollowArrow : MonoBehaviour
{
	[Token(Token = "0x4002755")]
	[FieldOffset(Offset = "0x18")]
	public BallShooter shooter;

	[Token(Token = "0x4002756")]
	[FieldOffset(Offset = "0x20")]
	private bool isAdjusting;

	[Token(Token = "0x6002234")]
	[Address(RVA = "0x146ED08", Offset = "0x146ED08", VA = "0x146ED08")]
	private void Start()
	{
	}

	[Token(Token = "0x6002235")]
	[Address(RVA = "0x146EE68", Offset = "0x146EE68", VA = "0x146EE68")]
	private void UpdateFollow(Vector3 boost, bool t)
	{
	}

	[Token(Token = "0x6002236")]
	[Address(RVA = "0x146EF38", Offset = "0x146EF38", VA = "0x146EF38")]
	private void Shooter_OnShoot(Vector2 obj)
	{
	}

	[Token(Token = "0x6002237")]
	[Address(RVA = "0x146EF40", Offset = "0x146EF40", VA = "0x146EF40")]
	public FollowArrow()
	{
	}
}
