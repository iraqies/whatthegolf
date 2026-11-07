using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000DB7")]
public class OnCatapultedByCarpet : MonoBehaviour
{
	[Token(Token = "0x4004ACB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UnityEvent _onCatapulted;

	[Token(Token = "0x6004091")]
	[Address(RVA = "0x1596450", Offset = "0x1596450", VA = "0x1596450")]
	public void Catapult()
	{
	}

	[Token(Token = "0x6004092")]
	[Address(RVA = "0x1596464", Offset = "0x1596464", VA = "0x1596464")]
	public OnCatapultedByCarpet()
	{
	}
}
