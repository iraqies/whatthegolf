using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001388")]
	public abstract class ModifyAudiosource : BaseAudioModifierMultiple
	{
		[Token(Token = "0x40068DB")]
		[FieldOffset(Offset = "0x38")]
		public AudioSource source;

		[Token(Token = "0x6005B39")]
		[Address(RVA = "0x156A8A4", Offset = "0x156A8A4", VA = "0x156A8A4", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6005B3A")]
		[Address(RVA = "0x156A94C", Offset = "0x156A94C", VA = "0x156A94C")]
		protected ModifyAudiosource()
		{
		}
	}
}
