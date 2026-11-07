using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E63")]
public class ActionOnTreeCount : MonoBehaviour
{
	[Token(Token = "0x4004DEE")]
	[FieldOffset(Offset = "0x18")]
	private TotalTreeCounter counter;

	[Token(Token = "0x4004DEF")]
	[FieldOffset(Offset = "0x20")]
	private int amountOfHits;

	[Token(Token = "0x4004DF0")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent OnAction1;

	[Token(Token = "0x4004DF1")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent OnAction2;

	[Token(Token = "0x4004DF2")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnAction3;

	[Token(Token = "0x600434C")]
	[Address(RVA = "0x1404844", Offset = "0x1404844", VA = "0x1404844")]
	private void Start()
	{
	}

	[Token(Token = "0x600434D")]
	[Address(RVA = "0x14048A0", Offset = "0x14048A0", VA = "0x14048A0")]
	private void Update()
	{
	}

	[Token(Token = "0x600434E")]
	[Address(RVA = "0x1404914", Offset = "0x1404914", VA = "0x1404914")]
	public ActionOnTreeCount()
	{
	}
}
