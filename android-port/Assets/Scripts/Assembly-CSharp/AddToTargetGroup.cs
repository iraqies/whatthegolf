using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D5B")]
public class AddToTargetGroup : MonoBehaviour
{
	[Token(Token = "0x4004898")]
	[FieldOffset(Offset = "0x18")]
	public CinemachineTargetGroup targetGroup;

	[Token(Token = "0x4004899")]
	[FieldOffset(Offset = "0x20")]
	private bool isAdded;

	[Token(Token = "0x6003ED4")]
	[Address(RVA = "0x1408AF4", Offset = "0x1408AF4", VA = "0x1408AF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6003ED5")]
	[Address(RVA = "0x1408BB0", Offset = "0x1408BB0", VA = "0x1408BB0")]
	public void AddTarget()
	{
	}

	[Token(Token = "0x6003ED6")]
	[Address(RVA = "0x1408C10", Offset = "0x1408C10", VA = "0x1408C10")]
	public AddToTargetGroup()
	{
	}
}
