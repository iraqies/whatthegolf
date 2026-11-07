using System;
using System.Collections.Generic;

namespace Rewired.Utils
{
	internal abstract class SafeDelegate : ICloneable
	{
		private static Action<Exception> fpZaZCYQmShOrIvhGSeXexBuYwKtA;

		internal abstract int Count { get; }

		internal static Action<Exception> S_ExceptionHandler
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal abstract void Clear();

		public abstract object Clone();
	}
	internal abstract class SafeDelegate<T> : SafeDelegate where T : class
	{
		private class ZVmDCTmiBmCfXBJcmZqXYxksQIHN
		{
			public readonly T gybqTscDHxcHontLfEbdWinPeCkKA;

			public readonly object QMmaBzbGhLRYBQhUiAbwUcRQwInF;

			public readonly object EZzJBXXjyieUbeYhLlWfaYRiXMqV;

			public readonly bool VpbfNLnAZtFmPVDaoFArWpYuhYTu;

			public ZVmDCTmiBmCfXBJcmZqXYxksQIHN(T P_0)
			{
			}

			public ZVmDCTmiBmCfXBJcmZqXYxksQIHN(ZVmDCTmiBmCfXBJcmZqXYxksQIHN P_0)
			{
			}

			public bool RjoIYnlMCCCHeQDOkNVYsnqUILvO()
			{
				return false;
			}
		}

		private Action<Exception> CwbPWAaYPGNxgJdSPyoDBEDDOAjr;

		private readonly List<ZVmDCTmiBmCfXBJcmZqXYxksQIHN> eEjopwMKawDinzISecKicaoZKNHDb;

		private readonly List<ZVmDCTmiBmCfXBJcmZqXYxksQIHN> tehaGGcITLJasAnKFCONSdYEENcb;

		internal override int Count => 0;

		protected SafeDelegate()
		{
		}

		protected SafeDelegate(Action<Exception> P_0)
		{
		}

		protected SafeDelegate(SafeDelegate<T> P_0)
		{
		}

		public void AddDelegate(T @delegate)
		{
		}

		public void RemoveDelegate(T @delegate)
		{
		}

		internal override void Clear()
		{
		}

		protected void Invoke(Action<object, T> invokeCallback)
		{
		}

		private bool fSBMVaLfQvgqXypKYGeLWMIbARbB(T P_0)
		{
			return false;
		}

		private int lsWdiPZgHHfEfIiesCpnLAlcpBgUA(T P_0)
		{
			return 0;
		}

		private static List<Delegate> SuxMhnrCMQkelvYwUQmFQbctxDcQ(Delegate P_0)
		{
			return null;
		}
	}
}
