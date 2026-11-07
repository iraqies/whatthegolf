using System;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal.Projectors
{
	[Serializable]
	internal class SSDProjector : Projector
	{
		private static Vector3[] vertices;

		private static int[] triangles;

		internal Vector3[] normals;

		internal Vector2[] uv;

		internal Vector2[] uv2;

		internal Color[] colors;

		private bool isVisible;

		private static Vector3 extents;

		public override bool IsVisible => false;

		internal SSDProjector(EasyDecal decal)
			: base(null, RecreationMode.Always)
		{
		}

		private void CreateStatics()
		{
		}

		private void CreateDynamics()
		{
		}

		private void CreateCubeMesh()
		{
		}

		internal override void OnGeometryPropertyChanged()
		{
		}

		internal override void Update()
		{
		}

		internal override void Project()
		{
		}

		private void InitializeProjectionCube()
		{
		}

		internal override void DrawGizmos(bool selected)
		{
		}
	}
}
