using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public abstract class ComponentControl : MonoBehaviour, IComponentControl
	{
		private sealed class DGQGkJdqAwwNsKpEeYWflohTBBwc : IDisposable, IEnumerator, IEnumerator<object>
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private object VqEePGSMyrGKIqkWibsjeHcWPSIx;

			public ComponentControl TtytLoUfsgUyhsklaKccrnoMiiek;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public DGQGkJdqAwwNsKpEeYWflohTBBwc(int P_0)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private IComponentController _controller;

		[NonSerialized]
		private bool obpzIVquVRQseulcTcTZaHvizTjRA;

		[NonSerialized]
		private bool RePRCVbBZgCcBPtVnJbUMgMOGrtL;

		private int _lastUpdateFrame;

		internal abstract bool osKcqUcyYlVGlGygpMaOnUYNqJDBA { get; }

		internal bool jYTNgflwwEgvgbZuuTHYnPAnuRao => oWiLLgLAcaWwLQraDxjPnTAHOnSe();

		internal abstract bool zVMdwTfPKvDkNFioqslEyZNgriSF();

		internal bool oWiLLgLAcaWwLQraDxjPnTAHOnSe()
		{
			return false;
		}

		internal ComponentControl()
		{
		}

		public abstract void ClearValue();

		void IComponentControl.Update()
		{
		}

		internal virtual void Awake()
		{
		}

		internal virtual void OnEnable()
		{
		}

		internal virtual void OnDisable()
		{
		}

		internal virtual void OnValidate()
		{
		}

		internal virtual void OnCanvasGroupChanged()
		{
		}

		internal virtual void OnTransformParentChanged()
		{
		}

		internal virtual void OnDidApplyAnimationProperties()
		{
		}

		internal virtual void Reset()
		{
		}

		internal virtual void ZCGETbjMQZUkyflRtYAqwQNUBPQIb()
		{
		}

		internal virtual bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return false;
		}

		internal virtual void lelFPleVPpiYwgZaVbxuBHPfxsFeA()
		{
		}

		internal virtual void sGOXUkdDJMvaXZNxRxZLevjalIqm()
		{
		}

		internal virtual void LYluBUMWPKbwashzGpNPLTeasipd()
		{
		}

		internal virtual void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		internal virtual void vXIboQFSGKdCLZnWmauizJnaOLuX()
		{
		}

		internal virtual void AOKLCSwSOHWHrUKFiqLEizXMqAyJ()
		{
		}

		internal bool EDufGzVNigBlMAOWvMGsHZmtQaph()
		{
			return false;
		}

		internal bool RyWbwvHKmMifMfqUEuQHCCdFAIHzD()
		{
			return false;
		}

		internal IComponentController kVndxYkOyKrGmxUDdlmyfMvjGUQDA()
		{
			return null;
		}

		internal abstract IComponentController FindController();

		internal abstract Type GetRequiredControllerType();

		private IEnumerator pszdJEkXjPTJncstTUIWtRdIvwUM()
		{
			return null;
		}

		private void qhuNDonLyhwaOUJVhxsLRGkQPgDT()
		{
		}

		private bool nGHzehsIbiveZqWLVMehuidueiKkA(bool P_0, bool P_1)
		{
			return false;
		}

		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		private void mymCkzUBjdFeOqwLJiYHNYJyCAjc()
		{
		}
	}
}
