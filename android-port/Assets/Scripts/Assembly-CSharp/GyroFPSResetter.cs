using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003F5")]
public class GyroFPSResetter : MonoBehaviour
{
	[Token(Token = "0x4001599")]
	[FieldOffset(Offset = "0x18")]
	public float defaultGyroFPS;

	[Token(Token = "0x6001292")]
	[Address(RVA = "0x14C01C0", Offset = "0x14C01C0", VA = "0x14C01C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001293")]
	[Address(RVA = "0x14C0278", Offset = "0x14C0278", VA = "0x14C0278")]
	private void Instance_OnToggleOverworld(bool active)
	{
	}

	[Token(Token = "0x6001294")]
	[Address(RVA = "0x14C0358", Offset = "0x14C0358", VA = "0x14C0358")]
	public GyroFPSResetter()
	{
	}
}
