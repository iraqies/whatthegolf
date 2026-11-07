using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors
{
	[Serializable]
	[Token(Token = "0x2000039")]
	internal class RayProjector : Projector
	{
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x28")]
		private float width;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x2C")]
		private float length;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x30")]
		internal Vector3[] sourceVertices;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x38")]
		internal Vector2[] sourceUVs;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x40")]
		internal int[] sourceTriangles;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x48")]
		internal HashSet<int> invalidIndices;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x50")]
		internal List<int> validIndices;

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2C6BC0C", Offset = "0x2C6BC0C", VA = "0x2C6BC0C")]
		internal RayProjector(EasyDecal decal)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2C6BCFC", Offset = "0x2C6BCFC", VA = "0x2C6BCFC")]
		private void CreateProjectionGrid()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2C6BE3C", Offset = "0x2C6BE3C", VA = "0x2C6BE3C")]
		private void CreatePlaneMesh()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2C6C060", Offset = "0x2C6C060", VA = "0x2C6C060", Slot = "7")]
		internal override void OnGeometryPropertyChanged()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2C6C084", Offset = "0x2C6C084", VA = "0x2C6C084", Slot = "12")]
		internal override void Project()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2C6CDD4", Offset = "0x2C6CDD4", VA = "0x2C6CDD4", Slot = "11")]
		internal override void DrawGizmos(bool selected)
		{
		}
	}
}
