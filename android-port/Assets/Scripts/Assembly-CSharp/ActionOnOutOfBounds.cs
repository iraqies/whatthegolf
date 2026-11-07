using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000330")]
public class ActionOnOutOfBounds : MonoBehaviour
{
	[Token(Token = "0x40011A7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UnityEvent OnOutOfBounds;

	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0x140478C", Offset = "0x140478C", VA = "0x140478C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x140483C", Offset = "0x140483C", VA = "0x140483C")]
	public ActionOnOutOfBounds()
	{
	}
}
