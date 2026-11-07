using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013DD")]
	public class AudioValueTransformMovement : BaseAudioValue
	{
		[Token(Token = "0x4006AC6")]
		[FieldOffset(Offset = "0x38")]
		public Transform listenTransform;

		[Token(Token = "0x4006AC7")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x17000A7D")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005CA7")]
			[Address(RVA = "0x1512A74", Offset = "0x1512A74", VA = "0x1512A74", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005CA8")]
		[Address(RVA = "0x1512A7C", Offset = "0x1512A7C", VA = "0x1512A7C", Slot = "5")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0x1512B1C", Offset = "0x1512B1C", VA = "0x1512B1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0x1512BBC", Offset = "0x1512BBC", VA = "0x1512BBC", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0x1512C1C", Offset = "0x1512C1C", VA = "0x1512C1C")]
		public AudioValueTransformMovement()
		{
		}
	}
}
