using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Rewired
{
	public abstract class ControllerWithAxes : ControllerWithMap
	{
		private sealed class nwJxbgGibhWHtWkcVbrEgPGgCWORA : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private ControllerPollingInfo VqEePGSMyrGKIqkWibsjeHcWPSIx;

			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			public ControllerWithAxes TtytLoUfsgUyhsklaKccrnoMiiek;

			private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

			ControllerPollingInfo IEnumerator<ControllerPollingInfo>.Current
			{
				[DebuggerHidden]
				get
				{
					return default;
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
			public nwJxbgGibhWHtWkcVbrEgPGgCWORA(int P_0)
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

			[DebuggerHidden]
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private sealed class HtWJjmVxkRQhqIhEaWYiykDtfmKE : IEnumerable<ControllerPollingInfo>, IEnumerator<ControllerPollingInfo>, IDisposable, IEnumerable, IEnumerator
		{
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			private ControllerPollingInfo VqEePGSMyrGKIqkWibsjeHcWPSIx;

			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			public ControllerWithAxes TtytLoUfsgUyhsklaKccrnoMiiek;

			private IEnumerator<ControllerPollingInfo> hSeONskmQJhVsjVUHGUASYbDGJrU;

			ControllerPollingInfo IEnumerator<ControllerPollingInfo>.Current
			{
				[DebuggerHidden]
				get
				{
					return default;
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
			public HtWJjmVxkRQhqIhEaWYiykDtfmKE(int P_0)
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

			private void uvbwjgAeXsWySvtbvsLpuFVuAgJB()
			{
			}

			private void tMeeFNDmLhzrFkrObkICOsBGeJux()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<ControllerPollingInfo> IEnumerable<ControllerPollingInfo>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		protected readonly int _axisCount;

		protected readonly int _axis2DCount;

		protected readonly Axis[] axes;

		protected readonly ReadOnlyCollection<Axis> axes_readOnly;

		protected readonly Axis2D[] axes2D;

		protected readonly ReadOnlyCollection<Axis2D> axes2D_readOnly;

		protected CalibrationMap _calibrationMap;

		private float[] BijdrwGaINHJxnPnVjrnZCtkCPVCb;

		private uint etHUIhDEqrnLEiPJGCMbqVceKELW;

		private Func<int, int> zSSDgSGEFuoVXbqlGAfVNVsHjHaRA;

		public int axisCount => 0;

		public int axis2DCount => 0;

		public IList<Axis> Axes => null;

		public CalibrationMap calibrationMap => null;

		public IList<ControllerElementIdentifier> AxisElementIdentifiers => null;

		internal ControllerWithAxes(int P_0, InputSource P_1, string P_2, string P_3, string P_4, ControllerType P_5, Guid P_6, int P_7, int P_8, bool[] P_9, HardwareControllerMap_Game P_10, Extension P_11, ControllerDataUpdater P_12)
			: base(0, InputSource.None, null, null, null, ControllerType.Keyboard, default, 0, null, null, null, null)
		{
		}

		public override Element GetElementById(int elementIdentifierId)
		{
			return null;
		}

		public int GetAxisIndexById(int elementIdentifierId)
		{
			return 0;
		}

		public float GetAxisById(int elementIdentifierId)
		{
			return 0f;
		}

		public float GetAxisRawById(int elementIdentifierId)
		{
			return 0f;
		}

		public override double GetLastTimeAnyElementChanged()
		{
			return 0.0;
		}

		public override double GetLastTimeAnyElementChanged(bool useRawValues)
		{
			return 0.0;
		}

		public double GetLastTimeAnyAxisChanged(bool useRawValues)
		{
			return 0.0;
		}

		public override IEnumerable<ControllerPollingInfo> PollForAllElementsDown()
		{
			return null;
		}

		public IEnumerable<ControllerPollingInfo> PollForAllAxes()
		{
			return null;
		}

		private void gjdBRcmBmbjkZAFXTlhOEtwctLxQb()
		{
		}

		protected virtual bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId)
		{
			pole = default;
			elementIdentifierId = default;
			return false;
		}

		public bool ImportCalibrationMapFromXmlString(string xmlString)
		{
			return false;
		}

		internal override void PwSVyxiNOmkyuuXUHWyuymUyabog(UpdateLoopType P_0)
		{
		}

		internal bool oZNTooZUteIdmEdiqibKSUQVHtqT(ActionElementMap P_0, int P_1, bool P_2, bool P_3, out float P_4)
		{
			P_4 = default;
			return false;
		}

		internal override void dSUizcQaOGnPQOOBZVgCNLRSewAe(ControllerMap P_0)
		{
		}

		internal override void JpxRPMmkCiJxotCLchUqPLcjlZiQ(ControllerMap P_0, ActionElementMap P_1)
		{
		}

		internal void CtrjjJxhauzevwWMqlUzXBxtwPCT()
		{
		}

		internal override void SPGTRPyvIslcMdbPTItsewSLRPxx()
		{
		}

		[CompilerGenerated]
		[DebuggerHidden]
		private IEnumerable<ControllerPollingInfo> kIFOMqoSovBmWyQlKpcSxOuXerX()
		{
			return null;
		}
	}
}
