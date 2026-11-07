using System;
using System.Collections.Generic;

public class TransitionTextEffects
{
	private readonly Dictionary<Type, TransitionTextEffect> byType = new Dictionary<Type, TransitionTextEffect>();

	public TransitionTextEffects(List<TransitionTextEffect> transitionTextEffects)
	{
		if (transitionTextEffects != null)
		{
			foreach (var e in transitionTextEffects)
			{
				if (e != null) byType[e.GetType()] = e;
			}
		}
	}

	public T Get<T>() where T : TransitionTextEffect
	{
		if (byType.TryGetValue(typeof(T), out var val))
			return val as T;
		return null;
	}
}
