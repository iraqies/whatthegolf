using System;
using Il2CppDummyDll;

namespace RootMotion.Dynamics
{
	[Serializable]
	[Token(Token = "0x2000106")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1401B08", Offset = "0x1401B08", VA = "0x1401B08")]
		protected SubBehaviourBase()
		{
		}
	}
}
