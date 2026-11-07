using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000358")]
public class SwapDollyPath : MonoBehaviour
{
	[Token(Token = "0x400126B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CinemachineSmoothPath newPath;

	[Token(Token = "0x400126C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CinemachineDollyCart cart;

	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x16EFC3C", Offset = "0x16EFC3C", VA = "0x16EFC3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x16EFD04", Offset = "0x16EFD04", VA = "0x16EFD04")]
	private void ChangePath()
	{
	}

	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x16EFD28", Offset = "0x16EFD28", VA = "0x16EFD28")]
	public SwapDollyPath()
	{
	}
}
