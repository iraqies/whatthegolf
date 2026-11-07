using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013D2")]
	public class AudioValueObjectRotation : BaseAudioValue
	{
		[Token(Token = "0x4006A8A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4006A8B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 axis;

		[Token(Token = "0x4006A8C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float smoothTime;

		[Token(Token = "0x4006A8D")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion lastRotation;

		[Token(Token = "0x4006A8E")]
		[FieldOffset(Offset = "0x60")]
		private float smoothVelocity;

		[Token(Token = "0x17000A74")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C74")]
			[Address(RVA = "0x1510650", Offset = "0x1510650", VA = "0x1510650", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C75")]
		[Address(RVA = "0x1510658", Offset = "0x1510658", VA = "0x1510658", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005C76")]
		[Address(RVA = "0x1510738", Offset = "0x1510738", VA = "0x1510738", Slot = "5")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6005C77")]
		[Address(RVA = "0x15107CC", Offset = "0x15107CC", VA = "0x15107CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C78")]
		[Address(RVA = "0x151086C", Offset = "0x151086C", VA = "0x151086C", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C79")]
		[Address(RVA = "0x1510928", Offset = "0x1510928", VA = "0x1510928")]
		public AudioValueObjectRotation()
		{
		}
	}
}
