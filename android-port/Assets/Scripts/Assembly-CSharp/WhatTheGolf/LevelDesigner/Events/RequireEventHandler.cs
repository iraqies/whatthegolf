using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012BE")]
	public abstract class RequireEventHandler
	{
		[Token(Token = "0x60056D1")]
		public abstract void Register(IRequireEvents obj);

		[Token(Token = "0x60056D2")]
		public abstract void Unregister(IRequireEvents obj);

		[Token(Token = "0x60056D3")]
		public abstract void ProcessEvent(IEvent evt);

		[Token(Token = "0x60056D4")]
		[Address(RVA = "0x164A5B8", Offset = "0x164A5B8", VA = "0x164A5B8")]
		protected RequireEventHandler()
		{
		}
	}
	[Token(Token = "0x20012BF")]
	public class RequireEventHandler<T> : RequireEventHandler, IDisposable where T : IEvent
	{
		[Token(Token = "0x40064FA")]
		[FieldOffset(Offset = "0x0")]
		private List<IRequireEvents<T>> m_RequireEvents;

		[Token(Token = "0x60056D5")]
		public RequireEventHandler()
		{
		}

		[Token(Token = "0x60056D6")]
		public override void ProcessEvent(IEvent evt)
		{
		}

		[Token(Token = "0x60056D7")]
		public override void Register(IRequireEvents obj)
		{
		}

		[Token(Token = "0x60056D8")]
		public override void Unregister(IRequireEvents obj)
		{
		}

		[Token(Token = "0x60056D9")]
		public void Dispose()
		{
		}
	}
}
