using UnityEngine;

namespace ch.sycoforge.Decal.Projectors
{
	internal class SkinnedBoxProjector : BoxProjector
	{
		internal SkinnedBoxProjector(EasyDecal decal)
			: base(null)
		{
		}

		internal override void Project()
		{
		}

		private void ProjectUsingList()
		{
		}

		private void ProjectUsingEnviroment()
		{
		}

		protected override void ProcessReceiver(GameObject receiver, int recursiveStepUp, int recursiveStepDown, bool ignoreTerrain = true)
		{
		}

		private void AddMesh(SkinnedMeshRenderer renderer, Transform receiver, Matrix4x4 localToWorld)
		{
		}

		public static Mesh BakeNoScale(SkinnedMeshRenderer skin)
		{
			return null;
		}
	}
}
