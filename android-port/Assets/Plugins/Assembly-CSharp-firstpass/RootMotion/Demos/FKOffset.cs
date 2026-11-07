using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001E0")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001E1")]
		public class Offset
		{
			[Token(Token = "0x4000CA0")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000CA1")]
			[FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000CA2")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000CA3")]
			[FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000D98")]
			[Address(RVA = "0x133A56C", Offset = "0x133A56C", VA = "0x133A56C")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000D99")]
			[Address(RVA = "0x133A6D4", Offset = "0x133A6D4", VA = "0x133A6D4")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000C9E")]
		[FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x136F37C", Offset = "0x136F37C", VA = "0x136F37C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x136F3D8", Offset = "0x136F3D8", VA = "0x136F3D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x136F454", Offset = "0x136F454", VA = "0x136F454")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x136F534", Offset = "0x136F534", VA = "0x136F534")]
		public FKOffset()
		{
		}
	}
}
