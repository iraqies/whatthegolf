using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000DE5")]
public class TotalTreeCounter : MonoBehaviour
{
	[Token(Token = "0x4004BBA")]
	[FieldOffset(Offset = "0x18")]
	public int amountOfTrees;

	[Token(Token = "0x4004BBB")]
	[FieldOffset(Offset = "0x1C")]
	public int totalTreesPopped;

	[Token(Token = "0x4004BBC")]
	[FieldOffset(Offset = "0x20")]
	public UnityEvent OnAllPopped;

	[Token(Token = "0x6004172")]
	[Address(RVA = "0x171E4A8", Offset = "0x171E4A8", VA = "0x171E4A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6004173")]
	[Address(RVA = "0x171E4D4", Offset = "0x171E4D4", VA = "0x171E4D4")]
	public TotalTreeCounter()
	{
	}
}
