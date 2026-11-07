using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000156")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x18")]
		public IK[] IKComponents;

		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x20")]
		public Animator animator;

		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700013D")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x138756C", Offset = "0x138756C", VA = "0x138756C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x1387614", Offset = "0x1387614", VA = "0x1387614")]
		private void Start()
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x1387684", Offset = "0x1387684", VA = "0x1387684")]
		private void Update()
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1387748", Offset = "0x1387748", VA = "0x1387748")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1387784", Offset = "0x1387784", VA = "0x1387784")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x13876B8", Offset = "0x13876B8", VA = "0x13876B8")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x1387874", Offset = "0x1387874", VA = "0x1387874")]
		public IKExecutionOrder()
		{
		}
	}
}
