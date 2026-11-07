using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013C6")]
	public class AudioValueDistance : BaseAudioValue
	{
		[Token(Token = "0x20013C7")]
		public enum DistanceListenType
		{
			[Token(Token = "0x4006A5E")]
			DISTANCE = 0,
			[Token(Token = "0x4006A5F")]
			DISTANCE_ON_Y = 1
		}

		[Token(Token = "0x4006A5A")]
		[FieldOffset(Offset = "0x38")]
		public Transform obj1;

		[Token(Token = "0x4006A5B")]
		[FieldOffset(Offset = "0x40")]
		public Transform obj2;

		[Token(Token = "0x4006A5C")]
		[FieldOffset(Offset = "0x48")]
		public DistanceListenType listenType;

		[Token(Token = "0x17000A6E")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C47")]
			[Address(RVA = "0x150EE30", Offset = "0x150EE30", VA = "0x150EE30", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C48")]
		[Address(RVA = "0x150EE38", Offset = "0x150EE38", VA = "0x150EE38")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C49")]
		[Address(RVA = "0x150EF10", Offset = "0x150EF10", VA = "0x150EF10", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005C4A")]
		[Address(RVA = "0x150F00C", Offset = "0x150F00C", VA = "0x150F00C", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C4B")]
		[Address(RVA = "0x150F1F4", Offset = "0x150F1F4", VA = "0x150F1F4")]
		public AudioValueDistance()
		{
		}
	}
}
