using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Rewired.Platforms.Custom
{
	[Token(Token = "0x20001A5")]
	public abstract class CustomInputSource : IDisposable
	{
		[Token(Token = "0x20001A6")]
		public abstract class Controller
		{
			[Token(Token = "0x400097C")]
			[FieldOffset(Offset = "0x10")]
			protected bool _isConnected;

			[Token(Token = "0x400097D")]
			[FieldOffset(Offset = "0x18")]
			protected string _deviceName;

			[Token(Token = "0x400097E")]
			[FieldOffset(Offset = "0x20")]
			protected string _customName;

			[Token(Token = "0x17000382")]
			public string customName
			{
				[Token(Token = "0x6000C99")]
				[Address(RVA = "0x24650D4", Offset = "0x24650D4", VA = "0x24650D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000383")]
			public bool isConnected
			{
				[Token(Token = "0x6000C9A")]
				[Address(RVA = "0x24650DC", Offset = "0x24650DC", VA = "0x24650DC")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000384")]
			public string deviceName
			{
				[Token(Token = "0x6000C9B")]
				[Address(RVA = "0x24650E4", Offset = "0x24650E4", VA = "0x24650E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x24650EC", Offset = "0x24650EC", VA = "0x24650EC")]
			protected Controller(string P_0)
			{
			}

			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x2465118", Offset = "0x2465118", VA = "0x2465118")]
			public void Disconnect()
			{
			}

			[Token(Token = "0x6000C9E")]
			public abstract void Update();
		}

		[Token(Token = "0x20001A7")]
		public abstract class Joystick : Controller
		{
			[Token(Token = "0x400097F")]
			[FieldOffset(Offset = "0x28")]
			private long? orGeZnHyIQImwrQbTiysYDyAvZUR;

			[Token(Token = "0x4000980")]
			[FieldOffset(Offset = "0x38")]
			private int xmEXVfyENtoyjKLfjizpdurnqqpi;

			[Token(Token = "0x4000981")]
			[FieldOffset(Offset = "0x40")]
			private readonly Axis[] gmjcdmbtDXKatrtMKrVjuasYTyOh;

			[Token(Token = "0x4000982")]
			[FieldOffset(Offset = "0x48")]
			private readonly Button[] YXuCILbbSuGPNMGgRTZoPeQmcMPsA;

			[Token(Token = "0x4000983")]
			[FieldOffset(Offset = "0x50")]
			private readonly ReadOnlyCollection<Axis> cBSHMOCbWzIiiaZpZEDfrfjPCNNab;

			[Token(Token = "0x4000984")]
			[FieldOffset(Offset = "0x58")]
			private readonly ReadOnlyCollection<Button> tnwAAWkpEQQDOblRgOpzbinWPPbqc;

			[Token(Token = "0x4000985")]
			[FieldOffset(Offset = "0x60")]
			private bool OlbVRqsSBEtRqSittUWERZaqzxXk;

			[Token(Token = "0x4000986")]
			[FieldOffset(Offset = "0x68")]
			private Rewired.Controller.Extension ieNssgrFeJiIpjsZwbsJdGwhvyJU;

			[Token(Token = "0x17000385")]
			public long? systemId
			{
				[Token(Token = "0x6000C9F")]
				[Address(RVA = "0x246512C", Offset = "0x246512C", VA = "0x246512C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000CA0")]
				[Address(RVA = "0x2465138", Offset = "0x2465138", VA = "0x2465138")]
				protected set
				{
				}
			}

			[Token(Token = "0x17000386")]
			public int unityId
			{
				[Token(Token = "0x6000CA1")]
				[Address(RVA = "0x2465140", Offset = "0x2465140", VA = "0x2465140")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000387")]
			public IList<Axis> Axes
			{
				[Token(Token = "0x6000CA2")]
				[Address(RVA = "0x2465148", Offset = "0x2465148", VA = "0x2465148")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000388")]
			public IList<Button> Buttons
			{
				[Token(Token = "0x6000CA3")]
				[Address(RVA = "0x2465150", Offset = "0x2465150", VA = "0x2465150")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000389")]
			public bool supportsVibration
			{
				[Token(Token = "0x6000CA4")]
				[Address(RVA = "0x2465158", Offset = "0x2465158", VA = "0x2465158")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000CA5")]
				[Address(RVA = "0x2465160", Offset = "0x2465160", VA = "0x2465160")]
				set
				{
				}
			}

			[Token(Token = "0x1700038A")]
			public Rewired.Controller.Extension extension
			{
				[Token(Token = "0x6000CA6")]
				[Address(RVA = "0x2465168", Offset = "0x2465168", VA = "0x2465168")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000CA7")]
				[Address(RVA = "0x2465170", Offset = "0x2465170", VA = "0x2465170")]
				set
				{
				}
			}

			[Token(Token = "0x1700038B")]
			public int buttonCount
			{
				[Token(Token = "0x6000CA8")]
				[Address(RVA = "0x24637D8", Offset = "0x24637D8", VA = "0x24637D8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700038C")]
			public int axisCount
			{
				[Token(Token = "0x6000CA9")]
				[Address(RVA = "0x2463820", Offset = "0x2463820", VA = "0x2463820")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x2465178", Offset = "0x2465178", VA = "0x2465178")]
			public Joystick(string P_0, long? P_1, int P_2, int P_3, int P_4)
			{
			}

			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x24653DC", Offset = "0x24653DC", VA = "0x24653DC", Slot = "5")]
			public virtual float GetAxisValue(int index)
			{
				return default;
			}

			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x246542C", Offset = "0x246542C", VA = "0x246542C", Slot = "6")]
			public virtual bool GetButtonValue(int index)
			{
				return default;
			}
		}

		[Token(Token = "0x20001A8")]
		public abstract class Element
		{
			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x24650C4", Offset = "0x24650C4", VA = "0x24650C4")]
			protected Element()
			{
			}
		}

		[Token(Token = "0x20001A9")]
		public sealed class Axis : Element
		{
			[Token(Token = "0x4000987")]
			[FieldOffset(Offset = "0x10")]
			public float value;

			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x24650BC", Offset = "0x24650BC", VA = "0x24650BC")]
			public Axis()
			{
			}
		}

		[Token(Token = "0x20001AA")]
		public sealed class Button : Element
		{
			[Token(Token = "0x4000988")]
			[FieldOffset(Offset = "0x10")]
			public bool value;

			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x24650CC", Offset = "0x24650CC", VA = "0x24650CC")]
			public Button()
			{
			}
		}

		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x10")]
		private readonly InputSource mKGFJudopEcewqKpuxRtaCtIVgIn;

		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<Joystick> lacEMsSikdfQQWUospJtpSoUfDdS;

		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0x20")]
		private readonly ReadOnlyCollection<Joystick> STDYSyyforIsYvzkZoBubRXRkbEE;

		[Token(Token = "0x4000978")]
		[FieldOffset(Offset = "0x28")]
		private bool CJusUpshQKVHuGVwEaiCDFqiDoUFA;

		[Token(Token = "0x4000979")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1930C0", Offset = "0x1930C0")]
		private Action m_nOYSRzstOJbWcLYZLMjrCoJoGBEN;

		[Token(Token = "0x400097A")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1930D0", Offset = "0x1930D0")]
		private Action m_SLDNNFtlUUCYOMZYUcmjzNuvBZei;

		[Token(Token = "0x400097B")]
		[FieldOffset(Offset = "0x40")]
		private bool AeWaeWamxRrERkciQkpFDWbRfZMkA;

		[Token(Token = "0x1700037F")]
		public bool useApproximateMatching
		{
			[Token(Token = "0x6000C83")]
			[Address(RVA = "0x2377BFC", Offset = "0x2377BFC", VA = "0x2377BFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x2377C04", Offset = "0x2377C04", VA = "0x2377C04")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000380")]
		internal InputSource twtzIKfuPcwLuTdbfRDPmfUOUduI
		{
			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x2377FE4", Offset = "0x2377FE4", VA = "0x2377FE4")]
			get
			{
				return XFUmJxlJbofHIzhewRJutVjfhbPL();
			}
		}

		[Token(Token = "0x17000381")]
		public abstract bool isReady
		{
			[Token(Token = "0x6000C97")]
			get;
		}

		[Token(Token = "0x1400001E")]
		private event Action nOYSRzstOJbWcLYZLMjrCoJoGBEN
		{
			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x2377C0C", Offset = "0x2377C0C", VA = "0x2377C0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195AB4", Offset = "0x195AB4")]
			add
			{
				alVWABSXzsQaFVWiUaUWqyJviqJw(action);
			}
			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x2377CB0", Offset = "0x2377CB0", VA = "0x2377CB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195AC4", Offset = "0x195AC4")]
			remove
			{
				mBDbggZkJKDHaIFtaJuFWkPdhpdrA(action);
			}
		}

		[Token(Token = "0x1400001F")]
		private event Action SLDNNFtlUUCYOMZYUcmjzNuvBZei
		{
			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x2377D54", Offset = "0x2377D54", VA = "0x2377D54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195AD4", Offset = "0x195AD4")]
			add
			{
				JwcfJfaOLsKfZtOacLvkfWrCnUUfB(action);
			}
			[Token(Token = "0x6000C88")]
			[Address(RVA = "0x2377DF8", Offset = "0x2377DF8", VA = "0x2377DF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195AE4", Offset = "0x195AE4")]
			remove
			{
				yMGTAHtJNYEIcHorwpREbqjiQaTlc(action);
			}
		}

		[Token(Token = "0x14000020")]
		internal event Action IjBZhVnpMDVJOoHiocMFmfzWUjXD
		{
			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x2376220", Offset = "0x2376220", VA = "0x2376220")]
			add
			{
				kcliwPuXVLfgBTTJDHAEHhHnxyVU(action);
			}
			[Token(Token = "0x6000C8A")]
			[Address(RVA = "0x2377E9C", Offset = "0x2377E9C", VA = "0x2377E9C")]
			remove
			{
				NbygqORNqcIzZyVXxGXzetijRFRB(action);
			}
		}

		[Token(Token = "0x14000021")]
		internal event Action bEQVXqVyYwXaKGcXFdnuHwwjmrcf
		{
			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0x23762C4", Offset = "0x23762C4", VA = "0x23762C4")]
			add
			{
				aJEszINcAYFgMGCMrjUNpcKKUqEg(action);
			}
			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x2377F40", Offset = "0x2377F40", VA = "0x2377F40")]
			remove
			{
				OwwNxycrqjcPdquUCatCFcMZTOnv(action);
			}
		}

		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x2377C0C", Offset = "0x2377C0C", VA = "0x2377C0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195AB4", Offset = "0x195AB4")]
		private void alVWABSXzsQaFVWiUaUWqyJviqJw(Action P_0)
		{
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x2377CB0", Offset = "0x2377CB0", VA = "0x2377CB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195AC4", Offset = "0x195AC4")]
		private void mBDbggZkJKDHaIFtaJuFWkPdhpdrA(Action P_0)
		{
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x2377D54", Offset = "0x2377D54", VA = "0x2377D54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195AD4", Offset = "0x195AD4")]
		private void JwcfJfaOLsKfZtOacLvkfWrCnUUfB(Action P_0)
		{
		}

		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x2377DF8", Offset = "0x2377DF8", VA = "0x2377DF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195AE4", Offset = "0x195AE4")]
		private void yMGTAHtJNYEIcHorwpREbqjiQaTlc(Action P_0)
		{
		}

		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x2376220", Offset = "0x2376220", VA = "0x2376220")]
		internal void kcliwPuXVLfgBTTJDHAEHhHnxyVU(Action P_0)
		{
		}

		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x2377E9C", Offset = "0x2377E9C", VA = "0x2377E9C")]
		internal void NbygqORNqcIzZyVXxGXzetijRFRB(Action P_0)
		{
		}

		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x23762C4", Offset = "0x23762C4", VA = "0x23762C4")]
		internal void aJEszINcAYFgMGCMrjUNpcKKUqEg(Action P_0)
		{
		}

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x2377F40", Offset = "0x2377F40", VA = "0x2377F40")]
		internal void OwwNxycrqjcPdquUCatCFcMZTOnv(Action P_0)
		{
		}

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x2377FE4", Offset = "0x2377FE4", VA = "0x2377FE4")]
		internal InputSource XFUmJxlJbofHIzhewRJutVjfhbPL()
		{
			return default;
		}

		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x2377FEC", Offset = "0x2377FEC", VA = "0x2377FEC")]
		public CustomInputSource(int P_0)
		{
		}

		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x23781F8", Offset = "0x23781F8", VA = "0x23781F8")]
		public void AddJoystick(Joystick joystick)
		{
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x23782C8", Offset = "0x23782C8", VA = "0x23782C8")]
		public IList<Joystick> GetJoysticks()
		{
			return null;
		}

		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x23782D0", Offset = "0x23782D0", VA = "0x23782D0", Slot = "5")]
		protected virtual void OnJoystickConnected()
		{
		}

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x23782E4", Offset = "0x23782E4", VA = "0x23782E4", Slot = "6")]
		protected virtual void OnJoystickDisconnected()
		{
		}

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x2377724", Offset = "0x2377724", VA = "0x2377724")]
		internal Joystick[] VLkpLxcdERXBKIOsaWtDTHIzOMAS()
		{
			return null;
		}

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x23782F8", Offset = "0x23782F8", VA = "0x23782F8", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x2378378", Offset = "0x2378378", VA = "0x2378378", Slot = "1")]
		~CustomInputSource()
		{
		}

		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x2378428", Offset = "0x2378428", VA = "0x2378428", Slot = "8")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000C98")]
		public abstract void Update();
	}
}
