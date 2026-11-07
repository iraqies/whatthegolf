using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E67")]
public class AddChildrenToTargetGroup : MonoBehaviour
{
	[Token(Token = "0x4004DFB")]
	[FieldOffset(Offset = "0x18")]
	public CinemachineTargetGroup targetGroup;

	[Token(Token = "0x4004DFC")]
	[FieldOffset(Offset = "0x20")]
	private bool isAdded;

	[Token(Token = "0x4004DFD")]
	[FieldOffset(Offset = "0x28")]
	private Transform[] children;

	[Token(Token = "0x600435B")]
	[Address(RVA = "0x14058E0", Offset = "0x14058E0", VA = "0x14058E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600435C")]
	[Address(RVA = "0x1405AFC", Offset = "0x1405AFC", VA = "0x1405AFC")]
	public void AddTarget()
	{
	}

	[Token(Token = "0x600435D")]
	[Address(RVA = "0x1405BB0", Offset = "0x1405BB0", VA = "0x1405BB0")]
	public AddChildrenToTargetGroup()
	{
	}
}
