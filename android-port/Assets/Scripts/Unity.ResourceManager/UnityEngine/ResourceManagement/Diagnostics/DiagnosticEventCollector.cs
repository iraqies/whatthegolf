using System;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Diagnostics
{
	[Token(Token = "0x200006A")]
	public class DiagnosticEventCollector : MonoBehaviour
	{
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x0")]
		private static DiagnosticEventCollector s_Collector;

		[Token(Token = "0x1700007F")]
		public static Guid PlayerConnectionGuid
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x2A65008", Offset = "0x2A65008", VA = "0x2A65008")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2A65140", Offset = "0x2A65140", VA = "0x2A65140")]
		public static DiagnosticEventCollector FindOrCreateGlobalInstance()
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2A65330", Offset = "0x2A65330", VA = "0x2A65330")]
		public static bool RegisterEventHandler(Action<DiagnosticEvent> handler, bool register, bool create)
		{
			return default;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2A653FC", Offset = "0x2A653FC", VA = "0x2A653FC")]
		public void UnregisterEventHandler(Action<DiagnosticEvent> handler)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2A6550C", Offset = "0x2A6550C", VA = "0x2A6550C")]
		public void PostEvent(DiagnosticEvent diagnosticEvent)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2A65720", Offset = "0x2A65720", VA = "0x2A65720")]
		public DiagnosticEventCollector()
		{
		}
	}
}
