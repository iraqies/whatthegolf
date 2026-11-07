using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.Diagnostics
{
	[Token(Token = "0x2000068")]
	public class DiagnosticEventCollectorSingleton : ComponentSingleton<DiagnosticEventCollectorSingleton>
	{
		[Serializable]
		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7C58", Offset = "0x1B7C58")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000118")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000119")]
			[FieldOffset(Offset = "0x8")]
			public static Func<DiagnosticEvent, int> _003C_003E9__8_0;

			[Token(Token = "0x400011A")]
			[FieldOffset(Offset = "0x10")]
			public static Action<DiagnosticEvent> _003C_003E9__11_0;

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x2A770A4", Offset = "0x2A770A4", VA = "0x2A770A4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600027A")]
			[Address(RVA = "0x2A770AC", Offset = "0x2A770AC", VA = "0x2A770AC")]
			internal int _003CRegisterEventHandler_003Eb__8_0(DiagnosticEvent evt)
			{
				return default;
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x2A770B4", Offset = "0x2A770B4", VA = "0x2A770B4")]
			internal void _003CAwake_003Eb__11_0(DiagnosticEvent diagnosticEvent)
			{
			}
		}

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x0")]
		private static Guid s_editorConnectionGuid;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x18")]
		internal Dictionary<int, DiagnosticEvent> m_CreatedEvents;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x20")]
		internal List<DiagnosticEvent> m_UnhandledEvents;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x28")]
		internal DelegateList<DiagnosticEvent> s_EventHandlers;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x30")]
		private float m_lastTickSent;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x34")]
		private int m_lastFrame;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x38")]
		private float fpsAvg;

		[Token(Token = "0x1700007E")]
		public static Guid PlayerConnectionGuid
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x2A6500C", Offset = "0x2A6500C", VA = "0x2A6500C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2A65728", Offset = "0x2A65728", VA = "0x2A65728", Slot = "4")]
		protected override string GetGameObjectName()
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2A65334", Offset = "0x2A65334", VA = "0x2A65334")]
		public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create)
		{
			return default;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2A6576C", Offset = "0x2A6576C", VA = "0x2A6576C")]
		internal void RegisterEventHandler(Action<DiagnosticEvent> handler)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2A6545C", Offset = "0x2A6545C", VA = "0x2A6545C")]
		public void UnregisterEventHandler(Action<DiagnosticEvent> handler)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2A65588", Offset = "0x2A65588", VA = "0x2A65588")]
		public void PostEvent(DiagnosticEvent diagnosticEvent)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2A65C8C", Offset = "0x2A65C8C", VA = "0x2A65C8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2A65DA4", Offset = "0x2A65DA4", VA = "0x2A65DA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2A65F60", Offset = "0x2A65F60", VA = "0x2A65F60")]
		public DiagnosticEventCollectorSingleton()
		{
		}
	}
}
