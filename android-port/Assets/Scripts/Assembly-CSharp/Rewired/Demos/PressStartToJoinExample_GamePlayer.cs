using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x2001170")]
	[Attribute(Name = "RequireComponent", RVA = "0x47FB4", Offset = "0x47FB4")]
	public class PressStartToJoinExample_GamePlayer : MonoBehaviour
	{
		[Token(Token = "0x4005C2D")]
		[FieldOffset(Offset = "0x18")]
		public int gamePlayerId;

		[Token(Token = "0x4005C2E")]
		[FieldOffset(Offset = "0x1C")]
		public float moveSpeed;

		[Token(Token = "0x4005C2F")]
		[FieldOffset(Offset = "0x20")]
		public float bulletSpeed;

		[Token(Token = "0x4005C30")]
		[FieldOffset(Offset = "0x28")]
		public GameObject bulletPrefab;

		[Token(Token = "0x4005C31")]
		[FieldOffset(Offset = "0x30")]
		private CharacterController cc;

		[Token(Token = "0x4005C32")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 moveVector;

		[Token(Token = "0x4005C33")]
		[FieldOffset(Offset = "0x44")]
		private bool fire;

		[Token(Token = "0x17000890")]
		private Player player
		{
			[Token(Token = "0x6004FB4")]
			[Address(RVA = "0x161F030", Offset = "0x161F030", VA = "0x161F030")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FB5")]
		[Address(RVA = "0x161F038", Offset = "0x161F038", VA = "0x161F038")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6004FB6")]
		[Address(RVA = "0x161F094", Offset = "0x161F094", VA = "0x161F094")]
		private void Update()
		{
		}

		[Token(Token = "0x6004FB7")]
		[Address(RVA = "0x161F16C", Offset = "0x161F16C", VA = "0x161F16C")]
		private void GetInput()
		{
		}

		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0x161F230", Offset = "0x161F230", VA = "0x161F230")]
		private void ProcessInput()
		{
		}

		[Token(Token = "0x6004FB9")]
		[Address(RVA = "0x161F444", Offset = "0x161F444", VA = "0x161F444")]
		public PressStartToJoinExample_GamePlayer()
		{
		}
	}
}
