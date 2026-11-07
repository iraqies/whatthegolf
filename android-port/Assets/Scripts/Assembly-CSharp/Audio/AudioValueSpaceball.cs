using Il2CppDummyDll;
using SpaceGolf;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013D7")]
	public class AudioValueSpaceball : BaseAudioValue
	{
		[Token(Token = "0x4006AB1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public SpaceGolfBallShooter shooter;

		[Token(Token = "0x17000A79")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C94")]
			[Address(RVA = "0x151216C", Offset = "0x151216C", VA = "0x151216C", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C95")]
		[Address(RVA = "0x1512174", Offset = "0x1512174", VA = "0x1512174")]
		private void Update()
		{
		}

		[Token(Token = "0x6005C96")]
		[Address(RVA = "0x1512180", Offset = "0x1512180", VA = "0x1512180", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C97")]
		[Address(RVA = "0x1512204", Offset = "0x1512204", VA = "0x1512204")]
		public AudioValueSpaceball()
		{
		}
	}
}
