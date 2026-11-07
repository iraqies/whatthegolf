using System;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal.Projectors
{
	[Serializable]
	public abstract class Projector
	{
		protected DynamicMesh dynamicMesh;

		protected int id;

		protected EasyDecal Parent { get; set; }

		public DynamicMesh Mesh => null;

		public virtual bool IsVisible => false;

		internal Projector(EasyDecal decal, RecreationMode mode)
		{
		}

		internal virtual void Reset()
		{
		}

		internal virtual void Update()
		{
		}

		internal void UpdateVertexColor()
		{
		}

		internal virtual void OnGeometryPropertyChanged()
		{
		}

		internal virtual void OnAlphaChanged()
		{
		}

		internal virtual void OnBakeStatusChanged()
		{
		}

		internal virtual void OnFadeOutStarted()
		{
		}

		internal virtual void DrawGizmos(bool selected)
		{
		}

		internal abstract void Project();
	}
}
