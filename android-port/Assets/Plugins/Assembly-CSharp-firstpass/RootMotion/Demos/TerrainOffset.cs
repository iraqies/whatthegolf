using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001E6")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000CBD")]
		[FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x13199FC", Offset = "0x13199FC", VA = "0x13199FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x1319B70", Offset = "0x1319B70", VA = "0x1319B70")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default;
		}

		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x1319D2C", Offset = "0x1319D2C", VA = "0x1319D2C")]
		public TerrainOffset()
		{
		}
	}
}
