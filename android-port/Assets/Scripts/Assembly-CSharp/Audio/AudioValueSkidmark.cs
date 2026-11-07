using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x20013D6")]
	public class AudioValueSkidmark : BaseAudioValue
	{
		[Token(Token = "0x4006AAD")]
		[FieldOffset(Offset = "0x38")]
		public Skidmarks skidmarks;

		[Token(Token = "0x4006AAE")]
		[FieldOffset(Offset = "0x40")]
		public float smoothTime;

		[Token(Token = "0x4006AAF")]
		[FieldOffset(Offset = "0x44")]
		private float lastIntensity;

		[Token(Token = "0x4006AB0")]
		[FieldOffset(Offset = "0x48")]
		private float smoothVelocity;

		[Token(Token = "0x17000A78")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005C8C")]
			[Address(RVA = "0x1511E28", Offset = "0x1511E28", VA = "0x1511E28", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005C8D")]
		[Address(RVA = "0x1511E30", Offset = "0x1511E30", VA = "0x1511E30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0x1511F58", Offset = "0x1511F58", VA = "0x1511F58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0x1512080", Offset = "0x1512080", VA = "0x1512080", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005C90")]
		[Address(RVA = "0x15120C4", Offset = "0x15120C4", VA = "0x15120C4")]
		private void OnCreateSkidmark(float v)
		{
		}

		[Token(Token = "0x6005C91")]
		[Address(RVA = "0x1512114", Offset = "0x1512114", VA = "0x1512114")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6005C92")]
		[Address(RVA = "0x1512158", Offset = "0x1512158", VA = "0x1512158", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005C93")]
		[Address(RVA = "0x151215C", Offset = "0x151215C", VA = "0x151215C")]
		public AudioValueSkidmark()
		{
		}
	}
}
