using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[Token(Token = "0x20002CB")]
	[DisallowMultipleComponent]
	public abstract class ComponentController : MonoBehaviour, IRegistrar<IComponentControl>, IComponentController
	{
		[Token(Token = "0x20002CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x191A3C", Offset = "0x191A3C")]
		private sealed class HoePfFXnUnFevIlMoWpfJiTDGFeU : IDisposable, IEnumerator, IEnumerator<object>
		{
			[Token(Token = "0x4000EB5")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x4000EB6")]
			[FieldOffset(Offset = "0x18")]
			private object VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000EB7")]
			[FieldOffset(Offset = "0x20")]
			public ComponentController TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x17000593")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600149E")]
				[Address(RVA = "0x24510D4", Offset = "0x24510D4", VA = "0x24510D4", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000594")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60014A0")]
				[Address(RVA = "0x245111C", Offset = "0x245111C", VA = "0x245111C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600149B")]
			[Address(RVA = "0x2451044", Offset = "0x2451044", VA = "0x2451044")]
			[DebuggerHidden]
			public HoePfFXnUnFevIlMoWpfJiTDGFeU(int P_0)
			{
			}

			[Token(Token = "0x600149C")]
			[Address(RVA = "0x2451070", Offset = "0x2451070", VA = "0x2451070", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600149D")]
			[Address(RVA = "0x2451074", Offset = "0x2451074", VA = "0x2451074", Slot = "5")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600149E")]
			[Address(RVA = "0x24510D4", Offset = "0x24510D4", VA = "0x24510D4", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600149F")]
			[Address(RVA = "0x24510DC", Offset = "0x24510DC", VA = "0x24510DC", Slot = "7")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60014A0")]
			[Address(RVA = "0x245111C", Offset = "0x245111C", VA = "0x245111C", Slot = "6")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[NonSerialized]
		[Token(Token = "0x4000EB2")]
		[FieldOffset(Offset = "0x18")]
		private bool obpzIVquVRQseulcTcTZaHvizTjRA;

		[NonSerialized]
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0x19")]
		private bool RePRCVbBZgCcBPtVnJbUMgMOGrtL;

		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0x20")]
		private List<IComponentControl> _controls;

		[Token(Token = "0x17000592")]
		internal bool jYTNgflwwEgvgbZuuTHYnPAnuRao
		{
			[Token(Token = "0x600148A")]
			[Address(RVA = "0x2351CBC", Offset = "0x2351CBC", VA = "0x2351CBC")]
			get
			{
				return oWiLLgLAcaWwLQraDxjPnTAHOnSe();
			}
		}

		[Token(Token = "0x600148A")]
		[Address(RVA = "0x2351CBC", Offset = "0x2351CBC", VA = "0x2351CBC")]
		internal bool oWiLLgLAcaWwLQraDxjPnTAHOnSe()
		{
			return default;
		}

		[Token(Token = "0x600148B")]
		[Address(RVA = "0x2351CC4", Offset = "0x2351CC4", VA = "0x2351CC4")]
		internal ComponentController()
		{
		}

		[Token(Token = "0x600148C")]
		[Address(RVA = "0x2351D48", Offset = "0x2351D48", VA = "0x2351D48", Slot = "6")]
		internal virtual void Awake()
		{
		}

		[Token(Token = "0x600148D")]
		[Address(RVA = "0x2351D54", Offset = "0x2351D54", VA = "0x2351D54", Slot = "7")]
		internal virtual void Update()
		{
		}

		[Token(Token = "0x600148E")]
		[Address(RVA = "0x2351EC8", Offset = "0x2351EC8", VA = "0x2351EC8", Slot = "8")]
		internal virtual void OnEnable()
		{
		}

		[Token(Token = "0x600148F")]
		[Address(RVA = "0x2352058", Offset = "0x2352058", VA = "0x2352058", Slot = "9")]
		internal virtual void OnDisable()
		{
		}

		[Token(Token = "0x6001490")]
		[Address(RVA = "0x2352078", Offset = "0x2352078", VA = "0x2352078", Slot = "10")]
		internal virtual void OnValidate()
		{
		}

		[Token(Token = "0x6001491")]
		[Address(RVA = "0x2352080", Offset = "0x2352080", VA = "0x2352080", Slot = "11")]
		internal virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6001492")]
		[Address(RVA = "0x23520D4", Offset = "0x23520D4", VA = "0x23520D4", Slot = "12")]
		internal virtual bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return default;
		}

		[Token(Token = "0x6001493")]
		[Address(RVA = "0x23520DC", Offset = "0x23520DC", VA = "0x23520DC", Slot = "13")]
		internal virtual void sGOXUkdDJMvaXZNxRxZLevjalIqm()
		{
		}

		[Token(Token = "0x6001494")]
		[Address(RVA = "0x23520EC", Offset = "0x23520EC", VA = "0x23520EC", Slot = "14")]
		internal virtual void LYluBUMWPKbwashzGpNPLTeasipd()
		{
		}

		[Token(Token = "0x6001495")]
		[Address(RVA = "0x23520F0", Offset = "0x23520F0", VA = "0x23520F0", Slot = "4")]
		private void Rewired_002EUtils_002EInterfaces_002EIRegistrar_003CRewired_002EComponentControls_002EIComponentControl_003E_002ERegister(IComponentControl control)
		{
		}

		[Token(Token = "0x6001496")]
		[Address(RVA = "0x235216C", Offset = "0x235216C", VA = "0x235216C", Slot = "5")]
		private void Rewired_002EUtils_002EInterfaces_002EIRegistrar_003CRewired_002EComponentControls_002EIComponentControl_003E_002EDeregister(IComponentControl control)
		{
		}

		[Token(Token = "0x6001497")]
		[Address(RVA = "0x23521F0", Offset = "0x23521F0", VA = "0x23521F0", Slot = "15")]
		public virtual void ClearControlValues()
		{
		}

		[Token(Token = "0x6001498")]
		[Address(RVA = "0x2352008", Offset = "0x2352008", VA = "0x2352008")]
		private void qhuNDonLyhwaOUJVhxsLRGkQPgDT()
		{
		}

		[Token(Token = "0x6001499")]
		[Address(RVA = "0x235207C", Offset = "0x235207C", VA = "0x235207C")]
		private void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		[Token(Token = "0x600149A")]
		[Address(RVA = "0x2351F94", Offset = "0x2351F94", VA = "0x2351F94")]
		private IEnumerator tkaLgOgyfPesbfcHrqkIAwRWsggK()
		{
			return null;
		}
	}
}
