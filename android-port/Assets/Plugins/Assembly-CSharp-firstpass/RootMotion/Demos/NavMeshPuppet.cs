using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;
using UnityEngine.AI;

namespace RootMotion.Demos
{
	[Token(Token = "0x200023A")]
	public class NavMeshPuppet : MonoBehaviour
	{
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0x20")]
		public NavMeshAgent agent;

		[Token(Token = "0x4000E94")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x4000E95")]
		[FieldOffset(Offset = "0x30")]
		public Animator animator;

		[Token(Token = "0x6000EF1")]
		[Address(RVA = "0x13BA16C", Offset = "0x13BA16C", VA = "0x13BA16C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000EF2")]
		[Address(RVA = "0x13BA264", Offset = "0x13BA264", VA = "0x13BA264")]
		public NavMeshPuppet()
		{
		}
	}
}
