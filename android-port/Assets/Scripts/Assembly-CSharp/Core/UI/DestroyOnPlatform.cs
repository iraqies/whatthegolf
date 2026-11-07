using System.Collections.Generic;
using UnityEngine;

namespace Core.UI
{
	public class DestroyOnPlatform : MonoBehaviour
	{
		public enum Behaviour
		{
			Destroy = 0,
			DeactivateComponent = 1
		}

		public List<EPlatformType> supportedPlatforms;

		[SerializeField]
		private MonoBehaviour component;

		[SerializeField]
		private Behaviour behaviour;

		private void Awake()
		{
		}
	}
}
