using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001DF")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000C99")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x36B3C", Offset = "0x36B3C")]
		private Vector3 pelvisTargetRight__BackingField;

		[Token(Token = "0x4000C9A")]
		[FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000C9B")]
		[FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000C9C")]
		[FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000C9D")]
		[FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170001B8")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000D8C")]
			[Address(RVA = "0x132B244", Offset = "0x132B244", VA = "0x132B244")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF5C", Offset = "0x3AF5C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000D8D")]
			[Address(RVA = "0x132B250", Offset = "0x132B250", VA = "0x132B250")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3AF6C", Offset = "0x3AF6C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x132B25C", Offset = "0x132B25C", VA = "0x132B25C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000D8F")]
		[Address(RVA = "0x132A378", Offset = "0x132A378", VA = "0x132A378")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000D90")]
		[Address(RVA = "0x132A7EC", Offset = "0x132A7EC", VA = "0x132A7EC")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000D91")]
		[Address(RVA = "0x132B350", Offset = "0x132B350", VA = "0x132B350")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000D92")]
		[Address(RVA = "0x132B788", Offset = "0x132B788", VA = "0x132B788")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000D93")]
		[Address(RVA = "0x132B8A4", Offset = "0x132B8A4", VA = "0x132B8A4")]
		public VRIKRootController()
		{
		}
	}
}
