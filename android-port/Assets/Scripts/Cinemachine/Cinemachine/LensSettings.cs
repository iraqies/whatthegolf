using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[Token(Token = "0x2000072")]
	public struct LensSettings
	{
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x0")]
		public static LensSettings Default;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x792EC", Offset = "0x792EC")]
		public float FieldOfView;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x4")]
		public float OrthographicSize;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x8")]
		public float NearClipPlane;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0xC")]
		public float FarClipPlane;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79308", Offset = "0x79308")]
		public float Dutch;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79328", Offset = "0x79328")]
		private bool Orthographic__BackingField;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79338", Offset = "0x79338")]
		private Vector2 SensorSize__BackingField;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79348", Offset = "0x79348")]
		private bool IsPhysicalCamera__BackingField;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 LensShift;

		[Token(Token = "0x170000C7")]
		public bool Orthographic
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x190B42C", Offset = "0x190B42C", VA = "0x190B42C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AC8", Offset = "0x79AC8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x190B434", Offset = "0x190B434", VA = "0x190B434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AD8", Offset = "0x79AD8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public Vector2 SensorSize
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x190B43C", Offset = "0x190B43C", VA = "0x190B43C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AE8", Offset = "0x79AE8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x190B444", Offset = "0x190B444", VA = "0x190B444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79AF8", Offset = "0x79AF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public float Aspect
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x190B44C", Offset = "0x190B44C", VA = "0x190B44C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CA")]
		public bool IsPhysicalCamera
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x190B464", Offset = "0x190B464", VA = "0x190B464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B08", Offset = "0x79B08")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x190B46C", Offset = "0x190B46C", VA = "0x190B46C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79B18", Offset = "0x79B18")]
			set
			{
			}
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x190B474", Offset = "0x190B474", VA = "0x190B474")]
		public static LensSettings FromCamera(Camera fromCamera)
		{
			return default;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x190AB78", Offset = "0x190AB78", VA = "0x190AB78")]
		public void SnapshotCameraReadOnlyProperties(Camera camera)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x190B5BC", Offset = "0x190B5BC", VA = "0x190B5BC")]
		public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x190B5D8", Offset = "0x190B5D8", VA = "0x190B5D8")]
		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t)
		{
			return default;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1907E70", Offset = "0x1907E70", VA = "0x1907E70")]
		public void Validate()
		{
		}
	}
}
