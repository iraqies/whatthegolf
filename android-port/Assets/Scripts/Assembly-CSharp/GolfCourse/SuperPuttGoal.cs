using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace GolfCourse
{
	[Token(Token = "0x2001211")]
	public class SuperPuttGoal : MonoBehaviour
	{
		[Token(Token = "0x4006193")]
		[FieldOffset(Offset = "0x18")]
		public bool ShowCustomTransition;

		[Token(Token = "0x4006194")]
		[FieldOffset(Offset = "0x20")]
		private Level level;

		[Token(Token = "0x4006195")]
		[FieldOffset(Offset = "0x28")]
		private SuperPuttTransitionTextEffect textEffect;

		[Token(Token = "0x600531C")]
		[Address(RVA = "0x16EE90C", Offset = "0x16EE90C", VA = "0x16EE90C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600531D")]
		[Address(RVA = "0x16EE9AC", Offset = "0x16EE9AC", VA = "0x16EE9AC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600531E")]
		[Address(RVA = "0x16EE9E4", Offset = "0x16EE9E4", VA = "0x16EE9E4")]
		public void CheckObject(Transform trans)
		{
		}

		[Token(Token = "0x600531F")]
		[Address(RVA = "0x16EEAB0", Offset = "0x16EEAB0", VA = "0x16EEAB0")]
		private void NotifyCompleted()
		{
		}

		[Token(Token = "0x6005320")]
		[Address(RVA = "0x16EEB74", Offset = "0x16EEB74", VA = "0x16EEB74")]
		public SuperPuttGoal()
		{
		}

		[Token(Token = "0x6005321")]
		[Address(RVA = "0x16EEB84", Offset = "0x16EEB84", VA = "0x16EEB84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70D68", Offset = "0x70D68")]
		private void _003CAwake_003Eb__3_0()
		{
		}
	}
}
