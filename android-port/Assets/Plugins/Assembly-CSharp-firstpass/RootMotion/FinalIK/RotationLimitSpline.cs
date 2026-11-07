using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001B1")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000B94")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36940", Offset = "0x36940")]
		public float twistLimit;

		[Token(Token = "0x4000B95")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x13F58AC", Offset = "0x13F58AC", VA = "0x13F58AC")]
		[Attribute(Name = "ContextMenu", RVA = "0x3AC8C", Offset = "0x3AC8C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x13F58F4", Offset = "0x13F58F4", VA = "0x13F58F4")]
		[Attribute(Name = "ContextMenu", RVA = "0x3ACC4", Offset = "0x3ACC4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x13F593C", Offset = "0x13F593C", VA = "0x13F593C")]
		[Attribute(Name = "ContextMenu", RVA = "0x3ACFC", Offset = "0x3ACFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x13F5984", Offset = "0x13F5984", VA = "0x13F5984")]
		[Attribute(Name = "ContextMenu", RVA = "0x3AD34", Offset = "0x3AD34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x13F59CC", Offset = "0x13F59CC", VA = "0x13F59CC")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x13F59E8", Offset = "0x13F59E8", VA = "0x13F59E8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x6000CD1")]
		[Address(RVA = "0x13F5A28", Offset = "0x13F5A28", VA = "0x13F5A28")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x6000CD2")]
		[Address(RVA = "0x13F5C8C", Offset = "0x13F5C8C", VA = "0x13F5C8C")]
		public RotationLimitSpline()
		{
		}
	}
}
