using UnityEngine;

namespace Triband.MountainGeneratorTool
{
	public sealed class MountainSettings : ScriptableObject
	{
		public float TopBevelSize;

		public float TopBevelHeight;

		public float BottomBevelSize;

		public float BottomBevelHeight;

		public bool RoundCorners;

		public float Roundness;

		public float CornerSize;

		public Material TopMaterial;

		public Material CornerMaterial;

		public Material SidesMaterial;

		public string Notes;
	}
}
