using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Internal
{
	[Serializable]
	[Token(Token = "0x200031B")]
	internal sealed class StandaloneAxis
	{
		[Token(Token = "0x200031C")]
		public delegate void AxisValueChangedEventHandler(float value);

		[Token(Token = "0x200031D")]
		public delegate void ButtonValueChangedEventHandler(bool value);

		[Token(Token = "0x200031E")]
		public delegate void ButtonDownEventHandler();

		[Token(Token = "0x200031F")]
		public delegate void ButtonUpEventHandler();

		[Token(Token = "0x400105E")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x194E54", Offset = "0x194E54")]
		[SerializeField]
		private float _buttonActivationThreshold;

		[Token(Token = "0x400105F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AxisCalibration _calibration;

		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x20")]
		private float _valueRaw;

		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x24")]
		private float _valueRawPrev;

		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x194EA4", Offset = "0x194EA4")]
		private AxisValueChangedEventHandler QNrCqvatavEJcWTIgbPSkLjfyicxA;

		[Token(Token = "0x4001063")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x194EB4", Offset = "0x194EB4")]
		private AxisValueChangedEventHandler oBjAdLZUVOmXJXCEMBvEAswUIAZz;

		[Token(Token = "0x4001064")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x194EC4", Offset = "0x194EC4")]
		private ButtonDownEventHandler vVVxSUwxUFLqYHHwdPpNCqlcvtkR;

		[Token(Token = "0x4001065")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x194ED4", Offset = "0x194ED4")]
		private ButtonUpEventHandler JDybOVVTuPaXSFNkAXlbqAxSkXAAb;

		[Token(Token = "0x4001066")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x194EE4", Offset = "0x194EE4")]
		private ButtonValueChangedEventHandler PzFiUmVEXzZrQfceZdtWQIJJeFTKA;

		[Token(Token = "0x4001067")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x194EF4", Offset = "0x194EF4")]
		private ButtonDownEventHandler XYJcmgVxsFrDhMNFejImljCGdBdn;

		[Token(Token = "0x4001068")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x194F04", Offset = "0x194F04")]
		private ButtonUpEventHandler OJCfamrLPmnglBpGQltFSmxEUUpq;

		[Token(Token = "0x4001069")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x194F14", Offset = "0x194F14")]
		private ButtonValueChangedEventHandler AGzBkAfEIMZVJxQEVLkUwrmubOfV;

		[Token(Token = "0x17000672")]
		public float buttonActivationThreshold
		{
			[Token(Token = "0x60017F6")]
			[Address(RVA = "0x24184D0", Offset = "0x24184D0", VA = "0x24184D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000673")]
		public AxisCalibration calibration
		{
			[Token(Token = "0x60017F7")]
			[Address(RVA = "0x24184D8", Offset = "0x24184D8", VA = "0x24184D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000674")]
		public float valueRaw
		{
			[Token(Token = "0x60017F8")]
			[Address(RVA = "0x24184E0", Offset = "0x24184E0", VA = "0x24184E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000675")]
		public float valueRawPrev
		{
			[Token(Token = "0x60017F9")]
			[Address(RVA = "0x24184E8", Offset = "0x24184E8", VA = "0x24184E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000676")]
		public float value
		{
			[Token(Token = "0x60017FA")]
			[Address(RVA = "0x24184F0", Offset = "0x24184F0", VA = "0x24184F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000677")]
		public float valuePrev
		{
			[Token(Token = "0x60017FB")]
			[Address(RVA = "0x241850C", Offset = "0x241850C", VA = "0x241850C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000678")]
		public bool rawButtonValue
		{
			[Token(Token = "0x60017FC")]
			[Address(RVA = "0x2418528", Offset = "0x2418528", VA = "0x2418528")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000679")]
		public bool rawButtonValuePrev
		{
			[Token(Token = "0x60017FD")]
			[Address(RVA = "0x241853C", Offset = "0x241853C", VA = "0x241853C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700067A")]
		public bool buttonValue
		{
			[Token(Token = "0x60017FE")]
			[Address(RVA = "0x2418550", Offset = "0x2418550", VA = "0x2418550")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700067B")]
		public bool buttonValuePrev
		{
			[Token(Token = "0x60017FF")]
			[Address(RVA = "0x24185AC", Offset = "0x24185AC", VA = "0x24185AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700067C")]
		internal float rawMax
		{
			[Token(Token = "0x6001800")]
			[Address(RVA = "0x2418608", Offset = "0x2418608", VA = "0x2418608")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700067D")]
		internal float rawZero
		{
			[Token(Token = "0x6001801")]
			[Address(RVA = "0x2418638", Offset = "0x2418638", VA = "0x2418638")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000041")]
		private event AxisValueChangedEventHandler _AxisValueChangedEvent
		{
			[Token(Token = "0x6001802")]
			[Address(RVA = "0x2418658", Offset = "0x2418658", VA = "0x2418658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197390", Offset = "0x197390")]
			add
			{
				AeSzurUEgoPLNVVeZVUCgcFdEgPk(axisValueChangedEventHandler);
			}
			[Token(Token = "0x6001803")]
			[Address(RVA = "0x24186FC", Offset = "0x24186FC", VA = "0x24186FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973A0", Offset = "0x1973A0")]
			remove
			{
				hRhbvzDKQmlJZEbUDVQFfHfnfvomb(axisValueChangedEventHandler);
			}
		}

		[Token(Token = "0x14000042")]
		public event AxisValueChangedEventHandler AxisValueChangedEvent
		{
			[Token(Token = "0x6001804")]
			[Address(RVA = "0x24187A0", Offset = "0x24187A0", VA = "0x24187A0")]
			add
			{
			}
			[Token(Token = "0x6001805")]
			[Address(RVA = "0x2418844", Offset = "0x2418844", VA = "0x2418844")]
			remove
			{
			}
		}

		[Token(Token = "0x14000043")]
		private event AxisValueChangedEventHandler _RawAxisValueChangedEvent
		{
			[Token(Token = "0x6001806")]
			[Address(RVA = "0x24188E8", Offset = "0x24188E8", VA = "0x24188E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973B0", Offset = "0x1973B0")]
			add
			{
				oIgOQRlUJEzaBypcjimwROpFpOnb(axisValueChangedEventHandler);
			}
			[Token(Token = "0x6001807")]
			[Address(RVA = "0x241898C", Offset = "0x241898C", VA = "0x241898C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973C0", Offset = "0x1973C0")]
			remove
			{
				DaCBKygiAYtLFgQeYqpykyBnnWki(axisValueChangedEventHandler);
			}
		}

		[Token(Token = "0x14000044")]
		public event AxisValueChangedEventHandler RawAxisValueChangedEvent
		{
			[Token(Token = "0x6001808")]
			[Address(RVA = "0x2418A30", Offset = "0x2418A30", VA = "0x2418A30")]
			add
			{
			}
			[Token(Token = "0x6001809")]
			[Address(RVA = "0x2418AD4", Offset = "0x2418AD4", VA = "0x2418AD4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000045")]
		private event ButtonDownEventHandler _ButtonDownEvent
		{
			[Token(Token = "0x600180A")]
			[Address(RVA = "0x2418B78", Offset = "0x2418B78", VA = "0x2418B78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973D0", Offset = "0x1973D0")]
			add
			{
				nhDoObcXFlMvhCXoqGBIKpnqAnQU(buttonDownEventHandler);
			}
			[Token(Token = "0x600180B")]
			[Address(RVA = "0x2418C1C", Offset = "0x2418C1C", VA = "0x2418C1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973E0", Offset = "0x1973E0")]
			remove
			{
				SpnGPCkIVBftNFVRyTcVfKYBmHBi(buttonDownEventHandler);
			}
		}

		[Token(Token = "0x14000046")]
		public event ButtonDownEventHandler ButtonDownEvent
		{
			[Token(Token = "0x600180C")]
			[Address(RVA = "0x2418CC0", Offset = "0x2418CC0", VA = "0x2418CC0")]
			add
			{
			}
			[Token(Token = "0x600180D")]
			[Address(RVA = "0x2418D64", Offset = "0x2418D64", VA = "0x2418D64")]
			remove
			{
			}
		}

		[Token(Token = "0x14000047")]
		private event ButtonUpEventHandler _ButtonUpEvent
		{
			[Token(Token = "0x600180E")]
			[Address(RVA = "0x2418E08", Offset = "0x2418E08", VA = "0x2418E08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973F0", Offset = "0x1973F0")]
			add
			{
				fbljwImkNgDtxVZTrvFGGoLwmfJ(buttonUpEventHandler);
			}
			[Token(Token = "0x600180F")]
			[Address(RVA = "0x2418EAC", Offset = "0x2418EAC", VA = "0x2418EAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197400", Offset = "0x197400")]
			remove
			{
				XgZiRkAQovdxaBqkYiHIjLPtTBODb(buttonUpEventHandler);
			}
		}

		[Token(Token = "0x14000048")]
		public event ButtonUpEventHandler ButtonUpEvent
		{
			[Token(Token = "0x6001810")]
			[Address(RVA = "0x2418F50", Offset = "0x2418F50", VA = "0x2418F50")]
			add
			{
			}
			[Token(Token = "0x6001811")]
			[Address(RVA = "0x2418FF4", Offset = "0x2418FF4", VA = "0x2418FF4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000049")]
		private event ButtonValueChangedEventHandler _ButtonValueChangedEvent
		{
			[Token(Token = "0x6001812")]
			[Address(RVA = "0x2419098", Offset = "0x2419098", VA = "0x2419098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197410", Offset = "0x197410")]
			add
			{
				bxhnOYxOdSZdCgLyydabQBHDudkG(buttonValueChangedEventHandler);
			}
			[Token(Token = "0x6001813")]
			[Address(RVA = "0x241913C", Offset = "0x241913C", VA = "0x241913C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197420", Offset = "0x197420")]
			remove
			{
				fbgqqUpGhGfDdTTzSBupoSPVMFDN(buttonValueChangedEventHandler);
			}
		}

		[Token(Token = "0x1400004A")]
		public event ButtonValueChangedEventHandler ButtonValueChangedEvent
		{
			[Token(Token = "0x6001814")]
			[Address(RVA = "0x24191E0", Offset = "0x24191E0", VA = "0x24191E0")]
			add
			{
			}
			[Token(Token = "0x6001815")]
			[Address(RVA = "0x2419284", Offset = "0x2419284", VA = "0x2419284")]
			remove
			{
			}
		}

		[Token(Token = "0x6001802")]
		[Address(RVA = "0x2418658", Offset = "0x2418658", VA = "0x2418658")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197390", Offset = "0x197390")]
		private void AeSzurUEgoPLNVVeZVUCgcFdEgPk(AxisValueChangedEventHandler P_0)
		{
		}

		[Token(Token = "0x6001803")]
		[Address(RVA = "0x24186FC", Offset = "0x24186FC", VA = "0x24186FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973A0", Offset = "0x1973A0")]
		private void hRhbvzDKQmlJZEbUDVQFfHfnfvomb(AxisValueChangedEventHandler P_0)
		{
		}

		[Token(Token = "0x6001806")]
		[Address(RVA = "0x24188E8", Offset = "0x24188E8", VA = "0x24188E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973B0", Offset = "0x1973B0")]
		private void oIgOQRlUJEzaBypcjimwROpFpOnb(AxisValueChangedEventHandler P_0)
		{
		}

		[Token(Token = "0x6001807")]
		[Address(RVA = "0x241898C", Offset = "0x241898C", VA = "0x241898C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973C0", Offset = "0x1973C0")]
		private void DaCBKygiAYtLFgQeYqpykyBnnWki(AxisValueChangedEventHandler P_0)
		{
		}

		[Token(Token = "0x600180A")]
		[Address(RVA = "0x2418B78", Offset = "0x2418B78", VA = "0x2418B78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973D0", Offset = "0x1973D0")]
		private void nhDoObcXFlMvhCXoqGBIKpnqAnQU(ButtonDownEventHandler P_0)
		{
		}

		[Token(Token = "0x600180B")]
		[Address(RVA = "0x2418C1C", Offset = "0x2418C1C", VA = "0x2418C1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973E0", Offset = "0x1973E0")]
		private void SpnGPCkIVBftNFVRyTcVfKYBmHBi(ButtonDownEventHandler P_0)
		{
		}

		[Token(Token = "0x600180E")]
		[Address(RVA = "0x2418E08", Offset = "0x2418E08", VA = "0x2418E08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1973F0", Offset = "0x1973F0")]
		private void fbljwImkNgDtxVZTrvFGGoLwmfJ(ButtonUpEventHandler P_0)
		{
		}

		[Token(Token = "0x600180F")]
		[Address(RVA = "0x2418EAC", Offset = "0x2418EAC", VA = "0x2418EAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197400", Offset = "0x197400")]
		private void XgZiRkAQovdxaBqkYiHIjLPtTBODb(ButtonUpEventHandler P_0)
		{
		}

		[Token(Token = "0x6001812")]
		[Address(RVA = "0x2419098", Offset = "0x2419098", VA = "0x2419098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197410", Offset = "0x197410")]
		private void bxhnOYxOdSZdCgLyydabQBHDudkG(ButtonValueChangedEventHandler P_0)
		{
		}

		[Token(Token = "0x6001813")]
		[Address(RVA = "0x241913C", Offset = "0x241913C", VA = "0x241913C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x197420", Offset = "0x197420")]
		private void fbgqqUpGhGfDdTTzSBupoSPVMFDN(ButtonValueChangedEventHandler P_0)
		{
		}

		[Token(Token = "0x6001816")]
		[Address(RVA = "0x2419328", Offset = "0x2419328", VA = "0x2419328")]
		internal StandaloneAxis()
		{
		}

		[Token(Token = "0x6001817")]
		[Address(RVA = "0x241939C", Offset = "0x241939C", VA = "0x241939C")]
		public void SetRawValue(float value)
		{
		}

		[Token(Token = "0x6001818")]
		[Address(RVA = "0x24196A4", Offset = "0x24196A4", VA = "0x24196A4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6001819")]
		[Address(RVA = "0x24196C4", Offset = "0x24196C4", VA = "0x24196C4")]
		internal static StandaloneAxis CreateRelative()
		{
			return null;
		}
	}
}
