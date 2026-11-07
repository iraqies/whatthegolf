using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D5A")]
public class AddToFoundTargetGroup : MonoBehaviour
{
	[Token(Token = "0x4004896")]
	[FieldOffset(Offset = "0x18")]
	public CinemachineTargetGroup targetGroup;

	[Token(Token = "0x4004897")]
	[FieldOffset(Offset = "0x20")]
	private bool isAdded;

	[Token(Token = "0x6003ED2")]
	[Address(RVA = "0x1408988", Offset = "0x1408988", VA = "0x1408988")]
	public void AddTarget()
	{
	}

	[Token(Token = "0x6003ED3")]
	[Address(RVA = "0x14089E8", Offset = "0x14089E8", VA = "0x14089E8")]
	public AddToFoundTargetGroup()
	{
	}
}
