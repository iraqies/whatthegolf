using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.ComponentControls.Data;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[Token(Token = "0x20002CD")]
	[DisallowMultipleComponent]
	public class CustomController : ComponentController
	{
		[Serializable]
		[Token(Token = "0x20002CE")]
		public class CreateCustomControllerSettings
		{
			[Token(Token = "0x4000EBE")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _createCustomController;

			[Token(Token = "0x4000EBF")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int _customControllerSourceId;

			[Token(Token = "0x4000EC0")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _assignToPlayerId;

			[Token(Token = "0x4000EC1")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private bool _destroyCustomController;

			[Token(Token = "0x17000598")]
			public bool createCustomController
			{
				[Token(Token = "0x60014C4")]
				[Address(RVA = "0x246369C", Offset = "0x246369C", VA = "0x246369C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000599")]
			public int customControllerSourceId
			{
				[Token(Token = "0x60014C5")]
				[Address(RVA = "0x24636A4", Offset = "0x24636A4", VA = "0x24636A4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700059A")]
			public int assignToPlayerId
			{
				[Token(Token = "0x60014C6")]
				[Address(RVA = "0x24636AC", Offset = "0x24636AC", VA = "0x24636AC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700059B")]
			public bool destroyCustomController
			{
				[Token(Token = "0x60014C7")]
				[Address(RVA = "0x24636B4", Offset = "0x24636B4", VA = "0x24636B4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60014C8")]
			[Address(RVA = "0x24636BC", Offset = "0x24636BC", VA = "0x24636BC")]
			public CreateCustomControllerSettings()
			{
			}
		}

		[Token(Token = "0x20002CF")]
		private struct qznnUAsCoSGpUBlBmvqxnRSYcwac
		{
			[Token(Token = "0x4000EC2")]
			[FieldOffset(Offset = "0x0")]
			public CustomControllerElementSelector.ElementType MdjBbHAfEpOIyysKWtDJwilBqwCjA;

			[Token(Token = "0x4000EC3")]
			[FieldOffset(Offset = "0x4")]
			public int fpRaWzdHfXPowZWkJxwTZPqeXOGK;

			[Token(Token = "0x4000EC4")]
			[FieldOffset(Offset = "0x8")]
			public float yYOUbwIbBcyPAQvjeAEXVsjzLAln;

			[Token(Token = "0x60014C9")]
			[Address(RVA = "0x24636D8", Offset = "0x24636D8", VA = "0x24636D8")]
			public qznnUAsCoSGpUBlBmvqxnRSYcwac(CustomControllerElementSelector.ElementType P_0, int P_1, float P_2)
			{
			}

			[Token(Token = "0x60014CA")]
			[Address(RVA = "0x24636E4", Offset = "0x24636E4", VA = "0x24636E4")]
			public qznnUAsCoSGpUBlBmvqxnRSYcwac(CustomControllerElementSelector.ElementType P_0, int P_1, bool P_2)
			{
			}

			[Token(Token = "0x60014CB")]
			[Address(RVA = "0x2463700", Offset = "0x2463700", VA = "0x2463700")]
			public bool AXRaAabAcDFslXRoZntGgwFsvHfcA(CustomControllerElementSelector.ElementType P_0, int P_1)
			{
				return default;
			}

			[Token(Token = "0x60014CC")]
			[Address(RVA = "0x2463724", Offset = "0x2463724", VA = "0x2463724")]
			public void oGPVXKkaRuOYcNaLJIZFXXgWIxtx(float P_0)
			{
			}

			[Token(Token = "0x60014CD")]
			[Address(RVA = "0x2463754", Offset = "0x2463754", VA = "0x2463754")]
			public void oGPVXKkaRuOYcNaLJIZFXXgWIxtx(bool P_0)
			{
			}
		}

		[Token(Token = "0x4000EB8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputManager_Base _rewiredInputManager;

		[Token(Token = "0x4000EB9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CustomControllerSelector _customControllerSelector;

		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CreateCustomControllerSettings _createCustomControllerSettings;

		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0x40")]
		private List<qznnUAsCoSGpUBlBmvqxnRSYcwac> eSbsYaKGZpVsnISkPHYjcxRLpYeD;

		[NonSerialized]
		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0x48")]
		private int VXJxyJaRzWDAeCgODeEzFozXCjuAb;

		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0x50")]
		private Action BbIMbQeLvHjivRxkUFEuuHyecJUe;

		[Token(Token = "0x17000595")]
		public InputManager_Base rewiredInputManager
		{
			[Token(Token = "0x60014A3")]
			[Address(RVA = "0x2371934", Offset = "0x2371934", VA = "0x2371934")]
			get
			{
				return null;
			}
			[Token(Token = "0x60014A4")]
			[Address(RVA = "0x237193C", Offset = "0x237193C", VA = "0x237193C")]
			set
			{
			}
		}

		[Token(Token = "0x17000596")]
		public CustomControllerSelector customControllerSelector
		{
			[Token(Token = "0x60014A5")]
			[Address(RVA = "0x2371A88", Offset = "0x2371A88", VA = "0x2371A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000597")]
		public CreateCustomControllerSettings createCustomControllerSettings
		{
			[Token(Token = "0x60014A6")]
			[Address(RVA = "0x2371A90", Offset = "0x2371A90", VA = "0x2371A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000026")]
		internal event Action InputSourceUpdateEvent
		{
			[Token(Token = "0x60014A1")]
			[Address(RVA = "0x237182C", Offset = "0x237182C", VA = "0x237182C")]
			add
			{
			}
			[Token(Token = "0x60014A2")]
			[Address(RVA = "0x23718B0", Offset = "0x23718B0", VA = "0x23718B0")]
			remove
			{
			}
		}

		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x2371A98", Offset = "0x2371A98", VA = "0x2371A98")]
		internal CustomController()
		{
		}

		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x2371B9C", Offset = "0x2371B9C", VA = "0x2371B9C")]
		public Rewired.CustomController GetCustomController()
		{
			return null;
		}

		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x2371D98", Offset = "0x2371D98", VA = "0x2371D98", Slot = "8")]
		internal override void OnEnable()
		{
		}

		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x2371DA0", Offset = "0x2371DA0", VA = "0x2371DA0", Slot = "9")]
		internal override void OnDisable()
		{
		}

		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x2371E18", Offset = "0x2371E18", VA = "0x2371E18", Slot = "10")]
		internal override void OnValidate()
		{
		}

		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x2371E98", Offset = "0x2371E98", VA = "0x2371E98", Slot = "11")]
		internal override void OnDestroy()
		{
		}

		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x2371FD8", Offset = "0x2371FD8", VA = "0x2371FD8", Slot = "12")]
		internal virtual bool OnInitialize()
		{
			return default;
		}

		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x2372140", Offset = "0x2372140", VA = "0x2372140", Slot = "13")]
		internal virtual void OnSubscribeEvents()
		{
		}

		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x2372284", Offset = "0x2372284", VA = "0x2372284", Slot = "14")]
		internal virtual void OnUnsubscribeEvents()
		{
		}

		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x2372348", Offset = "0x2372348", VA = "0x2372348", Slot = "15")]
		public override void ClearControlValues()
		{
		}

		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x23723C0", Offset = "0x23723C0", VA = "0x23723C0", Slot = "19")]
		internal virtual bool GetUseCustomController()
		{
			return default;
		}

		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x23723C8", Offset = "0x23723C8", VA = "0x23723C8", Slot = "20")]
		internal virtual void SetUseCustomController(bool value)
		{
		}

		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x23723CC", Offset = "0x23723CC", VA = "0x23723CC")]
		internal void SetAxisValue(CustomControllerElementSelector element, float value)
		{
		}

		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x2372974", Offset = "0x2372974", VA = "0x2372974")]
		internal void SetButtonValue(CustomControllerElementSelector element, bool value)
		{
		}

		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x2372B34", Offset = "0x2372B34", VA = "0x2372B34")]
		internal void ClearElementValue(CustomControllerElementTargetSet targetSet)
		{
		}

		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x2372BB8", Offset = "0x2372BB8", VA = "0x2372BB8")]
		internal void ClearElementValue(CustomControllerElementTarget target)
		{
		}

		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x2372BC8", Offset = "0x2372BC8", VA = "0x2372BC8")]
		internal void ClearElementValue(CustomControllerElementSelector element)
		{
		}

		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x2372D94", Offset = "0x2372D94", VA = "0x2372D94")]
		internal int ElementExists_Editor(CustomControllerElementSelector element)
		{
			return default;
		}

		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x23732E4", Offset = "0x23732E4", VA = "0x23732E4")]
		internal bool ElementExists(CustomControllerElementSelector element)
		{
			return default;
		}

		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x2373338", Offset = "0x2373338", VA = "0x2373338")]
		internal bool ValidateElements(CustomControllerElementTargetSet targetSet)
		{
			return default;
		}

		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x23733DC", Offset = "0x23733DC", VA = "0x23733DC")]
		internal bool ValidateElement(CustomControllerElementTarget target)
		{
			return default;
		}

		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x23733F0", Offset = "0x23733F0", VA = "0x23733F0")]
		internal bool ValidateElement(CustomControllerElementSelector element)
		{
			return default;
		}

		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x2371A1C", Offset = "0x2371A1C", VA = "0x2371A1C")]
		private void FyKKzlnIjsJaSimYwuqKSwNJHIHx()
		{
		}

		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x2372058", Offset = "0x2372058", VA = "0x2372058")]
		private bool ajhXJbgnqLHNDTtpxLqCuAgGrnVb()
		{
			return default;
		}

		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x23736E4", Offset = "0x23736E4", VA = "0x23736E4")]
		private void akoAoSlMJbQxrneSGafGKgGyINti()
		{
		}

		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x2371BA4", Offset = "0x2371BA4", VA = "0x2371BA4")]
		private Rewired.CustomController UhFBEoKYbICWKGrfPbNBAMYDdcqzA(bool P_0)
		{
			return null;
		}

		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x2373854", Offset = "0x2373854", VA = "0x2373854")]
		private void zOwlIzMeAPOyxMZgBlumMKHsNAAq(Rewired.CustomController P_0)
		{
		}

		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x2371EC0", Offset = "0x2371EC0", VA = "0x2371EC0")]
		private void wqpSDNioVwQwQGWdTeRRkteZueuX()
		{
		}

		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x2373CBC", Offset = "0x2373CBC", VA = "0x2373CBC")]
		private void uZsvbYnQMPckbZUTVOMacdUKDPsr()
		{
		}
	}
}
