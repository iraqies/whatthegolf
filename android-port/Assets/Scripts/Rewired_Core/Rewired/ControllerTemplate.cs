using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public abstract class ControllerTemplate : IControllerTemplate
	{
		internal abstract class tWsRepKMnZBPynxcHEOrqJwJrtqi : IControllerTemplateElement, IControllerTemplateElement_Internal
		{
			private readonly IControllerTemplate afWhZEYTbMFjMUeulVkAPjICyxpP;

			private readonly int YVGDeWQAhUWKAOSPoxXuizkXaiTI;

			private readonly string hEJFspqWqeBOdedbqHNRpPNEbfBG;

			private readonly ControllerTemplateElementType TIpqQbLCpFnyVWkQInNfNRXErYkK;

			protected readonly int QajDFFaomlkLHzaostfWYpGUioys;

			public int id => 0;

			public string descriptiveName => null;

			public ControllerTemplateElementType type => ControllerTemplateElementType.Axis;

			public abstract IControllerTemplateElementSource source { get; }

			public abstract bool exists { get; }

			protected tWsRepKMnZBPynxcHEOrqJwJrtqi(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3)
			{
			}

			public abstract int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list);
		}

		internal abstract class bDpsuBEObmlAmAiaSwlxSBIiPRrE : tWsRepKMnZBPynxcHEOrqJwJrtqi
		{
			protected readonly int uflBDILlxYOcIlCXbGnzgzAUpqtj;

			protected readonly AckvZZpMMZJEeXiTnzpZGygPjFpk[] mLceIVIgGsVFwNSYjUnnnJkOqsgBA;

			public override bool PhpaujTLOdqAPpftaxjzKpWeuveq => get_exists();

			protected bDpsuBEObmlAmAiaSwlxSBIiPRrE(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3, IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> P_4)
				: base(null, 0, null, ControllerTemplateElementType.Axis)
			{
			}

			public virtual bool get_exists()
			{
				return false;
			}
		}

		internal abstract class xplOfuRdmqGAkFpxdfKgUEIduiHT : bDpsuBEObmlAmAiaSwlxSBIiPRrE, IControllerTemplateElement, IControllerTemplateButton, IControllerTemplateAxis
		{
			private HxKJTjnYRTlXmgqyhXzejFNHdCai WdbNWWRsjxFdwKePDCTZQcFZsADA;

			private string sXTfsIlBXgXZPLOKJteRVBexfODV;

			private string qEHEGyASthJfEnPlUcWyGSdtXxUdA;

			public float brHdwUJAbVcsilgLZZabrTqmRcFR => DBgaSEJhqXFKMAmvAoKNLIutBNZC();

			public float rEhPDLHiMGJDkTLyTdjOJSGOONIl => pyjLMkCEHVkGoHtdCNZhKxMEyaic();

			public bool vTrlgouSJGtOvawjunaiRTKrzwsD => GddMcZGLtcTrMmBPixnpWKiMKJsF();

			public bool fDZzkobccRjlJoXBBUdrauDEaisJ => HuWagyLnDKjhEgjuLjGrDCQcxncb();

			float IControllerTemplateAxis.value => 0f;

			float IControllerTemplateAxis.valuePrev => 0f;

			IControllerTemplateAxisSource IControllerTemplateAxis.source => null;

			bool IControllerTemplateButton.value => false;

			bool IControllerTemplateButton.valuePrev => false;

			bool IControllerTemplateButton.justPressed => false;

			bool IControllerTemplateButton.justReleased => false;

			float IControllerTemplateButton.pressure => 0f;

			float IControllerTemplateButton.pressurePrev => 0f;

			IControllerTemplateButtonSource IControllerTemplateButton.source => null;

			public override IControllerTemplateElementSource source => null;

			protected xplOfuRdmqGAkFpxdfKgUEIduiHT(IControllerTemplate P_0, int P_1, string P_2, string P_3, string P_4, ControllerTemplateElementType P_5, HxKJTjnYRTlXmgqyhXzejFNHdCai P_6, IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> P_7)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}

			public float DBgaSEJhqXFKMAmvAoKNLIutBNZC()
			{
				return 0f;
			}

			public float pyjLMkCEHVkGoHtdCNZhKxMEyaic()
			{
				return 0f;
			}

			public bool GddMcZGLtcTrMmBPixnpWKiMKJsF()
			{
				return false;
			}

			public bool HuWagyLnDKjhEgjuLjGrDCQcxncb()
			{
				return false;
			}

			public override int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list)
			{
				return 0;
			}

			private static bool HeYIANgmGmbuIDCCgMyGfxvlhNCCB(ControllerElementTarget P_0, IControllerElementTarget P_1)
			{
				return false;
			}
		}

		internal sealed class CUvgYPcuNWQUoLfxEuBtidskpMACb : xplOfuRdmqGAkFpxdfKgUEIduiHT
		{
			public CUvgYPcuNWQUoLfxEuBtidskpMACb(IControllerTemplate P_0, int P_1, string P_2, string P_3, string P_4, HxKJTjnYRTlXmgqyhXzejFNHdCai P_5, IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> P_6)
				: base(null, 0, null, null, null, ControllerTemplateElementType.Axis, null, null)
			{
			}

			internal static CUvgYPcuNWQUoLfxEuBtidskpMACb jqAWqFpdLUDQRsdZuZzXWwxrjFMg(IControllerTemplate P_0)
			{
				return null;
			}
		}

		internal sealed class lxRJFUppkWtxxkUrZqBFElqfoxBT : xplOfuRdmqGAkFpxdfKgUEIduiHT
		{
			public lxRJFUppkWtxxkUrZqBFElqfoxBT(IControllerTemplate P_0, int P_1, string P_2, string P_3, string P_4, HxKJTjnYRTlXmgqyhXzejFNHdCai P_5, IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> P_6)
				: base(null, 0, null, null, null, ControllerTemplateElementType.Axis, null, null)
			{
			}

			internal static lxRJFUppkWtxxkUrZqBFElqfoxBT jqAWqFpdLUDQRsdZuZzXWwxrjFMg(IControllerTemplate P_0)
			{
				return null;
			}
		}

		internal abstract class HdTcpZLoztFKwinvXwmQwXyhMbTN : tWsRepKMnZBPynxcHEOrqJwJrtqi
		{
			protected readonly int pQhFxcuPrcDhCdBqMHKrOfeGZOVtA;

			protected readonly tWsRepKMnZBPynxcHEOrqJwJrtqi[] hObmyuQkxgNXDiBtSEwFNgLuBsoZ;

			public override bool PhpaujTLOdqAPpftaxjzKpWeuveq => get_exists();

			public override IControllerTemplateElementSource rmMLNGpqXVBSkkjZadentyrvdrgtA => get_source();

			protected HdTcpZLoztFKwinvXwmQwXyhMbTN(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_4)
				: base(null, 0, null, ControllerTemplateElementType.Axis)
			{
			}

			public virtual bool get_exists()
			{
				return false;
			}

			public virtual IControllerTemplateElementSource get_source()
			{
				return null;
			}

			public override int GetElementTargets(ControllerElementTarget P_0, ref IList<ControllerTemplateElementTarget> P_1)
			{
				return 0;
			}
		}

		internal abstract class nYkTjlGDFGRTHCcTrhwSGlyYngjs : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement
		{
			public Vector2 value => default;

			public Vector2 valuePrev => default;

			public IControllerTemplateAxis horizontal => null;

			public IControllerTemplateAxis vertical => null;

			protected nYkTjlGDFGRTHCcTrhwSGlyYngjs(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_4)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}
		}

		internal abstract class bjgAGIyWikBSsbhClQzhHYYDVXWHA : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement
		{
			public Vector3 value => default;

			public Vector3 valuePrev => default;

			public IControllerTemplateAxis horizontal => null;

			public IControllerTemplateAxis vertical => null;

			protected bjgAGIyWikBSsbhClQzhHYYDVXWHA(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_4)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}
		}

		internal abstract class NiMBoKRLrOMewcYQIYFQMWTnOIKl : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement
		{
			public Vector3 position => default;

			public Vector3 positionPrev => default;

			public Vector3 rotation => default;

			public Vector3 rotationPrev => default;

			public IControllerTemplateAxis positionX => null;

			public IControllerTemplateAxis positionY => null;

			public IControllerTemplateAxis positionZ => null;

			public IControllerTemplateAxis rotationX => null;

			public IControllerTemplateAxis rotationY => null;

			public IControllerTemplateAxis rotationZ => null;

			protected NiMBoKRLrOMewcYQIYFQMWTnOIKl(IControllerTemplate P_0, int P_1, string P_2, ControllerTemplateElementType P_3, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_4)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}
		}

		internal sealed class RAKYiYDzCotPmRFpoYhKhoekJhXO : bjgAGIyWikBSsbhClQzhHYYDVXWHA, IControllerTemplateElement, IControllerTemplateStick
		{
			public IControllerTemplateAxis rotation => null;

			private RAKYiYDzCotPmRFpoYhKhoekJhXO(IControllerTemplate P_0, int P_1, string P_2, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_3)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}

			public RAKYiYDzCotPmRFpoYhKhoekJhXO(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4, xplOfuRdmqGAkFpxdfKgUEIduiHT P_5)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}
		}

		internal sealed class SKdXFctHzBFnUqLKBBYLuFHjtgwO : nYkTjlGDFGRTHCcTrhwSGlyYngjs, IControllerTemplateElement, IControllerTemplateThumbStick
		{
			public IControllerTemplateButton press => null;

			private SKdXFctHzBFnUqLKBBYLuFHjtgwO(IControllerTemplate P_0, int P_1, string P_2, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_3)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}

			internal SKdXFctHzBFnUqLKBBYLuFHjtgwO(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4, xplOfuRdmqGAkFpxdfKgUEIduiHT P_5)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}
		}

		internal sealed class mZYAZnUOIAemtuOjxZzStAVMBQqAA : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement, IControllerTemplateDPad
		{
			public Vector2 value => default;

			public Vector2 valuePrev => default;

			public IControllerTemplateButton up => null;

			public IControllerTemplateButton right => null;

			public IControllerTemplateButton down => null;

			public IControllerTemplateButton left => null;

			private mZYAZnUOIAemtuOjxZzStAVMBQqAA(IControllerTemplate P_0, int P_1, string P_2, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_3)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}

			internal mZYAZnUOIAemtuOjxZzStAVMBQqAA(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4, xplOfuRdmqGAkFpxdfKgUEIduiHT P_5, xplOfuRdmqGAkFpxdfKgUEIduiHT P_6, xplOfuRdmqGAkFpxdfKgUEIduiHT P_7)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}
		}

		internal sealed class jkoAMVJJeANHSBEVLSTTFmSjWbSNb : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement, IControllerTemplateThrottle
		{
			public float value => 0f;

			public float valuePrev => 0f;

			public IControllerTemplateAxis throttle => null;

			public IControllerTemplateButton minDetent => null;

			private jkoAMVJJeANHSBEVLSTTFmSjWbSNb(IControllerTemplate P_0, int P_1, string P_2, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_3)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}

			internal jkoAMVJJeANHSBEVLSTTFmSjWbSNb(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}
		}

		internal sealed class ICIKEZuceqNSJzmhODcuDQQHKDajb : HdTcpZLoztFKwinvXwmQwXyhMbTN, IControllerTemplateElement, IControllerTemplateHat
		{
			public Vector2 value => default;

			public Vector2 valuePrev => default;

			public IControllerTemplateButton up => null;

			public IControllerTemplateButton upRight => null;

			public IControllerTemplateButton right => null;

			public IControllerTemplateButton downRight => null;

			public IControllerTemplateButton down => null;

			public IControllerTemplateButton downLeft => null;

			public IControllerTemplateButton left => null;

			public IControllerTemplateButton upLeft => null;

			private ICIKEZuceqNSJzmhODcuDQQHKDajb(IControllerTemplate P_0, int P_1, string P_2, tWsRepKMnZBPynxcHEOrqJwJrtqi[] P_3)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}

			internal ICIKEZuceqNSJzmhODcuDQQHKDajb(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4, xplOfuRdmqGAkFpxdfKgUEIduiHT P_5, xplOfuRdmqGAkFpxdfKgUEIduiHT P_6, xplOfuRdmqGAkFpxdfKgUEIduiHT P_7, xplOfuRdmqGAkFpxdfKgUEIduiHT P_8, xplOfuRdmqGAkFpxdfKgUEIduiHT P_9, xplOfuRdmqGAkFpxdfKgUEIduiHT P_10)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}
		}

		internal sealed class CLDVmlgHxUZAcZnHbFwnwNPRZHzA : nYkTjlGDFGRTHCcTrhwSGlyYngjs, IControllerTemplateElement, IControllerTemplateYoke
		{
			public IControllerTemplateAxis rotation => null;

			public IControllerTemplateAxis pushPull => null;

			internal CLDVmlgHxUZAcZnHbFwnwNPRZHzA(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}
		}

		internal sealed class iiKqtnQKUCcgSHGKrWUpGepvbyMab : NiMBoKRLrOMewcYQIYFQMWTnOIKl, IControllerTemplateElement, IControllerTemplateStick6D
		{
			internal iiKqtnQKUCcgSHGKrWUpGepvbyMab(IControllerTemplate P_0, int P_1, string P_2, xplOfuRdmqGAkFpxdfKgUEIduiHT P_3, xplOfuRdmqGAkFpxdfKgUEIduiHT P_4, xplOfuRdmqGAkFpxdfKgUEIduiHT P_5, xplOfuRdmqGAkFpxdfKgUEIduiHT P_6, xplOfuRdmqGAkFpxdfKgUEIduiHT P_7, xplOfuRdmqGAkFpxdfKgUEIduiHT P_8)
				: base(null, 0, null, ControllerTemplateElementType.Axis, null)
			{
			}
		}

		internal class AckvZZpMMZJEeXiTnzpZGygPjFpk
		{
			public readonly Controller.Element IeBiSvPSlvevRBzqkYknNspTYxmIA;

			public readonly IControllerElementTarget QMmaBzbGhLRYBQhUiAbwUcRQwInF;

			public bool vTrlgouSJGtOvawjunaiRTKrzwsD => GddMcZGLtcTrMmBPixnpWKiMKJsF();

			public bool fDZzkobccRjlJoXBBUdrauDEaisJ => HuWagyLnDKjhEgjuLjGrDCQcxncb();

			public bool zJkMPGtMddueMcJDyMsXdhcqorQl => SScjRKOHMCnGlZmgdXNNmzEgUuQQ();

			public bool uoMLTbBPDCNDEQdFdJvyeBicfQGhA => zRHruiUgkZDcgQEmNwkYTMlmeZAj();

			public float brHdwUJAbVcsilgLZZabrTqmRcFR => DBgaSEJhqXFKMAmvAoKNLIutBNZC();

			public float rEhPDLHiMGJDkTLyTdjOJSGOONIl => pyjLMkCEHVkGoHtdCNZhKxMEyaic();

			public AckvZZpMMZJEeXiTnzpZGygPjFpk(IControllerElementTarget P_0, Controller.Element P_1)
			{
			}

			public bool GddMcZGLtcTrMmBPixnpWKiMKJsF()
			{
				return false;
			}

			public bool HuWagyLnDKjhEgjuLjGrDCQcxncb()
			{
				return false;
			}

			public bool SScjRKOHMCnGlZmgdXNNmzEgUuQQ()
			{
				return false;
			}

			public bool zRHruiUgkZDcgQEmNwkYTMlmeZAj()
			{
				return false;
			}

			public float DBgaSEJhqXFKMAmvAoKNLIutBNZC()
			{
				return 0f;
			}

			public float pyjLMkCEHVkGoHtdCNZhKxMEyaic()
			{
				return 0f;
			}

			public static AckvZZpMMZJEeXiTnzpZGygPjFpk jqAWqFpdLUDQRsdZuZzXWwxrjFMg()
			{
				return null;
			}
		}

		internal class mMyCOJEBAEHmGFJutMHNAUKrIxjSA
		{
			public readonly Controller MHuXHKLCPsUIeLOovImpnHVJaYufA;

			public readonly IHardwareControllerTemplateMap_Internal DqWEEmjnsXsjFhDjdIFgWVfVygCQA;

			public mMyCOJEBAEHmGFJutMHNAUKrIxjSA(Controller P_0, IHardwareControllerTemplateMap_Internal P_1)
			{
			}
		}

		private readonly string hEJFspqWqeBOdedbqHNRpPNEbfBG;

		private readonly Guid OJEPZrVGmynCKCXPlorDNMQIZfnQ;

		private readonly Controller oBPMdftKtJLWDwKjOKgLuimxBfUKA;

		private readonly ADictionary<int, IControllerTemplateElement> DSJJnwwCJPjjjysohBSGxpSbEGtBA;

		private readonly ADictionary<string, IControllerTemplateElement> fnwsuLHukmUXSqAdAeHEuLmuQsWD;

		private IControllerTemplateElement[] hObmyuQkxgNXDiBtSEwFNgLuBsoZ;

		private ReadOnlyCollection<IControllerTemplateElement> VewvmtxDhBKjfOztXaGoFFLyxNDV;

		private readonly int QajDFFaomlkLHzaostfWYpGUioys;

		string IControllerTemplate.name => null;

		Guid IControllerTemplate.typeGuid => default;

		IList<IControllerTemplateElement> IControllerTemplate.elements => null;

		int IControllerTemplate.elementCount => 0;

		protected ControllerTemplate(object P_0)
		{
		}

		private ControllerTemplate(mMyCOJEBAEHmGFJutMHNAUKrIxjSA P_0)
		{
		}

		public IControllerTemplateElement GetElement(int id)
		{
			return null;
		}

		IControllerTemplateElement IControllerTemplate.GetElement(int id)
		{
			return null;
		}

		int IControllerTemplate.GetElementTargets(ControllerElementTarget find, IList<ControllerTemplateElementTarget> results)
		{
			return 0;
		}

		private int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> results)
		{
			return 0;
		}

		private static IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> MgpsizkckMCngeoIfdZBxlQJxgpDA(Controller P_0, IControllerTemplateAxisSource P_1)
		{
			return null;
		}

		private static IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> MgpsizkckMCngeoIfdZBxlQJxgpDA(Controller P_0, IControllerTemplateButtonSource P_1)
		{
			return null;
		}

		private static IList<AckvZZpMMZJEeXiTnzpZGygPjFpk> MgpsizkckMCngeoIfdZBxlQJxgpDA(Controller P_0, IControllerElementTarget P_1)
		{
			return null;
		}

		private static xplOfuRdmqGAkFpxdfKgUEIduiHT JDJOMZTtkxuCBxrYAauGFfbVcvIbA(IControllerTemplate P_0, ADictionary<int, IControllerTemplateElement> P_1, int P_2)
		{
			return null;
		}

		private static xplOfuRdmqGAkFpxdfKgUEIduiHT ksUjSAMUrwIVaaryoEPEWmsYdJdS(IControllerTemplate P_0, ADictionary<int, IControllerTemplateElement> P_1, int P_2)
		{
			return null;
		}
	}
}
