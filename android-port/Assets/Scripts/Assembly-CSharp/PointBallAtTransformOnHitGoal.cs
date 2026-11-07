using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DCD")]
public class PointBallAtTransformOnHitGoal : MonoBehaviour
{
	[Token(Token = "0x4004B46")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform _shootOutDirection;

	[Token(Token = "0x6004112")]
	[Address(RVA = "0x1604380", Offset = "0x1604380", VA = "0x1604380")]
	private void Start()
	{
	}

	[Token(Token = "0x6004113")]
	[Address(RVA = "0x1604450", Offset = "0x1604450", VA = "0x1604450")]
	private void OnHit(OverworldGoal arg1, Vector3 arg2, OverworldBall2D arg3)
	{
	}

	[Token(Token = "0x6004114")]
	[Address(RVA = "0x160448C", Offset = "0x160448C", VA = "0x160448C")]
	public PointBallAtTransformOnHitGoal()
	{
	}
}
