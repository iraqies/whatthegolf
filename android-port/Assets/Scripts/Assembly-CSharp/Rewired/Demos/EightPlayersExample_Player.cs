using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x2001167")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x47E7C", Offset = "0x47E7C")]
	public class EightPlayersExample_Player : MonoBehaviour
	{
		[Token(Token = "0x4005BFC")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		[Token(Token = "0x4005BFD")]
		[FieldOffset(Offset = "0x1C")]
		public float moveSpeed;

		[Token(Token = "0x4005BFE")]
		[FieldOffset(Offset = "0x20")]
		public float bulletSpeed;

		[Token(Token = "0x4005BFF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject bulletPrefab;

		[Token(Token = "0x4005C00")]
		[FieldOffset(Offset = "0x30")]
		private Player player;

		[Token(Token = "0x4005C01")]
		[FieldOffset(Offset = "0x38")]
		private CharacterController cc;

		[Token(Token = "0x4005C02")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 moveVector;

		[Token(Token = "0x4005C03")]
		[FieldOffset(Offset = "0x4C")]
		private bool fire;

		[NonSerialized]
		[Token(Token = "0x4005C04")]
		[FieldOffset(Offset = "0x4D")]
		private bool initialized;

		[Token(Token = "0x6004F77")]
		[Address(RVA = "0x143B804", Offset = "0x143B804", VA = "0x143B804")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004F78")]
		[Address(RVA = "0x143B860", Offset = "0x143B860", VA = "0x143B860")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6004F79")]
		[Address(RVA = "0x143B8EC", Offset = "0x143B8EC", VA = "0x143B8EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F7A")]
		[Address(RVA = "0x143BA20", Offset = "0x143BA20", VA = "0x143BA20")]
		private void GetInput()
		{
		}

		[Token(Token = "0x6004F7B")]
		[Address(RVA = "0x143BAD8", Offset = "0x143BAD8", VA = "0x143BAD8")]
		private void ProcessInput()
		{
		}

		[Token(Token = "0x6004F7C")]
		[Address(RVA = "0x143BCEC", Offset = "0x143BCEC", VA = "0x143BCEC")]
		public EightPlayersExample_Player()
		{
		}
	}
}
