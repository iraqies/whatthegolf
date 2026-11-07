using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos
{
	[Token(Token = "0x2001177")]
	public class SimpleControlRemapping : MonoBehaviour
	{
		[Token(Token = "0x2001178")]
		private class Row
		{
			[Token(Token = "0x4005C61")]
			[FieldOffset(Offset = "0x10")]
			public InputAction action;

			[Token(Token = "0x4005C62")]
			[FieldOffset(Offset = "0x18")]
			public AxisRange actionRange;

			[Token(Token = "0x4005C63")]
			[FieldOffset(Offset = "0x20")]
			public Button button;

			[Token(Token = "0x4005C64")]
			[FieldOffset(Offset = "0x28")]
			public Text text;

			[Token(Token = "0x6004FE3")]
			[Address(RVA = "0x184E000", Offset = "0x184E000", VA = "0x184E000")]
			public Row()
			{
			}
		}

		[Token(Token = "0x2001179")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4803C", Offset = "0x4803C")]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			[Token(Token = "0x4005C65")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x4005C66")]
			[FieldOffset(Offset = "0x14")]
			public int actionElementMapId;

			[Token(Token = "0x4005C67")]
			[FieldOffset(Offset = "0x18")]
			public SimpleControlRemapping _003C_003E4__this;

			[Token(Token = "0x6004FE4")]
			[Address(RVA = "0x184DCFC", Offset = "0x184DCFC", VA = "0x184DCFC")]
			public _003C_003Ec__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6004FE5")]
			[Address(RVA = "0x184DD04", Offset = "0x184DD04", VA = "0x184DD04")]
			internal void _003CRedrawUI_003Eb__0()
			{
			}
		}

		[Token(Token = "0x200117A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4804C", Offset = "0x4804C")]
		private sealed class _003CStartListeningDelayed_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005C68")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005C69")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005C6A")]
			[FieldOffset(Offset = "0x20")]
			public SimpleControlRemapping _003C_003E4__this;

			[Token(Token = "0x4005C6B")]
			[FieldOffset(Offset = "0x28")]
			public int index;

			[Token(Token = "0x4005C6C")]
			[FieldOffset(Offset = "0x2C")]
			public int actionElementMapToReplaceId;

			[Token(Token = "0x17000897")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004FE9")]
				[Address(RVA = "0x184DFB0", Offset = "0x184DFB0", VA = "0x184DFB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000898")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004FEB")]
				[Address(RVA = "0x184DFF8", Offset = "0x184DFF8", VA = "0x184DFF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004FE6")]
			[Address(RVA = "0x184DD28", Offset = "0x184DD28", VA = "0x184DD28")]
			[DebuggerHidden]
			public _003CStartListeningDelayed_003Ed__28(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004FE7")]
			[Address(RVA = "0x184DD54", Offset = "0x184DD54", VA = "0x184DD54", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004FE8")]
			[Address(RVA = "0x184DD58", Offset = "0x184DD58", VA = "0x184DD58", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004FE9")]
			[Address(RVA = "0x184DFB0", Offset = "0x184DFB0", VA = "0x184DFB0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004FEA")]
			[Address(RVA = "0x184DFB8", Offset = "0x184DFB8", VA = "0x184DFB8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004FEB")]
			[Address(RVA = "0x184DFF8", Offset = "0x184DFF8", VA = "0x184DFF8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005C54")]
		private const string category = "Default";

		[Token(Token = "0x4005C55")]
		private const string layout = "Default";

		[Token(Token = "0x4005C56")]
		private const string uiCategory = "UI";

		[Token(Token = "0x4005C57")]
		[FieldOffset(Offset = "0x18")]
		private InputMapper inputMapper;

		[Token(Token = "0x4005C58")]
		[FieldOffset(Offset = "0x20")]
		public GameObject buttonPrefab;

		[Token(Token = "0x4005C59")]
		[FieldOffset(Offset = "0x28")]
		public GameObject textPrefab;

		[Token(Token = "0x4005C5A")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform fieldGroupTransform;

		[Token(Token = "0x4005C5B")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform actionGroupTransform;

		[Token(Token = "0x4005C5C")]
		[FieldOffset(Offset = "0x40")]
		public Text controllerNameUIText;

		[Token(Token = "0x4005C5D")]
		[FieldOffset(Offset = "0x48")]
		public Text statusUIText;

		[Token(Token = "0x4005C5E")]
		[FieldOffset(Offset = "0x50")]
		private ControllerType selectedControllerType;

		[Token(Token = "0x4005C5F")]
		[FieldOffset(Offset = "0x54")]
		private int selectedControllerId;

		[Token(Token = "0x4005C60")]
		[FieldOffset(Offset = "0x58")]
		private List<Row> rows;

		[Token(Token = "0x17000894")]
		private Player player
		{
			[Token(Token = "0x6004FD2")]
			[Address(RVA = "0x16AA9AC", Offset = "0x16AA9AC", VA = "0x16AA9AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000895")]
		private ControllerMap controllerMap
		{
			[Token(Token = "0x6004FD3")]
			[Address(RVA = "0x16AAA1C", Offset = "0x16AAA1C", VA = "0x16AAA1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000896")]
		private Controller controller
		{
			[Token(Token = "0x6004FD4")]
			[Address(RVA = "0x16AAB30", Offset = "0x16AAB30", VA = "0x16AAB30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FD5")]
		[Address(RVA = "0x16AABC4", Offset = "0x16AABC4", VA = "0x16AABC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6004FD6")]
		[Address(RVA = "0x16AB870", Offset = "0x16AB870", VA = "0x16AB870")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6004FD7")]
		[Address(RVA = "0x16AB988", Offset = "0x16AB988", VA = "0x16AB988")]
		private void RedrawUI()
		{
		}

		[Token(Token = "0x6004FD8")]
		[Address(RVA = "0x16ABF04", Offset = "0x16ABF04", VA = "0x16ABF04")]
		private void ClearUI()
		{
		}

		[Token(Token = "0x6004FD9")]
		[Address(RVA = "0x16AAE74", Offset = "0x16AAE74", VA = "0x16AAE74")]
		private void InitializeUI()
		{
		}

		[Token(Token = "0x6004FDA")]
		[Address(RVA = "0x16AC01C", Offset = "0x16AC01C", VA = "0x16AC01C")]
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
		{
		}

		[Token(Token = "0x6004FDB")]
		[Address(RVA = "0x16AC224", Offset = "0x16AC224", VA = "0x16AC224")]
		private void SetSelectedController(ControllerType controllerType)
		{
		}

		[Token(Token = "0x6004FDC")]
		[Address(RVA = "0x16AC430", Offset = "0x16AC430", VA = "0x16AC430")]
		public void OnControllerSelected(int controllerType)
		{
		}

		[Token(Token = "0x6004FDD")]
		[Address(RVA = "0x16AC434", Offset = "0x16AC434", VA = "0x16AC434")]
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
		{
		}

		[Token(Token = "0x6004FDE")]
		[Address(RVA = "0x16AC51C", Offset = "0x16AC51C", VA = "0x16AC51C")]
		private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId)
		{
			return null;
		}

		[Token(Token = "0x6004FDF")]
		[Address(RVA = "0x16AC5A4", Offset = "0x16AC5A4", VA = "0x16AC5A4")]
		private void OnControllerChanged(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6004FE0")]
		[Address(RVA = "0x16AC5AC", Offset = "0x16AC5AC", VA = "0x16AC5AC")]
		private void OnInputMapped(InputMapper.InputMappedEventData data)
		{
		}

		[Token(Token = "0x6004FE1")]
		[Address(RVA = "0x16AC5B0", Offset = "0x16AC5B0", VA = "0x16AC5B0")]
		private void OnStopped(InputMapper.StoppedEventData data)
		{
		}

		[Token(Token = "0x6004FE2")]
		[Address(RVA = "0x16AC6A8", Offset = "0x16AC6A8", VA = "0x16AC6A8")]
		public SimpleControlRemapping()
		{
		}
	}
}
