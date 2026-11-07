using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C61")]
public class ToggleGameobjectOnShot : MonoBehaviour
{
	[Token(Token = "0x40043EB")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> Objects;

	[Token(Token = "0x40043EC")]
	[FieldOffset(Offset = "0x20")]
	public bool OnlyOnce;

	[Token(Token = "0x40043ED")]
	[FieldOffset(Offset = "0x21")]
	public bool StartState;

	[Token(Token = "0x40043EE")]
	[FieldOffset(Offset = "0x22")]
	private bool hasBeenToggled;

	[Token(Token = "0x6003ACC")]
	[Address(RVA = "0x171A84C", Offset = "0x171A84C", VA = "0x171A84C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003ACD")]
	[Address(RVA = "0x171AA2C", Offset = "0x171AA2C", VA = "0x171AA2C")]
	private void BallOnOnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x6003ACE")]
	[Address(RVA = "0x171ABAC", Offset = "0x171ABAC", VA = "0x171ABAC")]
	public ToggleGameobjectOnShot()
	{
	}
}
