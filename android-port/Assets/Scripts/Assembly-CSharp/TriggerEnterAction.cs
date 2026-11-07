using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E35")]
public class TriggerEnterAction : MonoBehaviour
{
	[Token(Token = "0x4004D14")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent<GameObject> triggerEntered;

	[Token(Token = "0x60042A0")]
	[Address(RVA = "0x172DD60", Offset = "0x172DD60", VA = "0x172DD60")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60042A1")]
	[Address(RVA = "0x172DDE8", Offset = "0x172DDE8", VA = "0x172DDE8")]
	public TriggerEnterAction()
	{
	}
}
