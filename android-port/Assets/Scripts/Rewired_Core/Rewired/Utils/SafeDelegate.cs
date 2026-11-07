using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired.Utils
{
	[Token(Token = "0x200032D")]
	internal abstract class SafeDelegate : ICloneable
	{
		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0x0")]
		private static Action<Exception> fpZaZCYQmShOrIvhGSeXexBuYwKtA;

		[Token(Token = "0x17000694")]
		internal abstract int Count
		{
			[Token(Token = "0x6001869")]
			get;
		}

		[Token(Token = "0x17000695")]
		internal static Action<Exception> S_ExceptionHandler
		{
			[Token(Token = "0x600186C")]
			[Address(RVA = "0x240BBCC", Offset = "0x240BBCC", VA = "0x240BBCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600186D")]
			[Address(RVA = "0x240BC18", Offset = "0x240BC18", VA = "0x240BC18")]
			set
			{
			}
		}

		[Token(Token = "0x600186A")]
		internal abstract void Clear();

		[Token(Token = "0x600186B")]
		public abstract object Clone();

		[Token(Token = "0x600186E")]
		[Address(RVA = "0x240BC70", Offset = "0x240BC70", VA = "0x240BC70")]
		protected SafeDelegate()
		{
		}
	}
	[Token(Token = "0x200032E")]
	internal abstract class SafeDelegate<T> : SafeDelegate where T : class
	{
		[Token(Token = "0x200032F")]
		private class ZVmDCTmiBmCfXBJcmZqXYxksQIHN
		{
			[Token(Token = "0x4001082")]
			[FieldOffset(Offset = "0x0")]
			public readonly T gybqTscDHxcHontLfEbdWinPeCkKA;

			[Token(Token = "0x4001083")]
			[FieldOffset(Offset = "0x0")]
			public readonly object QMmaBzbGhLRYBQhUiAbwUcRQwInF;

			[Token(Token = "0x4001084")]
			[FieldOffset(Offset = "0x0")]
			public readonly object EZzJBXXjyieUbeYhLlWfaYRiXMqV;

			[Token(Token = "0x4001085")]
			[FieldOffset(Offset = "0x0")]
			public readonly bool VpbfNLnAZtFmPVDaoFArWpYuhYTu;

			[Token(Token = "0x600187A")]
			public ZVmDCTmiBmCfXBJcmZqXYxksQIHN(T P_0)
			{
			}

			[Token(Token = "0x600187B")]
			public ZVmDCTmiBmCfXBJcmZqXYxksQIHN(ZVmDCTmiBmCfXBJcmZqXYxksQIHN P_0)
			{
			}

			[Token(Token = "0x600187C")]
			public bool RjoIYnlMCCCHeQDOkNVYsnqUILvO()
			{
				return default;
			}
		}

		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0x0")]
		private Action<Exception> CwbPWAaYPGNxgJdSPyoDBEDDOAjr;

		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<ZVmDCTmiBmCfXBJcmZqXYxksQIHN> eEjopwMKawDinzISecKicaoZKNHDb;

		[Token(Token = "0x4001081")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<ZVmDCTmiBmCfXBJcmZqXYxksQIHN> tehaGGcITLJasAnKFCONSdYEENcb;

		[Token(Token = "0x17000696")]
		internal override int Count
		{
			[Token(Token = "0x600186F")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001870")]
		protected SafeDelegate()
		{
		}

		[Token(Token = "0x6001871")]
		protected SafeDelegate(Action<Exception> P_0)
		{
		}

		[Token(Token = "0x6001872")]
		protected SafeDelegate(SafeDelegate<T> P_0)
		{
		}

		[Token(Token = "0x6001873")]
		public void AddDelegate(T @delegate)
		{
		}

		[Token(Token = "0x6001874")]
		public void RemoveDelegate(T @delegate)
		{
		}

		[Token(Token = "0x6001875")]
		internal override void Clear()
		{
		}

		[Token(Token = "0x6001876")]
		protected void Invoke(Action<object, T> invokeCallback)
		{
		}

		[Token(Token = "0x6001877")]
		private bool fSBMVaLfQvgqXypKYGeLWMIbARbB(T P_0)
		{
			return default;
		}

		[Token(Token = "0x6001878")]
		private int lsWdiPZgHHfEfIiesCpnLAlcpBgUA(T P_0)
		{
			return default;
		}

		[Token(Token = "0x6001879")]
		private static List<Delegate> SuxMhnrCMQkelvYwUQmFQbctxDcQ(Delegate P_0)
		{
			return null;
		}
	}
}
