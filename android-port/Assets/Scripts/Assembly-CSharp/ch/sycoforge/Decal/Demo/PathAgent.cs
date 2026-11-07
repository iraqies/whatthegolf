using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace ch.sycoforge.Decal.Demo
{
	[Token(Token = "0x2000F49")]
	[Attribute(Name = "RequireComponent", RVA = "0x45924", Offset = "0x45924")]
	[Attribute(Name = "RequireComponent", RVA = "0x45924", Offset = "0x45924")]
	public class PathAgent : MonoBehaviour
	{
		[Token(Token = "0x4005289")]
		[FieldOffset(Offset = "0x18")]
		public float PathThickness;

		[Token(Token = "0x400528A")]
		[FieldOffset(Offset = "0x1C")]
		public float NormalPathOffset;

		[Token(Token = "0x400528B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x54274", Offset = "0x54274")]
		public float Radius;

		[Token(Token = "0x400528C")]
		[FieldOffset(Offset = "0x24")]
		public float AngleThreshold;

		[Token(Token = "0x400528D")]
		[FieldOffset(Offset = "0x28")]
		public bool DrawGizmos;

		[Token(Token = "0x400528E")]
		[FieldOffset(Offset = "0x30")]
		public EasyDecal TargetAimDecal;

		[Token(Token = "0x400528F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject TargetPointDecalPrefab;

		[Token(Token = "0x4005290")]
		[FieldOffset(Offset = "0x40")]
		private List<Vector3> path;

		[Token(Token = "0x4005291")]
		[FieldOffset(Offset = "0x48")]
		private NavMeshAgent agent;

		[Token(Token = "0x4005292")]
		[FieldOffset(Offset = "0x50")]
		private LineRenderer lineRenderer;

		[Token(Token = "0x4005293")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 decalOffset;

		[Token(Token = "0x4005294")]
		private const int MAXDISTANCE = 50;

		[Token(Token = "0x600476A")]
		[Address(RVA = "0x15DCAB0", Offset = "0x15DCAB0", VA = "0x15DCAB0")]
		private void Start()
		{
		}

		[Token(Token = "0x600476B")]
		[Address(RVA = "0x15DCB54", Offset = "0x15DCB54", VA = "0x15DCB54")]
		private void Update()
		{
		}

		[Token(Token = "0x600476C")]
		[Address(RVA = "0x15DCFBC", Offset = "0x15DCFBC", VA = "0x15DCFBC")]
		private void SetTarget(Ray mouseRay)
		{
		}

		[Token(Token = "0x600476D")]
		[Address(RVA = "0x15DCBC4", Offset = "0x15DCBC4", VA = "0x15DCBC4")]
		private void CreatePath(Ray mouseRay)
		{
		}

		[Token(Token = "0x600476E")]
		[Address(RVA = "0x15DD13C", Offset = "0x15DD13C", VA = "0x15DD13C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600476F")]
		[Address(RVA = "0x15DD2A8", Offset = "0x15DD2A8", VA = "0x15DD2A8")]
		public PathAgent()
		{
		}
	}
}
