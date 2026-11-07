using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	[Token(Token = "0x200006A")]
	[DisallowMultipleComponent]
	public class ToggleGroup : UIBehaviour
	{
		[Serializable]
		[Token(Token = "0x200006B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F69F4", Offset = "0x1F69F4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400022A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400022B")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<Toggle> _003C_003E9__13_0;

			[Token(Token = "0x400022C")]
			[FieldOffset(Offset = "0x10")]
			public static Func<Toggle, bool> _003C_003E9__14_0;

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x2C48CDC", Offset = "0x2C48CDC", VA = "0x2C48CDC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x2C48CE4", Offset = "0x2C48CE4", VA = "0x2C48CE4")]
			internal bool _003CAnyTogglesOn_003Eb__13_0(Toggle x)
			{
				return default;
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x2C48CFC", Offset = "0x2C48CFC", VA = "0x2C48CFC")]
			internal bool _003CActiveToggles_003Eb__14_0(Toggle x)
			{
				return default;
			}
		}

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_AllowSwitchOff;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x20")]
		protected List<Toggle> m_Toggles;

		[Token(Token = "0x1700014C")]
		public bool allowSwitchOff
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x2C421C0", Offset = "0x2C421C0", VA = "0x2C421C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x2C421C8", Offset = "0x2C421C8", VA = "0x2C421C8")]
			set
			{
			}
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2C421D0", Offset = "0x2C421D0", VA = "0x2C421D0")]
		protected ToggleGroup()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2C42250", Offset = "0x2C42250", VA = "0x2C42250", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2C42258", Offset = "0x2C42258", VA = "0x2C42258", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2C4225C", Offset = "0x2C4225C", VA = "0x2C4225C")]
		private void ValidateToggleIsInGroup(Toggle toggle)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2C41D70", Offset = "0x2C41D70", VA = "0x2C41D70")]
		public void NotifyToggleOn(Toggle toggle, bool sendCallback = true)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2C41C30", Offset = "0x2C41C30", VA = "0x2C41C30")]
		public void UnregisterToggle(Toggle toggle)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2C41CD0", Offset = "0x2C41CD0", VA = "0x2C41CD0")]
		public void RegisterToggle(Toggle toggle)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2C414AC", Offset = "0x2C414AC", VA = "0x2C414AC")]
		public void EnsureValidState()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2C41EFC", Offset = "0x2C41EFC", VA = "0x2C41EFC")]
		public bool AnyTogglesOn()
		{
			return default;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2C423B8", Offset = "0x2C423B8", VA = "0x2C423B8")]
		public IEnumerable<Toggle> ActiveToggles()
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2C424EC", Offset = "0x2C424EC", VA = "0x2C424EC")]
		public Toggle GetFirstActiveToggle()
		{
			return null;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2C42588", Offset = "0x2C42588", VA = "0x2C42588")]
		public void SetAllTogglesOff(bool sendCallback = true)
		{
		}
	}
}
