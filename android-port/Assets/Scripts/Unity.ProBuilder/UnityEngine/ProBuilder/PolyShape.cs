using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x2000013")]
	[DisallowMultipleComponent]
	internal sealed class PolyShape : MonoBehaviour
	{
		[Token(Token = "0x2000014")]
		public enum PolyEditMode
		{
			[Token(Token = "0x4000047")]
			None = 0,
			[Token(Token = "0x4000048")]
			Path = 1,
			[Token(Token = "0x4000049")]
			Height = 2,
			[Token(Token = "0x400004A")]
			Edit = 3
		}

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x18")]
		private ProBuilderMesh m_Mesh;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5FFC", Offset = "0x1B5FFC")]
		internal List<Vector3> m_Points;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6048", Offset = "0x1B6048")]
		[SerializeField]
		private float m_Extrude;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B6094", Offset = "0x1B6094")]
		private PolyEditMode m_EditMode;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B60E0", Offset = "0x1B60E0")]
		private bool m_FlipNormals;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		internal bool isOnGrid;

		[Token(Token = "0x1700001B")]
		public ReadOnlyCollection<Vector3> controlPoints
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x2A4D9B8", Offset = "0x2A4D9B8", VA = "0x2A4D9B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public float extrude
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x2A4DA98", Offset = "0x2A4DA98", VA = "0x2A4DA98")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x2A4DAA0", Offset = "0x2A4DAA0", VA = "0x2A4DAA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public PolyEditMode polyEditMode
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x2A4DAA8", Offset = "0x2A4DAA8", VA = "0x2A4DAA8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x2A4DAB0", Offset = "0x2A4DAB0", VA = "0x2A4DAB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool flipNormals
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x2A4DAB8", Offset = "0x2A4DAB8", VA = "0x2A4DAB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x2A4DAC0", Offset = "0x2A4DAC0", VA = "0x2A4DAC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public ProBuilderMesh mesh
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x2A4DAC8", Offset = "0x2A4DAC8", VA = "0x2A4DAC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x2A4DB74", Offset = "0x2A4DB74", VA = "0x2A4DB74")]
			set
			{
			}
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2A4DA38", Offset = "0x2A4DA38", VA = "0x2A4DA38")]
		public void SetControlPoints(IList<Vector3> points)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2A4DB7C", Offset = "0x2A4DB7C", VA = "0x2A4DB7C")]
		private bool IsSnapEnabled()
		{
			return default;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2A4DB84", Offset = "0x2A4DB84", VA = "0x2A4DB84")]
		public PolyShape()
		{
		}
	}
}
