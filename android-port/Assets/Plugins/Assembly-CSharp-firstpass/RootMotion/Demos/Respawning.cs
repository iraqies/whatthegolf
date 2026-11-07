using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000246")]
	public class Respawning : MonoBehaviour
	{
		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x18")]
		public Transform pool;

		[Token(Token = "0x4000ECC")]
		[FieldOffset(Offset = "0x20")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000ECD")]
		[FieldOffset(Offset = "0x28")]
		public string idleAnimation;

		[Token(Token = "0x4000ECE")]
		[FieldOffset(Offset = "0x30")]
		private Transform puppetRoot;

		[Token(Token = "0x170001DD")]
		private bool isPooled
		{
			[Token(Token = "0x6000F1F")]
			[Address(RVA = "0x13DBFC4", Offset = "0x13DBFC4", VA = "0x13DBFC4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000F20")]
		[Address(RVA = "0x13DC05C", Offset = "0x13DC05C", VA = "0x13DC05C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x13DC0B8", Offset = "0x13DC0B8", VA = "0x13DC0B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F22")]
		[Address(RVA = "0x13DC1F8", Offset = "0x13DC1F8", VA = "0x13DC1F8")]
		private void Pool()
		{
		}

		[Token(Token = "0x6000F23")]
		[Address(RVA = "0x13DC21C", Offset = "0x13DC21C", VA = "0x13DC21C")]
		private void Respawn(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x13DC33C", Offset = "0x13DC33C", VA = "0x13DC33C")]
		public Respawning()
		{
		}
	}
}
