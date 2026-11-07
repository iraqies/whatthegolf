using System;
using Il2CppDummyDll;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x200008D")]
	public sealed class PlayerMouse : PlayerController, IPlayerController, IMouseInputSource
	{
		[Token(Token = "0x200008E")]
		public new sealed class Definition : PlayerController.Definition
		{
			[Token(Token = "0x4000238")]
			[FieldOffset(Offset = "0x20")]
			public bool defaultToCenter;

			[Token(Token = "0x4000239")]
			[FieldOffset(Offset = "0x21")]
			public bool clampToMovementArea;

			[Token(Token = "0x400023A")]
			[FieldOffset(Offset = "0x24")]
			public ScreenRect movementArea;

			[Token(Token = "0x400023B")]
			[FieldOffset(Offset = "0x34")]
			public MovementAreaUnit movementAreaUnit;

			[Token(Token = "0x400023C")]
			[FieldOffset(Offset = "0x38")]
			public float pointerSpeed;

			[Token(Token = "0x400023D")]
			[FieldOffset(Offset = "0x3C")]
			public bool useHardwarePointerPosition;

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x238DB28", Offset = "0x238DB28", VA = "0x238DB28")]
			internal Definition()
			{
			}
		}

		[Token(Token = "0x200008F")]
		public new static class Factory
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x238DBD8", Offset = "0x238DBD8", VA = "0x238DBD8")]
			public static PlayerMouse Create()
			{
				return null;
			}

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x238DBE4", Offset = "0x238DBE4", VA = "0x238DBE4")]
			private static PlayerMouse lOzmglNwrCkddSvkHTjSvLufiURJ(int P_0, int P_1)
			{
				return null;
			}

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x238E0F8", Offset = "0x238E0F8", VA = "0x238E0F8")]
			public static PlayerMouse Create(Definition definition)
			{
				return null;
			}
		}

		[Token(Token = "0x2000090")]
		public enum MovementAreaUnit
		{
			[Token(Token = "0x400023F")]
			Screen = 0,
			[Token(Token = "0x4000240")]
			Pixel = 1
		}

		[Serializable]
		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190A20", Offset = "0x190A20")]
		private sealed class OSlalNkQgdyCxwlOJLXPaRyIfeNGb
		{
			[Token(Token = "0x4000241")]
			[FieldOffset(Offset = "0x0")]
			public static readonly OSlalNkQgdyCxwlOJLXPaRyIfeNGb _003C_003E9;

			[Token(Token = "0x4000242")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<Axis> _003C_003E9__18_0;

			[Token(Token = "0x4000243")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<Axis> _003C_003E9__18_1;

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x238E1C0", Offset = "0x238E1C0", VA = "0x238E1C0")]
			public OSlalNkQgdyCxwlOJLXPaRyIfeNGb()
			{
			}

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x238E1C8", Offset = "0x238E1C8", VA = "0x238E1C8")]
			internal bool puHFbMbZKRgRrEHnPuZHpJpqxAWQ(Axis P_0)
			{
				return default;
			}

			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x238E28C", Offset = "0x238E28C", VA = "0x238E28C")]
			internal bool REKreJAUTcsuDTPasfcxGOWTYUPN(Axis P_0)
			{
				return default;
			}
		}

		[Token(Token = "0x4000214")]
		internal const bool crtgmFtaoxGkFJALkMneypaJfbiyA = true;

		[Token(Token = "0x4000215")]
		internal const float MMQMoBURzBdZBfOjtcIkfEfkHrEOb = 1f;

		[Token(Token = "0x4000216")]
		internal const bool LzflEobrLLpTJphRiJMslgKKQqtW = true;

		[Token(Token = "0x4000217")]
		internal const bool UaubgkjmjCUdjbSqoBxQcCBeFCzaA = true;

		[Token(Token = "0x4000218")]
		internal const MovementAreaUnit fWjLMXkdMrbVvorEgceTaczTnnaCA = MovementAreaUnit.Screen;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly ScreenRect fIHmOZwdmcjhhxjckEtHRKVcffPV;

		[Token(Token = "0x400021A")]
		private const int SJoqyEGVJCuGrikQRqLOaiOnfzEy = 3;

		[Token(Token = "0x400021B")]
		private const int GUNBIxEurJSTmnKyGWDLWunVbhacb = 3;

		[Token(Token = "0x400021C")]
		internal const string UBEwMPhRyWhgjZfJODajRYTkhJxs = "Movement";

		[Token(Token = "0x400021D")]
		internal const string lVzfbDHjIdsxijlEtVFXCigxqwNcA = "Horizontal";

		[Token(Token = "0x400021E")]
		internal const string UCSlGWzkwqjaLupizGIniUHJEIdaA = "Vertical";

		[Token(Token = "0x400021F")]
		internal const string YLFBHELRKskAimMMrrXAfAyFFpmKA = "Wheel";

		[Token(Token = "0x4000220")]
		internal const string dDrOhokZbajufyoDftYgXqwWJoVn = "Wheel Horizontal";

		[Token(Token = "0x4000221")]
		internal const string afSeorwduFlbtHKKNjdxQHAhqnTD = "Wheel Vertical";

		[Token(Token = "0x4000222")]
		internal const string nhUJEDdiQsIbcGpOsANfefKxnMRT = "Left Button";

		[Token(Token = "0x4000223")]
		internal const string qWQgTKqBQhGnlAHZJvMzvUPiGZsRA = "Right Button";

		[Token(Token = "0x4000224")]
		internal const string MwHiTwfJjckLcVTHAoDvFCfriYBE = "Middle Button";

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x70")]
		private readonly int hxwwgxFnUtCslUpZOgPZCzFqFiqTA;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x74")]
		private readonly int DfEbwMtWVLWsSBqreuwzeVrQSwSl;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x78")]
		private readonly int vNbVHcuTotuEFGaawHzjVdfyCmuy;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x7C")]
		private readonly int fDcRizljsZXtisTJjJvDCnfVRvUD;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x80")]
		private readonly int TxNNxPSzkkcdkUCsYUxErSslcylE;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x84")]
		private readonly int CLpkKlcRLHDYaVHsUTnEbULSfghR;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x88")]
		private bool fyHlDWcNNzDNgJlSyUKoyrsWGWGe;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x8C")]
		private Vector2 oxrDIMticzxeKaxrOYeUhCepuoyF;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x94")]
		private Vector2 pplLsqMoYgzVgPCIqghiiSHWqzGt;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x9C")]
		private Vector2 JHlQdvIDknwhbpDkONoyRzgqysDj;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0xA4")]
		private Vector2 NNeHrvYGutiOIXhlhFaJfwMWTlqw;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0xAC")]
		private Vector2 QBcPXjdeXZuzabhNCsEDWKxPBdte;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0xB4")]
		private float GDHSElRvsGdWdBmtMLHmEKBiKTpC;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0xB8")]
		private bool HdRGQgJBdNkpNiMbgdWNiHTQRrDaB;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0xC0")]
		private Action<Vector2> rnnZqqYfwFdqnJnqPRsOnSOuchohb;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0xC8")]
		private bool mBgpERXzEyTjbWeGHFvSbaUoJveW;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0xCC")]
		private ScreenRect jJwbONnbKvXKWbnpYndOAguJcFwjA;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0xDC")]
		private bool plrzNanNFfWnyYQasrBNsxGHRJzg;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0xE0")]
		private MovementAreaUnit GmCwmKihHCIrRGKDcEPfvjNWacpx;

		[Token(Token = "0x17000172")]
		public bool defaultToCenter
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x23F9BEC", Offset = "0x23F9BEC", VA = "0x23F9BEC", Slot = "40")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x23F9DB8", Offset = "0x23F9DB8", VA = "0x23F9DB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		public bool clampToMovementArea
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x23F9DC0", Offset = "0x23F9DC0", VA = "0x23F9DC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x23F9DC8", Offset = "0x23F9DC8", VA = "0x23F9DC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000174")]
		public ScreenRect movementArea
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x23F9DD0", Offset = "0x23F9DD0", VA = "0x23F9DD0", Slot = "41")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x23F9E8C", Offset = "0x23F9E8C", VA = "0x23F9E8C", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public MovementAreaUnit movementAreaUnit
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x23F9E98", Offset = "0x23F9E98", VA = "0x23F9E98", Slot = "43")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x23F9F44", Offset = "0x23F9F44", VA = "0x23F9F44", Slot = "44")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public Vector2 screenPosition
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x23F9F4C", Offset = "0x23F9F4C", VA = "0x23F9F4C", Slot = "45")]
			get
			{
				return default;
			}
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x23FA014", Offset = "0x23FA014", VA = "0x23FA014")]
			set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public Vector2 screenPositionPrev
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x23FA12C", Offset = "0x23FA12C", VA = "0x23FA12C", Slot = "46")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000178")]
		public Vector2 screenPositionDelta
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x23FA1F4", Offset = "0x23FA1F4", VA = "0x23FA1F4", Slot = "47")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000179")]
		public MouseAxis xAxis
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x23FA2BC", Offset = "0x23FA2BC", VA = "0x23FA2BC", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		public MouseAxis yAxis
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x23FA458", Offset = "0x23FA458", VA = "0x23FA458", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017B")]
		public MouseWheel wheel
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x23FA5F4", Offset = "0x23FA5F4", VA = "0x23FA5F4", Slot = "50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017C")]
		public Button leftButton
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x23FA76C", Offset = "0x23FA76C", VA = "0x23FA76C", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017D")]
		public Button rightButton
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x23FA8BC", Offset = "0x23FA8BC", VA = "0x23FA8BC", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017E")]
		public Button middleButton
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x23FAA0C", Offset = "0x23FAA0C", VA = "0x23FAA0C", Slot = "53")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017F")]
		public float pointerSpeed
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x23FAB5C", Offset = "0x23FAB5C", VA = "0x23FAB5C", Slot = "54")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x23FAC08", Offset = "0x23FAC08", VA = "0x23FAC08")]
			set
			{
			}
		}

		[Token(Token = "0x17000180")]
		public bool useHardwarePointerPosition
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x23FACD4", Offset = "0x23FACD4", VA = "0x23FACD4", Slot = "55")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x23FAD84", Offset = "0x23FAD84", VA = "0x23FAD84")]
			set
			{
			}
		}

		[Token(Token = "0x17000181")]
		private bool Rewired_002EUI_002EIMouseInputSource_002Eenabled
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x23FB6A0", Offset = "0x23FB6A0", VA = "0x23FB6A0", Slot = "31")]
			get
			{
				return Rewired_002EUI_002EIMouseInputSource_002Eget_enabled();
			}
		}

		[Token(Token = "0x17000182")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPosition
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x23FB6C0", Offset = "0x23FB6C0", VA = "0x23FB6C0", Slot = "37")]
			get
			{
				return Rewired_002EUI_002EIMouseInputSource_002Eget_screenPosition();
			}
		}

		[Token(Token = "0x17000183")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EscreenPositionDelta
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x23FB6C8", Offset = "0x23FB6C8", VA = "0x23FB6C8", Slot = "38")]
			get
			{
				return Rewired_002EUI_002EIMouseInputSource_002Eget_screenPositionDelta();
			}
		}

		[Token(Token = "0x17000184")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002EwheelDelta
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x23FB6D0", Offset = "0x23FB6D0", VA = "0x23FB6D0", Slot = "39")]
			get
			{
				return Rewired_002EUI_002EIMouseInputSource_002Eget_wheelDelta();
			}
		}

		[Token(Token = "0x17000185")]
		private bool Rewired_002EUI_002EIMouseInputSource_002Elocked
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x23FB718", Offset = "0x23FB718", VA = "0x23FB718", Slot = "32")]
			get
			{
				return Rewired_002EUI_002EIMouseInputSource_002Eget_locked();
			}
		}

		[Token(Token = "0x14000008")]
		public event Action<Vector2> ScreenPositionChangedEvent
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x23FAE88", Offset = "0x23FAE88", VA = "0x23FAE88", Slot = "56")]
			add
			{
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x23FAF80", Offset = "0x23FAF80", VA = "0x23FAF80", Slot = "57")]
			remove
			{
			}
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x23F8AB0", Offset = "0x23F8AB0", VA = "0x23F8AB0")]
		private PlayerMouse(Definition P_0)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x23FB004", Offset = "0x23FB004", VA = "0x23FB004", Slot = "27")]
		protected override bool Update(UpdateLoopType updateLoop)
		{
			return default;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x23FB4B0", Offset = "0x23FB4B0", VA = "0x23FB4B0", Slot = "28")]
		protected override void UpdateFinished()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x23FB620", Offset = "0x23FB620", VA = "0x23FB620", Slot = "29")]
		protected override void ClearVars()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x23FA018", Offset = "0x23FA018", VA = "0x23FA018")]
		private void vtzxdsmrfDcFGyGcdkIRsgZqTqgO(Vector2 P_0)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x23F9AEC", Offset = "0x23F9AEC", VA = "0x23F9AEC")]
		private ScreenRect NPAuUJFLGVUbDGIXwfwBXFKraBmJ()
		{
			return default;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x23FAE54", Offset = "0x23FAE54", VA = "0x23FAE54")]
		private void PBiXClCdYpXIpnoPsGXhDsFMbZNGb()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x23FB414", Offset = "0x23FB414", VA = "0x23FB414")]
		private static float kRkyQqefvvPbnHhOJTSOYsKxiTXc(Axis P_0, float P_1, float P_2)
		{
			return default;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x23FB6A0", Offset = "0x23FB6A0", VA = "0x23FB6A0", Slot = "31")]
		private bool Rewired_002EUI_002EIMouseInputSource_002Eget_enabled()
		{
			return default;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x23FB6A8", Offset = "0x23FB6A8", VA = "0x23FB6A8", Slot = "34")]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonDown(int button)
		{
			return default;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x23FB6B0", Offset = "0x23FB6B0", VA = "0x23FB6B0", Slot = "35")]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButtonUp(int button)
		{
			return default;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x23FB6B8", Offset = "0x23FB6B8", VA = "0x23FB6B8", Slot = "36")]
		private bool Rewired_002EUI_002EIMouseInputSource_002EGetButton(int button)
		{
			return default;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x23FB6C0", Offset = "0x23FB6C0", VA = "0x23FB6C0", Slot = "37")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002Eget_screenPosition()
		{
			return default;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x23FB6C8", Offset = "0x23FB6C8", VA = "0x23FB6C8", Slot = "38")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002Eget_screenPositionDelta()
		{
			return default;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x23FB6D0", Offset = "0x23FB6D0", VA = "0x23FB6D0", Slot = "39")]
		private Vector2 Rewired_002EUI_002EIMouseInputSource_002Eget_wheelDelta()
		{
			return default;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x23FB718", Offset = "0x23FB718", VA = "0x23FB718", Slot = "32")]
		private bool Rewired_002EUI_002EIMouseInputSource_002Eget_locked()
		{
			return default;
		}
	}
}
