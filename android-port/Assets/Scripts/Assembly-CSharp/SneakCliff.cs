using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DDD")]
public class SneakCliff : MonoBehaviour
{
	[Token(Token = "0x4004B83")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator _animator;

	[Token(Token = "0x4004B84")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int Stop;

	[Token(Token = "0x4004B85")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int Walk;

	[Token(Token = "0x6004152")]
	[Address(RVA = "0x16BA4E8", Offset = "0x16BA4E8", VA = "0x16BA4E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6004153")]
	[Address(RVA = "0x16BA63C", Offset = "0x16BA63C", VA = "0x16BA63C")]
	private void OnStop()
	{
	}

	[Token(Token = "0x6004154")]
	[Address(RVA = "0x16BA6E4", Offset = "0x16BA6E4", VA = "0x16BA6E4")]
	private void OnMove()
	{
	}

	[Token(Token = "0x6004155")]
	[Address(RVA = "0x16BA78C", Offset = "0x16BA78C", VA = "0x16BA78C")]
	public SneakCliff()
	{
	}
}
