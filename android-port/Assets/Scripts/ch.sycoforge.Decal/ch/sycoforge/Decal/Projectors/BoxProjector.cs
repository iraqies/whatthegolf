using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal.Projectors
{
	[Token(Token = "0x200002C")]
	public class BoxProjector : Projector
	{
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x28")]
		protected float radius;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x30")]
		protected HashSet<int> processedIds;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x38")]
		protected IMeshCutter meshCutter;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x40")]
		private CandidateProcessHandler m_OnCandidatesProcessed_;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x48")]
		private List<GameObject> hits;

		[Token(Token = "0x1400000D")]
		public event CandidateProcessHandler OnCandidatesProcessed
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x2C560F0", Offset = "0x2C560F0", VA = "0x2C560F0")]
			add
			{
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x2C56238", Offset = "0x2C56238", VA = "0x2C56238")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		private event CandidateProcessHandler OnCandidatesProcessed_
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x2C56194", Offset = "0x2C56194", VA = "0x2C56194")]
			add
			{
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x2C562DC", Offset = "0x2C562DC", VA = "0x2C562DC")]
			remove
			{
			}
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2C56380", Offset = "0x2C56380", VA = "0x2C56380")]
		internal BoxProjector(EasyDecal decal)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2C564AC", Offset = "0x2C564AC", VA = "0x2C564AC")]
		protected Collider[] FindCandidates()
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2C565D8", Offset = "0x2C565D8", VA = "0x2C565D8", Slot = "12")]
		internal override void Project()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2C56EA0", Offset = "0x2C56EA0", VA = "0x2C56EA0")]
		private void ProjectUsingList()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2C567C4", Offset = "0x2C567C4", VA = "0x2C567C4")]
		private void ProjectUsingEnvironment()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2C57DDC", Offset = "0x2C57DDC", VA = "0x2C57DDC", Slot = "13")]
		protected virtual void ProcessReceiver(GameObject receiver, int recursiveStepUp, int recursiveStepDown, bool ignoreTerrain = true)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2C57890", Offset = "0x2C57890", VA = "0x2C57890")]
		protected List<GameObject> Find(float radius)
		{
			return null;
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2C57580", Offset = "0x2C57580", VA = "0x2C57580")]
		private List<ProxyMesh> FindInProxies(float radius)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2C5750C", Offset = "0x2C5750C", VA = "0x2C5750C")]
		private void AddTerrain(GameObject receiver)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2C58594", Offset = "0x2C58594", VA = "0x2C58594")]
		private void AddTerrain(Terrain terrain)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2C57B94", Offset = "0x2C57B94", VA = "0x2C57B94")]
		private void AddMesh(GameObject receiver)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2C577A4", Offset = "0x2C577A4", VA = "0x2C577A4")]
		private void AddMesh(Mesh mesh, Transform receiver)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2C590E8", Offset = "0x2C590E8", VA = "0x2C590E8")]
		private void AddMesh(MeshCollider meshCollider, Transform receiver)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2C59228", Offset = "0x2C59228", VA = "0x2C59228")]
		private void AddMesh(BoxCollider boxCollider, Transform receiver)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2C59724", Offset = "0x2C59724", VA = "0x2C59724", Slot = "11")]
		internal override void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x60001AA")]
		private T Find<T>(IList<Collider> colliders) where T : Collider
		{
			return null;
		}
	}
}
