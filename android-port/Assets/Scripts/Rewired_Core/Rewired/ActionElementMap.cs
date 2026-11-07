using System;
using System.Text;
using Il2CppDummyDll;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Token(Token = "0x20000DA")]
	public sealed class ActionElementMap
	{
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal int _actionCategoryId;

		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		internal int _actionId;

		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal ControllerElementType _elementType;

		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		internal int _elementIdentifierId;

		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal AxisRange _axisRange;

		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		internal bool _invert;

		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal Pole _axisContribution;

		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		internal KeyboardKeyCode _keyboardKeyCode;

		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal ModifierKey _modifierKey1;

		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		internal ModifierKey _modifierKey2;

		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal ModifierKey _modifierKey3;

		[NonSerialized]
		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x40")]
		internal ControllerMap mtCzlvnEPTtCfVpotNRemSaRaiHy;

		[NonSerialized]
		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x48")]
		internal bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

		[NonSerialized]
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x50")]
		private string PslWOFZWArVhPwzuPAbExXVaDTAn;

		[NonSerialized]
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x58")]
		internal string SdQoKSvwiaNzVKQzixNlXbImXkJd;

		[NonSerialized]
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x60")]
		internal int FBOOknsxpcCbVstgmGENdPFIgrbiA;

		[NonSerialized]
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x64")]
		internal readonly int YVGDeWQAhUWKAOSPoxXuizkXaiTI;

		[NonSerialized]
		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x68")]
		private string psPQblyfSyeXXqySXnnGpikIacn;

		[NonSerialized]
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x70")]
		private ModifierKeyFlags nnaFVGcLVdorJHZDQBRlgrMPmkJLA;

		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x0")]
		private static int uidCounter;

		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x8")]
		private static StringBuilder s_toStringSB;

		[Token(Token = "0x170001C9")]
		public int actionId
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x2348878", Offset = "0x2348878", VA = "0x2348878")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001CA")]
		public ControllerElementType elementType
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x2348880", Offset = "0x2348880", VA = "0x2348880")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x2348888", Offset = "0x2348888", VA = "0x2348888")]
			internal set
			{
				AQtmJuWrLHPQSquyyGnfWvcLtYwo(controllerElementType);
			}
		}

		[Token(Token = "0x170001CB")]
		public int elementIdentifierId
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x2348890", Offset = "0x2348890", VA = "0x2348890")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001CC")]
		public AxisRange axisRange
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x2348898", Offset = "0x2348898", VA = "0x2348898")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x23488A0", Offset = "0x23488A0", VA = "0x23488A0")]
			set
			{
			}
		}

		[Token(Token = "0x170001CD")]
		public bool invert
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x23489F8", Offset = "0x23489F8", VA = "0x23489F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x2348A00", Offset = "0x2348A00", VA = "0x2348A00")]
			set
			{
			}
		}

		[Token(Token = "0x170001CE")]
		public Pole axisContribution
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x2348A08", Offset = "0x2348A08", VA = "0x2348A08")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x2348A10", Offset = "0x2348A10", VA = "0x2348A10")]
			set
			{
			}
		}

		[Token(Token = "0x170001CF")]
		public KeyboardKeyCode keyboardKeyCode
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x2348A5C", Offset = "0x2348A5C", VA = "0x2348A5C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D0")]
		public ModifierKey modifierKey1
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x2348A64", Offset = "0x2348A64", VA = "0x2348A64")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D1")]
		public ModifierKey modifierKey2
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x2348A6C", Offset = "0x2348A6C", VA = "0x2348A6C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D2")]
		public ModifierKey modifierKey3
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x2348A74", Offset = "0x2348A74", VA = "0x2348A74")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D3")]
		public AxisType axisType
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x2348A7C", Offset = "0x2348A7C", VA = "0x2348A7C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D4")]
		public ModifierKeyFlags modifierKeyFlags
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x2348AA0", Offset = "0x2348AA0", VA = "0x2348AA0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D5")]
		public KeyCode keyCode
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x2348AF8", Offset = "0x2348AF8", VA = "0x2348AF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D6")]
		public bool hasModifiers
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x2348B04", Offset = "0x2348B04", VA = "0x2348B04")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D7")]
		public ControllerMap controllerMap
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x2348B44", Offset = "0x2348B44", VA = "0x2348B44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D8")]
		public bool enabled
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x2348B4C", Offset = "0x2348B4C", VA = "0x2348B4C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001D9")]
		public string elementIdentifierName
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x2348B54", Offset = "0x2348B54", VA = "0x2348B54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DA")]
		public string actionDescriptiveName
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x2348FCC", Offset = "0x2348FCC", VA = "0x2348FCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DB")]
		public int elementIndex
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x2348FD4", Offset = "0x2348FD4", VA = "0x2348FD4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001DC")]
		public int id
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x2348FDC", Offset = "0x2348FDC", VA = "0x2348FDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001DD")]
		private bool zkETwoZKejElGcEroHdnUgfjunDj
		{
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x2348FE4", Offset = "0x2348FE4", VA = "0x2348FE4")]
			get
			{
				return FJrMzAmLTrkUomwBsYsjbWtqRtii();
			}
		}

		[Token(Token = "0x170001DE")]
		private static int JYOCoLrZDRYoCWqKYeukLdGKhAkD
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x2349008", Offset = "0x2349008", VA = "0x2349008")]
			get
			{
				return zWEGScGaSltixbwZYqEMGnXxxoUb();
			}
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2348704", Offset = "0x2348704", VA = "0x2348704")]
		internal static bool QCVAmAdeLePlbTxUIzzPjfmaVeTVA(ActionElementMap P_0)
		{
			return default;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x23487A0", Offset = "0x23487A0", VA = "0x23487A0")]
		internal static void TMUhagmzRxUiUzNvCwfMFSIQTjlQ(ActionElementMap P_0, ActionElementMap P_1)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2348888", Offset = "0x2348888", VA = "0x2348888")]
		internal void AQtmJuWrLHPQSquyyGnfWvcLtYwo(ControllerElementType P_0)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2348FE4", Offset = "0x2348FE4", VA = "0x2348FE4")]
		private bool FJrMzAmLTrkUomwBsYsjbWtqRtii()
		{
			return default;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2349008", Offset = "0x2349008", VA = "0x2349008")]
		private static int zWEGScGaSltixbwZYqEMGnXxxoUb()
		{
			return default;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x2349064", Offset = "0x2349064", VA = "0x2349064")]
		public ActionElementMap()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x23490EC", Offset = "0x23490EC", VA = "0x23490EC")]
		public ActionElementMap(ActionElementMap P_0)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2349188", Offset = "0x2349188", VA = "0x2349188")]
		public ActionElementMap(int P_0, ControllerElementType P_1, int P_2, Pole P_3, AxisRange P_4)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x234923C", Offset = "0x234923C", VA = "0x234923C")]
		public ActionElementMap(int P_0, ControllerElementType P_1, int P_2, Pole P_3, AxisRange P_4, bool P_5)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x23492F8", Offset = "0x23492F8", VA = "0x23492F8")]
		public ActionElementMap(int P_0, ControllerElementType P_1, Pole P_2, KeyboardKeyCode P_3, ModifierKey P_4, ModifierKey P_5, ModifierKey P_6)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x2349404", Offset = "0x2349404", VA = "0x2349404")]
		public bool CheckForAssignmentConflict(ElementAssignment elementAssignment)
		{
			return default;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2349780", Offset = "0x2349780", VA = "0x2349780")]
		public bool CheckForAssignmentConflict(ActionElementMap elementMap)
		{
			return default;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x23498D4", Offset = "0x23498D4", VA = "0x23498D4")]
		public bool ShowInField(AxisRange fieldActionRange)
		{
			return default;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x2349A44", Offset = "0x2349A44", VA = "0x2349A44")]
		public bool IsTarget(IControllerElementTarget elementTarget)
		{
			return default;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x2349E8C", Offset = "0x2349E8C", VA = "0x2349E8C")]
		internal void nCUqazOObDuxSjUNBaQhabwMxrSG(ControllerMap P_0)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x234A244", Offset = "0x234A244", VA = "0x234A244")]
		internal void RPQWwIDvDftjNUjQfuErQNYMCCXf(ControllerMap P_0, HardwareControllerMap_Game P_1)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x2348950", Offset = "0x2348950", VA = "0x2348950")]
		private void nCUqazOObDuxSjUNBaQhabwMxrSG(bool P_0)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x234A000", Offset = "0x234A000", VA = "0x234A000")]
		private void nCUqazOObDuxSjUNBaQhabwMxrSG(ControllerType P_0, HardwareControllerMap_Game P_1, bool P_2)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x234A4A8", Offset = "0x234A4A8", VA = "0x234A4A8")]
		private void CDLhhgcCAqAPleEiFLEpofnRBfbxB()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2348C44", Offset = "0x2348C44", VA = "0x2348C44")]
		private string LyIVgolBjAMYeoKpsoIigsELsYEn()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x234A614", Offset = "0x234A614", VA = "0x234A614")]
		internal void SPGTRPyvIslcMdbPTItsewSLRPxx()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2349634", Offset = "0x2349634", VA = "0x2349634")]
		private bool bTAqFyCMPbodjFoGDJiBBafSUzeK(KeyboardKeyCode P_0, ModifierKeyFlags P_1)
		{
			return default;
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x23496DC", Offset = "0x23496DC", VA = "0x23496DC")]
		private bool VRhVzxJaLZwPAtuskjJJAdBoDhdfA(int P_0, AxisRange P_1)
		{
			return default;
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x23495B8", Offset = "0x23495B8", VA = "0x23495B8")]
		private bool FQWFCoIwCteEoiEAlAcjUmMJEdcz(ElementAssignmentType P_0)
		{
			return default;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x23493D8", Offset = "0x23493D8", VA = "0x23493D8")]
		private void MZUkToGXsQXPxJOcQfnpjeaIEHlQ()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x234A3A0", Offset = "0x234A3A0", VA = "0x234A3A0")]
		private void zXJRmmRaQKjjOSfrREURcPDTHJinA()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x234A6A8", Offset = "0x234A6A8", VA = "0x234A6A8")]
		internal SerializedObject JxowpgGeLUBIhbyiSIIfFkkGllDuA()
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x234A9E0", Offset = "0x234A9E0", VA = "0x234A9E0")]
		internal void ckPgJNiFQjrLdKfwClUsdsySXFyIb(SerializedObject P_0)
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x234ACE0", Offset = "0x234ACE0", VA = "0x234ACE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
