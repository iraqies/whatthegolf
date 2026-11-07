using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007B0")]
public class ObjectCleanup : MonoBehaviour
{
	[Token(Token = "0x400288E")]
	[FieldOffset(Offset = "0x18")]
	public string objectToCleanUpName;

	[Token(Token = "0x400288F")]
	[FieldOffset(Offset = "0x20")]
	private GameObject objectToCleanUp;

	[Token(Token = "0x6002334")]
	[Address(RVA = "0x15918AC", Offset = "0x15918AC", VA = "0x15918AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002335")]
	[Address(RVA = "0x15918F8", Offset = "0x15918F8", VA = "0x15918F8")]
	public ObjectCleanup()
	{
	}
}
