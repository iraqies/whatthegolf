using System.Collections.Generic;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal.Projectors
{
	public class BoxProjector : Projector
	{
		protected float radius;

		protected HashSet<int> processedIds;

		protected IMeshCutter meshCutter;

		private CandidateProcessHandler m_OnCandidatesProcessed_;

		private List<GameObject> hits;

		public event CandidateProcessHandler OnCandidatesProcessed
		{
			add
			{
			}
			remove
			{
			}
		}

		private event CandidateProcessHandler OnCandidatesProcessed_
		{
			add
			{
			}
			remove
			{
			}
		}

		internal BoxProjector(EasyDecal decal)
			: base(null, RecreationMode.Always)
		{
		}

		protected Collider[] FindCandidates()
		{
			return null;
		}

		internal override void Project()
		{
		}

		private void ProjectUsingList()
		{
		}

		private void ProjectUsingEnvironment()
		{
		}

		protected virtual void ProcessReceiver(GameObject receiver, int recursiveStepUp, int recursiveStepDown, bool ignoreTerrain = true)
		{
		}

		protected List<GameObject> Find(float radius)
		{
			return null;
		}

		private List<ProxyMesh> FindInProxies(float radius)
		{
			return null;
		}

		private void AddTerrain(GameObject receiver)
		{
		}

		private void AddTerrain(Terrain terrain)
		{
		}

		private void AddMesh(GameObject receiver)
		{
		}

		private void AddMesh(Mesh mesh, Transform receiver)
		{
		}

		private void AddMesh(MeshCollider meshCollider, Transform receiver)
		{
		}

		private void AddMesh(BoxCollider boxCollider, Transform receiver)
		{
		}

		internal override void DrawGizmos(bool selected)
		{
		}

		private T Find<T>(IList<Collider> colliders) where T : Collider
		{
			return null;
		}
	}
}
