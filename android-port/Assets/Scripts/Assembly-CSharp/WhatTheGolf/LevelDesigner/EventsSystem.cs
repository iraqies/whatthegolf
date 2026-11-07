using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001251")]
	internal sealed class EventsSystem : BaseSystem
	{
		[Token(Token = "0x40062A6")]
		private const int kMaxProcessEventsPerFrame = 5;

		[Token(Token = "0x40062A7")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Enum, Type> s_EventArgumentMap;

		[Token(Token = "0x40062A8")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, RequireEventHandler> m_EventHandlers;

		[Token(Token = "0x40062A9")]
		[FieldOffset(Offset = "0x10")]
		private static List<IEvent> m_Events;

		[Token(Token = "0x6005461")]
		[Address(RVA = "0x1447538", Offset = "0x1447538", VA = "0x1447538")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x712F8", Offset = "0x712F8")]
		private static void InitOnLoad()
		{
		}

		[Token(Token = "0x6005462")]
		[Address(RVA = "0x1446580", Offset = "0x1446580", VA = "0x1446580")]
		public static void QueueEvent(IEvent evt)
		{
		}

		[Token(Token = "0x6005463")]
		[Address(RVA = "0x14480F4", Offset = "0x14480F4", VA = "0x14480F4", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005464")]
		[Address(RVA = "0x14480F8", Offset = "0x14480F8", VA = "0x14480F8", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6005465")]
		[Address(RVA = "0x1448210", Offset = "0x1448210", VA = "0x1448210", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005466")]
		[Address(RVA = "0x14482A8", Offset = "0x14482A8", VA = "0x14482A8")]
		public static void Register(IRequireEvents consumer)
		{
		}

		[Token(Token = "0x6005467")]
		[Address(RVA = "0x144843C", Offset = "0x144843C", VA = "0x144843C")]
		public static void Unregister(IRequireEvents consumer)
		{
		}

		[Token(Token = "0x6005468")]
		private static void ProcessEvent<T>(T evt) where T : IEvent
		{
		}

		[Token(Token = "0x6005469")]
		[Address(RVA = "0x1447CB8", Offset = "0x1447CB8", VA = "0x1447CB8")]
		private static bool Validate(IEvent evt)
		{
			return default;
		}

		[Token(Token = "0x600546A")]
		[Address(RVA = "0x14485D0", Offset = "0x14485D0", VA = "0x14485D0")]
		public EventsSystem()
		{
		}
	}
}
