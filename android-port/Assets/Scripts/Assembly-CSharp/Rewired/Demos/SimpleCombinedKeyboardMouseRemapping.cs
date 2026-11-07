using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos
{
	[Token(Token = "0x2001172")]
	public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour
	{
		[Token(Token = "0x2001173")]
		private class Row
		{
			[Token(Token = "0x4005C44")]
			[FieldOffset(Offset = "0x10")]
			public InputAction action;

			[Token(Token = "0x4005C45")]
			[FieldOffset(Offset = "0x18")]
			public AxisRange actionRange;

			[Token(Token = "0x4005C46")]
			[FieldOffset(Offset = "0x20")]
			public Button button;

			[Token(Token = "0x4005C47")]
			[FieldOffset(Offset = "0x28")]
			public Text text;

			[Token(Token = "0x6004FC9")]
			[Address(RVA = "0x184DCF4", Offset = "0x184DCF4", VA = "0x184DCF4")]
			public Row()
			{
			}
		}

		[Token(Token = "0x2001174")]
		private struct TargetMapping
		{
			[Token(Token = "0x4005C48")]
			[FieldOffset(Offset = "0x0")]
			public ControllerMap controllerMap;

			[Token(Token = "0x4005C49")]
			[FieldOffset(Offset = "0x8")]
			public int actionElementMapId;
		}

		[Token(Token = "0x2001175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4801C", Offset = "0x4801C")]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			[Token(Token = "0x4005C4A")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x4005C4B")]
			[FieldOffset(Offset = "0x14")]
			public int actionElementMapId;

			[Token(Token = "0x4005C4C")]
			[FieldOffset(Offset = "0x18")]
			public SimpleCombinedKeyboardMouseRemapping _003C_003E4__this;

			[Token(Token = "0x6004FCA")]
			[Address(RVA = "0x184D914", Offset = "0x184D914", VA = "0x184D914")]
			public _003C_003Ec__DisplayClass17_0()
			{
			}

			[Token(Token = "0x6004FCB")]
			[Address(RVA = "0x184D91C", Offset = "0x184D91C", VA = "0x184D91C")]
			internal void _003CRedrawUI_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2001176")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4802C", Offset = "0x4802C")]
		private sealed class _003CStartListeningDelayed_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005C4D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005C4E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005C4F")]
			[FieldOffset(Offset = "0x20")]
			public SimpleCombinedKeyboardMouseRemapping _003C_003E4__this;

			[Token(Token = "0x4005C50")]
			[FieldOffset(Offset = "0x28")]
			public int index;

			[Token(Token = "0x4005C51")]
			[FieldOffset(Offset = "0x30")]
			public ControllerMap keyboardMap;

			[Token(Token = "0x4005C52")]
			[FieldOffset(Offset = "0x38")]
			public int actionElementMapToReplaceId;

			[Token(Token = "0x4005C53")]
			[FieldOffset(Offset = "0x40")]
			public ControllerMap mouseMap;

			[Token(Token = "0x17000892")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004FCF")]
				[Address(RVA = "0x184DCA4", Offset = "0x184DCA4", VA = "0x184DCA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000893")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004FD1")]
				[Address(RVA = "0x184DCEC", Offset = "0x184DCEC", VA = "0x184DCEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004FCC")]
			[Address(RVA = "0x184D940", Offset = "0x184D940", VA = "0x184D940")]
			[DebuggerHidden]
			public _003CStartListeningDelayed_003Ed__22(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004FCD")]
			[Address(RVA = "0x184D96C", Offset = "0x184D96C", VA = "0x184D96C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004FCE")]
			[Address(RVA = "0x184D970", Offset = "0x184D970", VA = "0x184D970", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004FCF")]
			[Address(RVA = "0x184DCA4", Offset = "0x184DCA4", VA = "0x184DCA4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004FD0")]
			[Address(RVA = "0x184DCAC", Offset = "0x184DCAC", VA = "0x184DCAC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004FD1")]
			[Address(RVA = "0x184DCEC", Offset = "0x184DCEC", VA = "0x184DCEC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005C37")]
		private const string category = "Default";

		[Token(Token = "0x4005C38")]
		private const string layout = "Default";

		[Token(Token = "0x4005C39")]
		private const string uiCategory = "UI";

		[Token(Token = "0x4005C3A")]
		[FieldOffset(Offset = "0x18")]
		private InputMapper inputMapper_keyboard;

		[Token(Token = "0x4005C3B")]
		[FieldOffset(Offset = "0x20")]
		private InputMapper inputMapper_mouse;

		[Token(Token = "0x4005C3C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject buttonPrefab;

		[Token(Token = "0x4005C3D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject textPrefab;

		[Token(Token = "0x4005C3E")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform fieldGroupTransform;

		[Token(Token = "0x4005C3F")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform actionGroupTransform;

		[Token(Token = "0x4005C40")]
		[FieldOffset(Offset = "0x48")]
		public Text controllerNameUIText;

		[Token(Token = "0x4005C41")]
		[FieldOffset(Offset = "0x50")]
		public Text statusUIText;

		[Token(Token = "0x4005C42")]
		[FieldOffset(Offset = "0x58")]
		private List<Row> rows;

		[Token(Token = "0x4005C43")]
		[FieldOffset(Offset = "0x60")]
		private TargetMapping _replaceTargetMapping;

		[Token(Token = "0x17000891")]
		private Player player
		{
			[Token(Token = "0x6004FBD")]
			[Address(RVA = "0x16A8DDC", Offset = "0x16A8DDC", VA = "0x16A8DDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FBE")]
		[Address(RVA = "0x16A8E4C", Offset = "0x16A8E4C", VA = "0x16A8E4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6004FBF")]
		[Address(RVA = "0x16A9B24", Offset = "0x16A9B24", VA = "0x16A9B24")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0x16A9B80", Offset = "0x16A9B80", VA = "0x16A9B80")]
		private void RedrawUI()
		{
		}

		[Token(Token = "0x6004FC1")]
		[Address(RVA = "0x16AA188", Offset = "0x16AA188", VA = "0x16AA188")]
		private void ClearUI()
		{
		}

		[Token(Token = "0x6004FC2")]
		[Address(RVA = "0x16A9128", Offset = "0x16A9128", VA = "0x16A9128")]
		private void InitializeUI()
		{
		}

		[Token(Token = "0x6004FC3")]
		[Address(RVA = "0x16AA278", Offset = "0x16AA278", VA = "0x16AA278")]
		private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
		{
		}

		[Token(Token = "0x6004FC4")]
		[Address(RVA = "0x16AA480", Offset = "0x16AA480", VA = "0x16AA480")]
		private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
		{
		}

		[Token(Token = "0x6004FC5")]
		[Address(RVA = "0x16AA6CC", Offset = "0x16AA6CC", VA = "0x16AA6CC")]
		private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
		{
			return null;
		}

		[Token(Token = "0x6004FC6")]
		[Address(RVA = "0x16AA770", Offset = "0x16AA770", VA = "0x16AA770")]
		private void OnInputMapped(InputMapper.InputMappedEventData data)
		{
		}

		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0x16AA7E8", Offset = "0x16AA7E8", VA = "0x16AA7E8")]
		private void OnStopped(InputMapper.StoppedEventData data)
		{
		}

		[Token(Token = "0x6004FC8")]
		[Address(RVA = "0x16AA8E0", Offset = "0x16AA8E0", VA = "0x16AA8E0")]
		public SimpleCombinedKeyboardMouseRemapping()
		{
		}
	}
}
