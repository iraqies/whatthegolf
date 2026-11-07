using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E22")]
public class OverworldFlagOnCompleteOnce : MonoBehaviour
{
	[Token(Token = "0x4004CBA")]
	[FieldOffset(Offset = "0x18")]
	private OverworldGoal thisFlag;

	[Token(Token = "0x4004CBB")]
	[FieldOffset(Offset = "0x20")]
	private bool wasAlreadyCompleted;

	[Token(Token = "0x4004CBC")]
	[FieldOffset(Offset = "0x21")]
	private bool exploded;

	[Token(Token = "0x4004CBD")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent onFlagCompleteFirstTime;

	[Token(Token = "0x4004CBE")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent onFlagAlreadyCompleted;

	[Token(Token = "0x6004255")]
	[Address(RVA = "0x15B7644", Offset = "0x15B7644", VA = "0x15B7644")]
	private void Start()
	{
	}

	[Token(Token = "0x6004256")]
	[Address(RVA = "0x15B76B4", Offset = "0x15B76B4", VA = "0x15B76B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6004257")]
	[Address(RVA = "0x15B7718", Offset = "0x15B7718", VA = "0x15B7718")]
	public OverworldFlagOnCompleteOnce()
	{
	}
}
