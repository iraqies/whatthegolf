using UnityEngine;
using UnityEngine.Rendering;

namespace StylizedWater
{
	[ExecuteInEditMode]
	public class StylizedWaterShadowCaster : MonoBehaviour
	{
		private CommandBuffer cmd;

		public Light dirLight;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
