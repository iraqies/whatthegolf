using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Serializable]
	[Token(Token = "0x2000005")]
	public sealed class CanvasParameters : ScriptableObject
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_Width;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int m_Height;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_Density;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_DensityChanged;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_TempDensity;

		[Token(Token = "0x1700000E")]
		public int width
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x29FA7A8", Offset = "0x29FA7A8", VA = "0x29FA7A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x29FA7B0", Offset = "0x29FA7B0", VA = "0x29FA7B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int height
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x29FA7B8", Offset = "0x29FA7B8", VA = "0x29FA7B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x29FA7C0", Offset = "0x29FA7C0", VA = "0x29FA7C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public int density
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x29FA7C8", Offset = "0x29FA7C8", VA = "0x29FA7C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x29FA7D0", Offset = "0x29FA7D0", VA = "0x29FA7D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public bool densityChanged
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x29FA7D8", Offset = "0x29FA7D8", VA = "0x29FA7D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x29FA7E0", Offset = "0x29FA7E0", VA = "0x29FA7E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public int tempDensity
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x29FA7E8", Offset = "0x29FA7E8", VA = "0x29FA7E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x29FA7F0", Offset = "0x29FA7F0", VA = "0x29FA7F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public float scaleX
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x29FA7F8", Offset = "0x29FA7F8", VA = "0x29FA7F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000014")]
		public float scaleY
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x29FA818", Offset = "0x29FA818", VA = "0x29FA818")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000015")]
		public float invScaleX
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x29FA834", Offset = "0x29FA834", VA = "0x29FA834")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000016")]
		public float invScaleY
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x29FA85C", Offset = "0x29FA85C", VA = "0x29FA85C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000017")]
		public int pointCount
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x29FA880", Offset = "0x29FA880", VA = "0x29FA880")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000018")]
		public Matrix4x4 fieldToLocalMatrix
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x29FA88C", Offset = "0x29FA88C", VA = "0x29FA88C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000019")]
		public Matrix4x4 localToFieldMatrix
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x29FA958", Offset = "0x29FA958", VA = "0x29FA958")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x29FA770", Offset = "0x29FA770", VA = "0x29FA770")]
		public CanvasParameters()
		{
		}
	}
}
