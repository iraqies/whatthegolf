using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000042")]
	public class CinemachineGroupComposer : CinemachineComposer
	{
		[Token(Token = "0x2000043")]
		public enum FramingMode
		{
			[Token(Token = "0x400018F")]
			Horizontal = 0,
			[Token(Token = "0x4000190")]
			Vertical = 1,
			[Token(Token = "0x4000191")]
			HorizontalAndVertical = 2
		}

		[Token(Token = "0x2000044")]
		public enum AdjustmentMode
		{
			[Token(Token = "0x4000193")]
			ZoomOnly = 0,
			[Token(Token = "0x4000194")]
			DollyOnly = 1,
			[Token(Token = "0x4000195")]
			DollyThenZoom = 2
		}

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x128")]
		public float m_GroupFramingSize;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x12C")]
		public FramingMode m_FramingMode;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78B80", Offset = "0x78B80")]
		public float m_FrameDamping;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x134")]
		public AdjustmentMode m_AdjustmentMode;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x138")]
		public float m_MaxDollyIn;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x13C")]
		public float m_MaxDollyOut;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x140")]
		public float m_MinimumDistance;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x144")]
		public float m_MaximumDistance;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78B98", Offset = "0x78B98")]
		public float m_MinimumFOV;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x14C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78BB4", Offset = "0x78BB4")]
		public float m_MaximumFOV;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x150")]
		public float m_MinimumOrthoSize;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x154")]
		public float m_MaximumOrthoSize;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x158")]
		private float m_prevFramingDistance;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x15C")]
		private float m_prevFOV;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x160")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78BD0", Offset = "0x78BD0")]
		private Bounds LastBounds__BackingField;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x178")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x78BE0", Offset = "0x78BE0")]
		private Matrix4x4 LastBoundsMatrix__BackingField;

		[Token(Token = "0x17000057")]
		public Bounds LastBounds
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x18F7344", Offset = "0x18F7344", VA = "0x18F7344")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x796B8", Offset = "0x796B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x18F7358", Offset = "0x18F7358", VA = "0x18F7358")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x796C8", Offset = "0x796C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public Matrix4x4 LastBoundsMatrix
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x18F736C", Offset = "0x18F736C", VA = "0x18F736C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x796D8", Offset = "0x796D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x18F7384", Offset = "0x18F7384", VA = "0x18F7384")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x796E8", Offset = "0x796E8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x18F7264", Offset = "0x18F7264", VA = "0x18F7264")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x18F739C", Offset = "0x18F739C", VA = "0x18F739C", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x18F7F88", Offset = "0x18F7F88", VA = "0x18F7F88")]
		private float GetTargetHeight(Vector2 boundsSize)
		{
			return default;
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x18F7D0C", Offset = "0x18F7D0C", VA = "0x18F7D0C")]
		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd)
		{
			return default;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x18F810C", Offset = "0x18F810C", VA = "0x18F810C")]
		public CinemachineGroupComposer()
		{
		}
	}
}
