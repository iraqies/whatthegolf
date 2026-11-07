using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013E0")]
	public abstract class BaseAudioValue : MonoBehaviour
	{
		[Token(Token = "0x4006AD1")]
		[FieldOffset(Offset = "0x18")]
		public bool alwaysSetValue;

		[Token(Token = "0x4006AD2")]
		[FieldOffset(Offset = "0x19")]
		public bool forcePositiveValue;

		[Token(Token = "0x4006AD3")]
		[FieldOffset(Offset = "0x1A")]
		public bool transmitDelta;

		[Token(Token = "0x4006AD4")]
		[FieldOffset(Offset = "0x1C")]
		protected float value;

		[Token(Token = "0x4006AD5")]
		[FieldOffset(Offset = "0x20")]
		protected float lastValue;

		[Token(Token = "0x4006AD6")]
		[FieldOffset(Offset = "0x24")]
		protected float delta;

		[Token(Token = "0x4006AD7")]
		[FieldOffset(Offset = "0x28")]
		private bool stopTransmitting;

		[Token(Token = "0x4006AD8")]
		[FieldOffset(Offset = "0x29")]
		private bool isStopped;

		[Token(Token = "0x4006AD9")]
		[FieldOffset(Offset = "0x30")]
		public Action<float> onValueChange;

		[Token(Token = "0x17000A7F")]
		public float GetValue
		{
			[Token(Token = "0x6005CB3")]
			[Address(RVA = "0x151B5F0", Offset = "0x151B5F0", VA = "0x151B5F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A80")]
		protected abstract bool Use2D
		{
			[Token(Token = "0x6005CB6")]
			get;
		}

		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0x151B5E8", Offset = "0x151B5E8", VA = "0x151B5E8", Slot = "4")]
		public virtual string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0x151B5F8", Offset = "0x151B5F8", VA = "0x151B5F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005CB5")]
		[Address(RVA = "0x151020C", Offset = "0x151020C", VA = "0x151020C", Slot = "5")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x6005CB7")]
		[Address(RVA = "0x151B604", Offset = "0x151B604", VA = "0x151B604")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005CB8")]
		[Address(RVA = "0x150F0CC", Offset = "0x150F0CC", VA = "0x150F0CC", Slot = "7")]
		protected virtual void SetValue()
		{
		}

		[Token(Token = "0x6005CB9")]
		[Address(RVA = "0x150F204", Offset = "0x150F204", VA = "0x150F204")]
		protected BaseAudioValue()
		{
		}
	}
}
