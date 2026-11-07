using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public class DynamicSkinnedMesh : DynamicMesh
	{
		private SkinQuality skinQuality;

		private Transform[] bones;

		private Matrix4x4[] bindPoses;

		private List<BoneWeight> bonesWeights;

		private BoneWeight[] originalBonesWeights;

		public Transform[] Bones => null;

		public List<BoneWeight> BonesWeights => null;

		internal DynamicSkinnedMesh(DecalBase parent, RecreationMode mode)
			: base(null, RecreationMode.Always)
		{
		}

		public void Add(Mesh mesh, Transform[] bones, Matrix4x4 localToWorld)
		{
		}

		internal override void RemoveRange(int startIndex, int count)
		{
		}

		protected override void OnProcessVertexIndex(int index, bool valid)
		{
		}

		public override Mesh ConvertToMesh(Mesh target, bool reset = false)
		{
			return null;
		}

		public override void Clear()
		{
		}
	}
}
