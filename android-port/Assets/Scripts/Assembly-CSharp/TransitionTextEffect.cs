using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000589")]
public abstract class TransitionTextEffect : MonoBehaviour
{
	[Token(Token = "0x170002C0")]
	public abstract bool IsBusy
	{
		[Token(Token = "0x600193D")]
		get;
	}

	[Token(Token = "0x600193A")]
	public abstract void Initialize();

	[Token(Token = "0x600193B")]
	public abstract void Prepare([Optional] string text, bool onTheSide = false);

	[Token(Token = "0x600193C")]
	public abstract IEnumerator Show(float transitionInDuration);

	[Token(Token = "0x600193E")]
	public abstract IEnumerator Hide(float transitionOutDuration);

	[Token(Token = "0x600193F")]
	[Address(RVA = "0x172C8D4", Offset = "0x172C8D4", VA = "0x172C8D4")]
	protected TransitionTextEffect()
	{
	}
}
