using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001AB")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000B7B")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000B7C")]
		[FieldOffset(Offset = "0x24")]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000B7D")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x36894", Offset = "0x36894")]
		private bool defaultLocalRotationOverride__BackingField;

		[Token(Token = "0x4000B7E")]
		[FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x4000B7F")]
		[FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x4000B80")]
		[FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000198")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x13F38C0", Offset = "0x13F38C0", VA = "0x13F38C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000199")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x13F38CC", Offset = "0x13F38CC", VA = "0x13F38CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019A")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x13F38E8", Offset = "0x13F38E8", VA = "0x13F38E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A9CC", Offset = "0x3A9CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x13F38F0", Offset = "0x13F38F0", VA = "0x13F38F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A9DC", Offset = "0x3A9DC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x13F35A0", Offset = "0x13F35A0", VA = "0x13F35A0")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x13F35E8", Offset = "0x13F35E8", VA = "0x13F35E8")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x13F3600", Offset = "0x13F3600", VA = "0x13F3600")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default;
		}

		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x13F381C", Offset = "0x13F381C", VA = "0x13F381C")]
		public bool Apply()
		{
			return default;
		}

		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x13F388C", Offset = "0x13F388C", VA = "0x13F388C")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000C9E")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x13F371C", Offset = "0x13F371C", VA = "0x13F371C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x13F38F8", Offset = "0x13F38F8", VA = "0x13F38F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x13F38FC", Offset = "0x13F38FC", VA = "0x13F38FC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x13F3930", Offset = "0x13F3930", VA = "0x13F3930")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default;
		}

		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x13F39AC", Offset = "0x13F39AC", VA = "0x13F39AC")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default;
		}

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x13F3B40", Offset = "0x13F3B40", VA = "0x13F3B40")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default;
		}

		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x13F3BB0", Offset = "0x13F3BB0", VA = "0x13F3BB0")]
		protected RotationLimit()
		{
		}
	}
}
