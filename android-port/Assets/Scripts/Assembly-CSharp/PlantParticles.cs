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
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Emit(int amount)
	{
	}
}
