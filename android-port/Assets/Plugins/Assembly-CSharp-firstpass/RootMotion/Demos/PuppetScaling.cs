using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000244")]
	public class PuppetScaling : MonoBehaviour
	{
		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000EC3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36DD0", Offset = "0x36DD0")]
		public float masterScale;

		[Token(Token = "0x4000EC4")]
		[FieldOffset(Offset = "0x24")]
		public int muscleIndex;

		[Token(Token = "0x4000EC5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36DF0", Offset = "0x36DF0")]
		public float muscleScale;

		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0x2C")]
		private float defaultMuscleSpring;

		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x13D5914", Offset = "0x13D5914", VA = "0x13D5914")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F1B")]
		[Address(RVA = "0x13D593C", Offset = "0x13D593C", VA = "0x13D593C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F1C")]
		[Address(RVA = "0x13D5C5C", Offset = "0x13D5C5C", VA = "0x13D5C5C")]
		public PuppetScaling()
		{
		}
	}
}
