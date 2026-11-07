using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001368")]
	public class OnCollisionAudioManyColliders : OnCollisionAudioBase
	{
		[Token(Token = "0x400680A")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Rigidbody rigid;

		[Token(Token = "0x400680B")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Rigidbody2D rigid2D;

		[Token(Token = "0x400680C")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<GameObject> parts;

		[Token(Token = "0x400680D")]
		[FieldOffset(Offset = "0x138")]
		private RigidbodyCollisionInfo collisionInfo;

		[Token(Token = "0x17000A3B")]
		private bool IsUsing2D
		{
			[Token(Token = "0x6005A99")]
			[Address(RVA = "0x1597958", Offset = "0x1597958", VA = "0x1597958")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A3C")]
		private bool IsUsingAnyRigidbody
		{
			[Token(Token = "0x6005A9A")]
			[Address(RVA = "0x1597A1C", Offset = "0x1597A1C", VA = "0x1597A1C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A3D")]
		private GameObject GetRootGameObject
		{
			[Token(Token = "0x6005A9B")]
			[Address(RVA = "0x1597AE4", Offset = "0x1597AE4", VA = "0x1597AE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005A9C")]
		[Address(RVA = "0x1597BCC", Offset = "0x1597BCC", VA = "0x1597BCC")]
		private void Start()
		{
		}

		[Token(Token = "0x6005A9D")]
		[Address(RVA = "0x1597E6C", Offset = "0x1597E6C", VA = "0x1597E6C")]
		public void AddPart(GameObject go)
		{
		}

		[Token(Token = "0x6005A9E")]
		[Address(RVA = "0x1597ED0", Offset = "0x1597ED0", VA = "0x1597ED0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6005A9F")]
		[Address(RVA = "0x159813C", Offset = "0x159813C", VA = "0x159813C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005AA0")]
		[Address(RVA = "0x1598264", Offset = "0x1598264", VA = "0x1598264")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005AA1")]
		[Address(RVA = "0x159838C", Offset = "0x159838C", VA = "0x159838C")]
		private void CollisionInfo_OnCollision(HitInfo obj)
		{
		}

		[Token(Token = "0x6005AA2")]
		[Address(RVA = "0x1598424", Offset = "0x1598424", VA = "0x1598424")]
		public OnCollisionAudioManyColliders()
		{
		}
	}
}
