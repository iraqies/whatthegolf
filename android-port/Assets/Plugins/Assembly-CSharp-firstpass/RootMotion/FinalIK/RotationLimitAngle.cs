using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001AC")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000B81")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RangeAttribute", RVA = "0x368A4", Offset = "0x368A4")]
		public float limit;

		[Token(Token = "0x4000B82")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x368C0", Offset = "0x368C0")]
		public float twistLimit;

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x13F3BE4", Offset = "0x13F3BE4", VA = "0x13F3BE4")]
		[Attribute(Name = "ContextMenu", RVA = "0x3A9EC", Offset = "0x3A9EC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x13F3C2C", Offset = "0x13F3C2C", VA = "0x13F3C2C")]
		[Attribute(Name = "ContextMenu", RVA = "0x3AA24", Offset = "0x3AA24")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x13F3C74", Offset = "0x13F3C74", VA = "0x13F3C74")]
		[Attribute(Name = "ContextMenu", RVA = "0x3AA5C", Offset = "0x3AA5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x13F3CBC", Offset = "0x13F3CBC", VA = "0x13F3CBC")]
		[Attribute(Name = "ContextMenu", RVA = "0x3AA94", Offset = "0x3AA94")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x13F3D04", Offset = "0x13F3D04", VA = "0x13F3D04", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x13F3D44", Offset = "0x13F3D44", VA = "0x13F3D44")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x13F3EF4", Offset = "0x13F3EF4", VA = "0x13F3EF4")]
		public RotationLimitAngle()
		{
		}
	}
}
