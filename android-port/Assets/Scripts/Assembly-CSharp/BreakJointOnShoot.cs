using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000205")]
public class BreakJointOnShoot : MonoBehaviour
{
	[Token(Token = "0x40009E4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x40009E5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Joint joint;

	[Token(Token = "0x600090C")]
	[Address(RVA = "0x1706060", Offset = "0x1706060", VA = "0x1706060")]
	private void Start()
	{
	}

	[Token(Token = "0x600090D")]
	[Address(RVA = "0x1706110", Offset = "0x1706110", VA = "0x1706110")]
	private void Controller_OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600090E")]
	[Address(RVA = "0x1706204", Offset = "0x1706204", VA = "0x1706204")]
	public BreakJointOnShoot()
	{
	}
}
