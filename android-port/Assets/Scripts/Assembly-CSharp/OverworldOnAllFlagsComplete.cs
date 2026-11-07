using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000DC2")]
public class OverworldOnAllFlagsComplete : MonoBehaviour
{
	[Token(Token = "0x4004B05")]
	[FieldOffset(Offset = "0x18")]
	private OverworldButton2D overWorldButton;

	[Token(Token = "0x4004B06")]
	[FieldOffset(Offset = "0x20")]
	private bool allFlagsCompleted;

	[Token(Token = "0x4004B07")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent onAllFlagsCompleted;

	[Token(Token = "0x60040CF")]
	[Address(RVA = "0x15C8180", Offset = "0x15C8180", VA = "0x15C8180")]
	private void Start()
	{
	}

	[Token(Token = "0x60040D0")]
	[Address(RVA = "0x15C81E4", Offset = "0x15C81E4", VA = "0x15C81E4")]
	private void Update()
	{
	}

	[Token(Token = "0x60040D1")]
	[Address(RVA = "0x15C823C", Offset = "0x15C823C", VA = "0x15C823C")]
	public OverworldOnAllFlagsComplete()
	{
	}
}
