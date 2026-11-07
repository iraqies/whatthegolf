using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rewired.Platforms.Custom
{
	public abstract class CustomInputSource : IDisposable
	{
		public abstract class Controller
		{
			protected bool _isConnected;

			protected string _deviceName;

			protected string _customName;

			public string customName => null;

			public bool isConnected => false;

			public string deviceName => null;

			protected Controller(string P_0)
			{
			}

			public void Disconnect()
			{
			}

			public abstract void Update();
		}

		public abstract class Joystick : Controller
		{
			private long? orGeZnHyIQImwrQbTiysYDyAvZUR;

			private int xmEXVfyENtoyjKLfjizpdurnqqpi;

			private readonly Axis[] gmjcdmbtDXKatrtMKrVjuasYTyOh;

			private readonly Button[] YXuCILbbSuGPNMGgRTZoPeQmcMPsA;

			private readonly ReadOnlyCollection<Axis> cBSHMOCbWzIiiaZpZEDfrfjPCNNab;

			private readonly ReadOnlyCollection<Button> tnwAAWkpEQQDOblRgOpzbinWPPbqc;

			private bool OlbVRqsSBEtRqSittUWERZaqzxXk;

			private Rewired.Controller.Extension ieNssgrFeJiIpjsZwbsJdGwhvyJU;

			public long? systemId
			{
				get
				{
					return null;
				}
				protected set
				{
				}
			}

			public int unityId => 0;

			public IList<Axis> Axes => null;

			public IList<Button> Buttons => null;

			public bool supportsVibration
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public Rewired.Controller.Extension extension
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public int buttonCount => 0;

			public int axisCount => 0;

			public Joystick(string P_0, long? P_1, int P_2, int P_3, int P_4)
				: base(null)
			{
			}

			public virtual float GetAxisValue(int index)
			{
				return 0f;
			}

			public virtual bool GetButtonValue(int index)
			{
				return false;
			}
		}

		public abstract class Element
		{
		}

		public sealed class Axis : Element
		{
			public float value;
		}

		public sealed class Button : Element
		{
			public bool value;
		}

		private readonly InputSource mKGFJudopEcewqKpuxRtaCtIVgIn;

		private readonly List<Joystick> lacEMsSikdfQQWUospJtpSoUfDdS;

		private readonly ReadOnlyCollection<Joystick> STDYSyyforIsYvzkZoBubRXRkbEE;

		private bool CJusUpshQKVHuGVwEaiCDFqiDoUFA;

		private Action nOYSRzstOJbWcLYZLMjrCoJoGBEN__BackingField;

		private Action SLDNNFtlUUCYOMZYUcmjzNuvBZei__BackingField;

		private bool AeWaeWamxRrERkciQkpFDWbRfZMkA;

		public bool useApproximateMatching
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		internal InputSource twtzIKfuPcwLuTdbfRDPmfUOUduI => XFUmJxlJbofHIzhewRJutVjfhbPL();

		public abstract bool isReady { get; }

		private event Action nOYSRzstOJbWcLYZLMjrCoJoGBEN
		{
			add
			{
				alVWABSXzsQaFVWiUaUWqyJviqJw(action);
			}
			remove
			{
				mBDbggZkJKDHaIFtaJuFWkPdhpdrA(action);
			}
		}

		private event Action SLDNNFtlUUCYOMZYUcmjzNuvBZei
		{
			add
			{
				JwcfJfaOLsKfZtOacLvkfWrCnUUfB(action);
			}
			remove
			{
				yMGTAHtJNYEIcHorwpREbqjiQaTlc(action);
			}
		}

		internal event Action IjBZhVnpMDVJOoHiocMFmfzWUjXD
		{
			add
			{
				kcliwPuXVLfgBTTJDHAEHhHnxyVU(action);
			}
			remove
			{
				NbygqORNqcIzZyVXxGXzetijRFRB(action);
			}
		}

		internal event Action bEQVXqVyYwXaKGcXFdnuHwwjmrcf
		{
			add
			{
				aJEszINcAYFgMGCMrjUNpcKKUqEg(action);
			}
			remove
			{
				OwwNxycrqjcPdquUCatCFcMZTOnv(action);
			}
		}

		private void alVWABSXzsQaFVWiUaUWqyJviqJw(Action P_0)
		{
		}

		private void mBDbggZkJKDHaIFtaJuFWkPdhpdrA(Action P_0)
		{
		}

		private void JwcfJfaOLsKfZtOacLvkfWrCnUUfB(Action P_0)
		{
		}

		private void yMGTAHtJNYEIcHorwpREbqjiQaTlc(Action P_0)
		{
		}

		internal void kcliwPuXVLfgBTTJDHAEHhHnxyVU(Action P_0)
		{
		}

		internal void NbygqORNqcIzZyVXxGXzetijRFRB(Action P_0)
		{
		}

		internal void aJEszINcAYFgMGCMrjUNpcKKUqEg(Action P_0)
		{
		}

		internal void OwwNxycrqjcPdquUCatCFcMZTOnv(Action P_0)
		{
		}

		internal InputSource XFUmJxlJbofHIzhewRJutVjfhbPL()
		{
			return InputSource.None;
		}

		public CustomInputSource(int P_0)
		{
		}

		public void AddJoystick(Joystick joystick)
		{
		}

		public IList<Joystick> GetJoysticks()
		{
			return null;
		}

		protected virtual void OnJoystickConnected()
		{
		}

		protected virtual void OnJoystickDisconnected()
		{
		}

		internal Joystick[] VLkpLxcdERXBKIOsaWtDTHIzOMAS()
		{
			return null;
		}

		public virtual void Dispose()
		{
		}

		~CustomInputSource()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public abstract void Update();
	}
}
