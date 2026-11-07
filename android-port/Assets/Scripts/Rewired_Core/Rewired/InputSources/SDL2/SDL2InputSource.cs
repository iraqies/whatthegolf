using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Config;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Data;

namespace Rewired.InputSources.SDL2
{
	[Token(Token = "0x2000164")]
	internal class SDL2InputSource : IDisposable, IInputSource
	{
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x10")]
		private bool APoNWtXoeYHyrbDkDswtiTxkfkUL;

		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x11")]
		private bool BUmHgvFAJSaxNqKAkNFxTGAZejPIA;

		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x12")]
		private bool eEerJXpIkLJjWGhWhVTVcNOaIiBAA;

		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x13")]
		private bool ZZJerRuoZikIBFxmWuqdynzQHrgs;

		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x14")]
		private bool obpzIVquVRQseulcTcTZaHvizTjRA;

		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x18")]
		private ADictionary<int, RzpKZbCpWsgubaEUuUNtBGeHcjal> pfvHZfkVJHuFpTIaVPSjIEuhIisl;

		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x20")]
		private ADictionary<int, hphINTghzNEHxUPDVroFxKuDYUSd> PVAbxWitkmowNRFVfIMGpcpwKhDb;

		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x28")]
		private ikfePoAXHchteyoSqLTiXmtbNjbd.pZxgJRiLHTbtEDaQOLvsJOffWSZlA uqAvHWxPxhMooBQwGulIkvAnIrsK;

		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0xB0")]
		private NativeBuffer TNIvOvlbHBfBTxffqblcIdyNTeAv;

		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1930B0", Offset = "0x1930B0")]
		private Action DEbuznmERjiCnEQGPtRombzvjfeh;

		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0xC0")]
		private bool AeWaeWamxRrERkciQkpFDWbRfZMkA;

		[Token(Token = "0x1400001A")]
		private event Action _DeviceChangedEvent
		{
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x2409F0C", Offset = "0x2409F0C", VA = "0x2409F0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959E4", Offset = "0x1959E4")]
			add
			{
				wktFDwPoDTIgPwgEdTShFPdGZamx(action);
			}
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x2409FB0", Offset = "0x2409FB0", VA = "0x2409FB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959F4", Offset = "0x1959F4")]
			remove
			{
				gmJoWdBTSiKdSPvZqbYdJWWUEJhG(action);
			}
		}

		[Token(Token = "0x1400001B")]
		public event Action DeviceChangedEvent
		{
			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x240A054", Offset = "0x240A054", VA = "0x240A054", Slot = "5")]
			add
			{
			}
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x240A0F8", Offset = "0x240A0F8", VA = "0x240A0F8", Slot = "6")]
			remove
			{
			}
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x2409960", Offset = "0x2409960", VA = "0x2409960")]
		public SDL2InputSource(UpdateLoopSetting P_0, bool P_1, bool P_2, bool P_3, bool P_4)
		{
		}

		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x2409F0C", Offset = "0x2409F0C", VA = "0x2409F0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959E4", Offset = "0x1959E4")]
		private void wktFDwPoDTIgPwgEdTShFPdGZamx(Action P_0)
		{
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x2409FB0", Offset = "0x2409FB0", VA = "0x2409FB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1959F4", Offset = "0x1959F4")]
		private void gmJoWdBTSiKdSPvZqbYdJWWUEJhG(Action P_0)
		{
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x240A19C", Offset = "0x240A19C", VA = "0x240A19C", Slot = "7")]
		public void Update()
		{
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x240A1A0", Offset = "0x240A1A0", VA = "0x240A1A0", Slot = "8")]
		public void UpdateDevices(UpdateLoopType updateLoop)
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x240A40C", Offset = "0x240A40C", VA = "0x240A40C", Slot = "9")]
		public void UpdateFinished()
		{
		}

		[Token(Token = "0x6000B70")]
		public IList<T> GetJoysticks<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x240A410", Offset = "0x240A410", VA = "0x240A410")]
		private int JroAzOpjwsDYKzrwpdynudJALgYw()
		{
			return default;
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x240A4A4", Offset = "0x240A4A4", VA = "0x240A4A4")]
		private RzpKZbCpWsgubaEUuUNtBGeHcjal sPkUKVZmchFVNidkQRboCROhnvCCb(int P_0)
		{
			return null;
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x240A724", Offset = "0x240A724", VA = "0x240A724")]
		private hphINTghzNEHxUPDVroFxKuDYUSd CjLPIfXjmqNmUlqeTaqMbkLryMPW(int P_0)
		{
			return null;
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x240A5B0", Offset = "0x240A5B0", VA = "0x240A5B0")]
		private wHGpGKjtVGRHisAxykuOCasKYqsT hVeGBaBzltexdRYAcQljPYVxCajV(int P_0, ADyAksuGELvZwlagWICRBzcTKbTy P_1)
		{
			return null;
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x240A838", Offset = "0x240A838", VA = "0x240A838")]
		private wHGpGKjtVGRHisAxykuOCasKYqsT drHmgMPLOXLUEkgSFgWiQvgDDEVkA(int P_0, FpZXCDmwgTbyWItcpddtIBipfuYO P_1)
		{
			return null;
		}

		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x2409DA0", Offset = "0x2409DA0", VA = "0x2409DA0")]
		private void bXSliKMHXPBxpbZBblVKTWOVAoDn()
		{
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x240ABBC", Offset = "0x240ABBC", VA = "0x240ABBC")]
		private void NIHulfYmlhxPFhjrJaZNmdqSxxeU()
		{
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x240A908", Offset = "0x240A908", VA = "0x240A908")]
		private bool qckZxShqtYgKZSGQmXJLvbtBGAUy(int P_0)
		{
			return default;
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x240AEC8", Offset = "0x240AEC8", VA = "0x240AEC8")]
		private void GHLFUYDRbbdpOizTVbmQosBYlpOBb(int P_0)
		{
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x240AA68", Offset = "0x240AA68", VA = "0x240AA68")]
		private bool sauBYMcgVeObPsfBYhmYAmBhcfFRA(int P_0)
		{
			return default;
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x240AFA4", Offset = "0x240AFA4", VA = "0x240AFA4")]
		private void UDOqbwjHuFmoHKVRbpUeSRwwxwEP(int P_0)
		{
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x240B080", Offset = "0x240B080", VA = "0x240B080")]
		private RzpKZbCpWsgubaEUuUNtBGeHcjal ppFBkIhRhknvjnBNoaaKkvYBrvifA(int P_0)
		{
			return null;
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x240B104", Offset = "0x240B104", VA = "0x240B104")]
		private hphINTghzNEHxUPDVroFxKuDYUSd jluJYbeJLOPOOXhJzwEBSEwiSgyc(int P_0)
		{
			return null;
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x240A1B4", Offset = "0x240A1B4", VA = "0x240A1B4")]
		private void oJttfTtVdWGnUshHrBdcJQnschXi()
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x240B370", Offset = "0x240B370", VA = "0x240B370")]
		private void QkDdJZMeBWGmiTXpZruuOfpBcrGl(ref ikfePoAXHchteyoSqLTiXmtbNjbd.sFUCNuAYHSPTHylLJckTelReGUqeA P_0, double P_1)
		{
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x240B458", Offset = "0x240B458", VA = "0x240B458")]
		private void QzkzNtVdoeaHYXdXIxuZnnghGPzp(ref ikfePoAXHchteyoSqLTiXmtbNjbd.fmwgCVUPDchacTEIiLOOwEGTbSwbA P_0, double P_1)
		{
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x240B544", Offset = "0x240B544", VA = "0x240B544")]
		private void fenyqpXVagBGimkMtqegPbByvNZ(ref ikfePoAXHchteyoSqLTiXmtbNjbd.iiruHewHkaiIjvQfNEZCiUOhIISuA P_0, double P_1)
		{
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x240B62C", Offset = "0x240B62C", VA = "0x240B62C")]
		private void xEvwtCwvXpqXAQHCKqeFDfSOaEgAA(ref ikfePoAXHchteyoSqLTiXmtbNjbd.cITSKHpEhhWXYboHxofjjtgysgrk P_0, double P_1)
		{
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x240B630", Offset = "0x240B630", VA = "0x240B630")]
		private void xStnTqeXNNLuVqbjECVBheQIpYjL(ref ikfePoAXHchteyoSqLTiXmtbNjbd.tChToPLypbFFSxiImMkXHnPUIRwL P_0)
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x240B670", Offset = "0x240B670", VA = "0x240B670")]
		private void tmvdtQgSLxIHkpXFVEzxWLEZERzE(ref ikfePoAXHchteyoSqLTiXmtbNjbd.tChToPLypbFFSxiImMkXHnPUIRwL P_0)
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x240B188", Offset = "0x240B188", VA = "0x240B188")]
		private void UZKMNAtlCaqUIsgJeTMhZrtXANEV(ref ikfePoAXHchteyoSqLTiXmtbNjbd.ZEOAmaGwHsGsccptuDaoqLSgaeZab P_0, double P_1)
		{
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x240B278", Offset = "0x240B278", VA = "0x240B278")]
		private void fAbcVBwBbAeGWTivPzKEUQjfdTjjA(ref ikfePoAXHchteyoSqLTiXmtbNjbd.eXVVMJbpjbLDGKnRQxBArKeojiNbA P_0, double P_1)
		{
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x240B6B0", Offset = "0x240B6B0", VA = "0x240B6B0")]
		private void QxMJfTDDqnmaAXdoNozbymRRMAEf(ref ikfePoAXHchteyoSqLTiXmtbNjbd.ccpFLpGYCrvnKOEpfTBuqyEAScmnA P_0)
		{
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x240B6F0", Offset = "0x240B6F0", VA = "0x240B6F0")]
		private void qotXQOCpSJCmEiNAYaOCvMUFNGSEb(ref ikfePoAXHchteyoSqLTiXmtbNjbd.ccpFLpGYCrvnKOEpfTBuqyEAScmnA P_0)
		{
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x240B36C", Offset = "0x240B36C", VA = "0x240B36C")]
		private void PdOvnrteRYEkjsTlxcNZOOlZLmvt(ref ikfePoAXHchteyoSqLTiXmtbNjbd.ccpFLpGYCrvnKOEpfTBuqyEAScmnA P_0)
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x240B730", Offset = "0x240B730", VA = "0x240B730")]
		private void SujGBkgZLmlPPzTolCwPCiDoNLgC(int P_0, GGbtdUzpXnCzPhpAqObQrrCgdzpo P_1, byte P_2, short P_3, double P_4)
		{
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x240B7F0", Offset = "0x240B7F0", VA = "0x240B7F0")]
		private void TAZBCtpkDDTJftPZOFwSbmvsVdVsA(int P_0, GGbtdUzpXnCzPhpAqObQrrCgdzpo P_1, byte P_2, short P_3, double P_4)
		{
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x2409C6C", Offset = "0x2409C6C", VA = "0x2409C6C")]
		private void nafLQIiEsnsNNjBRiGfkhykETqeQ()
		{
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x2409E8C", Offset = "0x2409E8C", VA = "0x2409E8C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x240B8B0", Offset = "0x240B8B0", VA = "0x240B8B0", Slot = "1")]
		~SDL2InputSource()
		{
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x240B960", Offset = "0x240B960", VA = "0x240B960", Slot = "11")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
