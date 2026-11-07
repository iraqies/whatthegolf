using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200049C")]
public class DisableObjectIfFlagNotCompleted : MonoBehaviour
{
	[Token(Token = "0x4001861")]
	[FieldOffset(Offset = "0x18")]
	public List<OverworldGoal> goals;

	[Token(Token = "0x6001557")]
	[Address(RVA = "0x18DD514", Offset = "0x18DD514", VA = "0x18DD514")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001558")]
	[Address(RVA = "0x18DD7D4", Offset = "0x18DD7D4", VA = "0x18DD7D4")]
	private void Goal_OnUpdateData(OverworldGoal goal)
	{
	}

	[Token(Token = "0x6001559")]
	[Address(RVA = "0x18DD82C", Offset = "0x18DD82C", VA = "0x18DD82C")]
	public DisableObjectIfFlagNotCompleted()
	{
	}
}
