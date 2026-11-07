using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x200058A")]
public class TransitionTextEffects
{
	[Token(Token = "0x4001C62")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<Type, TransitionTextEffect> byType;

	[Token(Token = "0x6001940")]
	[Address(RVA = "0x172B3C0", Offset = "0x172B3C0", VA = "0x172B3C0")]
	public TransitionTextEffects(List<TransitionTextEffect> transitionTextEffects)
	{
	}

	[Token(Token = "0x6001941")]
	public T Get<T>() where T : TransitionTextEffect
	{
		return null;
	}
}
