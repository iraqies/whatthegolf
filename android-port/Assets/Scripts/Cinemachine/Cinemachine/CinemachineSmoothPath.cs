using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000029")]
	public class CinemachineSmoothPath : CinemachinePathBase
	{
		[Serializable]
		[Token(Token = "0x200002A")]
		public struct Waypoint
		{
			[Token(Token = "0x40000D3")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0xC")]
			public float roll;

			[Token(Token = "0x17000035")]
			internal Vector4 AsVector4
			{
				[Token(Token = "0x60000FD")]
				[Address(RVA = "0x19119A0", Offset = "0x19119A0", VA = "0x19119A0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x19119D8", Offset = "0x19119D8", VA = "0x19119D8")]
			internal static Waypoint FromVector4(Vector4 v)
			{
				return default;
			}
		}

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x48")]
		public bool m_Looped;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x50")]
		public Waypoint[] m_Waypoints;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x58")]
		private Waypoint[] m_ControlPoints1;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x60")]
		private Waypoint[] m_ControlPoints2;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsLoopedCache;

		[Token(Token = "0x17000031")]
		public override float MinPos
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x18FE1A8", Offset = "0x18FE1A8", VA = "0x18FE1A8", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000032")]
		public override float MaxPos
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x18FE1B0", Offset = "0x18FE1B0", VA = "0x18FE1B0", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000033")]
		public override bool Looped
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x18FE1F0", Offset = "0x18FE1F0", VA = "0x18FE1F0", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000034")]
		public override int DistanceCacheSampleStepsPerSegment
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x18FE1F8", Offset = "0x18FE1F8", VA = "0x18FE1F8", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x18FE200", Offset = "0x18FE200", VA = "0x18FE200")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x18FE210", Offset = "0x18FE210", VA = "0x18FE210")]
		private void Reset()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x18FE2E0", Offset = "0x18FE2E0", VA = "0x18FE2E0", Slot = "14")]
		public override void InvalidateDistanceCache()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x18FE2F0", Offset = "0x18FE2F0", VA = "0x18FE2F0")]
		private void UpdateControlPoints()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x18FE590", Offset = "0x18FE590", VA = "0x18FE590")]
		private float GetBoundingIndices(float pos, out int indexA, out int indexB)
		{
			return default;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x18FE670", Offset = "0x18FE670", VA = "0x18FE670", Slot = "8")]
		public override Vector3 EvaluatePosition(float pos)
		{
			return default;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x18FE868", Offset = "0x18FE868", VA = "0x18FE868", Slot = "9")]
		public override Vector3 EvaluateTangent(float pos)
		{
			return default;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x18FEABC", Offset = "0x18FEABC", VA = "0x18FEABC", Slot = "10")]
		public override Quaternion EvaluateOrientation(float pos)
		{
			return default;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x18FEDC4", Offset = "0x18FEDC4", VA = "0x18FEDC4")]
		public CinemachineSmoothPath()
		{
		}
	}
}
