using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public abstract class ComponentController : MonoBehaviour, IRegistrar<IComponentControl>, IComponentController
	{
		private sealed class HoePfFXnUnFevIlMoWpfJiTDGFeU : IDisposable, IEnumerator, IEnumerator<object>
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private object VqEePGSMyrGKIqkWibsjeHcWPSIx;

			public ComponentController TtytLoUfsgUyhsklaKccrnoMiiek;

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
			public HoePfFXnUnFevIlMoWpfJiTDGFeU(int P_0)
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

		[NonSerialized]
		private bool obpzIVquVRQseulcTcTZaHvizTjRA;

		[NonSerialized]
		private bool RePRCVbBZgCcBPtVnJbUMgMOGrtL;

		private List<IComponentControl> _controls;

		internal bool jYTNgflwwEgvgbZuuTHYnPAnuRao => oWiLLgLAcaWwLQraDxjPnTAHOnSe();

		internal bool oWiLLgLAcaWwLQraDxjPnTAHOnSe()
		{
			return false;
		}

		internal ComponentController()
		{
		}

		internal virtual void Awake()
		{
		}

		internal virtual void Update()
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

		internal virtual void OnDestroy()
		{
		}

		internal virtual bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return false;
		}

		internal virtual void sGOXUkdDJMvaXZNxRxZLevjalIqm()
		{
		}

		internal virtual void LYluBUMWPKbwashzGpNPLTeasipd()
		{
		}

		void IRegistrar<IComponentControl>.Register(IComponentControl control)
		{
		}

		void IRegistrar<IComponentControl>.Deregister(IComponentControl control)
		{
		}

		public virtual void ClearControlValues()
		{
		}

		private void qhuNDonLyhwaOUJVhxsLRGkQPgDT()
		{
		}

		private void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		private IEnumerator tkaLgOgyfPesbfcHrqkIAwRWsggK()
		{
			return null;
		}
	}
}
