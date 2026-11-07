using System;
using System.Collections.Generic;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal.Projectors
{
	[Serializable]
	internal class RayProjector : Projector
	{
		private float width;

		private float length;

		internal Vector3[] sourceVertices;

		internal Vector2[] sourceUVs;

		internal int[] sourceTriangles;

		internal HashSet<int> invalidIndices;

		internal List<int> validIndices;

		internal RayProjector(EasyDecal decal)
			: base(null, RecreationMode.Always)
		{
		}

		private void CreateProjectionGrid()
		{
		}

		private void CreatePlaneMesh()
		{
		}

		internal override void OnGeometryPropertyChanged()
		{
		}

		internal override void Project()
		{
		}

		internal override void DrawGizmos(bool selected)
		{
		}
	}
}
