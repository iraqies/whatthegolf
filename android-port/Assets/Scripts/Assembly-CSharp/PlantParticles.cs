using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlantParticles : MonoBehaviour
{
	public enum PlantType
	{
		office = 0,
		sawable = 1,
		door = 2
	}

	public PlantType type;

	[CompilerGenerated]
	private Action<PlantParticles, int> m_OnParticles;

	public event Action<PlantParticles, int> OnParticles
	{
		[CompilerGenerated]
		add
		{
			m_OnParticles = (Action<PlantParticles, int>)Delegate.Combine(m_OnParticles, value);
		}
		[CompilerGenerated]
		remove
		{
			m_OnParticles = (Action<PlantParticles, int>)Delegate.Remove(m_OnParticles, value);
		}
	}

	public void Emit(int amount)
	{
		m_OnParticles?.Invoke(this, amount);
	}
}
