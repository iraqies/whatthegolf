using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x2001081")]
	[Attribute(Name = "RequireComponent", RVA = "0x4794C", Offset = "0x4794C")]
	public class MoveLineRendererWithTransform : MonoBehaviour
	{
		[Token(Token = "0x40056DA")]
		[FieldOffset(Offset = "0x18")]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x40056DB")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 lastTransformPosition;

		[Token(Token = "0x6004A03")]
		[Address(RVA = "0x157121C", Offset = "0x157121C", VA = "0x157121C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004A04")]
		[Address(RVA = "0x157129C", Offset = "0x157129C", VA = "0x157129C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004A05")]
		[Address(RVA = "0x1571370", Offset = "0x1571370", VA = "0x1571370")]
		public MoveLineRendererWithTransform()
		{
		}
	}
}
