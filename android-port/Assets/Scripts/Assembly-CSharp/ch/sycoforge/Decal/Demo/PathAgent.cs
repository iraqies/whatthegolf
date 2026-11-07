using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ch.sycoforge.Decal.Demo
{
	public class PathAgent : MonoBehaviour
	{
		public float PathThickness;

		public float NormalPathOffset;

		public float Radius;

		public float AngleThreshold;

		public bool DrawGizmos;

		public EasyDecal TargetAimDecal;

		public GameObject TargetPointDecalPrefab;

		private List<Vector3> path;

		private NavMeshAgent agent;

		private LineRenderer lineRenderer;

		private Vector3 decalOffset;

		private const int MAXDISTANCE = 50;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SetTarget(Ray mouseRay)
		{
		}

		private void CreatePath(Ray mouseRay)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
