using System;
using System.Collections.Generic;
using Rewired.ComponentControls.Data;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public class CustomController : ComponentController
	{
		[Serializable]
		public class CreateCustomControllerSettings
		{
			[SerializeField]
			private bool _createCustomController;

			[SerializeField]
			private int _customControllerSourceId;

			[SerializeField]
			private int _assignToPlayerId;

			[SerializeField]
			private bool _destroyCustomController;

			public bool createCustomController => false;

			public int customControllerSourceId => 0;

			public int assignToPlayerId => 0;

			public bool destroyCustomController => false;
		}

		private struct qznnUAsCoSGpUBlBmvqxnRSYcwac
		{
			public CustomControllerElementSelector.ElementType MdjBbHAfEpOIyysKWtDJwilBqwCjA;

			public int fpRaWzdHfXPowZWkJxwTZPqeXOGK;

			public float yYOUbwIbBcyPAQvjeAEXVsjzLAln;

			public qznnUAsCoSGpUBlBmvqxnRSYcwac(CustomControllerElementSelector.ElementType P_0, int P_1, float P_2)
			{
				MdjBbHAfEpOIyysKWtDJwilBqwCjA = CustomControllerElementSelector.ElementType.Axis;
				fpRaWzdHfXPowZWkJxwTZPqeXOGK = 0;
				yYOUbwIbBcyPAQvjeAEXVsjzLAln = 0f;
			}

			public qznnUAsCoSGpUBlBmvqxnRSYcwac(CustomControllerElementSelector.ElementType P_0, int P_1, bool P_2)
			{
				MdjBbHAfEpOIyysKWtDJwilBqwCjA = CustomControllerElementSelector.ElementType.Axis;
				fpRaWzdHfXPowZWkJxwTZPqeXOGK = 0;
				yYOUbwIbBcyPAQvjeAEXVsjzLAln = 0f;
			}

			public bool AXRaAabAcDFslXRoZntGgwFsvHfcA(CustomControllerElementSelector.ElementType P_0, int P_1)
			{
				return false;
			}

			public void oGPVXKkaRuOYcNaLJIZFXXgWIxtx(float P_0)
			{
			}

			public void oGPVXKkaRuOYcNaLJIZFXXgWIxtx(bool P_0)
			{
			}
		}

		[SerializeField]
		private InputManager_Base _rewiredInputManager;

		[SerializeField]
		private CustomControllerSelector _customControllerSelector;

		[SerializeField]
		private CreateCustomControllerSettings _createCustomControllerSettings;

		private List<qznnUAsCoSGpUBlBmvqxnRSYcwac> eSbsYaKGZpVsnISkPHYjcxRLpYeD;

		[NonSerialized]
		private int VXJxyJaRzWDAeCgODeEzFozXCjuAb;

		private Action BbIMbQeLvHjivRxkUFEuuHyecJUe;

		public InputManager_Base rewiredInputManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CustomControllerSelector customControllerSelector => null;

		public CreateCustomControllerSettings createCustomControllerSettings => null;

		internal event Action InputSourceUpdateEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		internal CustomController()
		{
		}

		public Rewired.CustomController GetCustomController()
		{
			return null;
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

		internal override void OnDestroy()
		{
		}

		internal override bool lpOPYPkfRAdylCMSLphTlIgUWIWy()
		{
			return false;
		}

		internal override void sGOXUkdDJMvaXZNxRxZLevjalIqm()
		{
		}

		internal override void LYluBUMWPKbwashzGpNPLTeasipd()
		{
		}

		public override void ClearControlValues()
		{
		}

		internal virtual bool GetUseCustomController()
		{
			return false;
		}

		internal virtual void SetUseCustomController(bool value)
		{
		}

		internal void SetAxisValue(CustomControllerElementSelector element, float value)
		{
		}

		internal void SetButtonValue(CustomControllerElementSelector element, bool value)
		{
		}

		internal void ClearElementValue(CustomControllerElementTargetSet targetSet)
		{
		}

		internal void ClearElementValue(CustomControllerElementTarget target)
		{
		}

		internal void ClearElementValue(CustomControllerElementSelector element)
		{
		}

		internal int ElementExists_Editor(CustomControllerElementSelector element)
		{
			return 0;
		}

		internal bool ElementExists(CustomControllerElementSelector element)
		{
			return false;
		}

		internal bool ValidateElements(CustomControllerElementTargetSet targetSet)
		{
			return false;
		}

		internal bool ValidateElement(CustomControllerElementTarget target)
		{
			return false;
		}

		internal bool ValidateElement(CustomControllerElementSelector element)
		{
			return false;
		}

		private void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		private bool ajhXJbgnqLHNDTtpxLqCuAgGrnVb()
		{
			return false;
		}

		private void akoAoSlMJbQxrneSGafGKgGyINti()
		{
		}

		private Rewired.CustomController UhFBEoKYbICWKGrfPbNBAMYDdcqzA(bool P_0)
		{
			return null;
		}

		private void zOwlIzMeAPOyxMZgBlumMKHsNAAq(Rewired.CustomController P_0)
		{
		}

		private void wqpSDNioVwQwQGWdTeRRkteZueuX()
		{
		}

		private void uZsvbYnQMPckbZUTVOMacdUKDPsr()
		{
		}
	}
}
