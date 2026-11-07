using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000DBF")]
public class OverworldFlagOnComplete : MonoBehaviour
{
	[Token(Token = "0x4004AF7")]
	[FieldOffset(Offset = "0x18")]
	private OverworldGoal thisFlag;

	[Token(Token = "0x4004AF8")]
	[FieldOffset(Offset = "0x20")]
	private bool flagIsCompleted;

	[Token(Token = "0x4004AF9")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent onFlagComplete;

	[Token(Token = "0x60040BF")]
	[Address(RVA = "0x15B7588", Offset = "0x15B7588", VA = "0x15B7588")]
	private void Start()
	{
	}

	[Token(Token = "0x60040C0")]
	[Address(RVA = "0x15B75EC", Offset = "0x15B75EC", VA = "0x15B75EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60040C1")]
	[Address(RVA = "0x15B763C", Offset = "0x15B763C", VA = "0x15B763C")]
	public OverworldFlagOnComplete()
	{
	}
}
