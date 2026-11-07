using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002A7")]
	[DisallowMultipleComponent]
	public class Timekeeper : Singleton<Timekeeper>
	{
		[Token(Token = "0x400114B")]
		public const int DefaultMaxParticleLoops = 10;

		[Token(Token = "0x400114C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _debug;

		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _maxParticleLoops;

		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, GlobalClock> _clocks;

		[Token(Token = "0x1700021E")]
		public bool debug
		{
			[Token(Token = "0x6001184")]
			[Address(RVA = "0x131D8F0", Offset = "0x131D8F0", VA = "0x131D8F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001185")]
			[Address(RVA = "0x131D8F8", Offset = "0x131D8F8", VA = "0x131D8F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700021F")]
		public int maxParticleLoops
		{
			[Token(Token = "0x6001186")]
			[Address(RVA = "0x131D900", Offset = "0x131D900", VA = "0x131D900")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001187")]
			[Address(RVA = "0x131D908", Offset = "0x131D908", VA = "0x131D908")]
			set
			{
			}
		}

		[Token(Token = "0x17000220")]
		public IEnumerable<GlobalClock> clocks
		{
			[Token(Token = "0x6001188")]
			[Address(RVA = "0x131D910", Offset = "0x131D910", VA = "0x131D910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000221")]
		internal static float unscaledDeltaTime
		{
			[Token(Token = "0x600118E")]
			[Address(RVA = "0x131DDE4", Offset = "0x131DDE4", VA = "0x131DDE4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001182")]
		[Address(RVA = "0x131D740", Offset = "0x131D740", VA = "0x131D740")]
		public Timekeeper()
		{
		}

		[Token(Token = "0x6001183")]
		[Address(RVA = "0x131D81C", Offset = "0x131D81C", VA = "0x131D81C", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6001189")]
		[Address(RVA = "0x131D964", Offset = "0x131D964", VA = "0x131D964", Slot = "6")]
		public virtual bool HasClock(string key)
		{
			return default;
		}

		[Token(Token = "0x600118A")]
		[Address(RVA = "0x131DA14", Offset = "0x131DA14", VA = "0x131DA14", Slot = "7")]
		public virtual GlobalClock Clock(string key)
		{
			return null;
		}

		[Token(Token = "0x600118B")]
		[Address(RVA = "0x131DB30", Offset = "0x131DB30", VA = "0x131DB30", Slot = "8")]
		public virtual GlobalClock AddClock(string key)
		{
			return null;
		}

		[Token(Token = "0x600118C")]
		[Address(RVA = "0x131DC90", Offset = "0x131DC90", VA = "0x131DC90", Slot = "9")]
		public virtual void RemoveClock(string key)
		{
		}

		[Token(Token = "0x600118D")]
		[Address(RVA = "0x131DDAC", Offset = "0x131DDAC", VA = "0x131DDAC")]
		internal static TimeState GetTimeState(float timeScale)
		{
			return default;
		}
	}
}
