using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils;

namespace Rewired
{
	[Token(Token = "0x2000104")]
	public sealed class InputMapper
	{
		[Token(Token = "0x2000105")]
		public class Context
		{
			[Token(Token = "0x4000609")]
			[FieldOffset(Offset = "0x10")]
			private int JwOchbdvhsvHVdSyYjtqEJdTZzYG;

			[Token(Token = "0x400060A")]
			[FieldOffset(Offset = "0x18")]
			private ControllerMap mtCzlvnEPTtCfVpotNRemSaRaiHy;

			[Token(Token = "0x400060B")]
			[FieldOffset(Offset = "0x20")]
			private ActionElementMap ZgUUXfqlaqVFIkvwiPHXzUSJadsv;

			[Token(Token = "0x400060C")]
			[FieldOffset(Offset = "0x28")]
			private AxisRange tHhmpPjSUBKFuHQGzuGSIhGJKVlJ;

			[Token(Token = "0x400060D")]
			[FieldOffset(Offset = "0x2C")]
			private bool TxSJwJoaEWVxcucVapNSpYPnWYhO;

			[Token(Token = "0x17000268")]
			public int actionId
			{
				[Token(Token = "0x60007A3")]
				[Address(RVA = "0x2488EB8", Offset = "0x2488EB8", VA = "0x2488EB8")]
				get
				{
					return default;
				}
				[Token(Token = "0x60007A4")]
				[Address(RVA = "0x2488EC0", Offset = "0x2488EC0", VA = "0x2488EC0")]
				set
				{
				}
			}

			[Token(Token = "0x17000269")]
			public ControllerMap controllerMap
			{
				[Token(Token = "0x60007A5")]
				[Address(RVA = "0x2488F98", Offset = "0x2488F98", VA = "0x2488F98")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007A6")]
				[Address(RVA = "0x2488FA0", Offset = "0x2488FA0", VA = "0x2488FA0")]
				set
				{
				}
			}

			[Token(Token = "0x1700026A")]
			public ActionElementMap actionElementMapToReplace
			{
				[Token(Token = "0x60007A7")]
				[Address(RVA = "0x2489018", Offset = "0x2489018", VA = "0x2489018")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007A8")]
				[Address(RVA = "0x2489020", Offset = "0x2489020", VA = "0x2489020")]
				set
				{
				}
			}

			[Token(Token = "0x1700026B")]
			public AxisRange actionRange
			{
				[Token(Token = "0x60007A9")]
				[Address(RVA = "0x2489098", Offset = "0x2489098", VA = "0x2489098")]
				get
				{
					return default;
				}
				[Token(Token = "0x60007AA")]
				[Address(RVA = "0x24890A0", Offset = "0x24890A0", VA = "0x24890A0")]
				set
				{
				}
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x2489118", Offset = "0x2489118", VA = "0x2489118")]
			public Context()
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x2489130", Offset = "0x2489130", VA = "0x2489130")]
			private Context(Context P_0)
			{
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x248925C", Offset = "0x248925C", VA = "0x248925C")]
			public Context Clone()
			{
				return null;
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x24892C0", Offset = "0x24892C0", VA = "0x24892C0")]
			internal void McsukFueSylUgFGcFPeYxdJEncmf()
			{
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x2488F38", Offset = "0x2488F38", VA = "0x2488F38")]
			private bool DcXiEIErDgHhAMPiWzVHzKbFEhbaA()
			{
				return default;
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x24891BC", Offset = "0x24891BC", VA = "0x24891BC")]
			public static void Copy(Context source, Context destination)
			{
			}
		}

		[Token(Token = "0x2000106")]
		public enum ConflictResponse
		{
			[Token(Token = "0x400060F")]
			Cancel = 0,
			[Token(Token = "0x4000610")]
			Replace = 1,
			[Token(Token = "0x4000611")]
			Add = 2,
			[Token(Token = "0x4000612")]
			Ignore = 3
		}

		[Token(Token = "0x2000107")]
		public abstract class EventData
		{
			[Token(Token = "0x4000613")]
			[FieldOffset(Offset = "0x10")]
			public readonly InputMapper inputMapper;

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x2488E38", Offset = "0x2488E38", VA = "0x2488E38")]
			internal EventData(InputMapper P_0)
			{
			}
		}

		[Token(Token = "0x2000108")]
		public class InputMappedEventData : EventData
		{
			[Token(Token = "0x4000614")]
			[FieldOffset(Offset = "0x18")]
			public readonly ActionElementMap actionElementMap;

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x248DA20", Offset = "0x248DA20", VA = "0x248DA20")]
			internal InputMappedEventData(InputMapper P_0, ActionElementMap P_1)
			{
			}
		}

		[Token(Token = "0x2000109")]
		public class CanceledEventData : EventData
		{
			[Token(Token = "0x4000615")]
			[FieldOffset(Offset = "0x18")]
			public readonly string message;

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x2488E00", Offset = "0x2488E00", VA = "0x2488E00")]
			internal CanceledEventData(InputMapper P_0, string P_1)
			{
			}
		}

		[Token(Token = "0x200010A")]
		public class ErrorEventData : EventData
		{
			[Token(Token = "0x4000616")]
			[FieldOffset(Offset = "0x18")]
			public readonly string message;

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x248DA84", Offset = "0x248DA84", VA = "0x248DA84")]
			internal ErrorEventData(InputMapper P_0, string P_1)
			{
			}
		}

		[Token(Token = "0x200010B")]
		public class TimedOutEventData : EventData
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x248DA58", Offset = "0x248DA58", VA = "0x248DA58")]
			internal TimedOutEventData(InputMapper P_0)
			{
			}
		}

		[Token(Token = "0x200010C")]
		public class StartedEventData : EventData
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x248DABC", Offset = "0x248DABC", VA = "0x248DABC")]
			internal StartedEventData(InputMapper P_0)
			{
			}
		}

		[Token(Token = "0x200010D")]
		public class StoppedEventData : EventData
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x248DAE8", Offset = "0x248DAE8", VA = "0x248DAE8")]
			internal StoppedEventData(InputMapper P_0)
			{
			}
		}

		[Token(Token = "0x200010E")]
		public class ConflictFoundEventData : EventData
		{
			[Token(Token = "0x4000617")]
			[FieldOffset(Offset = "0x18")]
			public readonly Action<ConflictResponse> responseCallback;

			[Token(Token = "0x4000618")]
			[FieldOffset(Offset = "0x20")]
			public readonly ElementAssignmentInfo assignment;

			[Token(Token = "0x4000619")]
			[FieldOffset(Offset = "0x28")]
			public readonly IList<ElementAssignmentConflictInfo> conflicts;

			[Token(Token = "0x400061A")]
			[FieldOffset(Offset = "0x30")]
			public readonly bool isProtected;

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x2488E64", Offset = "0x2488E64", VA = "0x2488E64")]
			internal ConflictFoundEventData(InputMapper P_0, Action<ConflictResponse> P_1, ElementAssignmentInfo P_2, IList<ElementAssignmentConflictInfo> P_3, bool P_4)
			{
			}
		}

		[Token(Token = "0x200010F")]
		private enum pqkQWTNgxZgZDuoNDchCJcOmqHeX
		{
			[Token(Token = "0x400061C")]
			InputMapped = 0,
			[Token(Token = "0x400061D")]
			Error = 1,
			[Token(Token = "0x400061E")]
			Canceled = 2,
			[Token(Token = "0x400061F")]
			TimedOut = 3,
			[Token(Token = "0x4000620")]
			Started = 4,
			[Token(Token = "0x4000621")]
			Stopped = 5,
			[Token(Token = "0x4000622")]
			ConflictsFound = 6
		}

		[Token(Token = "0x2000110")]
		public enum Status
		{
			[Token(Token = "0x4000624")]
			Idle = 0,
			[Token(Token = "0x4000625")]
			Listening = 1,
			[Token(Token = "0x4000626")]
			AwaitingResponse = 2
		}

		[Token(Token = "0x2000111")]
		private class CvqneWRBGLDpMpWAQjcseqxhBpXs
		{
			[Token(Token = "0x2000112")]
			private enum orJKwROrxEMHlZoxkEuFEygqZgJe
			{
				[Token(Token = "0x4000634")]
				Quit = 0,
				[Token(Token = "0x4000635")]
				Continue = 1
			}

			[Token(Token = "0x2000113")]
			private enum ntchdUCcXwcgtXgjQQoXMalaVOZY
			{
				[Token(Token = "0x4000637")]
				None = 0,
				[Token(Token = "0x4000638")]
				ConflictChecking = 1
			}

			[Token(Token = "0x2000114")]
			private class ahBotaQnJGXqbWYAMrHFvDmYrQCw
			{
				[Token(Token = "0x4000639")]
				[FieldOffset(Offset = "0x10")]
				private Player XGUdRXTQSWQSPvuOLhFeAdcEiwfEA;

				[Token(Token = "0x400063A")]
				[FieldOffset(Offset = "0x18")]
				private int JwOchbdvhsvHVdSyYjtqEJdTZzYG;

				[Token(Token = "0x400063B")]
				[FieldOffset(Offset = "0x20")]
				private Context EyTixTudEJpQwYlPZfsgAcQHgTShA;

				[Token(Token = "0x400063C")]
				[FieldOffset(Offset = "0x28")]
				private ControllerType KHkewZTAeuvHVDDJaWvnQRRxxDiF;

				[Token(Token = "0x400063D")]
				[FieldOffset(Offset = "0x2C")]
				private int UceKlChkUHGjQaNwpAzeqaieFMpt;

				[Token(Token = "0x400063E")]
				[FieldOffset(Offset = "0x30")]
				private ControllerPollingInfo CKVHjYHWrghTEaPwhAisJZEYMPckA;

				[Token(Token = "0x400063F")]
				[FieldOffset(Offset = "0x68")]
				private ModifierKeyFlags njfMvUCuswHuLtHoZcdqAwTyNgamA;

				[Token(Token = "0x1700026F")]
				public Player XAbNzJSvSNjTFwhnJridEdiVWtEM
				{
					[Token(Token = "0x60007E9")]
					[Address(RVA = "0x23B6130", Offset = "0x23B6130", VA = "0x23B6130")]
					get
					{
						return HlNvpalKJDTHNnTaGzpAQCpqBqkN();
					}
				}

				[Token(Token = "0x17000270")]
				public Context pPfCANsxvNQuUlkJnpcfgXnXxIDA
				{
					[Token(Token = "0x60007EA")]
					[Address(RVA = "0x23B6138", Offset = "0x23B6138", VA = "0x23B6138")]
					get
					{
						return BplATpStfHKFujLhGezwaYrdYQfd();
					}
				}

				[Token(Token = "0x17000271")]
				public ControllerType zCReGrIKaGDiebYAdEKHNKYMyFBzA
				{
					[Token(Token = "0x60007EB")]
					[Address(RVA = "0x23B6140", Offset = "0x23B6140", VA = "0x23B6140")]
					get
					{
						return EuagPFCCohHTwfgTqaHdPdGetvWf();
					}
				}

				[Token(Token = "0x17000272")]
				public int dxNWoKAWRnEjMzagpBqSNtmzbbJFA
				{
					[Token(Token = "0x60007EC")]
					[Address(RVA = "0x23B6148", Offset = "0x23B6148", VA = "0x23B6148")]
					get
					{
						return BSnYzyWHBXLzEEeHFUmlTmwuBpYh();
					}
				}

				[Token(Token = "0x17000273")]
				public ControllerPollingInfo sszRiigBPWwssYinvCcBpLjSAKDk
				{
					[Token(Token = "0x60007ED")]
					[Address(RVA = "0x23B6150", Offset = "0x23B6150", VA = "0x23B6150")]
					get
					{
						return RDGCAmfhmfouKTqoLEPavWcDmAmi();
					}
				}

				[Token(Token = "0x17000274")]
				public AxisRange fHLnmlqZlxUGHumVxAlzXLaaqYid
				{
					[Token(Token = "0x60007EE")]
					[Address(RVA = "0x23B616C", Offset = "0x23B616C", VA = "0x23B616C")]
					get
					{
						return cJEmkNaoZpQUIMaPmFiDyGpuimtaA();
					}
				}

				[Token(Token = "0x60007E9")]
				[Address(RVA = "0x23B6130", Offset = "0x23B6130", VA = "0x23B6130")]
				public Player HlNvpalKJDTHNnTaGzpAQCpqBqkN()
				{
					return null;
				}

				[Token(Token = "0x60007EA")]
				[Address(RVA = "0x23B6138", Offset = "0x23B6138", VA = "0x23B6138")]
				public Context BplATpStfHKFujLhGezwaYrdYQfd()
				{
					return null;
				}

				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x23B6140", Offset = "0x23B6140", VA = "0x23B6140")]
				public ControllerType EuagPFCCohHTwfgTqaHdPdGetvWf()
				{
					return default;
				}

				[Token(Token = "0x60007EC")]
				[Address(RVA = "0x23B6148", Offset = "0x23B6148", VA = "0x23B6148")]
				public int BSnYzyWHBXLzEEeHFUmlTmwuBpYh()
				{
					return default;
				}

				[Token(Token = "0x60007ED")]
				[Address(RVA = "0x23B6150", Offset = "0x23B6150", VA = "0x23B6150")]
				public ControllerPollingInfo RDGCAmfhmfouKTqoLEPavWcDmAmi()
				{
					return default;
				}

				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x23B616C", Offset = "0x23B616C", VA = "0x23B616C")]
				public AxisRange cJEmkNaoZpQUIMaPmFiDyGpuimtaA()
				{
					return default;
				}

				[Token(Token = "0x60007EF")]
				[Address(RVA = "0x23B61B4", Offset = "0x23B61B4", VA = "0x23B61B4")]
				public ahBotaQnJGXqbWYAMrHFvDmYrQCw()
				{
				}

				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x23B61BC", Offset = "0x23B61BC", VA = "0x23B61BC")]
				public void zQQfvDZMmpVqPPLYlLuSJXXpwJcI(Player P_0, Context P_1)
				{
				}

				[Token(Token = "0x60007F1")]
				[Address(RVA = "0x23B62B4", Offset = "0x23B62B4", VA = "0x23B62B4")]
				public void SPGTRPyvIslcMdbPTItsewSLRPxx()
				{
				}

				[Token(Token = "0x60007F2")]
				[Address(RVA = "0x23B62DC", Offset = "0x23B62DC", VA = "0x23B62DC")]
				public ElementAssignment cSuMzNCcXuHqgLTvaWKYHJKlsSxF(ControllerPollingInfo P_0)
				{
					return default;
				}

				[Token(Token = "0x60007F3")]
				[Address(RVA = "0x23B62F8", Offset = "0x23B62F8", VA = "0x23B62F8")]
				public ElementAssignment cSuMzNCcXuHqgLTvaWKYHJKlsSxF()
				{
					return default;
				}
			}

			[Token(Token = "0x4000627")]
			[FieldOffset(Offset = "0x10")]
			private readonly InputMapper afWhZEYTbMFjMUeulVkAPjICyxpP;

			[Token(Token = "0x4000628")]
			[FieldOffset(Offset = "0x18")]
			private readonly Options bQaqZJNDPpHZPsCPODygOhVQNZSi;

			[Token(Token = "0x4000629")]
			[FieldOffset(Offset = "0x20")]
			private readonly ahBotaQnJGXqbWYAMrHFvDmYrQCw XBlAEiNAPcZviZPoPeMZCDRJgHvhb;

			[Token(Token = "0x400062A")]
			[FieldOffset(Offset = "0x28")]
			private readonly Dictionary<pqkQWTNgxZgZDuoNDchCJcOmqHeX, SafeDelegate> ItibWhVtFYsKkkzgAslrAMMJBUdm;

			[Token(Token = "0x400062B")]
			[FieldOffset(Offset = "0x30")]
			private readonly Dictionary<string, SafeDelegate> EYTwJGPmykStfmwylYPUYmHfLkXc;

			[Token(Token = "0x400062C")]
			[FieldOffset(Offset = "0x38")]
			private Status XdgtdolzOKCisEMMipKQoOiLOdpP;

			[Token(Token = "0x400062D")]
			[FieldOffset(Offset = "0x3C")]
			private ntchdUCcXwcgtXgjQQoXMalaVOZY mCQjtXATsANARKIfzgFjCFzLJbuk;

			[Token(Token = "0x400062E")]
			[FieldOffset(Offset = "0x40")]
			private double ExyPsGsshISNmqeXwjckKDdtxeWL;

			[Token(Token = "0x400062F")]
			[FieldOffset(Offset = "0x48")]
			private bool krpgyNgQxdwqyoPnegpuDaJKflImb;

			[Token(Token = "0x4000630")]
			[FieldOffset(Offset = "0x50")]
			private List<Player> giFwvOCPGoSmUaILJeUWgcGjKatcb;

			[Token(Token = "0x4000631")]
			[FieldOffset(Offset = "0x58")]
			private readonly List<ControllerPollingInfo> BkWFEQMfPJgBeguEEWxANYukEiIpA;

			[Token(Token = "0x4000632")]
			[FieldOffset(Offset = "0x60")]
			private ElementAssignment wzLoyrPiQXkkLKFeRGxQilFyGjAW;

			[Token(Token = "0x1700026C")]
			public Status sziyftxgQGatauzlOMGISVXaTbkL
			{
				[Token(Token = "0x60007B9")]
				[Address(RVA = "0x2489708", Offset = "0x2489708", VA = "0x2489708")]
				get
				{
					return TXrGBDsZhSQTTgPdkAcjqRrWhaMw();
				}
			}

			[Token(Token = "0x1700026D")]
			public float naGntkOZQLOShDdZHaUwnVhYxrwU
			{
				[Token(Token = "0x60007BA")]
				[Address(RVA = "0x2489710", Offset = "0x2489710", VA = "0x2489710")]
				get
				{
					return GhLTvroGqwKAzDBdeUKEDgloVKIn();
				}
			}

			[Token(Token = "0x1700026E")]
			private bool byOwfPNomSOHtxIoYQbeOLyoyvtp
			{
				[Token(Token = "0x60007BB")]
				[Address(RVA = "0x24897C4", Offset = "0x24897C4", VA = "0x24897C4")]
				get
				{
					return bkOKthjcEmExRHICDVKSMBlFzDMr();
				}
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x2489708", Offset = "0x2489708", VA = "0x2489708")]
			public Status TXrGBDsZhSQTTgPdkAcjqRrWhaMw()
			{
				return default;
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x2489710", Offset = "0x2489710", VA = "0x2489710")]
			public float GhLTvroGqwKAzDBdeUKEDgloVKIn()
			{
				return default;
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x24897C4", Offset = "0x24897C4", VA = "0x24897C4")]
			private bool bkOKthjcEmExRHICDVKSMBlFzDMr()
			{
				return default;
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x24897FC", Offset = "0x24897FC", VA = "0x24897FC")]
			public CvqneWRBGLDpMpWAQjcseqxhBpXs(InputMapper P_0, Dictionary<pqkQWTNgxZgZDuoNDchCJcOmqHeX, SafeDelegate> P_1)
			{
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x2489B30", Offset = "0x2489B30", VA = "0x2489B30", Slot = "1")]
			protected virtual void iMcWPzJbivbQRVFtjrscsWpjuUvv()
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x2489CA0", Offset = "0x2489CA0", VA = "0x2489CA0")]
			public void edGQWybkvEgdpdpFVqgmUdPGZTqV(Context P_0, Options P_1)
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x248A9F4", Offset = "0x248A9F4", VA = "0x248A9F4")]
			public void aewbAWLwjOMPaDEVSdRuwWfvOfOy(string P_0)
			{
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x248AA44", Offset = "0x248AA44", VA = "0x248AA44")]
			private void jRaYtHNVcykNMAbqOnSGaKIIGSEaA(UpdateLoopType P_0)
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x248B364", Offset = "0x248B364", VA = "0x248B364")]
			private void neftIrgqNxhCwszXDdZtxDjrjvobA()
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x2489AA4", Offset = "0x2489AA4", VA = "0x2489AA4")]
			private void ptzeSUAYMaLUihwOYdMoDqBEoBwfb()
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x248ACEC", Offset = "0x248ACEC", VA = "0x248ACEC")]
			private orJKwROrxEMHlZoxkEuFEygqZgJe UyRVEmUxbBtltEEdOBBAVeBHFQqI(out ElementAssignment P_0)
			{
				return default;
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x248B694", Offset = "0x248B694", VA = "0x248B694")]
			private bool STPFoldQiIgbyUwLdbiFQeDTmmXcA(out IEnumerable<ControllerPollingInfo> P_0, out ModifierKeyFlags P_1)
			{
				return default;
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x248BA80", Offset = "0x248BA80", VA = "0x248BA80")]
			private IEnumerable<ControllerPollingInfo> BiwbXVvcKnIOQbTlOKLCPppmELTTA(out ModifierKeyFlags P_0)
			{
				return null;
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x248BBEC", Offset = "0x248BBEC", VA = "0x248BBEC")]
			private ControllerPollingInfo jPMuuFpqUaInuRebGecmGOJvhrTc(Options P_0, out ModifierKeyFlags P_1)
			{
				return default;
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x248BCC4", Offset = "0x248BCC4", VA = "0x248BCC4")]
			private static ControllerPollingInfo jPMuuFpqUaInuRebGecmGOJvhrTc(Options P_0, out bool P_1, out ModifierKeyFlags P_2, out string P_3)
			{
				return default;
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x248B8F4", Offset = "0x248B8F4", VA = "0x248B8F4")]
			private static bool aWFHDrZoEukmCfujrhhslmlnRYxI(ControllerPollingInfo P_0, Options P_1)
			{
				return default;
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x248BA24", Offset = "0x248BA24", VA = "0x248BA24")]
			private static bool dnAIMjUBnUPJVoHyTaRwRwAwQKUw(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ControllerPollingInfo P_1, Options P_2)
			{
				return default;
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x248A360", Offset = "0x248A360", VA = "0x248A360")]
			private void RGdghEDCtZTDtTJkekaqelsMLCYxA()
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x248B1EC", Offset = "0x248B1EC", VA = "0x248B1EC")]
			private orJKwROrxEMHlZoxkEuFEygqZgJe XQvbhXZZWShRcStLzMWDUWauxTgB(ElementAssignment P_0)
			{
				return default;
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x248C354", Offset = "0x248C354", VA = "0x248C354")]
			private static bool zpdYSIHfNkXPRvuXubZssDEJWmfo(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ElementAssignment P_1, List<Player> P_2)
			{
				return default;
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x248C750", Offset = "0x248C750", VA = "0x248C750")]
			private static bool BUpNasfbyZAwibvyZWWVBAbhdvHvA(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ElementAssignment P_1, List<Player> P_2)
			{
				return default;
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x248CB70", Offset = "0x248CB70", VA = "0x248CB70")]
			private static IList<ElementAssignmentConflictInfo> mghaFDRvWsAVVqqMCmSlbieDlvjf(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ElementAssignment P_1, List<Player> P_2)
			{
				return null;
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x248C660", Offset = "0x248C660", VA = "0x248C660")]
			private static bool NwmzUMEJidbTncESwkEkhCWCHBGaB(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ElementAssignment P_1, out ElementAssignmentConflictCheck P_2)
			{
				return default;
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x248CFEC", Offset = "0x248CFEC", VA = "0x248CFEC")]
			private static void hXvMxxkKCLvhHBeSrwUyHeBlAfieA(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ElementAssignment P_1, List<Player> P_2)
			{
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x248A80C", Offset = "0x248A80C", VA = "0x248A80C")]
			private void xYtunnRQSBvIGaqlmkiBhHCsbShL()
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x2489BD4", Offset = "0x2489BD4", VA = "0x2489BD4")]
			private void ZOnnIzLBcftHDPCtAfFaHvArCPmu()
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x248D130", Offset = "0x248D130", VA = "0x248D130")]
			private bool wkpNeFCrHzcEPUxAratvQgFUxojE(pqkQWTNgxZgZDuoNDchCJcOmqHeX P_0)
			{
				return default;
			}

			[Token(Token = "0x60007D4")]
			private void VsncEXPmWhCpsdBznLpDcPGGNdsDb<_0001>(pqkQWTNgxZgZDuoNDchCJcOmqHeX P_0, _0001 P_1)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x248A2EC", Offset = "0x248A2EC", VA = "0x248A2EC")]
			private void oPFAmVelZJDtWASPerVVQHoNElpEB()
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x248D1B0", Offset = "0x248D1B0", VA = "0x248D1B0")]
			private void kHUcNXbpGaVFWfMPDPbJeQQOjAMsA()
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x248D1BC", Offset = "0x248D1BC", VA = "0x248D1BC")]
			private void pGjfThRdwdYslSUltPbtbdmIslJG(ActionElementMap P_0)
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x2489F94", Offset = "0x2489F94", VA = "0x2489F94")]
			private void cdvAJZQOaueWVSUWhZVkYhmBZYnr(string P_0)
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x248C488", Offset = "0x248C488", VA = "0x248C488")]
			private orJKwROrxEMHlZoxkEuFEygqZgJe JzzzVbXyFKRxXlzBbmvWUgjGLrtn(ElementAssignment P_0)
			{
				return default;
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x248D59C", Offset = "0x248D59C", VA = "0x248D59C")]
			private orJKwROrxEMHlZoxkEuFEygqZgJe pyvXxNScWSyyWnhaFCmMYsdGfuIN(ConflictResponse P_0, ElementAssignment P_1)
			{
				return default;
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x248D608", Offset = "0x248D608", VA = "0x248D608")]
			private orJKwROrxEMHlZoxkEuFEygqZgJe pyvXxNScWSyyWnhaFCmMYsdGfuIN(ConflictResponse P_0, ElementAssignment P_1, bool P_2)
			{
				return default;
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x248ACA4", Offset = "0x248ACA4", VA = "0x248ACA4")]
			private void NoVBwEHJvuoWIcMpToDgoLvFkuZq()
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x248A2A4", Offset = "0x248A2A4", VA = "0x248A2A4")]
			private void azHfZagcdORTVurnPQNDbgGCdlzpA(string P_0)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x248D3F4", Offset = "0x248D3F4", VA = "0x248D3F4")]
			private void tgUTbEyPyhymqcBMomTjUwYyjwls()
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x248D7A8", Offset = "0x248D7A8", VA = "0x248D7A8")]
			private void eocEHWldcxlYmWpmkDPDdzoPtuby()
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x248B284", Offset = "0x248B284", VA = "0x248B284")]
			private void uKsxONBMitySWjBsbNQCaNoHODzg(ElementAssignment P_0)
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x248D204", Offset = "0x248D204", VA = "0x248D204")]
			private void TrZGBvKAMkLMckUvfUMfwWVjFdgj(ActionElementMap P_0)
			{
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x248D834", Offset = "0x248D834", VA = "0x248D834")]
			private void DswviOkrXXirXpDfcdVjxtbqGOvM()
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x248D928", Offset = "0x248D928", VA = "0x248D928")]
			private void giuQAOGqgJGpaeVmdyUvrLopDENzA(string P_0)
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x248D2FC", Offset = "0x248D2FC", VA = "0x248D2FC")]
			private void ELYOwNrqZrDeeRwnkiivRaQzqjNs(string P_0)
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x248D424", Offset = "0x248D424", VA = "0x248D424")]
			private void KPPucdQoFIfBoANWjeNBCXpDcNUQB(ElementAssignmentInfo P_0, IList<ElementAssignmentConflictInfo> P_1, bool P_2)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x248A900", Offset = "0x248A900", VA = "0x248A900")]
			private void ykcpdHpSundMctFmxDBIkMsMwkTvA()
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x248B39C", Offset = "0x248B39C", VA = "0x248B39C")]
			private void xLsGPWjIjHQugjDsVbvTUfZqPFCkA()
			{
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x248DB14", Offset = "0x248DB14", VA = "0x248DB14")]
			public void UAUojKKmPKyQXeiIwvgxiCJhByZFA(ConflictResponse P_0)
			{
			}
		}

		[Token(Token = "0x2000115")]
		public class Options
		{
			[Token(Token = "0x4000640")]
			[FieldOffset(Offset = "0x10")]
			private bool IDPlvLmvqniVnBkNLduvMBGhhgoJ;

			[Token(Token = "0x4000641")]
			[FieldOffset(Offset = "0x11")]
			private bool GYYKsUfQAvHqiGkybLpagildpMBMB;

			[Token(Token = "0x4000642")]
			[FieldOffset(Offset = "0x12")]
			private bool MDPuypiBRcAoKOWhcnOZosrsRkyP;

			[Token(Token = "0x4000643")]
			[FieldOffset(Offset = "0x14")]
			private float xRNCaqgKPAyRGPJLoiKsOYWNCGdRA;

			[Token(Token = "0x4000644")]
			[FieldOffset(Offset = "0x18")]
			private bool WMmVYLXfNSKDUyXjoBbZHboFGnogA;

			[Token(Token = "0x4000645")]
			[FieldOffset(Offset = "0x19")]
			private bool kWWfdMvCuNaUyfrFZmQkblqizLTiB;

			[Token(Token = "0x4000646")]
			[FieldOffset(Offset = "0x1A")]
			private bool ilSnwtrglULTnOhqJautuPKbGAKn;

			[Token(Token = "0x4000647")]
			[FieldOffset(Offset = "0x1B")]
			private bool mUKfPJHjhyqwCOWcAewLNAKTELllA;

			[Token(Token = "0x4000648")]
			[FieldOffset(Offset = "0x20")]
			private int[] kkOpBBidpWKrnMNyxIsrIeLWSTlK;

			[Token(Token = "0x4000649")]
			[FieldOffset(Offset = "0x28")]
			private ConflictResponse OWCkeBziEouRJRnoAgCFhBhPFobi;

			[Token(Token = "0x400064A")]
			[FieldOffset(Offset = "0x2C")]
			private bool PbumTIAPdGbQbaGQKLcBLfEqoNnvA;

			[Token(Token = "0x400064B")]
			[FieldOffset(Offset = "0x2D")]
			private bool njiBtqGzYTEYcKVKEUjVepkJLgMCA;

			[Token(Token = "0x400064C")]
			[FieldOffset(Offset = "0x2E")]
			private bool bMCLrBQXlpobcuKOSepkFZFwnOju;

			[Token(Token = "0x400064D")]
			[FieldOffset(Offset = "0x2F")]
			private bool olgzYYtkqXhUvreijXBRFMlhjXLy;

			[Token(Token = "0x400064E")]
			[FieldOffset(Offset = "0x30")]
			private float HyZFlvYpIwEbpyDWQFrICFwcgdvQA;

			[Token(Token = "0x400064F")]
			internal const string xUYjZpzFCvsWRWbASgswBDnvNOOv = "isElementAllowed";

			[Token(Token = "0x4000650")]
			[FieldOffset(Offset = "0x38")]
			private readonly Dictionary<string, SafeDelegate> EYTwJGPmykStfmwylYPUYmHfLkXc;

			[Token(Token = "0x17000275")]
			public bool allowAxes
			{
				[Token(Token = "0x60007F4")]
				[Address(RVA = "0x248DD08", Offset = "0x248DD08", VA = "0x248DD08")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000276")]
			public bool allowButtons
			{
				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x248DD10", Offset = "0x248DD10", VA = "0x248DD10")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000277")]
			public bool allowButtonsOnFullAxisAssignment
			{
				[Token(Token = "0x60007F6")]
				[Address(RVA = "0x248DD18", Offset = "0x248DD18", VA = "0x248DD18")]
				get
				{
					return default;
				}
				[Token(Token = "0x60007F7")]
				[Address(RVA = "0x248DD20", Offset = "0x248DD20", VA = "0x248DD20")]
				set
				{
				}
			}

			[Token(Token = "0x17000278")]
			public float timeout
			{
				[Token(Token = "0x60007F8")]
				[Address(RVA = "0x248DD28", Offset = "0x248DD28", VA = "0x248DD28")]
				get
				{
					return default;
				}
				[Token(Token = "0x60007F9")]
				[Address(RVA = "0x248DD30", Offset = "0x248DD30", VA = "0x248DD30")]
				set
				{
				}
			}

			[Token(Token = "0x17000279")]
			public bool checkForConflicts
			{
				[Token(Token = "0x60007FA")]
				[Address(RVA = "0x248DD60", Offset = "0x248DD60", VA = "0x248DD60")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700027A")]
			public bool checkForConflictsWithAllPlayers
			{
				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x248DD68", Offset = "0x248DD68", VA = "0x248DD68")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700027B")]
			public bool checkForConflictsWithSelf
			{
				[Token(Token = "0x60007FC")]
				[Address(RVA = "0x248DD70", Offset = "0x248DD70", VA = "0x248DD70")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700027C")]
			public bool checkForConflictsWithSystemPlayer
			{
				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x248DD78", Offset = "0x248DD78", VA = "0x248DD78")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700027D")]
			public int[] checkForConflictsWithPlayerIds
			{
				[Token(Token = "0x60007FE")]
				[Address(RVA = "0x248DD80", Offset = "0x248DD80", VA = "0x248DD80")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700027E")]
			public ConflictResponse defaultActionWhenConflictFound
			{
				[Token(Token = "0x60007FF")]
				[Address(RVA = "0x248DD88", Offset = "0x248DD88", VA = "0x248DD88")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700027F")]
			public bool ignoreMouseXAxis
			{
				[Token(Token = "0x6000800")]
				[Address(RVA = "0x248DD90", Offset = "0x248DD90", VA = "0x248DD90")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000801")]
				[Address(RVA = "0x248DD98", Offset = "0x248DD98", VA = "0x248DD98")]
				set
				{
				}
			}

			[Token(Token = "0x17000280")]
			public bool ignoreMouseYAxis
			{
				[Token(Token = "0x6000802")]
				[Address(RVA = "0x248DDA0", Offset = "0x248DDA0", VA = "0x248DDA0")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000803")]
				[Address(RVA = "0x248DDA8", Offset = "0x248DDA8", VA = "0x248DDA8")]
				set
				{
				}
			}

			[Token(Token = "0x17000281")]
			public bool allowKeyboardKeysWithModifiers
			{
				[Token(Token = "0x6000804")]
				[Address(RVA = "0x248DDB0", Offset = "0x248DDB0", VA = "0x248DDB0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000282")]
			public bool allowKeyboardModifierKeyAsPrimary
			{
				[Token(Token = "0x6000805")]
				[Address(RVA = "0x248DDB8", Offset = "0x248DDB8", VA = "0x248DDB8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000283")]
			public float holdDurationToMapKeyboardModifierKeyAsPrimary
			{
				[Token(Token = "0x6000806")]
				[Address(RVA = "0x248DDC0", Offset = "0x248DDC0", VA = "0x248DDC0")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000807")]
			internal _0001 ILFjrlXErAaQYsYRoWPNsXQagWVF<_0001>(string P_0) where _0001 : SafeDelegate
			{
				return null;
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x24899B0", Offset = "0x24899B0", VA = "0x24899B0")]
			public Options()
			{
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x248DDC8", Offset = "0x248DDC8", VA = "0x248DDC8")]
			private Options(Options P_0)
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x248DF18", Offset = "0x248DF18", VA = "0x248DF18")]
			public Options Clone()
			{
				return null;
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x248DF7C", Offset = "0x248DF7C", VA = "0x248DF7C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x248B490", Offset = "0x248B490", VA = "0x248B490")]
			internal void SPGTRPyvIslcMdbPTItsewSLRPxx()
			{
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x2489FDC", Offset = "0x2489FDC", VA = "0x2489FDC")]
			public static void Copy(Options source, Options destination)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190CB0", Offset = "0x190CB0")]
		private sealed class CsGLCHGTcukphAwqbUFlUowthqtc
		{
			[Token(Token = "0x4000651")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CsGLCHGTcukphAwqbUFlUowthqtc _003C_003E9;

			[Token(Token = "0x4000652")]
			[FieldOffset(Offset = "0x8")]
			public static Action<Exception> _003C_003E9__54_0;

			[Token(Token = "0x4000653")]
			[FieldOffset(Offset = "0x10")]
			public static Action<Exception> _003C_003E9__54_1;

			[Token(Token = "0x4000654")]
			[FieldOffset(Offset = "0x18")]
			public static Action<Exception> _003C_003E9__54_2;

			[Token(Token = "0x4000655")]
			[FieldOffset(Offset = "0x20")]
			public static Action<Exception> _003C_003E9__54_3;

			[Token(Token = "0x4000656")]
			[FieldOffset(Offset = "0x28")]
			public static Action<Exception> _003C_003E9__54_4;

			[Token(Token = "0x4000657")]
			[FieldOffset(Offset = "0x30")]
			public static Action<Exception> _003C_003E9__54_5;

			[Token(Token = "0x4000658")]
			[FieldOffset(Offset = "0x38")]
			public static Action<Exception> _003C_003E9__54_6;

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x248932C", Offset = "0x248932C", VA = "0x248932C")]
			public CsGLCHGTcukphAwqbUFlUowthqtc()
			{
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x2489334", Offset = "0x2489334", VA = "0x2489334")]
			internal void LxzSEBmrlSVTqfGKXIVzaayfTTdc(Exception P_0)
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x24893C0", Offset = "0x24893C0", VA = "0x24893C0")]
			internal void whQAbIKdlWAuKNfnCCpBCsQATqQq(Exception P_0)
			{
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x248944C", Offset = "0x248944C", VA = "0x248944C")]
			internal void GnyWwuvxKiIMVMoznmjfsbsRoSwP(Exception P_0)
			{
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x24894D8", Offset = "0x24894D8", VA = "0x24894D8")]
			internal void XXnxMLQjJTcsWUofzcaMfDmkXJIUA(Exception P_0)
			{
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x2489564", Offset = "0x2489564", VA = "0x2489564")]
			internal void UOYunpdinGHuNRmNChOUOPDbJPnU(Exception P_0)
			{
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0x24895F0", Offset = "0x24895F0", VA = "0x24895F0")]
			internal void HhbwmKFqIeHIdcsYQeyCYPMSvbEoA(Exception P_0)
			{
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x248967C", Offset = "0x248967C", VA = "0x248967C")]
			internal void OEwqbJSoFMHyBHdRIAzzLZQaFDvE(Exception P_0)
			{
			}
		}

		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x0")]
		private static InputMapper sKlAxiBmvyBxAjrDeOltNvBiEdkP;

		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x8")]
		private static int TMzSxjjyapuKOmNiKYPcOmUjpTlD;

		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0x10")]
		private readonly int wfFGgdoRWtehIGyVjVmwswiztTuV;

		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x14")]
		private readonly bool wAyxrYqTkTfseXCamASZxBaTedubA;

		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x18")]
		private readonly CvqneWRBGLDpMpWAQjcseqxhBpXs gKQddRRUdFFTaMlSYrVtPlluZoRb;

		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x20")]
		private Options bQaqZJNDPpHZPsCPODygOhVQNZSi;

		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<pqkQWTNgxZgZDuoNDchCJcOmqHeX, SafeDelegate> ItibWhVtFYsKkkzgAslrAMMJBUdm;

		[Token(Token = "0x17000264")]
		public static InputMapper Default
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x23D6CE4", Offset = "0x23D6CE4", VA = "0x23D6CE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000265")]
		public Options options
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x23D7668", Offset = "0x23D7668", VA = "0x23D7668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000266")]
		public Status status
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x23D7758", Offset = "0x23D7758", VA = "0x23D7758")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000267")]
		public float timeRemaining
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x23D7774", Offset = "0x23D7774", VA = "0x23D7774")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action<InputMappedEventData> InputMappedEvent
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x23D7790", Offset = "0x23D7790", VA = "0x23D7790")]
			add
			{
			}
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x23D788C", Offset = "0x23D788C", VA = "0x23D788C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event Action<StoppedEventData> StoppedEvent
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0x23D7988", Offset = "0x23D7988", VA = "0x23D7988")]
			add
			{
			}
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x23D7A84", Offset = "0x23D7A84", VA = "0x23D7A84")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event Action<ConflictFoundEventData> ConflictFoundEvent
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x23D7B80", Offset = "0x23D7B80", VA = "0x23D7B80")]
			add
			{
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x23D7C7C", Offset = "0x23D7C7C", VA = "0x23D7C7C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x23D760C", Offset = "0x23D760C", VA = "0x23D760C")]
		private static int ZbDIHfcjnfeHcHypbxiSfPJiJyKdA()
		{
			return default;
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x23D7D78", Offset = "0x23D7D78", VA = "0x23D7D78")]
		public InputMapper()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x23D6D58", Offset = "0x23D6D58", VA = "0x23D6D58")]
		private InputMapper(bool P_0)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x23D7DEC", Offset = "0x23D7DEC", VA = "0x23D7DEC")]
		public void RemoveAllEventListeners()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x23D7F50", Offset = "0x23D7F50", VA = "0x23D7F50")]
		public bool Start(Context mappingContext)
		{
			return default;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x23D820C", Offset = "0x23D820C", VA = "0x23D820C")]
		public void Stop()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x23D8014", Offset = "0x23D8014", VA = "0x23D8014")]
		private bool edGQWybkvEgdpdpFVqgmUdPGZTqV(Context P_0, Options P_1)
		{
			return default;
		}
	}
}
