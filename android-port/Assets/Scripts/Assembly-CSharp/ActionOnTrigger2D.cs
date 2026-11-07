using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000CF5")]
public class ActionOnTrigger2D : MonoBehaviour
{
	[Token(Token = "0x4004663")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnTriggerEnter;

	[Token(Token = "0x6003D44")]
	[Address(RVA = "0x1404924", Offset = "0x1404924", VA = "0x1404924")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003D45")]
	[Address(RVA = "0x1404938", Offset = "0x1404938", VA = "0x1404938")]
	public ActionOnTrigger2D()
	{
	}
}
