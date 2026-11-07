using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001AD")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000B83")]
		[FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x4000B84")]
		[FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x4000B85")]
		[FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x4000B86")]
		[FieldOffset(Offset = "0x44")]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000B87")]
		[FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000B88")]
		[FieldOffset(Offset = "0x58")]
		private float lastAngle;

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x13F3F34", Offset = "0x13F3F34", VA = "0x13F3F34")]
		[Attribute(Name = "ContextMenu", RVA = "0x3AACC", Offset = "0x3AACC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x13F3F7C", Offset = "0x13F3F7C", VA = "0x13F3F7C")]
		[Attribute(Name = "ContextMenu", RVA = "0x3AB04", Offset = "0x3AB04")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x13F3FC4", Offset = "0x13F3FC4", VA = "0x13F3FC4")]
		[Attribute(Name = "ContextMenu", RVA = "0x3AB3C", Offset = "0x3AB3C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x13F400C", Offset = "0x13F400C", VA = "0x13F400C")]
		[Attribute(Name = "ContextMenu", RVA = "0x3AB74", Offset = "0x3AB74")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x13F4054", Offset = "0x13F4054", VA = "0x13F4054", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x13F407C", Offset = "0x13F407C", VA = "0x13F407C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x13F42F0", Offset = "0x13F42F0", VA = "0x13F42F0")]
		public RotationLimitHinge()
		{
		}
	}
}
