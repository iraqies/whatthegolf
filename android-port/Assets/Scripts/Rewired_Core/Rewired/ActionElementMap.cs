using System;
using System.Text;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class ActionElementMap
	{
		[SerializeField]
		internal int _actionCategoryId;

		[SerializeField]
		internal int _actionId;

		[SerializeField]
		internal ControllerElementType _elementType;

		[SerializeField]
		internal int _elementIdentifierId;

		[SerializeField]
		internal AxisRange _axisRange;

		[SerializeField]
		internal bool _invert;

		[SerializeField]
		internal Pole _axisContribution;

		[SerializeField]
		internal KeyboardKeyCode _keyboardKeyCode;

		[SerializeField]
		internal ModifierKey _modifierKey1;

		[SerializeField]
		internal ModifierKey _modifierKey2;

		[SerializeField]
		internal ModifierKey _modifierKey3;

		[NonSerialized]
		internal ControllerMap mtCzlvnEPTtCfVpotNRemSaRaiHy;

		[NonSerialized]
		internal bool kKFZZElqKQSUFMZnWdEudRvTJGpo;

		[NonSerialized]
		private string PslWOFZWArVhPwzuPAbExXVaDTAn;

		[NonSerialized]
		internal string SdQoKSvwiaNzVKQzixNlXbImXkJd;

		[NonSerialized]
		internal int FBOOknsxpcCbVstgmGENdPFIgrbiA;

		[NonSerialized]
		internal readonly int YVGDeWQAhUWKAOSPoxXuizkXaiTI;

		[NonSerialized]
		private string psPQblyfSyeXXqySXnnGpikIacn;

		[NonSerialized]
		private ModifierKeyFlags nnaFVGcLVdorJHZDQBRlgrMPmkJLA;

		private static int uidCounter;

		private static StringBuilder s_toStringSB;

		public int actionId => 0;

		public ControllerElementType elementType
		{
			get
			{
				return ControllerElementType.Axis;
			}
			internal set
			{
				AQtmJuWrLHPQSquyyGnfWvcLtYwo(controllerElementType);
			}
		}

		public int elementIdentifierId => 0;

		public AxisRange axisRange
		{
			get
			{
				return AxisRange.Full;
			}
			set
			{
			}
		}

		public bool invert
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Pole axisContribution
		{
			get
			{
				return Pole.Positive;
			}
			set
			{
			}
		}

		public KeyboardKeyCode keyboardKeyCode => KeyboardKeyCode.None;

		public ModifierKey modifierKey1 => ModifierKey.None;

		public ModifierKey modifierKey2 => ModifierKey.None;

		public ModifierKey modifierKey3 => ModifierKey.None;

		public AxisType axisType => AxisType.None;

		public ModifierKeyFlags modifierKeyFlags => ModifierKeyFlags.None;

		public KeyCode keyCode => KeyCode.None;

		public bool hasModifiers => false;

		public ControllerMap controllerMap => null;

		public bool enabled => false;

		public string elementIdentifierName => null;

		public string actionDescriptiveName => null;

		public int elementIndex => 0;

		public int id => 0;

		private bool zkETwoZKejElGcEroHdnUgfjunDj => FJrMzAmLTrkUomwBsYsjbWtqRtii();

		private static int JYOCoLrZDRYoCWqKYeukLdGKhAkD => zWEGScGaSltixbwZYqEMGnXxxoUb();

		internal static bool QCVAmAdeLePlbTxUIzzPjfmaVeTVA(ActionElementMap P_0)
		{
			return false;
		}

		internal static void TMUhagmzRxUiUzNvCwfMFSIQTjlQ(ActionElementMap P_0, ActionElementMap P_1)
		{
		}

		internal void AQtmJuWrLHPQSquyyGnfWvcLtYwo(ControllerElementType P_0)
		{
		}

		private bool FJrMzAmLTrkUomwBsYsjbWtqRtii()
		{
			return false;
		}

		private static int zWEGScGaSltixbwZYqEMGnXxxoUb()
		{
			return 0;
		}

		public ActionElementMap()
		{
		}

		public ActionElementMap(ActionElementMap P_0)
		{
		}

		public ActionElementMap(int P_0, ControllerElementType P_1, int P_2, Pole P_3, AxisRange P_4)
		{
		}

		public ActionElementMap(int P_0, ControllerElementType P_1, int P_2, Pole P_3, AxisRange P_4, bool P_5)
		{
		}

		public ActionElementMap(int P_0, ControllerElementType P_1, Pole P_2, KeyboardKeyCode P_3, ModifierKey P_4, ModifierKey P_5, ModifierKey P_6)
		{
		}

		public bool CheckForAssignmentConflict(ElementAssignment elementAssignment)
		{
			return false;
		}

		public bool CheckForAssignmentConflict(ActionElementMap elementMap)
		{
			return false;
		}

		public bool ShowInField(AxisRange fieldActionRange)
		{
			return false;
		}

		public bool IsTarget(IControllerElementTarget elementTarget)
		{
			return false;
		}

		internal void nCUqazOObDuxSjUNBaQhabwMxrSG(ControllerMap P_0)
		{
		}

		internal void RPQWwIDvDftjNUjQfuErQNYMCCXf(ControllerMap P_0, HardwareControllerMap_Game P_1)
		{
		}

		private void nCUqazOObDuxSjUNBaQhabwMxrSG(bool P_0)
		{
		}

		private void nCUqazOObDuxSjUNBaQhabwMxrSG(ControllerType P_0, HardwareControllerMap_Game P_1, bool P_2)
		{
		}

		private void CDLhhgcCAqAPleEiFLEpofnRBfbxB()
		{
		}

		private string LyIVgolBjAMYeoKpsoIigsELsYEn()
		{
			return null;
		}

		internal void SPGTRPyvIslcMdbPTItsewSLRPxx()
		{
		}

		private bool bTAqFyCMPbodjFoGDJiBBafSUzeK(KeyboardKeyCode P_0, ModifierKeyFlags P_1)
		{
			return false;
		}

		private bool VRhVzxJaLZwPAtuskjJJAdBoDhdfA(int P_0, AxisRange P_1)
		{
			return false;
		}

		private bool FQWFCoIwCteEoiEAlAcjUmMJEdcz(ElementAssignmentType P_0)
		{
			return false;
		}

		private void MZUkToGXsQXPxJOcQfnpjeaIEHlQ()
		{
		}

		private void zXJRmmRaQKjjOSfrREURcPDTHJinA()
		{
		}

		internal SerializedObject JxowpgGeLUBIhbyiSIIfFkkGllDuA()
		{
			return null;
		}

		internal void ckPgJNiFQjrLdKfwClUsdsySXFyIb(SerializedObject P_0)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
