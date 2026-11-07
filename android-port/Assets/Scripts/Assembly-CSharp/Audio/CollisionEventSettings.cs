using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200136B")]
	public class CollisionEventSettings : MonoBehaviour, IAudioEvent, ISetRigidbodyRoot
	{
		[Token(Token = "0x4006814")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float minVelocity;

		[Token(Token = "0x4006815")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float maxVelocity;

		[Token(Token = "0x4006816")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool includeAbove;

		[Token(Token = "0x4006817")]
		[FieldOffset(Offset = "0x28")]
		private GameObject root;

		[Token(Token = "0x4006818")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A4A0", Offset = "0x5A4A0")]
		private Action<Vector3> OnAudioEvent__BackingField;

		[Token(Token = "0x4006819")]
		[FieldOffset(Offset = "0x38")]
		private bool m_initialized;

		[Token(Token = "0x400681A")]
		[FieldOffset(Offset = "0x40")]
		private RigidbodyCollisionInfo collisionInfo;

		[Token(Token = "0x17000A40")]
		public Action<Vector3> OnAudioEvent
		{
			[Token(Token = "0x6005AB3")]
			[Address(RVA = "0x18A8840", Offset = "0x18A8840", VA = "0x18A8840", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72428", Offset = "0x72428")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AB4")]
			[Address(RVA = "0x18A8848", Offset = "0x18A8848", VA = "0x18A8848", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72438", Offset = "0x72438")]
			set
			{
			}
		}

		[Token(Token = "0x17000A41")]
		public GameObject GetRoot
		{
			[Token(Token = "0x6005AB5")]
			[Address(RVA = "0x18A8850", Offset = "0x18A8850", VA = "0x18A8850", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005AB6")]
		[Address(RVA = "0x18A8858", Offset = "0x18A8858", VA = "0x18A8858", Slot = "7")]
		public void SetRoot(GameObject _root)
		{
		}

		[Token(Token = "0x6005AB7")]
		[Address(RVA = "0x18A8860", Offset = "0x18A8860", VA = "0x18A8860")]
		public void AddCollisionInfo()
		{
		}

		[Token(Token = "0x6005AB8")]
		[Address(RVA = "0x18A8AB4", Offset = "0x18A8AB4", VA = "0x18A8AB4")]
		private void CollisionInfo_OnTrigger(TriggerInfo obj)
		{
		}

		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0x18A8B28", Offset = "0x18A8B28", VA = "0x18A8B28")]
		private void CollisionInfo_OnCollision(HitInfo obj)
		{
		}

		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0x18A8B9C", Offset = "0x18A8B9C", VA = "0x18A8B9C")]
		public CollisionEventSettings()
		{
		}
	}
}
