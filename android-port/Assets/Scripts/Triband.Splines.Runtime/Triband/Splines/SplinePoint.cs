using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	[Token(Token = "0x2000007")]
	public sealed class SplinePoint
	{
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 m_Position;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Quaternion m_Rotation;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 m_LeftTangent;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 m_RightTangent;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private HandleMode m_HandleMode;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TangentMode m_LeftTangentMode;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TangentMode m_RightTangentMode;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 m_Up;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x60")]
		private Spline m_Spline;

		[Token(Token = "0x1700000B")]
		public Spline spline
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x2A0908C", Offset = "0x2A0908C", VA = "0x2A0908C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x2A09094", Offset = "0x2A09094", VA = "0x2A09094")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Vector3 position
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x2A0909C", Offset = "0x2A0909C", VA = "0x2A0909C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2A0318C", Offset = "0x2A0318C", VA = "0x2A0318C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Vector3 leftTangent
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x2A09340", Offset = "0x2A09340", VA = "0x2A09340")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x2A0464C", Offset = "0x2A0464C", VA = "0x2A0464C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Vector3 rightTangent
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x2A098D8", Offset = "0x2A098D8", VA = "0x2A098D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x2A04654", Offset = "0x2A04654", VA = "0x2A04654")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public HandleMode handleMode
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x2A099B8", Offset = "0x2A099B8", VA = "0x2A099B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x2A048D4", Offset = "0x2A048D4", VA = "0x2A048D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public TangentMode leftTangentMode
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2A09EEC", Offset = "0x2A09EEC", VA = "0x2A09EEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2A048D8", Offset = "0x2A048D8", VA = "0x2A048D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public TangentMode rightTangentMode
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2A0A1D8", Offset = "0x2A0A1D8", VA = "0x2A0A1D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2A048E0", Offset = "0x2A048E0", VA = "0x2A048E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public Vector3 up
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x2A0A1E0", Offset = "0x2A0A1E0", VA = "0x2A0A1E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2A02B3C", Offset = "0x2A02B3C", VA = "0x2A02B3C")]
		internal SplinePoint(Spline spline, Vector3 position, Quaternion rotation, Vector3 leftTangent, Vector3 rightTangent, Vector3 up)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2A03A70", Offset = "0x2A03A70", VA = "0x2A03A70")]
		internal SplinePoint(Spline spline, Vector3 position, Quaternion rotation, Vector3 leftTangent, Vector3 rightTangent, Vector3 up, HandleMode handleMode, TangentMode leftTangentMode, TangentMode rightTangentMode)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2A04110", Offset = "0x2A04110", VA = "0x2A04110")]
		public Vector3 GetTangent(TangentDirection direction)
		{
			return default;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2A0A1EC", Offset = "0x2A0A1EC", VA = "0x2A0A1EC")]
		public SplinePoint GetPreviousPoint()
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2A0A2D0", Offset = "0x2A0A2D0", VA = "0x2A0A2D0")]
		public SplinePoint GetNextPoint()
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2A09420", Offset = "0x2A09420", VA = "0x2A09420")]
		public Vector3 GetLinearTangent(TangentDirection direction)
		{
			return default;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2A090A8", Offset = "0x2A090A8", VA = "0x2A090A8")]
		private void UpdatePosition(Vector3 position)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2A09528", Offset = "0x2A09528", VA = "0x2A09528")]
		private void UpdateTangent(Vector3 value, TangentDirection direction)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2A099C0", Offset = "0x2A099C0", VA = "0x2A099C0")]
		private void UpdateHandleMode(HandleMode mode)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2A09EF4", Offset = "0x2A09EF4", VA = "0x2A09EF4")]
		private void UpdateTangentMode(TangentMode mode, TangentDirection direction)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2A04D60", Offset = "0x2A04D60", VA = "0x2A04D60")]
		internal void RecursivelyAutoSmoothTangents()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2A0A3C0", Offset = "0x2A0A3C0", VA = "0x2A0A3C0")]
		public bool AutoSmoothTangents()
		{
			return default;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2A0A76C", Offset = "0x2A0A76C", VA = "0x2A0A76C")]
		public void AutoSmoothTangentsOnPreviousPoint(SplinePoint recursionOrigin)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2A0A7B0", Offset = "0x2A0A7B0", VA = "0x2A0A7B0")]
		public void AutoSmoothTangentsOnNextPoint(SplinePoint recursionOrigin)
		{
		}
	}
}
