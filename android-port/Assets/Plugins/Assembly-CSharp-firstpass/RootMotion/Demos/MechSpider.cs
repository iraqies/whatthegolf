using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001E8")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x4000CD3")]
		[FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000CD4")]
		[FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000CD5")]
		[FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000CD6")]
		[FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000CD7")]
		[FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000CD8")]
		[FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000CD9")]
		[FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000CDA")]
		[FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000CDB")]
		[FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000CDC")]
		[FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000CDD")]
		[FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000CDE")]
		[FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000CDF")]
		[FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x4000CE0")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000CE1")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x13ABAD8", Offset = "0x13ABAD8", VA = "0x13ABAD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x13AC2FC", Offset = "0x13AC2FC", VA = "0x13AC2FC")]
		private Vector3 GetLegCentroid()
		{
			return default;
		}

		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x13AC094", Offset = "0x13AC094", VA = "0x13AC094")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default;
		}

		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x13AC410", Offset = "0x13AC410", VA = "0x13AC410")]
		public MechSpider()
		{
		}
	}
}
