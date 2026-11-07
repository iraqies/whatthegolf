using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000DF9")]
public class ToyButtonBehaviour : MonoBehaviour
{
	[Token(Token = "0x4004C14")]
	[FieldOffset(Offset = "0x18")]
	public bool canBePushedAgain;

	[Token(Token = "0x4004C15")]
	[FieldOffset(Offset = "0x20")]
	public Animator buttonAnimator;

	[Token(Token = "0x4004C16")]
	[FieldOffset(Offset = "0x28")]
	public ButtonConsoleBehaviour console;

	[Token(Token = "0x4004C17")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent OnButtonPushed;

	[Token(Token = "0x4004C18")]
	[FieldOffset(Offset = "0x38")]
	private bool pushed;

	[Token(Token = "0x60041CC")]
	[Address(RVA = "0x171FC8C", Offset = "0x171FC8C", VA = "0x171FC8C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60041CD")]
	[Address(RVA = "0x171FDE0", Offset = "0x171FDE0", VA = "0x171FDE0")]
	public ToyButtonBehaviour()
	{
	}
}
