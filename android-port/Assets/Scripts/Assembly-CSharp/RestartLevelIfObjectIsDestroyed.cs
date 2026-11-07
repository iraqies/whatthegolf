using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C27")]
public class RestartLevelIfObjectIsDestroyed : MonoBehaviour
{
	[Token(Token = "0x4004308")]
	[FieldOffset(Offset = "0x18")]
	public float Delay;

	[Token(Token = "0x6003A1E")]
	[Address(RVA = "0x164D200", Offset = "0x164D200", VA = "0x164D200")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6003A1F")]
	[Address(RVA = "0x164D2D8", Offset = "0x164D2D8", VA = "0x164D2D8")]
	public RestartLevelIfObjectIsDestroyed()
	{
	}
}
