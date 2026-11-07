using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x2000049")]
	public abstract class ControllerTemplate : IControllerTemplate
	{
		[Token(Token = "0x200004A")]
		internal abstract class tWsRepKMnZBPynxcHEOrqJwJrtqi : IControllerTemplateElement, IControllerTemplateElement_Internal
		{
			[Token(Token = "0x40001AD")]
			[FieldOffset(Offset = "0x10")]
			private readonly IControllerTemplate afWhZEYTbMFjMUeulVkAPjICyxpP;

			[Token(Token = "0x40001AE")]
			[FieldOffset(Offset = "0x18")]
			private readonly int YVGDeWQAhUWKAOSPoxXuizkXaiTI;

			[Token(Token = "0x40001AF")]
			[FieldOffset(Offset = "0x20")]
			private readonly string hEJFspqWqeBOdedbqHNRpPNEbfBG;

			[Token(Token = "0x40001B0")]
			[FieldOffset(Offset = "0x28")]
			private readonly ControllerTemplateElementType TIpqQbLCpFnyVWkQInNfNRXErYkK;

			[Token(Token = "0x40001B1")]
			[FieldOffset(Offset = "0x2C")]
			protected readonly int QajDFFaomlkLHzaostfWYpGUioys;

			[Token(Token = "0x170000B0")]
			public int id
			{
				[Token(Token = "0x600024F")]
				[Address(RVA = "0x246108C", Offset = "0x246108C", VA = "0x246108C", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000B1")]
			public string descriptiveName
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x246113C", Offset = "0x246113C", VA = "0x246113C", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			public ControllerTemplateElementType type
			{
				[Token(Token = "0x6000251")]
				[Address(RVA = "0x24611EC", Offset = "0x24611EC", VA = "0x24611EC", Slot = "6")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000B3")]
			public abstract IControllerTemplateElementSource source
			{
				[Token(Token = "0x6000253")]
				get;
			}

			[Token(Token = "0x170000B4")]
			public abstract bool exists
			{
				[Token(Token = "0x6000254")]
				get;
			}

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x2460F60", Offset = "0x2460F60", VA = "0x2460F60")]
			protected tWsRepKMnZBPynxcHEOrqJwJrtqi(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3)
			{
			}

			[Token(Token = "0x6000252")]
			public abstract int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list);
		}

		[Token(Token = "0x200004B")]
		internal abstract class bDpsuBEObmlAmAiaSwlxSBIiPRrE : tWsRepKMnZBPynxcHEOrqJwJrtqi
		{
			[Token(Token = "0x40001B2")]
			[FieldOffset(Offset = "0x30")]
			protected readonly int uflBDILlxYOcIlCXbGnzgzAUpqtj;

			[Token(Token = "0x40001B3")]
			[FieldOffset(Offset = "0x38")]
			protected readonly AckvZZpMMZJEeXiTnzpZGygPjFpk[] mLceIVIgGsVFwNSYjUnnnJkOqsgBA;

			[Token(Token = "0x170000B5")]
			public override bool PhpaujTLOdqAPpftaxjzKpWeuveq
			{
				[Token(Token = "0x6000256")]
				[Address(RVA = "0x245E9BC", Offset = "0x245E9BC", VA = "0x245E9BC", Slot = "12")]
				get
				{
					return YDyvQJGPvEUIrRcdgJmGRqIGjtcJ();
				}
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x245E8F8", Offset = "0x245E8F8", VA = "0x245E8F8")]
			protected bDpsuBEObmlAmAiaSwlxSBIiPRrE(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3, IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> P_4)
			{
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0x245E9BC", Offset = "0x245E9BC", VA = "0x245E9BC", Slot = "12")]
			public virtual bool YDyvQJGPvEUIrRcdgJmGRqIGjtcJ()
			{
				return default;
			}
		}

		[Token(Token = "0x200004C")]
		internal abstract class xplOfuRdmqGAkFpxdfKgUEIduiHT : bDpsuBEObmlAmAiaSwlxSBIiPRrE, IControllerTemplateElement, IControllerTemplateButton, IControllerTemplateAxis
		{
			[Token(Token = "0x40001B4")]
			[FieldOffset(Offset = "0x40")]
			private HxKJTjnYRTlXmgqyhXzejFNHdCai WdbNWWRsjxFdwKePDCTZQcFZsADA;

			[Token(Token = "0x40001B5")]
			[FieldOffset(Offset = "0x48")]
			private string sXTfsIlBXgXZPLOKJteRVBexfODV;

			[Token(Token = "0x40001B6")]
			[FieldOffset(Offset = "0x50")]
			private string qEHEGyASthJfEnPlUcWyGSdtXxUdA;

			[Token(Token = "0x170000B6")]
			public float brHdwUJAbVcsilgLZZabrTqmRcFR
			{
				[Token(Token = "0x6000258")]
				[Address(RVA = "0x24608C8", Offset = "0x24608C8", VA = "0x24608C8")]
				get
				{
					return DBgaSEJhqXFKMAmvAoKNLIutBNZC();
				}
			}

			[Token(Token = "0x170000B7")]
			public float rEhPDLHiMGJDkTLyTdjOJSGOONIl
			{
				[Token(Token = "0x6000259")]
				[Address(RVA = "0x2460BE4", Offset = "0x2460BE4", VA = "0x2460BE4")]
				get
				{
					return pyjLMkCEHVkGoHtdCNZhKxMEyaic();
				}
			}

			[Token(Token = "0x170000B8")]
			public bool vTrlgouSJGtOvawjunaiRTKrzwsD
			{
				[Token(Token = "0x600025A")]
				[Address(RVA = "0x246143C", Offset = "0x246143C", VA = "0x246143C")]
				get
				{
					return GddMcZGLtcTrMmBPixnpWKiMKJsF();
				}
			}

			[Token(Token = "0x170000B9")]
			public bool fDZzkobccRjlJoXBBUdrauDEaisJ
			{
				[Token(Token = "0x600025B")]
				[Address(RVA = "0x2461580", Offset = "0x2461580", VA = "0x2461580")]
				get
				{
					return HuWagyLnDKjhEgjuLjGrDCQcxncb();
				}
			}

			[Token(Token = "0x170000BA")]
			private float Rewired_002EIControllerTemplateAxis_002Evalue
			{
				[Token(Token = "0x600025C")]
				[Address(RVA = "0x24616C4", Offset = "0x24616C4", VA = "0x24616C4", Slot = "21")]
				get
				{
					return Rewired_002EIControllerTemplateAxis_002Eget_value();
				}
			}

			[Token(Token = "0x170000BB")]
			private float Rewired_002EIControllerTemplateAxis_002EvaluePrev
			{
				[Token(Token = "0x600025D")]
				[Address(RVA = "0x2461780", Offset = "0x2461780", VA = "0x2461780", Slot = "22")]
				get
				{
					return Rewired_002EIControllerTemplateAxis_002Eget_valuePrev();
				}
			}

			[Token(Token = "0x170000BC")]
			private IControllerTemplateAxisSource Rewired_002EIControllerTemplateAxis_002Esource
			{
				[Token(Token = "0x600025E")]
				[Address(RVA = "0x246183C", Offset = "0x246183C", VA = "0x246183C", Slot = "23")]
				get
				{
					return Rewired_002EIControllerTemplateAxis_002Eget_source();
				}
			}

			[Token(Token = "0x170000BD")]
			private bool Rewired_002EIControllerTemplateButton_002Evalue
			{
				[Token(Token = "0x600025F")]
				[Address(RVA = "0x24618EC", Offset = "0x24618EC", VA = "0x24618EC", Slot = "14")]
				get
				{
					return Rewired_002EIControllerTemplateButton_002Eget_value();
				}
			}

			[Token(Token = "0x170000BE")]
			private bool Rewired_002EIControllerTemplateButton_002EvaluePrev
			{
				[Token(Token = "0x6000260")]
				[Address(RVA = "0x24619A8", Offset = "0x24619A8", VA = "0x24619A8", Slot = "15")]
				get
				{
					return Rewired_002EIControllerTemplateButton_002Eget_valuePrev();
				}
			}

			[Token(Token = "0x170000BF")]
			private bool Rewired_002EIControllerTemplateButton_002EjustPressed
			{
				[Token(Token = "0x6000261")]
				[Address(RVA = "0x2461A64", Offset = "0x2461A64", VA = "0x2461A64", Slot = "18")]
				get
				{
					return Rewired_002EIControllerTemplateButton_002Eget_justPressed();
				}
			}

			[Token(Token = "0x170000C0")]
			private bool Rewired_002EIControllerTemplateButton_002EjustReleased
			{
				[Token(Token = "0x6000262")]
				[Address(RVA = "0x2461C00", Offset = "0x2461C00", VA = "0x2461C00", Slot = "19")]
				get
				{
					return Rewired_002EIControllerTemplateButton_002Eget_justReleased();
				}
			}

			[Token(Token = "0x170000C1")]
			private float Rewired_002EIControllerTemplateButton_002Epressure
			{
				[Token(Token = "0x6000263")]
				[Address(RVA = "0x2461D9C", Offset = "0x2461D9C", VA = "0x2461D9C", Slot = "16")]
				get
				{
					return Rewired_002EIControllerTemplateButton_002Eget_pressure();
				}
			}

			[Token(Token = "0x170000C2")]
			private float Rewired_002EIControllerTemplateButton_002EpressurePrev
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0x2461E58", Offset = "0x2461E58", VA = "0x2461E58", Slot = "17")]
				get
				{
					return Rewired_002EIControllerTemplateButton_002Eget_pressurePrev();
				}
			}

			[Token(Token = "0x170000C3")]
			private IControllerTemplateButtonSource Rewired_002EIControllerTemplateButton_002Esource
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0x2461F14", Offset = "0x2461F14", VA = "0x2461F14", Slot = "20")]
				get
				{
					return Rewired_002EIControllerTemplateButton_002Eget_source();
				}
			}

			[Token(Token = "0x170000C4")]
			public override IControllerTemplateElementSource source
			{
				[Token(Token = "0x6000266")]
				[Address(RVA = "0x2461FC4", Offset = "0x2461FC4", VA = "0x2461FC4", Slot = "11")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000257")]
			[Address(RVA = "0x246129C", Offset = "0x246129C", VA = "0x246129C")]
			protected xplOfuRdmqGAkFpxdfKgUEIduiHT(IControllerTemplate P_0, int P_1, string P_2, string P_3, string P_4, ControllerTemplateElementType P_5, HxKJTjnYRTlXmgqyhXzejFNHdCai P_6, IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> P_7)
			{
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x24608C8", Offset = "0x24608C8", VA = "0x24608C8")]
			public float DBgaSEJhqXFKMAmvAoKNLIutBNZC()
			{
				return default;
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x2460BE4", Offset = "0x2460BE4", VA = "0x2460BE4")]
			public float pyjLMkCEHVkGoHtdCNZhKxMEyaic()
			{
				return default;
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0x246143C", Offset = "0x246143C", VA = "0x246143C")]
			public bool GddMcZGLtcTrMmBPixnpWKiMKJsF()
			{
				return default;
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0x2461580", Offset = "0x2461580", VA = "0x2461580")]
			public bool HuWagyLnDKjhEgjuLjGrDCQcxncb()
			{
				return default;
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x24616C4", Offset = "0x24616C4", VA = "0x24616C4", Slot = "21")]
			private float Rewired_002EIControllerTemplateAxis_002Eget_value()
			{
				return default;
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x2461780", Offset = "0x2461780", VA = "0x2461780", Slot = "22")]
			private float Rewired_002EIControllerTemplateAxis_002Eget_valuePrev()
			{
				return default;
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0x246183C", Offset = "0x246183C", VA = "0x246183C", Slot = "23")]
			private IControllerTemplateAxisSource Rewired_002EIControllerTemplateAxis_002Eget_source()
			{
				return null;
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x24618EC", Offset = "0x24618EC", VA = "0x24618EC", Slot = "14")]
			private bool Rewired_002EIControllerTemplateButton_002Eget_value()
			{
				return default;
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x24619A8", Offset = "0x24619A8", VA = "0x24619A8", Slot = "15")]
			private bool Rewired_002EIControllerTemplateButton_002Eget_valuePrev()
			{
				return default;
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x2461A64", Offset = "0x2461A64", VA = "0x2461A64", Slot = "18")]
			private bool Rewired_002EIControllerTemplateButton_002Eget_justPressed()
			{
				return default;
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x2461C00", Offset = "0x2461C00", VA = "0x2461C00", Slot = "19")]
			private bool Rewired_002EIControllerTemplateButton_002Eget_justReleased()
			{
				return default;
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2461D9C", Offset = "0x2461D9C", VA = "0x2461D9C", Slot = "16")]
			private float Rewired_002EIControllerTemplateButton_002Eget_pressure()
			{
				return default;
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x2461E58", Offset = "0x2461E58", VA = "0x2461E58", Slot = "17")]
			private float Rewired_002EIControllerTemplateButton_002Eget_pressurePrev()
			{
				return default;
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x2461F14", Offset = "0x2461F14", VA = "0x2461F14", Slot = "20")]
			private IControllerTemplateButtonSource Rewired_002EIControllerTemplateButton_002Eget_source()
			{
				return null;
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x2462074", Offset = "0x2462074", VA = "0x2462074", Slot = "10")]
			public override int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list)
			{
				return default;
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x24624A0", Offset = "0x24624A0", VA = "0x24624A0")]
			private static bool HeYIANgmGmbuIDCCgMyGfxvlhNCCB(ControllerElementTarget P_0, IControllerElementTarget P_1)
			{
				return default;
			}
		}

		[Token(Token = "0x200004D")]
		internal sealed class CUvgYPcuNWQUoLfxEuBtidskpMACb : xplOfuRdmqGAkFpxdfKgUEIduiHT
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x245BB44", Offset = "0x245BB44", VA = "0x245BB44")]
			public CUvgYPcuNWQUoLfxEuBtidskpMACb(IControllerTemplate P_0, int P_1, string P_2, string P_3, string P_4, HxKJTjnYRTlXmgqyhXzejFNHdCai P_5, IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> P_6)
			{
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x245BCB4", Offset = "0x245BCB4", VA = "0x245BCB4")]
			internal static CUvgYPcuNWQUoLfxEuBtidskpMACb jqAWqFpdLUDQRsdZuZzXWwxrjFMg(IControllerTemplate P_0)
			{
				return null;
			}
		}

		[Token(Token = "0x200004E")]
		internal sealed class lxRJFUppkWtxxkUrZqBFElqfoxBT : xplOfuRdmqGAkFpxdfKgUEIduiHT
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x245F8EC", Offset = "0x245F8EC", VA = "0x245F8EC")]
			public lxRJFUppkWtxxkUrZqBFElqfoxBT(IControllerTemplate P_0, int P_1, string P_2, string P_3, string P_4, HxKJTjnYRTlXmgqyhXzejFNHdCai P_5, IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> P_6)
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x245FA5C", Offset = "0x245FA5C", VA = "0x245FA5C")]
			internal static lxRJFUppkWtxxkUrZqBFElqfoxBT jqAWqFpdLUDQRsdZuZzXWwxrjFMg(IControllerTemplate P_0)
			{
				return null;
			}
		}

		[Token(Token = "0x200004F")]
		internal abstract class HdTcpZLoztFKwinvXwmQwXyhMbTN : tWsRepKMnZBPynxcHEOrqJwJrtqi
		{
			[Token(Token = "0x40001B7")]
			[FieldOffset(Offset = "0x30")]
			protected readonly int pQhFxcuPrcDhCdBqMHKrOfeGZOVtA;

			[Token(Token = "0x40001B8")]
			[FieldOffset(Offset = "0x38")]
			protected readonly tWsRepKMnZBPynxcHEOrqJwJrtqi[] hObmyuQkxgNXDiBtSEwFNgLuBsoZ;

			[Token(Token = "0x170000C5")]
			public override bool PhpaujTLOdqAPpftaxjzKpWeuveq
			{
				[Token(Token = "0x600026E")]
				[Address(RVA = "0x245BE90", Offset = "0x245BE90", VA = "0x245BE90", Slot = "12")]
				get
				{
					return YDyvQJGPvEUIrRcdgJmGRqIGjtcJ();
				}
			}

			[Token(Token = "0x170000C6")]
			public override IControllerTemplateElementSource rmMLNGpqXVBSkkjZadentyrvdrgtA
			{
				[Token(Token = "0x600026F")]
				[Address(RVA = "0x245BF9C", Offset = "0x245BF9C", VA = "0x245BF9C", Slot = "11")]
				get
				{
					return MVmNVaAnZpWvkMHvvuWxKjqAiYHg();
				}
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x245BD98", Offset = "0x245BD98", VA = "0x245BD98")]
			protected HdTcpZLoztFKwinvXwmQwXyhMbTN(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_4)
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x245BE90", Offset = "0x245BE90", VA = "0x245BE90", Slot = "12")]
			public virtual bool YDyvQJGPvEUIrRcdgJmGRqIGjtcJ()
			{
				return default;
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x245BF9C", Offset = "0x245BF9C", VA = "0x245BF9C", Slot = "11")]
			public virtual IControllerTemplateElementSource MVmNVaAnZpWvkMHvvuWxKjqAiYHg()
			{
				return null;
			}

			[Token(Token = "0x6000270")]
			[Address(RVA = "0x245C044", Offset = "0x245C044", VA = "0x245C044", Slot = "10")]
			public virtual int dcYAIFdORVfJDeuFEeeoCqlvIpJzB(ControllerElementTarget P_0, ref IList<ControllerTemplateElementTarget> P_1)
			{
				return default;
			}
		}

		[Token(Token = "0x2000050")]
		internal abstract class nYkTjlGDFGRTHCcTrhwSGlyYngjs : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement
		{
			[Token(Token = "0x170000C7")]
			public Vector2 value
			{
				[Token(Token = "0x6000272")]
				[Address(RVA = "0x246071C", Offset = "0x246071C", VA = "0x246071C", Slot = "16")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000C8")]
			public Vector2 valuePrev
			{
				[Token(Token = "0x6000273")]
				[Address(RVA = "0x2460A38", Offset = "0x2460A38", VA = "0x2460A38", Slot = "17")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000C9")]
			public IControllerTemplateAxis horizontal
			{
				[Token(Token = "0x6000274")]
				[Address(RVA = "0x2460D54", Offset = "0x2460D54", VA = "0x2460D54", Slot = "18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			public IControllerTemplateAxis vertical
			{
				[Token(Token = "0x6000275")]
				[Address(RVA = "0x2460E58", Offset = "0x2460E58", VA = "0x2460E58", Slot = "19")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0x2460714", Offset = "0x2460714", VA = "0x2460714")]
			protected nYkTjlGDFGRTHCcTrhwSGlyYngjs(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_4)
			{
			}
		}

		[Token(Token = "0x2000051")]
		internal abstract class bjgAGIyWikBSsbhClQzhHYYDVXWHA : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement
		{
			[Token(Token = "0x170000CB")]
			public Vector3 value
			{
				[Token(Token = "0x6000277")]
				[Address(RVA = "0x245EAA8", Offset = "0x245EAA8", VA = "0x245EAA8", Slot = "16")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000CC")]
			public Vector3 valuePrev
			{
				[Token(Token = "0x6000278")]
				[Address(RVA = "0x245ECDC", Offset = "0x245ECDC", VA = "0x245ECDC", Slot = "17")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000CD")]
			public IControllerTemplateAxis horizontal
			{
				[Token(Token = "0x6000279")]
				[Address(RVA = "0x245EF10", Offset = "0x245EF10", VA = "0x245EF10", Slot = "18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			public IControllerTemplateAxis vertical
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0x245F014", Offset = "0x245F014", VA = "0x245F014", Slot = "19")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x245E3C4", Offset = "0x245E3C4", VA = "0x245E3C4")]
			protected bjgAGIyWikBSsbhClQzhHYYDVXWHA(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_4)
			{
			}
		}

		[Token(Token = "0x2000052")]
		internal abstract class NiMBoKRLrOMewcYQIYFQMWTnOIKl : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement
		{
			[Token(Token = "0x170000CF")]
			public Vector3 position
			{
				[Token(Token = "0x600027C")]
				[Address(RVA = "0x245D40C", Offset = "0x245D40C", VA = "0x245D40C", Slot = "16")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000D0")]
			public Vector3 positionPrev
			{
				[Token(Token = "0x600027D")]
				[Address(RVA = "0x245D640", Offset = "0x245D640", VA = "0x245D640", Slot = "17")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000D1")]
			public Vector3 rotation
			{
				[Token(Token = "0x600027E")]
				[Address(RVA = "0x245D874", Offset = "0x245D874", VA = "0x245D874", Slot = "18")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000D2")]
			public Vector3 rotationPrev
			{
				[Token(Token = "0x600027F")]
				[Address(RVA = "0x245DAAC", Offset = "0x245DAAC", VA = "0x245DAAC", Slot = "19")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000D3")]
			public IControllerTemplateAxis positionX
			{
				[Token(Token = "0x6000280")]
				[Address(RVA = "0x245DCE4", Offset = "0x245DCE4", VA = "0x245DCE4", Slot = "20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			public IControllerTemplateAxis positionY
			{
				[Token(Token = "0x6000281")]
				[Address(RVA = "0x245DDE8", Offset = "0x245DDE8", VA = "0x245DDE8", Slot = "21")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			public IControllerTemplateAxis positionZ
			{
				[Token(Token = "0x6000282")]
				[Address(RVA = "0x245DEF0", Offset = "0x245DEF0", VA = "0x245DEF0", Slot = "22")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			public IControllerTemplateAxis rotationX
			{
				[Token(Token = "0x6000283")]
				[Address(RVA = "0x245DFF8", Offset = "0x245DFF8", VA = "0x245DFF8", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			public IControllerTemplateAxis rotationY
			{
				[Token(Token = "0x6000284")]
				[Address(RVA = "0x245E100", Offset = "0x245E100", VA = "0x245E100", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			public IControllerTemplateAxis rotationZ
			{
				[Token(Token = "0x6000285")]
				[Address(RVA = "0x245E208", Offset = "0x245E208", VA = "0x245E208", Slot = "25")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x245D408", Offset = "0x245D408", VA = "0x245D408")]
			protected NiMBoKRLrOMewcYQIYFQMWTnOIKl(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_4)
			{
			}
		}

		[Token(Token = "0x2000053")]
		internal sealed class RAKYiYDzCotPmRFpoYhKhoekJhXO : bjgAGIyWikBSsbhClQzhHYYDVXWHA, IControllerTemplateElement, IControllerTemplateStick
		{
			[Token(Token = "0x170000D9")]
			public IControllerTemplateAxis rotation
			{
				[Token(Token = "0x6000288")]
				[Address(RVA = "0x245E4FC", Offset = "0x245E4FC", VA = "0x245E4FC", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x245E310", Offset = "0x245E310", VA = "0x245E310")]
			private RAKYiYDzCotPmRFpoYhKhoekJhXO(IControllerTemplate P_0, int P_1, string P_2, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_3)
			{
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x245E3C8", Offset = "0x245E3C8", VA = "0x245E3C8")]
			public RAKYiYDzCotPmRFpoYhKhoekJhXO(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4, xplOfuRdmqGAkFpxdfKgUEIduiHT P_5)
			{
			}
		}

		[Token(Token = "0x2000054")]
		internal sealed class SKdXFctHzBFnUqLKBBYLuFHjtgwO : nYkTjlGDFGRTHCcTrhwSGlyYngjs, IControllerTemplateElement, IControllerTemplateThumbStick
		{
			[Token(Token = "0x170000DA")]
			public IControllerTemplateButton press
			{
				[Token(Token = "0x600028B")]
				[Address(RVA = "0x245E7F0", Offset = "0x245E7F0", VA = "0x245E7F0", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x245E604", Offset = "0x245E604", VA = "0x245E604")]
			private SKdXFctHzBFnUqLKBBYLuFHjtgwO(IControllerTemplate P_0, int P_1, string P_2, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_3)
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x245E6BC", Offset = "0x245E6BC", VA = "0x245E6BC")]
			internal SKdXFctHzBFnUqLKBBYLuFHjtgwO(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4, xplOfuRdmqGAkFpxdfKgUEIduiHT P_5)
			{
			}
		}

		[Token(Token = "0x2000055")]
		internal sealed class mZYAZnUOIAemtuOjxZzStAVMBQqAA : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement, IControllerTemplateDPad
		{
			[Token(Token = "0x170000DB")]
			public Vector2 value
			{
				[Token(Token = "0x600028E")]
				[Address(RVA = "0x245FE30", Offset = "0x245FE30", VA = "0x245FE30", Slot = "16")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000DC")]
			public Vector2 valuePrev
			{
				[Token(Token = "0x600028F")]
				[Address(RVA = "0x2460094", Offset = "0x2460094", VA = "0x2460094", Slot = "17")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000DD")]
			public IControllerTemplateButton up
			{
				[Token(Token = "0x6000290")]
				[Address(RVA = "0x24602F8", Offset = "0x24602F8", VA = "0x24602F8", Slot = "18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			public IControllerTemplateButton right
			{
				[Token(Token = "0x6000291")]
				[Address(RVA = "0x24603FC", Offset = "0x24603FC", VA = "0x24603FC", Slot = "19")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			public IControllerTemplateButton down
			{
				[Token(Token = "0x6000292")]
				[Address(RVA = "0x2460504", Offset = "0x2460504", VA = "0x2460504", Slot = "20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			public IControllerTemplateButton left
			{
				[Token(Token = "0x6000293")]
				[Address(RVA = "0x246060C", Offset = "0x246060C", VA = "0x246060C", Slot = "21")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x245FBE8", Offset = "0x245FBE8", VA = "0x245FBE8")]
			private mZYAZnUOIAemtuOjxZzStAVMBQqAA(IControllerTemplate P_0, int P_1, string P_2, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_3)
			{
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x245FC9C", Offset = "0x245FC9C", VA = "0x245FC9C")]
			internal mZYAZnUOIAemtuOjxZzStAVMBQqAA(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4, xplOfuRdmqGAkFpxdfKgUEIduiHT P_5, xplOfuRdmqGAkFpxdfKgUEIduiHT P_6, xplOfuRdmqGAkFpxdfKgUEIduiHT P_7)
			{
			}
		}

		[Token(Token = "0x2000056")]
		internal sealed class jkoAMVJJeANHSBEVLSTTFmSjWbSNb : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement, IControllerTemplateThrottle
		{
			[Token(Token = "0x170000E1")]
			public float value
			{
				[Token(Token = "0x6000296")]
				[Address(RVA = "0x245F490", Offset = "0x245F490", VA = "0x245F490", Slot = "16")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000E2")]
			public float valuePrev
			{
				[Token(Token = "0x6000297")]
				[Address(RVA = "0x245F5B8", Offset = "0x245F5B8", VA = "0x245F5B8", Slot = "17")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000E3")]
			public IControllerTemplateAxis throttle
			{
				[Token(Token = "0x6000298")]
				[Address(RVA = "0x245F6E0", Offset = "0x245F6E0", VA = "0x245F6E0", Slot = "18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			public IControllerTemplateButton minDetent
			{
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x245F7E4", Offset = "0x245F7E4", VA = "0x245F7E4", Slot = "19")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0x245F2DC", Offset = "0x245F2DC", VA = "0x245F2DC")]
			private jkoAMVJJeANHSBEVLSTTFmSjWbSNb(IControllerTemplate P_0, int P_1, string P_2, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_3)
			{
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x245F390", Offset = "0x245F390", VA = "0x245F390")]
			internal jkoAMVJJeANHSBEVLSTTFmSjWbSNb(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4)
			{
			}
		}

		[Token(Token = "0x2000057")]
		internal sealed class ICIKEZuceqNSJzmhODcuDQQHKDajb : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement, IControllerTemplateHat
		{
			[Token(Token = "0x170000E5")]
			public Vector2 value
			{
				[Token(Token = "0x600029C")]
				[Address(RVA = "0x245C3A4", Offset = "0x245C3A4", VA = "0x245C3A4", Slot = "16")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000E6")]
			public Vector2 valuePrev
			{
				[Token(Token = "0x600029D")]
				[Address(RVA = "0x245C7B8", Offset = "0x245C7B8", VA = "0x245C7B8", Slot = "17")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170000E7")]
			public IControllerTemplateButton up
			{
				[Token(Token = "0x600029E")]
				[Address(RVA = "0x245CBCC", Offset = "0x245CBCC", VA = "0x245CBCC", Slot = "18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			public IControllerTemplateButton upRight
			{
				[Token(Token = "0x600029F")]
				[Address(RVA = "0x245CCD0", Offset = "0x245CCD0", VA = "0x245CCD0", Slot = "19")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			public IControllerTemplateButton right
			{
				[Token(Token = "0x60002A0")]
				[Address(RVA = "0x245CDD8", Offset = "0x245CDD8", VA = "0x245CDD8", Slot = "20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			public IControllerTemplateButton downRight
			{
				[Token(Token = "0x60002A1")]
				[Address(RVA = "0x245CEE0", Offset = "0x245CEE0", VA = "0x245CEE0", Slot = "21")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EB")]
			public IControllerTemplateButton down
			{
				[Token(Token = "0x60002A2")]
				[Address(RVA = "0x245CFE8", Offset = "0x245CFE8", VA = "0x245CFE8", Slot = "22")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			public IControllerTemplateButton downLeft
			{
				[Token(Token = "0x60002A3")]
				[Address(RVA = "0x245D0F0", Offset = "0x245D0F0", VA = "0x245D0F0", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			public IControllerTemplateButton left
			{
				[Token(Token = "0x60002A4")]
				[Address(RVA = "0x245D1F8", Offset = "0x245D1F8", VA = "0x245D1F8", Slot = "24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			public IControllerTemplateButton upLeft
			{
				[Token(Token = "0x60002A5")]
				[Address(RVA = "0x245D300", Offset = "0x245D300", VA = "0x245D300", Slot = "25")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x245C0E8", Offset = "0x245C0E8", VA = "0x245C0E8")]
			private ICIKEZuceqNSJzmhODcuDQQHKDajb(IControllerTemplate P_0, int P_1, string P_2, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_3)
			{
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x245C19C", Offset = "0x245C19C", VA = "0x245C19C")]
			internal ICIKEZuceqNSJzmhODcuDQQHKDajb(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4, xplOfuRdmqGAkFpxdfKgUEIduiHT P_5, xplOfuRdmqGAkFpxdfKgUEIduiHT P_6, xplOfuRdmqGAkFpxdfKgUEIduiHT P_7, xplOfuRdmqGAkFpxdfKgUEIduiHT P_8, xplOfuRdmqGAkFpxdfKgUEIduiHT P_9, xplOfuRdmqGAkFpxdfKgUEIduiHT P_10)
			{
			}
		}

		[Token(Token = "0x2000058")]
		internal sealed class CLDVmlgHxUZAcZnHbFwnwNPRZHzA : nYkTjlGDFGRTHCcTrhwSGlyYngjs, IControllerTemplateElement, IControllerTemplateYoke
		{
			[Token(Token = "0x170000EF")]
			public IControllerTemplateAxis rotation
			{
				[Token(Token = "0x60002A7")]
				[Address(RVA = "0x245B938", Offset = "0x245B938", VA = "0x245B938", Slot = "22")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			public IControllerTemplateAxis pushPull
			{
				[Token(Token = "0x60002A8")]
				[Address(RVA = "0x245BA3C", Offset = "0x245BA3C", VA = "0x245BA3C", Slot = "23")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x245B830", Offset = "0x245B830", VA = "0x245B830")]
			internal CLDVmlgHxUZAcZnHbFwnwNPRZHzA(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4)
			{
			}
		}

		[Token(Token = "0x2000059")]
		internal sealed class iiKqtnQKUCcgSHGKrWUpGepvbyMab : NiMBoKRLrOMewcYQIYFQMWTnOIKl, IControllerTemplateElement, IControllerTemplateStick6D
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x245F11C", Offset = "0x245F11C", VA = "0x245F11C")]
			internal iiKqtnQKUCcgSHGKrWUpGepvbyMab(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4, xplOfuRdmqGAkFpxdfKgUEIduiHT P_5, xplOfuRdmqGAkFpxdfKgUEIduiHT P_6, xplOfuRdmqGAkFpxdfKgUEIduiHT P_7, xplOfuRdmqGAkFpxdfKgUEIduiHT P_8)
			{
			}
		}

		[Token(Token = "0x200005A")]
		internal class AckvZZpMMZJEeXiTnzpZGygPjFpk
		{
			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x10")]
			public readonly Controller.Element IeBiSvPSlvevRBzqkYknNspTYxmIA;

			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x18")]
			public readonly IControllerElementTarget QMmaBzbGhLRYBQhUiAbwUcRQwInF;

			[Token(Token = "0x170000F1")]
			public bool vTrlgouSJGtOvawjunaiRTKrzwsD
			{
				[Token(Token = "0x60002AB")]
				[Address(RVA = "0x245AF98", Offset = "0x245AF98", VA = "0x245AF98")]
				get
				{
					return GddMcZGLtcTrMmBPixnpWKiMKJsF();
				}
			}

			[Token(Token = "0x170000F2")]
			public bool fDZzkobccRjlJoXBBUdrauDEaisJ
			{
				[Token(Token = "0x60002AC")]
				[Address(RVA = "0x245B158", Offset = "0x245B158", VA = "0x245B158")]
				get
				{
					return HuWagyLnDKjhEgjuLjGrDCQcxncb();
				}
			}

			[Token(Token = "0x170000F3")]
			public bool zJkMPGtMddueMcJDyMsXdhcqorQl
			{
				[Token(Token = "0x60002AD")]
				[Address(RVA = "0x245B318", Offset = "0x245B318", VA = "0x245B318")]
				get
				{
					return SScjRKOHMCnGlZmgdXNNmzEgUuQQ();
				}
			}

			[Token(Token = "0x170000F4")]
			public bool uoMLTbBPDCNDEQdFdJvyeBicfQGhA
			{
				[Token(Token = "0x60002AE")]
				[Address(RVA = "0x245B6F8", Offset = "0x245B6F8", VA = "0x245B6F8")]
				get
				{
					return zRHruiUgkZDcgQEmNwkYTMlmeZAj();
				}
			}

			[Token(Token = "0x170000F5")]
			public float brHdwUJAbVcsilgLZZabrTqmRcFR
			{
				[Token(Token = "0x60002AF")]
				[Address(RVA = "0x245B3E8", Offset = "0x245B3E8", VA = "0x245B3E8")]
				get
				{
					return DBgaSEJhqXFKMAmvAoKNLIutBNZC();
				}
			}

			[Token(Token = "0x170000F6")]
			public float rEhPDLHiMGJDkTLyTdjOJSGOONIl
			{
				[Token(Token = "0x60002B0")]
				[Address(RVA = "0x245B570", Offset = "0x245B570", VA = "0x245B570")]
				get
				{
					return pyjLMkCEHVkGoHtdCNZhKxMEyaic();
				}
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x245AF60", Offset = "0x245AF60", VA = "0x245AF60")]
			public AckvZZpMMZJEeXiTnzpZGygPjFpk(IControllerElementTarget P_0, Controller.Element P_1)
			{
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x245AF98", Offset = "0x245AF98", VA = "0x245AF98")]
			public bool GddMcZGLtcTrMmBPixnpWKiMKJsF()
			{
				return default;
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x245B158", Offset = "0x245B158", VA = "0x245B158")]
			public bool HuWagyLnDKjhEgjuLjGrDCQcxncb()
			{
				return default;
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x245B318", Offset = "0x245B318", VA = "0x245B318")]
			public bool SScjRKOHMCnGlZmgdXNNmzEgUuQQ()
			{
				return default;
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x245B6F8", Offset = "0x245B6F8", VA = "0x245B6F8")]
			public bool zRHruiUgkZDcgQEmNwkYTMlmeZAj()
			{
				return default;
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x245B3E8", Offset = "0x245B3E8", VA = "0x245B3E8")]
			public float DBgaSEJhqXFKMAmvAoKNLIutBNZC()
			{
				return default;
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x245B570", Offset = "0x245B570", VA = "0x245B570")]
			public float pyjLMkCEHVkGoHtdCNZhKxMEyaic()
			{
				return default;
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x245B7C8", Offset = "0x245B7C8", VA = "0x245B7C8")]
			public static AckvZZpMMZJEeXiTnzpZGygPjFpk jqAWqFpdLUDQRsdZuZzXWwxrjFMg()
			{
				return null;
			}
		}

		[Token(Token = "0x200005B")]
		internal class mMyCOJEBAEHmGFJutMHNAUKrIxjSA
		{
			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x10")]
			public readonly Controller MHuXHKLCPsUIeLOovImpnHVJaYufA;

			[Token(Token = "0x40001BC")]
			[FieldOffset(Offset = "0x18")]
			public readonly IHardwareControllerTemplateMap_Internal DqWEEmjnsXsjFhDjdIFgWVfVygCQA;

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x245FB40", Offset = "0x245FB40", VA = "0x245FB40")]
			public mMyCOJEBAEHmGFJutMHNAUKrIxjSA(Controller P_0, IHardwareControllerTemplateMap_Internal P_1)
			{
			}
		}

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x10")]
		private readonly string hEJFspqWqeBOdedbqHNRpPNEbfBG;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x18")]
		private readonly Guid OJEPZrVGmynCKCXPlorDNMQIZfnQ;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x28")]
		private readonly Controller oBPMdftKtJLWDwKjOKgLuimxBfUKA;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x30")]
		private readonly ADictionary<int, IControllerTemplateElement> DSJJnwwCJPjjjysohBSGxpSbEGtBA;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x38")]
		private readonly ADictionary<string, IControllerTemplateElement> fnwsuLHukmUXSqAdAeHEuLmuQsWD;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x40")]
		private IControllerTemplateElement[] hObmyuQkxgNXDiBtSEwFNgLuBsoZ;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x48")]
		private ReadOnlyCollection<IControllerTemplateElement> VewvmtxDhBKjfOztXaGoFFLyxNDV;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x50")]
		private readonly int QajDFFaomlkLHzaostfWYpGUioys;

		[Token(Token = "0x170000AC")]
		private string Rewired_002EIControllerTemplate_002Ename
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x236CEC4", Offset = "0x236CEC4", VA = "0x236CEC4", Slot = "4")]
			get
			{
				return Rewired_002EIControllerTemplate_002Eget_name();
			}
		}

		[Token(Token = "0x170000AD")]
		private Guid Rewired_002EIControllerTemplate_002EtypeGuid
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x236CF74", Offset = "0x236CF74", VA = "0x236CF74", Slot = "5")]
			get
			{
				return Rewired_002EIControllerTemplate_002Eget_typeGuid();
			}
		}

		[Token(Token = "0x170000AE")]
		private IList<IControllerTemplateElement> Rewired_002EIControllerTemplate_002Eelements
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x236D064", Offset = "0x236D064", VA = "0x236D064", Slot = "6")]
			get
			{
				return Rewired_002EIControllerTemplate_002Eget_elements();
			}
		}

		[Token(Token = "0x170000AF")]
		private int Rewired_002EIControllerTemplate_002EelementCount
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x236D114", Offset = "0x236D114", VA = "0x236D114", Slot = "7")]
			get
			{
				return Rewired_002EIControllerTemplate_002Eget_elementCount();
			}
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2368790", Offset = "0x2368790", VA = "0x2368790")]
		protected ControllerTemplate(object P_0)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2368838", Offset = "0x2368838", VA = "0x2368838")]
		private ControllerTemplate(mMyCOJEBAEHmGFJutMHNAUKrIxjSA P_0)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x236CCB4", Offset = "0x236CCB4", VA = "0x236CCB4")]
		protected IControllerTemplateElement GetElement(int id)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x236CEC4", Offset = "0x236CEC4", VA = "0x236CEC4", Slot = "4")]
		private string Rewired_002EIControllerTemplate_002Eget_name()
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x236CF74", Offset = "0x236CF74", VA = "0x236CF74", Slot = "5")]
		private Guid Rewired_002EIControllerTemplate_002Eget_typeGuid()
		{
			return default;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x236D064", Offset = "0x236D064", VA = "0x236D064", Slot = "6")]
		private IList<IControllerTemplateElement> Rewired_002EIControllerTemplate_002Eget_elements()
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x236D114", Offset = "0x236D114", VA = "0x236D114", Slot = "7")]
		private int Rewired_002EIControllerTemplate_002Eget_elementCount()
		{
			return default;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x236D1D0", Offset = "0x236D1D0", VA = "0x236D1D0", Slot = "8")]
		private IControllerTemplateElement Rewired_002EIControllerTemplate_002EGetElement(int id)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x236D294", Offset = "0x236D294", VA = "0x236D294", Slot = "9")]
		private int Rewired_002EIControllerTemplate_002EGetElementTargets(ControllerElementTarget find, IList<ControllerTemplateElementTarget> results)
		{
			return default;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x236D3C0", Offset = "0x236D3C0", VA = "0x236D3C0")]
		private int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> results)
		{
			return default;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x236C44C", Offset = "0x236C44C", VA = "0x236C44C")]
		private static IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> MgpsizkckMCngeoIfdZBxlQJxgpDA(Controller P_0, IControllerTemplateAxisSource P_1)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x236CA34", Offset = "0x236CA34", VA = "0x236CA34")]
		private static IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> MgpsizkckMCngeoIfdZBxlQJxgpDA(Controller P_0, IControllerTemplateButtonSource P_1)
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x236D654", Offset = "0x236D654", VA = "0x236D654")]
		private static IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> MgpsizkckMCngeoIfdZBxlQJxgpDA(Controller P_0, IControllerElementTarget P_1)
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x236CB0C", Offset = "0x236CB0C", VA = "0x236CB0C")]
		private static xplOfuRdmqGAkFpxdfKgUEIduiHT JDJOMZTtkxuCBxrYAauGFfbVcvIbA(IControllerTemplate P_0, ADictionary<int, IControllerTemplateElement> P_1, int P_2)
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x236CBE0", Offset = "0x236CBE0", VA = "0x236CBE0")]
		private static xplOfuRdmqGAkFpxdfKgUEIduiHT ksUjSAMUrwIVaaryoEPEWmsYdJdS(IControllerTemplate P_0, ADictionary<int, IControllerTemplateElement> P_1, int P_2)
		{
			return null;
		}
	}
}
