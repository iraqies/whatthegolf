using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public sealed class TouchButton : TouchInteractable
	{
		public enum ButtonType
		{
			Standard = 0,
			ToggleSwitch = 1
		}

		private enum OpkLqbttkDfdWPvVmlLCialkmZyE
		{
			None = 0,
			TowardTouch = 1,
			TowardHome = 2
		}

		private enum KNuxcpaopMTVUOnDxSWfwXInKYgs
		{
			Local = 0,
			TouchRegion = 1
		}

		[Serializable]
		public class AxisValueChangedEventHandler : UnityEvent<float>
		{
		}

		[Serializable]
		public class ButtonValueChangedEventHandler : UnityEvent<bool>
		{
		}

		[Serializable]
		public class ButtonDownEventHandler : UnityEvent
		{
		}

		[Serializable]
		public class ButtonUpEventHandler : UnityEvent
		{
		}

		private sealed class KykhxUELCIErMkPZtnTHwKXXpCVb : IDisposable, IEnumerator, IEnumerator<object>
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private object VqEePGSMyrGKIqkWibsjeHcWPSIx;

			public float QzkoAujiXELSEATTFbUXkPALueUS;

			public TouchButton TtytLoUfsgUyhsklaKccrnoMiiek;

			public PositionType NrdyBFMMWwnWFfEyWKBnxrSnZvnA;

			public Vector2 JTKktbfSAqGDQjeacpqTtOeybKpt;

			public OpkLqbttkDfdWPvVmlLCialkmZyE sGqbUlnFwRgsWfMjUESVfFgHGuQnb;

			private RectTransform zhIaopVbzvThffCKABmaaMXeNOEU;

			private Vector2 MAKcOIKScodBQvETwJwUTnXGybGz;

			private float EqWwPxCLglgHGkbPhQwGHBtsGbeTA;

			private float ifUZPTedFJKUBUSvTHjRpfgDkWRg;

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
			public KykhxUELCIErMkPZtnTHwKXXpCVb(int P_0)
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

		private const float SCWAmlAYUdOqKHXMQDaAhhwDAjLJb = 20f;

		[SerializeField]
		private CustomControllerElementTargetSetForFloat _targetCustomControllerElement;

		[SerializeField]
		private ButtonType _buttonType;

		[SerializeField]
		private bool _activateOnSwipeIn;

		[SerializeField]
		private bool _stayActiveOnSwipeOut;

		[SerializeField]
		private bool _useDigitalAxisSimulation;

		[SerializeField]
		private float _digitalAxisGravity;

		[SerializeField]
		private float _digitalAxisSensitivity;

		[SerializeField]
		private StandaloneAxis _axis;

		[SerializeField]
		private TouchRegion _touchRegion;

		[SerializeField]
		private bool _useTouchRegionOnly;

		[SerializeField]
		private bool _moveToTouchPosition;

		[SerializeField]
		private bool _returnOnRelease;

		[SerializeField]
		private bool _followTouchPosition;

		[SerializeField]
		private bool _animateOnMoveToTouch;

		[SerializeField]
		private float _moveToTouchSpeed;

		[SerializeField]
		private bool _animateOnReturn;

		[SerializeField]
		private float _returnSpeed;

		[SerializeField]
		private bool _manageRaycasting;

		private float GayFivmQsrHyXTnOsAoGyZrYONky;

		private float ZxGKbhZcbUmwqArGhtrVMLaWEajZ;

		private TouchRegion DdEciANgMGwGEPvgxnWPHBeJPbOd;

		private Vector2 lhmAxKFWhlSHZJoCEAJNVcCScTPH;

		private bool zAGNVhMcIKxGEzzgSRljWYiyquPd;

		private bool sTmRLabKJLmxGbwWDHHbRrMNNrqn;

		private OpkLqbttkDfdWPvVmlLCialkmZyE yJgkQZuMZrJUEaNCzYYZYngtVmoe;

		private int aXEzyiFgJCCEqWfKXxtFBJTVbEHIA;

		private int RxCFBSfZGSaxvGjcDdHvHngyjaKGB;

		[NonSerialized]
		private bool ALBJgfsRYJdMVJwePTiUwIfQxDNM;

		[NonSerialized]
		private bool zmNsczlnaJKPNGfDEeyyFdsXhpjgb;

		private IEnumerator FcwfREdgzibGQMOLZwevNMKYBahxA;

		private orKfWSGFqzCFUysymbkGocsATicLA RnmnTCNSMxWpWOEFwiXbynsDrRsy;

		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> hQWAhuEEpQgIIlrOEloKQoXoiIpCb;

		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> MnHeXlNYnTFAvDUkeuUfMXqRumEH;

		[SerializeField]
		private AxisValueChangedEventHandler _onAxisValueChanged;

		[SerializeField]
		private ButtonValueChangedEventHandler _onButtonValueChanged;

		[SerializeField]
		private ButtonDownEventHandler _onButtonDown;

		[SerializeField]
		private ButtonUpEventHandler _onButtonUp;

		private Dictionary<int, PointerEventData> EeRYMczwTzlgDjdFdgjMeYiqqewh;

		public CustomControllerElementTargetSetForFloat targetCustomControllerElement => null;

		public ButtonType buttonType
		{
			get
			{
				return ButtonType.Standard;
			}
			set
			{
			}
		}

		public bool activateOnSwipeIn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool stayActiveOnSwipeOut
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useDigitalAxisSimulation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float digitalAxisGravity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float digitalAxisSensitivity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TouchRegion touchRegion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool useTouchRegionOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool moveToTouchPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool returnOnRelease
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool followTouchPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool animateOnMoveToTouch
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float moveToTouchSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool animateOnReturn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float returnSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool manageRaycasting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int pointerId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool hasPointer => false;

		internal StandaloneAxis axis => null;

		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> moveStartedDelegate => gNAmPModgOnTGQNOFdvniFjIqAtIA();

		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> moveEndedDelegate => ArcFTIKWHTlheRJUlpwHPRlQJByib();

		private float axisValue => iQxCxdSsmUdMvhhyiopIwEuiAjwfb();

		private float axisValuePrev => PmTErSmrMWtvPqEJAGGfBmNOOztHA();

		private bool buttonValue => hWAMrPFVNkAChGJnTzqjVWFOlpTR();

		private bool buttonValuePrev => kQOwnBHmFOdVIgTYYPLkFJqcyioZA();

		private int effectivePointerId => GjrFlwkYGCpgHlpOAGJAeBjJqEGyA();

		public event UnityAction<float> AxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction<bool> ButtonValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction ButtonDownEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event UnityAction ButtonUpEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> gNAmPModgOnTGQNOFdvniFjIqAtIA()
		{
			return null;
		}

		private Action<OpkLqbttkDfdWPvVmlLCialkmZyE> ArcFTIKWHTlheRJUlpwHPRlQJByib()
		{
			return null;
		}

		private float iQxCxdSsmUdMvhhyiopIwEuiAjwfb()
		{
			return 0f;
		}

		private float PmTErSmrMWtvPqEJAGGfBmNOOztHA()
		{
			return 0f;
		}

		private bool hWAMrPFVNkAChGJnTzqjVWFOlpTR()
		{
			return false;
		}

		private bool kQOwnBHmFOdVIgTYYPLkFJqcyioZA()
		{
			return false;
		}

		private int GjrFlwkYGCpgHlpOAGJAeBjJqEGyA()
		{
			return 0;
		}

		private TouchButton()
		{
		}

		public void SetRawValue(float value)
		{
		}

		public void SetDefaultPosition()
		{
		}

		private void ILkWicEjdmMiShclEHEAqLqIsFgs(Vector2 P_0)
		{
		}

		public void ReturnToDefaultPosition(bool instant)
		{
		}

		public void ReturnToDefaultPosition()
		{
		}

		internal override void Awake()
		{
		}

		internal override void OnEnable()
		{
		}

		internal override void OnDisable()
		{
		}

		internal override void OnValidate()
		{
		}

		internal override void Reset()
		{
		}

		internal override void ZCGETbjMQZUkyflRtYAqwQNUBPQIb()
		{
		}

		internal override bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return false;
		}

		internal override void xhHhPOcavYUrBJGXQmMDzQMMGISaA()
		{
		}

		internal override void sGOXUkdDJMvaXZNxRxZLevjalIqm()
		{
		}

		internal override void LYluBUMWPKbwashzGpNPLTeasipd()
		{
		}

		internal override void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		internal override void vXIboQFSGKdCLZnWmauizJnaOLuX()
		{
		}

		public override void ClearValue()
		{
		}

		internal override bool jlMJYbxJlzjsBwCBJxvDZPhnPAZF()
		{
			return false;
		}

		internal override bool mxaQUajJeAklKpqxemiTJFTBFCaq(GameObject gameObject)
		{
			return false;
		}

		private void gvfEiYjewRKHGGOAcrURxtSizbWi()
		{
		}

		private void YusCwCBXNYifDsXyufhFJipnEDYfA()
		{
		}

		private void iPyjXvavVUKajQoZZSeerbagLuMc()
		{
		}

		private void SEATEbfdDvHdSchwPlVRmUEOleEvA(float P_0, bool P_1)
		{
		}

		private void nUjZujKpQkHytBBpLGGvYeLbADacA()
		{
		}

		private void xDmhrzXrrUeSovFVkqiudNvSOwvT()
		{
		}

		private void khkdMwnTAvlDqPvCkDAZhRJFGYZR()
		{
		}

		private void aaiAJUIcGSdONuPwfwJBPYnPJCarA()
		{
		}

		private bool UZuPaidSRpiDUdxlqCyJWkepnHav()
		{
			return false;
		}

		private void duaIiAtDTEcsqfybpdyfGRlfYedB(TouchRegion P_0)
		{
		}

		private void dlnLVQxHbOeHUrCToOHILuLpTVKI(TouchRegion P_0)
		{
		}

		private void SUSGFUJwfFASbZtQzNdxeGuaWaYnA()
		{
		}

		private void jbQgKcxKQGzETsTgYjuvYckRsvZo(Vector2 P_0, bool P_1, float P_2, OpkLqbttkDfdWPvVmlLCialkmZyE P_3)
		{
		}

		private void xHovnLtQkBnCuETzVQnpnWVuJUuI(Vector2 P_0, PositionType P_1, bool P_2, float P_3, OpkLqbttkDfdWPvVmlLCialkmZyE P_4)
		{
		}

		private IEnumerator tIfcRAEhuytogERPthhbDYOlhzfR(Vector2 P_0, PositionType P_1, float P_2, OpkLqbttkDfdWPvVmlLCialkmZyE P_3)
		{
			return null;
		}

		private void ROeJSkZhnkTDcLHfcKCeHhXUonug(OpkLqbttkDfdWPvVmlLCialkmZyE P_0, Vector2 P_1, PositionType P_2)
		{
		}

		private void XNKImEVsUNPavzxgPJMfIdoSEAWgA(OpkLqbttkDfdWPvVmlLCialkmZyE P_0)
		{
		}

		private void UkrWacxKoOMuRkiKLRmEmILrFhRJ(OpkLqbttkDfdWPvVmlLCialkmZyE P_0)
		{
		}

		private void GmcjKJeaVVcqXFRzEcparhxCpdPsA(int P_0)
		{
		}

		private void zPMUivaPRCCBydGFdfPeBETKRYnmc()
		{
		}

		private void nxTbtLCLjbyuyRGfsvxPBPMmlZRq()
		{
		}

		private bool NDhTMIQItThJsXWyCtLUVEorVCTb()
		{
			return false;
		}

		private void rEkWtHXjAKTOKMkJBxWaofkAFFvH()
		{
		}

		private bool SBhvinEbIDGWUMwfXythhrIpigKu(int P_0)
		{
			return false;
		}

		private PointerEventData utfJPhgnwTqKykeFFJYQHUTouefi(int P_0, GameObject P_1)
		{
			return null;
		}

		private PointerEventData pVfmwALlLutDLwJmMFqcBjCFoHIS(int P_0)
		{
			return null;
		}

		private void LQXnlCGWVQCMAatUhwMXImJPGHhKA(PointerEventData P_0)
		{
		}

		private PointerEventData HyACTUHUMITHJlwRMGbSiKvZntNC(int P_0)
		{
			return null;
		}

		private void kenMZNZStIQnTAavioStPdqUwyIF(PointerEventData P_0, KNuxcpaopMTVUOnDxSWfwXInKYgs P_1)
		{
		}

		private void ZEbUZdUWFIEfiSqeUnrGJHjcPybD(PointerEventData P_0, KNuxcpaopMTVUOnDxSWfwXInKYgs P_1)
		{
		}

		private void ZWAzvWwAMRawEGwPixAMPjfyqNgpA(PointerEventData P_0, KNuxcpaopMTVUOnDxSWfwXInKYgs P_1)
		{
		}

		private void zHqZkjRbrFTkqMfkkoUpBAuhCzKfA(PointerEventData P_0, KNuxcpaopMTVUOnDxSWfwXInKYgs P_1)
		{
		}

		private void PARBcfOJshIGNJtBDsuAyiETdYwy(int P_0, Vector2 P_1, KNuxcpaopMTVUOnDxSWfwXInKYgs P_2)
		{
		}

		private void MHcBbLUbNvVfJsmQBGwoxkdhumdt()
		{
		}

		internal override void OnPointerDown(PointerEventData eventData)
		{
		}

		internal override void OnPointerUp(PointerEventData eventData)
		{
		}

		internal override void OnPointerEnter(PointerEventData eventData)
		{
		}

		internal override void OnPointerExit(PointerEventData eventData)
		{
		}

		private void lEDjUpnxqBucRFkEDyJKbVEmsmkA(PointerEventData P_0)
		{
		}

		private void EuQQZFwdcthAzHoBOBDBcyHGjRwyB(PointerEventData P_0)
		{
		}

		private void OmQwIffSZPImRUCIYEOwFrZRxIQW(PointerEventData P_0)
		{
		}

		private void PnDoCbelFWRcICvBVIgnpCPKYTkI(PointerEventData P_0)
		{
		}

		private void ghoFULOHEeeqyJlbKyZkQSyDIDpV(float P_0)
		{
		}

		private void qfUERXIuwfqiizHPBEEFkyvphQUUA(bool P_0)
		{
		}

		private void nmsMSxYgtKmGYShDHFAdlkxbERSEA()
		{
		}

		private void KJnsAwDdnlgDqIbLNFXBLxAueot()
		{
		}
	}
}
