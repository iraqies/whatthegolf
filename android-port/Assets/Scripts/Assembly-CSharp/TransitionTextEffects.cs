using System;
using System.Collections.Generic;

public class TransitionTextEffects
{
	private readonly Dictionary<Type, TransitionTextEffect> byType;

	public TransitionTextEffects(List<TransitionTextEffect> transitionTextEffects)
	{
	}

	public T Get<T>() where T : TransitionTextEffect
	{
		return null;
	}
}
