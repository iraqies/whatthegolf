using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[Token(Token = "0x2000310")]
	public class CustomControllerElementTarget
	{
		[Token(Token = "0x2000311")]
		internal enum ValueRange
		{
			[Token(Token = "0x400102B")]
			Full = 0,
			[Token(Token = "0x400102C")]
			Positive = 1,
			[Token(Token = "0x400102D")]
			Negative = 2
		}

		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CustomControllerElementSelector _element;

		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ValueRange _valueRange;

		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Pole _valueContribution;

		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _invert;

		[Token(Token = "0x1700064D")]
		public CustomControllerElementSelector element
		{
			[Token(Token = "0x60017A5")]
			[Address(RVA = "0x2374AAC", Offset = "0x2374AAC", VA = "0x2374AAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064E")]
		public Pole valueContribution
		{
			[Token(Token = "0x60017A6")]
			[Address(RVA = "0x2374AB4", Offset = "0x2374AB4", VA = "0x2374AB4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60017A7")]
			[Address(RVA = "0x2374ABC", Offset = "0x2374ABC", VA = "0x2374ABC")]
			set
			{
			}
		}

		[Token(Token = "0x1700064F")]
		internal ValueRange valueRange
		{
			[Token(Token = "0x60017A8")]
			[Address(RVA = "0x2374AC4", Offset = "0x2374AC4", VA = "0x2374AC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60017A9")]
			[Address(RVA = "0x2374ACC", Offset = "0x2374ACC", VA = "0x2374ACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000650")]
		public bool invert
		{
			[Token(Token = "0x60017AA")]
			[Address(RVA = "0x2374AD4", Offset = "0x2374AD4", VA = "0x2374AD4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x2374ADC", Offset = "0x2374ADC", VA = "0x2374ADC")]
		internal CustomControllerElementTarget()
		{
		}

		[Token(Token = "0x60017AC")]
		[Address(RVA = "0x2374B7C", Offset = "0x2374B7C", VA = "0x2374B7C")]
		internal CustomControllerElementTarget(CustomControllerElementSelector P_0)
		{
		}

		[Token(Token = "0x60017AD")]
		[Address(RVA = "0x2374C28", Offset = "0x2374C28", VA = "0x2374C28")]
		internal void ClearElementCaches()
		{
		}
	}
}
