using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D54")]
public class QuestItemBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000D55")]
	public enum Collected
	{
		[Token(Token = "0x400488B")]
		FOLLOWBALL = 0,
		[Token(Token = "0x400488C")]
		BALLONTOP = 1,
		[Token(Token = "0x400488D")]
		DISAPPEAR = 2,
		[Token(Token = "0x400488E")]
		ACTIVATE = 3
	}

	[Token(Token = "0x4004882")]
	[FieldOffset(Offset = "0x18")]
	public bool isCollected;

	[Token(Token = "0x4004883")]
	[FieldOffset(Offset = "0x1C")]
	public Collected collectedBehaviour;

	[Token(Token = "0x4004884")]
	[FieldOffset(Offset = "0x20")]
	public float FollowDistance;

	[Token(Token = "0x4004885")]
	[FieldOffset(Offset = "0x24")]
	public float FollowSpeed;

	[Token(Token = "0x4004886")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 ballOnTopOffset;

	[Token(Token = "0x4004887")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody2D rigidbody2D;

	[Token(Token = "0x4004888")]
	[FieldOffset(Offset = "0x40")]
	private OverworldBallManager ballManager;

	[Token(Token = "0x4004889")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 lastNonNullVelocity;

	[Token(Token = "0x6003EC0")]
	[Address(RVA = "0x1632794", Offset = "0x1632794", VA = "0x1632794")]
	private void Start()
	{
	}

	[Token(Token = "0x6003EC1")]
	[Address(RVA = "0x16327FC", Offset = "0x16327FC", VA = "0x16327FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6003EC2")]
	[Address(RVA = "0x16328D8", Offset = "0x16328D8", VA = "0x16328D8")]
	private void FollowBallBehaviour()
	{
	}

	[Token(Token = "0x6003EC3")]
	[Address(RVA = "0x16329F0", Offset = "0x16329F0", VA = "0x16329F0")]
	private void SetupBallOnTop()
	{
	}

	[Token(Token = "0x6003EC4")]
	[Address(RVA = "0x1632B60", Offset = "0x1632B60", VA = "0x1632B60")]
	public void DestroyAfterCompletion()
	{
	}

	[Token(Token = "0x6003EC5")]
	[Address(RVA = "0x1632C3C", Offset = "0x1632C3C", VA = "0x1632C3C")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003EC6")]
	[Address(RVA = "0x1632CD0", Offset = "0x1632CD0", VA = "0x1632CD0")]
	public QuestItemBehaviour()
	{
	}
}
