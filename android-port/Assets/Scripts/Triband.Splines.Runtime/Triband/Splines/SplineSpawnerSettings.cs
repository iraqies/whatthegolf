using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	[Token(Token = "0x2000024")]
	public sealed class SplineSpawnerSettings
	{
		[Serializable]
		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B00AC", Offset = "0x1B00AC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40000A6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40000A7")]
			[FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> _003C_003E9__100_0;

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x2A0D540", Offset = "0x2A0D540", VA = "0x2A0D540")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x2A0D548", Offset = "0x2A0D548", VA = "0x2A0D548")]
			internal bool _003CIsValid_003Eb__100_0(GameObject s)
			{
				return default;
			}
		}

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PositionMode m_PositionMode;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int m_Count;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_LengthCompensation;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_Distance;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StartOffsetMode m_StartOffsetMode;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1B04AC", Offset = "0x1B04AC")]
		private float m_StartOffsetFraction;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_StartOffsetRepeat;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_StartOffsetDistance;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1B050C", Offset = "0x1B050C")]
		[SerializeField]
		private float m_EndOffsetFraction;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private StartOffsetMode m_EndOffsetMode;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_EndOffsetDistance;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool m_EndOffsetRepeat;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AlignmentMode m_AlignmentMode;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private RotationAlignmentMode m_RotationAlignmentMode;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector3 m_RotationPerObject;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_OffsetX;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_OffsetY;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_OffsetZ;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_RotationX;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_RotationY;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_RotationZ;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private bool m_Use3dScale;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_Scale;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_ScaleX;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_ScaleY;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private ParticleSystem.MinMaxCurve m_ScaleZ;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private int m_Seed;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x1C4")]
		[SerializeField]
		private ObjectMode m_ObjectMode;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private bool m_UseCapObjects;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private GameObject m_StartCapObject;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private GameObject m_EndCapObject;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private GameObject[] m_Objects;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private bool m_onlyUpdateOnSplineCompletion;

		[Token(Token = "0x17000033")]
		public bool OnlyUpdateOnSplineCompletion
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x2A0D1A4", Offset = "0x2A0D1A4", VA = "0x2A0D1A4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000034")]
		public PositionMode positionMode
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2A0D1AC", Offset = "0x2A0D1AC", VA = "0x2A0D1AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000035")]
		public int count
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2A0D1B4", Offset = "0x2A0D1B4", VA = "0x2A0D1B4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000036")]
		public ParticleSystem.MinMaxCurve distance
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2A0D1BC", Offset = "0x2A0D1BC", VA = "0x2A0D1BC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000037")]
		public bool lengthCompensation
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2A0D1C8", Offset = "0x2A0D1C8", VA = "0x2A0D1C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000038")]
		public StartOffsetMode startOffsetMode
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2A0D1D0", Offset = "0x2A0D1D0", VA = "0x2A0D1D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000039")]
		public bool startOffsetRepeat
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x2A0D1D8", Offset = "0x2A0D1D8", VA = "0x2A0D1D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003A")]
		public float startOffsetFraction
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x2A0D1E0", Offset = "0x2A0D1E0", VA = "0x2A0D1E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003B")]
		public float startOffsetDistance
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x2A0D1E8", Offset = "0x2A0D1E8", VA = "0x2A0D1E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003C")]
		public StartOffsetMode endOffsetMode
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2A0D1F0", Offset = "0x2A0D1F0", VA = "0x2A0D1F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003D")]
		public float endOffsetFraction
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2A0D1F8", Offset = "0x2A0D1F8", VA = "0x2A0D1F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003E")]
		public float endOffsetDistance
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x2A0D200", Offset = "0x2A0D200", VA = "0x2A0D200")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003F")]
		public bool endOffsetRepeat
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x2A0D208", Offset = "0x2A0D208", VA = "0x2A0D208")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000040")]
		public AlignmentMode alignmentMode
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x2A0D210", Offset = "0x2A0D210", VA = "0x2A0D210")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000041")]
		public RotationAlignmentMode RotationAlignmentMode
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x2A0D218", Offset = "0x2A0D218", VA = "0x2A0D218")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000042")]
		public Vector3 RotationPerObject
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x2A0D220", Offset = "0x2A0D220", VA = "0x2A0D220")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000043")]
		public ParticleSystem.MinMaxCurve offsetX
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x2A0D22C", Offset = "0x2A0D22C", VA = "0x2A0D22C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000044")]
		public ParticleSystem.MinMaxCurve offsetY
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x2A0D23C", Offset = "0x2A0D23C", VA = "0x2A0D23C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000045")]
		public ParticleSystem.MinMaxCurve offsetZ
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x2A0D24C", Offset = "0x2A0D24C", VA = "0x2A0D24C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000046")]
		public ParticleSystem.MinMaxCurve rotationX
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x2A0D25C", Offset = "0x2A0D25C", VA = "0x2A0D25C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000047")]
		public ParticleSystem.MinMaxCurve rotationY
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x2A0D26C", Offset = "0x2A0D26C", VA = "0x2A0D26C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000048")]
		public ParticleSystem.MinMaxCurve rotationZ
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x2A0D280", Offset = "0x2A0D280", VA = "0x2A0D280")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000049")]
		public bool use3dScale
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x2A0D290", Offset = "0x2A0D290", VA = "0x2A0D290")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004A")]
		public ParticleSystem.MinMaxCurve scale
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x2A0D298", Offset = "0x2A0D298", VA = "0x2A0D298")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004B")]
		public ParticleSystem.MinMaxCurve scaleX
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x2A0D2A4", Offset = "0x2A0D2A4", VA = "0x2A0D2A4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004C")]
		public ParticleSystem.MinMaxCurve scaleY
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x2A0D2B0", Offset = "0x2A0D2B0", VA = "0x2A0D2B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004D")]
		public ParticleSystem.MinMaxCurve scaleZ
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x2A0D2BC", Offset = "0x2A0D2BC", VA = "0x2A0D2BC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004E")]
		public int seed
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x2A0D2C8", Offset = "0x2A0D2C8", VA = "0x2A0D2C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004F")]
		public ObjectMode objectMode
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x2A0D2D0", Offset = "0x2A0D2D0", VA = "0x2A0D2D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000050")]
		public bool useCapObjects
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2A0D2D8", Offset = "0x2A0D2D8", VA = "0x2A0D2D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000051")]
		public GameObject startCapObject
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x2A0D2E0", Offset = "0x2A0D2E0", VA = "0x2A0D2E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public GameObject endCapObject
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2A0D2E8", Offset = "0x2A0D2E8", VA = "0x2A0D2E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public GameObject[] objects
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2A0D2F0", Offset = "0x2A0D2F0", VA = "0x2A0D2F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2A0B3D8", Offset = "0x2A0B3D8", VA = "0x2A0B3D8")]
		public SplineSpawnerSettings()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2A0B9FC", Offset = "0x2A0B9FC", VA = "0x2A0B9FC")]
		public bool IsValid()
		{
			return default;
		}
	}
}
