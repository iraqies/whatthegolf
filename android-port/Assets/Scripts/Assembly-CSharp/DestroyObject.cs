using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E7F")]
public class DestroyObject : MonoBehaviour
{
	[Token(Token = "0x4004E61")]
	[FieldOffset(Offset = "0x18")]
	public GameObject objectToDestroy;

	[Token(Token = "0x60043C1")]
	[Address(RVA = "0x18DAD14", Offset = "0x18DAD14", VA = "0x18DAD14")]
	private void Start()
	{
	}

	[Token(Token = "0x60043C2")]
	[Address(RVA = "0x18DADA8", Offset = "0x18DADA8", VA = "0x18DADA8")]
	public void Destroy()
	{
	}

	[Token(Token = "0x60043C3")]
	[Address(RVA = "0x18DAE20", Offset = "0x18DAE20", VA = "0x18DAE20")]
	public DestroyObject()
	{
	}
}
