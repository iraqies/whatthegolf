using Il2CppDummyDll;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x200009B")]
	public class PhysicsStabilizer : Singleton<PhysicsStabilizer>
	{
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x19")]
		private bool _firstUpdate;

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x13BE7B4", Offset = "0x13BE7B4", VA = "0x13BE7B4", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x13BE85C", Offset = "0x13BE85C", VA = "0x13BE85C", Slot = "9")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x13BE9D4", Offset = "0x13BE9D4", VA = "0x13BE9D4")]
		public PhysicsStabilizer()
		{
		}
	}
}
