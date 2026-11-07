using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Serializable]
	[Token(Token = "0x2000109")]
	public class Booster
	{
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x10")]
		public bool fullBody;

		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x18")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x20")]
		public Muscle.Group[] groups;

		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35634", Offset = "0x35634")]
		public float immunity;

		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x2C")]
		public float impulseMlp;

		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0x30")]
		public float boostParents;

		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x34")]
		public float boostChildren;

		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x38")]
		public float delay;

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x130C7C8", Offset = "0x130C7C8", VA = "0x130C7C8")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x130C9FC", Offset = "0x130C9FC", VA = "0x130C9FC")]
		public Booster()
		{
		}
	}
}
