using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[Token(Token = "0x2000315")]
	public sealed class CustomControllerElementSelector
	{
		[Token(Token = "0x2000316")]
		public enum ElementType
		{
			[Token(Token = "0x400103C")]
			Axis = 0,
			[Token(Token = "0x400103D")]
			Button = 1
		}

		[Token(Token = "0x2000317")]
		public enum SelectorType
		{
			[Token(Token = "0x400103F")]
			Name = 0,
			[Token(Token = "0x4001040")]
			Index = 1,
			[Token(Token = "0x4001041")]
			Id = 2
		}

		[Token(Token = "0x4001034")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ElementType _elementType;

		[Token(Token = "0x4001035")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SelectorType _selectorType;

		[Token(Token = "0x4001036")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _elementName;

		[Token(Token = "0x4001037")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _elementIndex;

		[Token(Token = "0x4001038")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _elementId;

		[Token(Token = "0x4001039")]
		[FieldOffset(Offset = "0x28")]
		private int bZHBbmkmHZYQqFMtcmgNWgeBYwrIA;

		[Token(Token = "0x400103A")]
		[FieldOffset(Offset = "0x2C")]
		private int pwUzICXNXsZDQyMZeUuAfkUZfIkhA;

		[Token(Token = "0x1700065C")]
		public ElementType elementType
		{
			[Token(Token = "0x60017C0")]
			[Address(RVA = "0x23749C0", Offset = "0x23749C0", VA = "0x23749C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60017C1")]
			[Address(RVA = "0x23749C8", Offset = "0x23749C8", VA = "0x23749C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700065D")]
		public SelectorType selectorType
		{
			[Token(Token = "0x60017C2")]
			[Address(RVA = "0x23749F0", Offset = "0x23749F0", VA = "0x23749F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700065E")]
		public string elementName
		{
			[Token(Token = "0x60017C3")]
			[Address(RVA = "0x23749F8", Offset = "0x23749F8", VA = "0x23749F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700065F")]
		public int elementIndex
		{
			[Token(Token = "0x60017C4")]
			[Address(RVA = "0x2374A00", Offset = "0x2374A00", VA = "0x2374A00")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000660")]
		public int elementId
		{
			[Token(Token = "0x60017C5")]
			[Address(RVA = "0x2374A08", Offset = "0x2374A08", VA = "0x2374A08")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000661")]
		public bool isAssigned
		{
			[Token(Token = "0x60017C6")]
			[Address(RVA = "0x2372FAC", Offset = "0x2372FAC", VA = "0x2372FAC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x237258C", Offset = "0x237258C", VA = "0x237258C")]
		public int GetElementIndex(Rewired.CustomController customController)
		{
			return default;
		}

		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x23735D4", Offset = "0x23735D4", VA = "0x23735D4")]
		public string GetSelectorFormattedString()
		{
			return null;
		}

		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x2374A10", Offset = "0x2374A10", VA = "0x2374A10")]
		private IList<ControllerElementIdentifier> qvVwrYBAAXQrxjjpEuLZPbzRvhAq(Rewired.CustomController P_0, ElementType P_1)
		{
			return null;
		}

		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x23749E4", Offset = "0x23749E4", VA = "0x23749E4")]
		public void ClearCache()
		{
		}

		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x2374A8C", Offset = "0x2374A8C", VA = "0x2374A8C")]
		public CustomControllerElementSelector()
		{
		}
	}
}
