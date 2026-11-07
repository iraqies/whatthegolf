using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000058")]
	public struct CameraState
	{
		[Token(Token = "0x2000059")]
		public enum BlendHintValue
		{
			[Token(Token = "0x400021B")]
			Nothing = 0,
			[Token(Token = "0x400021C")]
			NoPosition = 1,
			[Token(Token = "0x400021D")]
			NoOrientation = 2,
			[Token(Token = "0x400021E")]
			NoTransform = 3,
			[Token(Token = "0x400021F")]
			SphericalPositionBlend = 4,
			[Token(Token = "0x4000220")]
			CylindricalPositionBlend = 8,
			[Token(Token = "0x4000221")]
			RadialAimBlend = 16,
			[Token(Token = "0x4000222")]
			IgnoreLookAtTarget = 32,
			[Token(Token = "0x4000223")]
			NoLens = 64
		}

		[Token(Token = "0x200005A")]
		public struct CustomBlendable
		{
			[Token(Token = "0x4000224")]
			[FieldOffset(Offset = "0x0")]
			public Object m_Custom;

			[Token(Token = "0x4000225")]
			[FieldOffset(Offset = "0x8")]
			public float m_Weight;

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x190E784", Offset = "0x190E784", VA = "0x190E784")]
			public CustomBlendable(Object custom, float weight)
			{
			}
		}

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79080", Offset = "0x79080")]
		private LensSettings Lens__BackingField;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79090", Offset = "0x79090")]
		private Vector3 ReferenceUp__BackingField;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x790A0", Offset = "0x790A0")]
		private Vector3 ReferenceLookAt__BackingField;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x0")]
		public static Vector3 kNoPoint;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x790B0", Offset = "0x790B0")]
		private Vector3 RawPosition__BackingField;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x790C0", Offset = "0x790C0")]
		private Quaternion RawOrientation__BackingField;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x790D0", Offset = "0x790D0")]
		private Vector3 PositionDampingBypass__BackingField;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x790E0", Offset = "0x790E0")]
		private float ShotQuality__BackingField;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x790F0", Offset = "0x790F0")]
		private Vector3 PositionCorrection__BackingField;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79100", Offset = "0x79100")]
		private Quaternion OrientationCorrection__BackingField;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79110", Offset = "0x79110")]
		private BlendHintValue BlendHint__BackingField;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x90")]
		private CustomBlendable mCustom0;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0xA0")]
		private CustomBlendable mCustom1;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0xB0")]
		private CustomBlendable mCustom2;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0xC0")]
		private CustomBlendable mCustom3;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0xD0")]
		private List<CustomBlendable> m_CustomOverflow;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79120", Offset = "0x79120")]
		private int NumCustomBlendables__BackingField;

		[Token(Token = "0x1700006E")]
		public LensSettings Lens
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x18DF458", Offset = "0x18DF458", VA = "0x18DF458")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79778", Offset = "0x79778")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x18DF46C", Offset = "0x18DF46C", VA = "0x18DF46C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79788", Offset = "0x79788")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Vector3 ReferenceUp
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x18DF488", Offset = "0x18DF488", VA = "0x18DF488")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79798", Offset = "0x79798")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x18DF494", Offset = "0x18DF494", VA = "0x18DF494")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x797A8", Offset = "0x797A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public Vector3 ReferenceLookAt
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x18DF4A0", Offset = "0x18DF4A0", VA = "0x18DF4A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x797B8", Offset = "0x797B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x18DF4AC", Offset = "0x18DF4AC", VA = "0x18DF4AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x797C8", Offset = "0x797C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public bool HasLookAt
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x18DF4B8", Offset = "0x18DF4B8", VA = "0x18DF4B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000072")]
		public Vector3 RawPosition
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x18DF4D4", Offset = "0x18DF4D4", VA = "0x18DF4D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x797D8", Offset = "0x797D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x18DF4E0", Offset = "0x18DF4E0", VA = "0x18DF4E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x797E8", Offset = "0x797E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public Quaternion RawOrientation
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x18DF4EC", Offset = "0x18DF4EC", VA = "0x18DF4EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x797F8", Offset = "0x797F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x18DF4F8", Offset = "0x18DF4F8", VA = "0x18DF4F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79808", Offset = "0x79808")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public Vector3 PositionDampingBypass
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x18DF504", Offset = "0x18DF504", VA = "0x18DF504")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79818", Offset = "0x79818")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x18DF510", Offset = "0x18DF510", VA = "0x18DF510")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79828", Offset = "0x79828")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public float ShotQuality
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x18DF51C", Offset = "0x18DF51C", VA = "0x18DF51C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79838", Offset = "0x79838")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x18DF524", Offset = "0x18DF524", VA = "0x18DF524")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79848", Offset = "0x79848")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public Vector3 PositionCorrection
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x18DF52C", Offset = "0x18DF52C", VA = "0x18DF52C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79858", Offset = "0x79858")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x18DF538", Offset = "0x18DF538", VA = "0x18DF538")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79868", Offset = "0x79868")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public Quaternion OrientationCorrection
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x18DF544", Offset = "0x18DF544", VA = "0x18DF544")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79878", Offset = "0x79878")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x18DF550", Offset = "0x18DF550", VA = "0x18DF550")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79888", Offset = "0x79888")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public Vector3 CorrectedPosition
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x18DF55C", Offset = "0x18DF55C", VA = "0x18DF55C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000079")]
		public Quaternion CorrectedOrientation
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x18DF57C", Offset = "0x18DF57C", VA = "0x18DF57C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007A")]
		public Vector3 FinalPosition
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x18DF594", Offset = "0x18DF594", VA = "0x18DF594")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007B")]
		public Quaternion FinalOrientation
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x18DF5B4", Offset = "0x18DF5B4", VA = "0x18DF5B4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007C")]
		public BlendHintValue BlendHint
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x18DF698", Offset = "0x18DF698", VA = "0x18DF698")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79898", Offset = "0x79898")]
			get
			{
				return default;
			}
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x18DF6A0", Offset = "0x18DF6A0", VA = "0x18DF6A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x798A8", Offset = "0x798A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public static CameraState Default
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x18DF6A8", Offset = "0x18DF6A8", VA = "0x18DF6A8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007E")]
		public int NumCustomBlendables
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x18DF888", Offset = "0x18DF888", VA = "0x18DF888")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x798B8", Offset = "0x798B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x18DF890", Offset = "0x18DF890", VA = "0x18DF890")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x798C8", Offset = "0x798C8")]
			private set
			{
			}
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x18DF898", Offset = "0x18DF898", VA = "0x18DF898")]
		public CustomBlendable GetCustomBlendable(int index)
		{
			return default;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x18DF990", Offset = "0x18DF990", VA = "0x18DF990")]
		private int FindCustomBlendable(Object custom)
		{
			return default;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x18DFB8C", Offset = "0x18DFB8C", VA = "0x18DFB8C")]
		public void AddCustomBlendable(CustomBlendable b)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x18DFD28", Offset = "0x18DFD28", VA = "0x18DFD28")]
		public static CameraState Lerp(CameraState stateA, CameraState stateB, float t)
		{
			return default;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x18E09E8", Offset = "0x18E09E8", VA = "0x18E09E8")]
		private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t)
		{
			return default;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x18E0950", Offset = "0x18E0950", VA = "0x18E0950")]
		private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended)
		{
			return default;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x18E0994", Offset = "0x18E0994", VA = "0x18E0994")]
		private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended)
		{
			return default;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x18E0B00", Offset = "0x18E0B00", VA = "0x18E0B00")]
		private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t)
		{
			return default;
		}
	}
}
