using Il2CppDummyDll;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000021")]
	public class EasyDecalExtension : EasyDecal
	{
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x298")]
		public float AngularSpeed;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2C69A94", Offset = "0x2C69A94", VA = "0x2C69A94", Slot = "8")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2C69AF8", Offset = "0x2C69AF8", VA = "0x2C69AF8")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2C69B04", Offset = "0x2C69B04", VA = "0x2C69B04")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2C69B10", Offset = "0x2C69B10", VA = "0x2C69B10", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2C69BE0", Offset = "0x2C69BE0", VA = "0x2C69BE0")]
		public EasyDecalExtension()
		{
		}
	}
}
