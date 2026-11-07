using System;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameObjectBasedOnPlatform : MonoBehaviour
{
	[Serializable]
	public class PlatformToggle
	{
		public RuntimePlatform Platform;

		public bool State;
	}

	public List<PlatformToggle> Platforms;

	private void Awake()
	{
	}
}
