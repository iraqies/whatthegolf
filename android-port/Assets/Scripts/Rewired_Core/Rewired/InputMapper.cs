using System;
using System.Collections.Generic;
using Rewired.Utils;

namespace Rewired
{
	public sealed class InputMapper
	{
		public class Context
		{
			private int JwOchbdvhsvHVdSyYjtqEJdTZzYG;

			private ControllerMap mtCzlvnEPTtCfVpotNRemSaRaiHy;

			private ActionElementMap ZgUUXfqlaqVFIkvwiPHXzUSJadsv;

			private AxisRange tHhmpPjSUBKFuHQGzuGSIhGJKVlJ;

			private bool TxSJwJoaEWVxcucVapNSpYPnWYhO;

			public int actionId
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public ControllerMap controllerMap
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ActionElementMap actionElementMapToReplace
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public AxisRange actionRange
			{
				get
				{
					return AxisRange.Full;
				}
				set
				{
				}
			}

			public Context()
			{
			}

			private Context(Context P_0)
			{
			}

			public Context Clone()
			{
				return null;
			}

			internal void McsukFueSylUgFGcFPeYxdJEncmf()
			{
			}

			private bool DcXiEIErDgHhAMPiWzVHzKbFEhbaA()
			{
				return false;
			}

			public static void Copy(Context source, Context destination)
			{
			}
		}

		public enum ConflictResponse
		{
			Cancel = 0,
			Replace = 1,
			Add = 2,
			Ignore = 3
		}

		public abstract class EventData
		{
			public readonly InputMapper inputMapper;

			internal EventData(InputMapper P_0)
			{
			}
		}

		public class InputMappedEventData : EventData
		{
			public readonly ActionElementMap actionElementMap;

			internal InputMappedEventData(InputMapper P_0, ActionElementMap P_1)
				: base(null)
			{
			}
		}

		public class CanceledEventData : EventData
		{
			public readonly string message;

			internal CanceledEventData(InputMapper P_0, string P_1)
				: base(null)
			{
			}
		}

		public class ErrorEventData : EventData
		{
			public readonly string message;

			internal ErrorEventData(InputMapper P_0, string P_1)
				: base(null)
			{
			}
		}

		public class TimedOutEventData : EventData
		{
			internal TimedOutEventData(InputMapper P_0)
				: base(null)
			{
			}
		}

		public class StartedEventData : EventData
		{
			internal StartedEventData(InputMapper P_0)
				: base(null)
			{
			}
		}

		public class StoppedEventData : EventData
		{
			internal StoppedEventData(InputMapper P_0)
				: base(null)
			{
			}
		}

		public class ConflictFoundEventData : EventData
		{
			public readonly Action<ConflictResponse> responseCallback;

			public readonly ElementAssignmentInfo assignment;

			public readonly IList<ElementAssignmentConflictInfo> conflicts;

			public readonly bool isProtected;

			internal ConflictFoundEventData(InputMapper P_0, Action<ConflictResponse> P_1, ElementAssignmentInfo P_2, IList<ElementAssignmentConflictInfo> P_3, bool P_4)
				: base(null)
			{
			}
		}

		private enum pqkQWTNgxZgZDuoNDchCJcOmqHeX
		{
			InputMapped = 0,
			Error = 1,
			Canceled = 2,
			TimedOut = 3,
			Started = 4,
			Stopped = 5,
			ConflictsFound = 6
		}

		public enum Status
		{
			Idle = 0,
			Listening = 1,
			AwaitingResponse = 2
		}

		private class CvqneWRBGLDpMpWAQjcseqxhBpXs
		{
			private enum orJKwROrxEMHlZoxkEuFEygqZgJe
			{
				Quit = 0,
				Continue = 1
			}

			private enum ntchdUCcXwcgtXgjQQoXMalaVOZY
			{
				None = 0,
				ConflictChecking = 1
			}

			private class ahBotaQnJGXqbWYAMrHFvDmYrQCw
			{
				private Player XGUdRXTQSWQSPvuOLhFeAdcEiwfEA;

				private int JwOchbdvhsvHVdSyYjtqEJdTZzYG;

				private Context EyTixTudEJpQwYlPZfsgAcQHgTShA;

				private ControllerType KHkewZTAeuvHVDDJaWvnQRRxxDiF;

				private int UceKlChkUHGjQaNwpAzeqaieFMpt;

				private ControllerPollingInfo CKVHjYHWrghTEaPwhAisJZEYMPckA;

				private ModifierKeyFlags njfMvUCuswHuLtHoZcdqAwTyNgamA;

				public Player XAbNzJSvSNjTFwhnJridEdiVWtEM => HlNvpalKJDTHNnTaGzpAQCpqBqkN();

				public Context pPfCANsxvNQuUlkJnpcfgXnXxIDA => BplATpStfHKFujLhGezwaYrdYQfd();

				public ControllerType zCReGrIKaGDiebYAdEKHNKYMyFBzA => EuagPFCCohHTwfgTqaHdPdGetvWf();

				public int dxNWoKAWRnEjMzagpBqSNtmzbbJFA => BSnYzyWHBXLzEEeHFUmlTmwuBpYh();

				public ControllerPollingInfo sszRiigBPWwssYinvCcBpLjSAKDk => RDGCAmfhmfouKTqoLEPavWcDmAmi();

				public AxisRange fHLnmlqZlxUGHumVxAlzXLaaqYid => cJEmkNaoZpQUIMaPmFiDyGpuimtaA();

				public Player HlNvpalKJDTHNnTaGzpAQCpqBqkN()
				{
					return null;
				}

				public Context BplATpStfHKFujLhGezwaYrdYQfd()
				{
					return null;
				}

				public ControllerType EuagPFCCohHTwfgTqaHdPdGetvWf()
				{
					return ControllerType.Keyboard;
				}

				public int BSnYzyWHBXLzEEeHFUmlTmwuBpYh()
				{
					return 0;
				}

				public ControllerPollingInfo RDGCAmfhmfouKTqoLEPavWcDmAmi()
				{
					return default;
				}

				public AxisRange cJEmkNaoZpQUIMaPmFiDyGpuimtaA()
				{
					return AxisRange.Full;
				}

				public void zQQfvDZMmpVqPPLYlLuSJXXpwJcI(Player P_0, Context P_1)
				{
				}

				public void SPGTRPyvIslcMdbPTItsewSLRPxx()
				{
				}

				public ElementAssignment cSuMzNCcXuHqgLTvaWKYHJKlsSxF(ControllerPollingInfo P_0)
				{
					return default;
				}

				public ElementAssignment cSuMzNCcXuHqgLTvaWKYHJKlsSxF()
				{
					return default;
				}
			}

			private readonly InputMapper afWhZEYTbMFjMUeulVkAPjICyxpP;

			private readonly Options bQaqZJNDPpHZPsCPODygOhVQNZSi;

			private readonly ahBotaQnJGXqbWYAMrHFvDmYrQCw XBlAEiNAPcZviZPoPeMZCDRJgHvhb;

			private readonly Dictionary<pqkQWTNgxZgZDuoNDchCJcOmqHeX, SafeDelegate> ItibWhVtFYsKkkzgAslrAMMJBUdm;

			private readonly Dictionary<string, SafeDelegate> EYTwJGPmykStfmwylYPUYmHfLkXc;

			private Status XdgtdolzOKCisEMMipKQoOiLOdpP;

			private ntchdUCcXwcgtXgjQQoXMalaVOZY mCQjtXATsANARKIfzgFjCFzLJbuk;

			private double ExyPsGsshISNmqeXwjckKDdtxeWL;

			private bool krpgyNgQxdwqyoPnegpuDaJKflImb;

			private List<Player> giFwvOCPGoSmUaILJeUWgcGjKatcb;

			private readonly List<ControllerPollingInfo> BkWFEQMfPJgBeguEEWxANYukEiIpA;

			private ElementAssignment wzLoyrPiQXkkLKFeRGxQilFyGjAW;

			public Status sziyftxgQGatauzlOMGISVXaTbkL => TXrGBDsZhSQTTgPdkAcjqRrWhaMw();

			public float naGntkOZQLOShDdZHaUwnVhYxrwU => GhLTvroGqwKAzDBdeUKEDgloVKIn();

			private bool byOwfPNomSOHtxIoYQbeOLyoyvtp => bkOKthjcEmExRHICDVKSMBlFzDMr();

			public Status TXrGBDsZhSQTTgPdkAcjqRrWhaMw()
			{
				return Status.Idle;
			}

			public float GhLTvroGqwKAzDBdeUKEDgloVKIn()
			{
				return 0f;
			}

			private bool bkOKthjcEmExRHICDVKSMBlFzDMr()
			{
				return false;
			}

			public CvqneWRBGLDpMpWAQjcseqxhBpXs(InputMapper P_0, Dictionary<pqkQWTNgxZgZDuoNDchCJcOmqHeX, SafeDelegate> P_1)
			{
			}

			~CvqneWRBGLDpMpWAQjcseqxhBpXs()
			{
			}

			public void edGQWybkvEgdpdpFVqgmUdPGZTqV(Context P_0, Options P_1)
			{
			}

			public void aewbAWLwjOMPaDEVSdRuwWfvOfOy(string P_0)
			{
			}

			private void jRaYtHNVcykNMAbqOnSGaKIIGSEaA(UpdateLoopType P_0)
			{
			}

			private void neftIrgqNxhCwszXDdZtxDjrjvobA()
			{
			}

			private void ptzeSUAYMaLUihwOYdMoDqBEoBwfb()
			{
			}

			private orJKwROrxEMHlZoxkEuFEygqZgJe UyRVEmUxbBtltEEdOBBAVeBHFQqI(out ElementAssignment P_0)
			{
				P_0 = default;
				return orJKwROrxEMHlZoxkEuFEygqZgJe.Quit;
			}

			private bool STPFoldQiIgbyUwLdbiFQeDTmmXcA(out IEnumerable<ControllerPollingInfo> P_0, out ModifierKeyFlags P_1)
			{
				P_0 = null;
				P_1 = default;
				return false;
			}

			private IEnumerable<ControllerPollingInfo> BiwbXVvcKnIOQbTlOKLCPppmELTTA(out ModifierKeyFlags P_0)
			{
				P_0 = default;
				return null;
			}

			private ControllerPollingInfo jPMuuFpqUaInuRebGecmGOJvhrTc(Options P_0, out ModifierKeyFlags P_1)
			{
				P_1 = default;
				return default;
			}

			private static ControllerPollingInfo jPMuuFpqUaInuRebGecmGOJvhrTc(Options P_0, out bool P_1, out ModifierKeyFlags P_2, out string P_3)
			{
				P_1 = default;
				P_2 = default;
				P_3 = null;
				return default;
			}

			private static bool aWFHDrZoEukmCfujrhhslmlnRYxI(ControllerPollingInfo P_0, Options P_1)
			{
				return false;
			}

			private static bool dnAIMjUBnUPJVoHyTaRwRwAwQKUw(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ControllerPollingInfo P_1, Options P_2)
			{
				return false;
			}

			private void RGdghEDCtZTDtTJkekaqelsMLCYxA()
			{
			}

			private orJKwROrxEMHlZoxkEuFEygqZgJe XQvbhXZZWShRcStLzMWDUWauxTgB(ElementAssignment P_0)
			{
				return orJKwROrxEMHlZoxkEuFEygqZgJe.Quit;
			}

			private static bool zpdYSIHfNkXPRvuXubZssDEJWmfo(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ElementAssignment P_1, List<Player> P_2)
			{
				return false;
			}

			private static bool BUpNasfbyZAwibvyZWWVBAbhdvHvA(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ElementAssignment P_1, List<Player> P_2)
			{
				return false;
			}

			private static IList<ElementAssignmentConflictInfo> mghaFDRvWsAVVqqMCmSlbieDlvjf(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ElementAssignment P_1, List<Player> P_2)
			{
				return null;
			}

			private static bool NwmzUMEJidbTncESwkEkhCWCHBGaB(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ElementAssignment P_1, out ElementAssignmentConflictCheck P_2)
			{
				P_2 = default;
				return false;
			}

			private static void hXvMxxkKCLvhHBeSrwUyHeBlAfieA(ahBotaQnJGXqbWYAMrHFvDmYrQCw P_0, ElementAssignment P_1, List<Player> P_2)
			{
			}

			private void xYtunnRQSBvIGaqlmkiBhHCsbShL()
			{
			}

			private void ZOnnIzLBcftHDPCtAfFaHvArCPmu()
			{
			}

			private bool wkpNeFCrHzcEPUxAratvQgFUxojE(pqkQWTNgxZgZDuoNDchCJcOmqHeX P_0)
			{
				return false;
			}

			private void VsncEXPmWhCpsdBznLpDcPGGNdsDb<_0001>(pqkQWTNgxZgZDuoNDchCJcOmqHeX P_0, _0001 P_1)
			{
			}

			private void oPFAmVelZJDtWASPerVVQHoNElpEB()
			{
			}

			private void kHUcNXbpGaVFWfMPDPbJeQQOjAMsA()
			{
			}

			private void pGjfThRdwdYslSUltPbtbdmIslJG(ActionElementMap P_0)
			{
			}

			private void cdvAJZQOaueWVSUWhZVkYhmBZYnr(string P_0)
			{
			}

			private orJKwROrxEMHlZoxkEuFEygqZgJe JzzzVbXyFKRxXlzBbmvWUgjGLrtn(ElementAssignment P_0)
			{
				return orJKwROrxEMHlZoxkEuFEygqZgJe.Quit;
			}

			private orJKwROrxEMHlZoxkEuFEygqZgJe pyvXxNScWSyyWnhaFCmMYsdGfuIN(ConflictResponse P_0, ElementAssignment P_1)
			{
				return orJKwROrxEMHlZoxkEuFEygqZgJe.Quit;
			}

			private orJKwROrxEMHlZoxkEuFEygqZgJe pyvXxNScWSyyWnhaFCmMYsdGfuIN(ConflictResponse P_0, ElementAssignment P_1, bool P_2)
			{
				return orJKwROrxEMHlZoxkEuFEygqZgJe.Quit;
			}

			private void NoVBwEHJvuoWIcMpToDgoLvFkuZq()
			{
			}

			private void azHfZagcdORTVurnPQNDbgGCdlzpA(string P_0)
			{
			}

			private void tgUTbEyPyhymqcBMomTjUwYyjwls()
			{
			}

			private void eocEHWldcxlYmWpmkDPDdzoPtuby()
			{
			}

			private void uKsxONBMitySWjBsbNQCaNoHODzg(ElementAssignment P_0)
			{
			}

			private void TrZGBvKAMkLMckUvfUMfwWVjFdgj(ActionElementMap P_0)
			{
			}

			private void DswviOkrXXirXpDfcdVjxtbqGOvM()
			{
			}

			private void giuQAOGqgJGpaeVmdyUvrLopDENzA(string P_0)
			{
			}

			private void ELYOwNrqZrDeeRwnkiivRaQzqjNs(string P_0)
			{
			}

			private void KPPucdQoFIfBoANWjeNBCXpDcNUQB(ElementAssignmentInfo P_0, IList<ElementAssignmentConflictInfo> P_1, bool P_2)
			{
			}

			private void ykcpdHpSundMctFmxDBIkMsMwkTvA()
			{
			}

			private void xLsGPWjIjHQugjDsVbvTUfZqPFCkA()
			{
			}

			public void UAUojKKmPKyQXeiIwvgxiCJhByZFA(ConflictResponse P_0)
			{
			}
		}

		public class Options
		{
			private bool IDPlvLmvqniVnBkNLduvMBGhhgoJ;

			private bool GYYKsUfQAvHqiGkybLpagildpMBMB;

			private bool MDPuypiBRcAoKOWhcnOZosrsRkyP;

			private float xRNCaqgKPAyRGPJLoiKsOYWNCGdRA;

			private bool WMmVYLXfNSKDUyXjoBbZHboFGnogA;

			private bool kWWfdMvCuNaUyfrFZmQkblqizLTiB;

			private bool ilSnwtrglULTnOhqJautuPKbGAKn;

			private bool mUKfPJHjhyqwCOWcAewLNAKTELllA;

			private int[] kkOpBBidpWKrnMNyxIsrIeLWSTlK;

			private ConflictResponse OWCkeBziEouRJRnoAgCFhBhPFobi;

			private bool PbumTIAPdGbQbaGQKLcBLfEqoNnvA;

			private bool njiBtqGzYTEYcKVKEUjVepkJLgMCA;

			private bool bMCLrBQXlpobcuKOSepkFZFwnOju;

			private bool olgzYYtkqXhUvreijXBRFMlhjXLy;

			private float HyZFlvYpIwEbpyDWQFrICFwcgdvQA;

			internal const string xUYjZpzFCvsWRWbASgswBDnvNOOv = "isElementAllowed";

			private readonly Dictionary<string, SafeDelegate> EYTwJGPmykStfmwylYPUYmHfLkXc;

			public bool allowAxes => false;

			public bool allowButtons => false;

			public bool allowButtonsOnFullAxisAssignment
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public float timeout
			{
				get
				{
					return 0f;
				}
				set
				{
				}
			}

			public bool checkForConflicts => false;

			public bool checkForConflictsWithAllPlayers => false;

			public bool checkForConflictsWithSelf => false;

			public bool checkForConflictsWithSystemPlayer => false;

			public int[] checkForConflictsWithPlayerIds => null;

			public ConflictResponse defaultActionWhenConflictFound => ConflictResponse.Cancel;

			public bool ignoreMouseXAxis
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool ignoreMouseYAxis
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public bool allowKeyboardKeysWithModifiers => false;

			public bool allowKeyboardModifierKeyAsPrimary => false;

			public float holdDurationToMapKeyboardModifierKeyAsPrimary => 0f;

			internal _0001 ILFjrlXErAaQYsYRoWPNsXQagWVF<_0001>(string P_0) where _0001 : SafeDelegate
			{
				return null;
			}

			public Options()
			{
			}

			private Options(Options P_0)
			{
			}

			public Options Clone()
			{
				return null;
			}

			public override string ToString()
			{
				return null;
			}

			internal void SPGTRPyvIslcMdbPTItsewSLRPxx()
			{
			}

			public static void Copy(Options source, Options destination)
			{
			}
		}

		[Serializable]
		private sealed class CsGLCHGTcukphAwqbUFlUowthqtc
		{
			public static readonly CsGLCHGTcukphAwqbUFlUowthqtc _003C_003E9;

			public static Action<Exception> _003C_003E9__54_0;

			public static Action<Exception> _003C_003E9__54_1;

			public static Action<Exception> _003C_003E9__54_2;

			public static Action<Exception> _003C_003E9__54_3;

			public static Action<Exception> _003C_003E9__54_4;

			public static Action<Exception> _003C_003E9__54_5;

			public static Action<Exception> _003C_003E9__54_6;

			internal void LxzSEBmrlSVTqfGKXIVzaayfTTdc(Exception P_0)
			{
			}

			internal void whQAbIKdlWAuKNfnCCpBCsQATqQq(Exception P_0)
			{
			}

			internal void GnyWwuvxKiIMVMoznmjfsbsRoSwP(Exception P_0)
			{
			}

			internal void XXnxMLQjJTcsWUofzcaMfDmkXJIUA(Exception P_0)
			{
			}

			internal void UOYunpdinGHuNRmNChOUOPDbJPnU(Exception P_0)
			{
			}

			internal void HhbwmKFqIeHIdcsYQeyCYPMSvbEoA(Exception P_0)
			{
			}

			internal void OEwqbJSoFMHyBHdRIAzzLZQaFDvE(Exception P_0)
			{
			}
		}

		private static InputMapper sKlAxiBmvyBxAjrDeOltNvBiEdkP;

		private static int TMzSxjjyapuKOmNiKYPcOmUjpTlD;

		private readonly int wfFGgdoRWtehIGyVjVmwswiztTuV;

		private readonly bool wAyxrYqTkTfseXCamASZxBaTedubA;

		private readonly CvqneWRBGLDpMpWAQjcseqxhBpXs gKQddRRUdFFTaMlSYrVtPlluZoRb;

		private Options bQaqZJNDPpHZPsCPODygOhVQNZSi;

		private readonly Dictionary<pqkQWTNgxZgZDuoNDchCJcOmqHeX, SafeDelegate> ItibWhVtFYsKkkzgAslrAMMJBUdm;

		public static InputMapper Default => null;

		public Options options => null;

		public Status status => Status.Idle;

		public float timeRemaining => 0f;

		public event Action<InputMappedEventData> InputMappedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<StoppedEventData> StoppedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<ConflictFoundEventData> ConflictFoundEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private static int ZbDIHfcjnfeHcHypbxiSfPJiJyKdA()
		{
			return 0;
		}

		public InputMapper()
		{
		}

		private InputMapper(bool P_0)
		{
		}

		public void RemoveAllEventListeners()
		{
		}

		public bool Start(Context mappingContext)
		{
			return false;
		}

		public void Stop()
		{
		}

		private bool edGQWybkvEgdpdpFVqgmUdPGZTqV(Context P_0, Options P_1)
		{
			return false;
		}
	}
}
