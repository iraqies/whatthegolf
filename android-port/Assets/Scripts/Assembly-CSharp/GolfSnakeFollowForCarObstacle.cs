using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D7F")]
public class GolfSnakeFollowForCarObstacle : MonoBehaviour
{
	[Token(Token = "0x2000D80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A78", Offset = "0x44A78")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4004969")]
		[FieldOffset(Offset = "0x10")]
		public GolfSnakeFollowForCarObstacle _003C_003E4__this;

		[Token(Token = "0x400496A")]
		[FieldOffset(Offset = "0x18")]
		public GameObject clone;

		[Token(Token = "0x6003F76")]
		[Address(RVA = "0x17B5F64", Offset = "0x17B5F64", VA = "0x17B5F64")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6003F77")]
		[Address(RVA = "0x17B5F6C", Offset = "0x17B5F6C", VA = "0x17B5F6C")]
		internal void _003COnCollisionEnter_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4004966")]
	[FieldOffset(Offset = "0x18")]
	public GameObject flatGolfBallPrefab;

	[Token(Token = "0x4004967")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnCollision;

	[Token(Token = "0x4004968")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 flatBallScale;

	[Token(Token = "0x6003F73")]
	[Address(RVA = "0x14A433C", Offset = "0x14A433C", VA = "0x14A433C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003F74")]
	[Address(RVA = "0x14A4380", Offset = "0x14A4380", VA = "0x14A4380")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6003F75")]
	[Address(RVA = "0x14A4720", Offset = "0x14A4720", VA = "0x14A4720")]
	public GolfSnakeFollowForCarObstacle()
	{
	}
}
