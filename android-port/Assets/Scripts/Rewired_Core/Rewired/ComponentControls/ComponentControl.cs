using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[Token(Token = "0x20002C9")]
	[DisallowMultipleComponent]
	public abstract class ComponentControl : MonoBehaviour, IComponentControl
	{
		[Token(Token = "0x20002CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x191A1C", Offset = "0x191A1C")]
		private sealed class DGQGkJdqAwwNsKpEeYWflohTBBwc : IDisposable, IEnumerator, IEnumerator<object>
		{
			[Token(Token = "0x4000EAF")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x4000EB0")]
			[FieldOffset(Offset = "0x18")]
			private object VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000EB1")]
			[FieldOffset(Offset = "0x20")]
			public ComponentControl TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x17000590")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6001487")]
				[Address(RVA = "0x2450FF4", Offset = "0x2450FF4", VA = "0x2450FF4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000591")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6001489")]
				[Address(RVA = "0x245103C", Offset = "0x245103C", VA = "0x245103C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6001484")]
			[Address(RVA = "0x2450F50", Offset = "0x2450F50", VA = "0x2450F50")]
			[DebuggerHidden]
			public DGQGkJdqAwwNsKpEeYWflohTBBwc(int P_0)
			{
			}

			[Token(Token = "0x6001485")]
			[Address(RVA = "0x2450F7C", Offset = "0x2450F7C", VA = "0x2450F7C", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6001486")]
			[Address(RVA = "0x2450F80", Offset = "0x2450F80", VA = "0x2450F80", Slot = "5")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6001487")]
			[Address(RVA = "0x2450FF4", Offset = "0x2450FF4", VA = "0x2450FF4", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6001488")]
			[Address(RVA = "0x2450FFC", Offset = "0x2450FFC", VA = "0x2450FFC", Slot = "7")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6001489")]
			[Address(RVA = "0x245103C", Offset = "0x245103C", VA = "0x245103C", Slot = "6")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000EAB")]
		[FieldOffset(Offset = "0x18")]
		private IComponentController _controller;

		[NonSerialized]
		[Token(Token = "0x4000EAC")]
		[FieldOffset(Offset = "0x20")]
		private bool obpzIVquVRQseulcTcTZaHvizTjRA;

		[NonSerialized]
		[Token(Token = "0x4000EAD")]
		[FieldOffset(Offset = "0x21")]
		private bool RePRCVbBZgCcBPtVnJbUMgMOGrtL;

		[Token(Token = "0x4000EAE")]
		[FieldOffset(Offset = "0x24")]
		private int _lastUpdateFrame;

		[Token(Token = "0x1700058E")]
		internal abstract bool osKcqUcyYlVGlGygpMaOnUYNqJDBA
		{
			[Token(Token = "0x6001465")]
			get;
		}

		[Token(Token = "0x1700058F")]
		internal bool jYTNgflwwEgvgbZuuTHYnPAnuRao
		{
			[Token(Token = "0x6001466")]
			[Address(RVA = "0x23512C0", Offset = "0x23512C0", VA = "0x23512C0")]
			get
			{
				return oWiLLgLAcaWwLQraDxjPnTAHOnSe();
			}
		}

		[Token(Token = "0x6001465")]
		internal abstract bool zVMdwTfPKvDkNFioqslEyZNgriSF();

		[Token(Token = "0x6001466")]
		[Address(RVA = "0x23512C0", Offset = "0x23512C0", VA = "0x23512C0")]
		internal bool oWiLLgLAcaWwLQraDxjPnTAHOnSe()
		{
			return default;
		}

		[Token(Token = "0x6001467")]
		[Address(RVA = "0x23512C8", Offset = "0x23512C8", VA = "0x23512C8")]
		internal ComponentControl()
		{
		}

		[Token(Token = "0x6001468")]
		public abstract void ClearValue();

		[Token(Token = "0x6001469")]
		[Address(RVA = "0x23512D8", Offset = "0x23512D8", VA = "0x23512D8", Slot = "4")]
		private void Rewired_002EComponentControls_002EIComponentControl_002EUpdate()
		{
		}

		[Token(Token = "0x600146A")]
		[Address(RVA = "0x2351328", Offset = "0x2351328", VA = "0x2351328", Slot = "8")]
		internal virtual void Awake()
		{
		}

		[Token(Token = "0x600146B")]
		[Address(RVA = "0x2351334", Offset = "0x2351334", VA = "0x2351334", Slot = "9")]
		internal virtual void OnEnable()
		{
		}

		[Token(Token = "0x600146C")]
		[Address(RVA = "0x2351504", Offset = "0x2351504", VA = "0x2351504", Slot = "10")]
		internal virtual void OnDisable()
		{
		}

		[Token(Token = "0x600146D")]
		[Address(RVA = "0x2351548", Offset = "0x2351548", VA = "0x2351548", Slot = "11")]
		internal virtual void OnValidate()
		{
		}

		[Token(Token = "0x600146E")]
		[Address(RVA = "0x2351570", Offset = "0x2351570", VA = "0x2351570", Slot = "12")]
		internal virtual void OnCanvasGroupChanged()
		{
		}

		[Token(Token = "0x600146F")]
		[Address(RVA = "0x2351850", Offset = "0x2351850", VA = "0x2351850", Slot = "13")]
		internal virtual void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6001470")]
		[Address(RVA = "0x235186C", Offset = "0x235186C", VA = "0x235186C", Slot = "14")]
		internal virtual void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6001471")]
		[Address(RVA = "0x2351870", Offset = "0x2351870", VA = "0x2351870", Slot = "15")]
		internal virtual void Reset()
		{
		}

		[Token(Token = "0x6001472")]
		[Address(RVA = "0x2351874", Offset = "0x2351874", VA = "0x2351874", Slot = "16")]
		internal virtual void ZCGETbjMQZUkyflRtYAqwQNUBPQIb()
		{
		}

		[Token(Token = "0x6001473")]
		[Address(RVA = "0x2351878", Offset = "0x2351878", VA = "0x2351878", Slot = "17")]
		internal virtual bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return default;
		}

		[Token(Token = "0x6001474")]
		[Address(RVA = "0x2351960", Offset = "0x2351960", VA = "0x2351960", Slot = "18")]
		internal virtual void lelFPleVPpiYwgZaVbxuBHPfxsFeA()
		{
		}

		[Token(Token = "0x6001475")]
		[Address(RVA = "0x2351A58", Offset = "0x2351A58", VA = "0x2351A58", Slot = "19")]
		internal virtual void sGOXUkdDJMvaXZNxRxZLevjalIqm()
		{
		}

		[Token(Token = "0x6001476")]
		[Address(RVA = "0x2351AA0", Offset = "0x2351AA0", VA = "0x2351AA0", Slot = "20")]
		internal virtual void LYluBUMWPKbwashzGpNPLTeasipd()
		{
		}

		[Token(Token = "0x6001477")]
		[Address(RVA = "0x2351AAC", Offset = "0x2351AAC", VA = "0x2351AAC", Slot = "21")]
		internal virtual void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		[Token(Token = "0x6001478")]
		[Address(RVA = "0x2351AC8", Offset = "0x2351AC8", VA = "0x2351AC8", Slot = "22")]
		internal virtual void vXIboQFSGKdCLZnWmauizJnaOLuX()
		{
		}

		[Token(Token = "0x6001479")]
		[Address(RVA = "0x2351ACC", Offset = "0x2351ACC", VA = "0x2351ACC", Slot = "23")]
		internal virtual void AOKLCSwSOHWHrUKFiqLEizXMqAyJ()
		{
		}

		[Token(Token = "0x600147A")]
		[Address(RVA = "0x2351AD0", Offset = "0x2351AD0", VA = "0x2351AD0")]
		internal bool EDufGzVNigBlMAOWvMGsHZmtQaph()
		{
			return default;
		}

		[Token(Token = "0x600147B")]
		[Address(RVA = "0x2351B4C", Offset = "0x2351B4C", VA = "0x2351B4C")]
		internal bool RyWbwvHKmMifMfqUEuQHCCdFAIHzD()
		{
			return default;
		}

		[Token(Token = "0x600147C")]
		[Address(RVA = "0x2351BCC", Offset = "0x2351BCC", VA = "0x2351BCC")]
		internal IComponentController kVndxYkOyKrGmxUDdlmyfMvjGUQDA()
		{
			return null;
		}

		[Token(Token = "0x600147D")]
		internal abstract IComponentController FindController();

		[Token(Token = "0x600147E")]
		internal abstract Type GetRequiredControllerType();

		[Token(Token = "0x600147F")]
		[Address(RVA = "0x2351428", Offset = "0x2351428", VA = "0x2351428")]
		private IEnumerator pszdJEkXjPTJncstTUIWtRdIvwUM()
		{
			return null;
		}

		[Token(Token = "0x6001480")]
		[Address(RVA = "0x235149C", Offset = "0x235149C", VA = "0x235149C")]
		private void qhuNDonLyhwaOUJVhxsLRGkQPgDT()
		{
		}

		[Token(Token = "0x6001481")]
		[Address(RVA = "0x235158C", Offset = "0x235158C", VA = "0x235158C")]
		private bool nGHzehsIbiveZqWLVMehuidueiKkA(bool P_0, bool P_1)
		{
			return default;
		}

		[Token(Token = "0x6001482")]
		[Address(RVA = "0x2351564", Offset = "0x2351564", VA = "0x2351564")]
		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		[Token(Token = "0x6001483")]
		[Address(RVA = "0x2351BD4", Offset = "0x2351BD4", VA = "0x2351BD4")]
		private void mymCkzUBjdFeOqwLJiYHNYJyCAjc()
		{
		}
	}
}
