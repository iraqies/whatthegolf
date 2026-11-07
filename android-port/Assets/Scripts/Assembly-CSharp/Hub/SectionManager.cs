using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x2001082")]
	public class SectionManager : MonoBehaviour
	{
		[Token(Token = "0x2001083")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x479B4", Offset = "0x479B4")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40056E5")]
			[FieldOffset(Offset = "0x10")]
			public HubPlatformSection section;

			[Token(Token = "0x6004A0A")]
			[Address(RVA = "0x18409C4", Offset = "0x18409C4", VA = "0x18409C4")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6004A0B")]
			[Address(RVA = "0x18409CC", Offset = "0x18409CC", VA = "0x18409CC")]
			internal bool _003CInit_003Eb__1(ContentPackDef c)
			{
				return default;
			}
		}

		[Token(Token = "0x2001084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x479C4", Offset = "0x479C4")]
		private sealed class _003CFixColliders_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40056E6")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40056E7")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40056E8")]
			[FieldOffset(Offset = "0x20")]
			public SectionManager _003C_003E4__this;

			[Token(Token = "0x170007CB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004A0F")]
				[Address(RVA = "0x1840B24", Offset = "0x1840B24", VA = "0x1840B24", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007CC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004A11")]
				[Address(RVA = "0x1840B6C", Offset = "0x1840B6C", VA = "0x1840B6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004A0C")]
			[Address(RVA = "0x1840A00", Offset = "0x1840A00", VA = "0x1840A00")]
			[DebuggerHidden]
			public _003CFixColliders_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004A0D")]
			[Address(RVA = "0x1840A2C", Offset = "0x1840A2C", VA = "0x1840A2C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004A0E")]
			[Address(RVA = "0x1840A30", Offset = "0x1840A30", VA = "0x1840A30", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004A0F")]
			[Address(RVA = "0x1840B24", Offset = "0x1840B24", VA = "0x1840B24", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004A10")]
			[Address(RVA = "0x1840B2C", Offset = "0x1840B2C", VA = "0x1840B2C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004A11")]
			[Address(RVA = "0x1840B6C", Offset = "0x1840B6C", VA = "0x1840B6C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40056DC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject mainSectionPortrait;

		[Token(Token = "0x40056DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject mainSectionLandscape;

		[Token(Token = "0x40056DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject leftSectionPortrait;

		[Token(Token = "0x40056DF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject leftSectionLandscape;

		[Token(Token = "0x40056E0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject rightSectionPortrait;

		[Token(Token = "0x40056E1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject rightSectionLandscape;

		[Token(Token = "0x40056E2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<HideAreaOnConsoles> hideAreasScriptList;

		[Token(Token = "0x40056E3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GridFiller gridFiller;

		[Token(Token = "0x40056E4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<HubPlatformSection> hubPlatformSections;

		[Token(Token = "0x6004A06")]
		[Address(RVA = "0x1682900", Offset = "0x1682900", VA = "0x1682900")]
		public void Init()
		{
		}

		[Token(Token = "0x6004A07")]
		[Address(RVA = "0x1682DB4", Offset = "0x1682DB4", VA = "0x1682DB4")]
		private IEnumerator FixColliders()
		{
			return null;
		}

		[Token(Token = "0x6004A08")]
		[Address(RVA = "0x1682E28", Offset = "0x1682E28", VA = "0x1682E28")]
		public SectionManager()
		{
		}

		[Token(Token = "0x6004A09")]
		[Address(RVA = "0x1682EA8", Offset = "0x1682EA8", VA = "0x1682EA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F3D4", Offset = "0x6F3D4")]
		private void _003CInit_003Eb__9_0()
		{
		}
	}
}
