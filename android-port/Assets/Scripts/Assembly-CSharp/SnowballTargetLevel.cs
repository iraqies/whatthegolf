using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000033")]
public class SnowballTargetLevel : MonoBehaviour
{
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x18")]
	public List<SnowBallTargetBehaviour> Targets;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UnityEvent OnTargetsDown;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool WinOnTargetsHit;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x16BCE40", Offset = "0x16BCE40", VA = "0x16BCE40")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x16BD094", Offset = "0x16BD094", VA = "0x16BD094")]
	private void OnCollapsed(SnowBallTargetBehaviour snowBallTargetBehaviour)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x16BD164", Offset = "0x16BD164", VA = "0x16BD164")]
	public SnowballTargetLevel()
	{
	}
}
