using Il2CppDummyDll;
using Rewired.Drivers.Interfaces;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired.ControllerExtensions
{
	[Token(Token = "0x20002B9")]
	public sealed class DualShock4Extension : Controller.Extension, IControllerVibrator, IDualShock4Extension
	{
		[Token(Token = "0x20002BA")]
		private class zGbxhXXgFWMcqcJRuIauEwjeRofV : IControllerExtensionSource
		{
			[Token(Token = "0x4000E76")]
			[FieldOffset(Offset = "0x10")]
			public readonly IDriver_DualShock4 UVnyPZOPqXebrkDwGURsMwQhOdVT;

			[Token(Token = "0x4000E77")]
			[FieldOffset(Offset = "0x18")]
			public readonly bool BMKmLgTjByiExXMvsepaerGfBiXH;

			[Token(Token = "0x4000E78")]
			[FieldOffset(Offset = "0x1C")]
			public readonly int IvQuNSqDypWdalUGYcleYiqEVPmd;
		}

		[Token(Token = "0x4000E73")]
		[FieldOffset(Offset = "0x28")]
		private zGbxhXXgFWMcqcJRuIauEwjeRofV eyyVWBZaxsCJCQMmwhCWcagfYfzWA;

		[Token(Token = "0x4000E74")]
		[FieldOffset(Offset = "0x30")]
		private bool OfwbAYIoZdGfvbuKLWzFcjGDPogfc;

		[Token(Token = "0x4000E75")]
		[FieldOffset(Offset = "0x38")]
		private TimerAbs[] IfVBCqaFujeIzJMUNQBcBKnduRXLA;

		[Token(Token = "0x17000563")]
		public int vibrationMotorCount
		{
			[Token(Token = "0x60013C7")]
			[Address(RVA = "0x23C7630", Offset = "0x23C7630", VA = "0x23C7630", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000564")]
		public int maxTouches
		{
			[Token(Token = "0x60013D3")]
			[Address(RVA = "0x23C8944", Offset = "0x23C8944", VA = "0x23C8944", Slot = "16")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x23C74F0", Offset = "0x23C74F0", VA = "0x23C74F0")]
		private DualShock4Extension(DualShock4Extension P_0)
		{
		}

		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x23C76F8", Offset = "0x23C76F8", VA = "0x23C76F8", Slot = "9")]
		public void SetVibration(int motorIndex, float motorLevel, float duration)
		{
		}

		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x23C7878", Offset = "0x23C7878", VA = "0x23C7878", Slot = "21")]
		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x60013CA")]
		[Address(RVA = "0x23C7700", Offset = "0x23C7700", VA = "0x23C7700", Slot = "10")]
		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x23C7BD0", Offset = "0x23C7BD0", VA = "0x23C7BD0", Slot = "11")]
		public void StopVibration()
		{
		}

		[Token(Token = "0x60013CC")]
		[Address(RVA = "0x23C7880", Offset = "0x23C7880", VA = "0x23C7880")]
		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x23C7E70", Offset = "0x23C7E70", VA = "0x23C7E70", Slot = "15")]
		public void SetLightColor(Color color)
		{
		}

		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x23C8128", Offset = "0x23C8128", VA = "0x23C8128")]
		public void SetLightFlash(float onDuration, float offDuration)
		{
		}

		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x23C8330", Offset = "0x23C8330", VA = "0x23C8330")]
		public void StopLightFlash()
		{
		}

		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x23C849C", Offset = "0x23C849C", VA = "0x23C849C", Slot = "12")]
		public Vector3 GetAccelerometerValue()
		{
			return default;
		}

		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x23C8628", Offset = "0x23C8628", VA = "0x23C8628", Slot = "13")]
		public Quaternion GetOrientation()
		{
			return default;
		}

		[Token(Token = "0x60013D2")]
		[Address(RVA = "0x23C87E8", Offset = "0x23C87E8", VA = "0x23C87E8", Slot = "14")]
		public void ResetOrientation()
		{
		}

		[Token(Token = "0x60013D4")]
		[Address(RVA = "0x23C8A98", Offset = "0x23C8A98", VA = "0x23C8A98", Slot = "17")]
		public int GetTouchId(int index)
		{
			return default;
		}

		[Token(Token = "0x60013D5")]
		[Address(RVA = "0x23C8C2C", Offset = "0x23C8C2C", VA = "0x23C8C2C", Slot = "18")]
		public bool GetTouchPosition(int index, out Vector2 position)
		{
			return default;
		}

		[Token(Token = "0x60013D6")]
		[Address(RVA = "0x23C8DE0", Offset = "0x23C8DE0", VA = "0x23C8DE0", Slot = "19")]
		public bool IsTouching(int index)
		{
			return default;
		}

		[Token(Token = "0x60013D7")]
		[Address(RVA = "0x23C8F74", Offset = "0x23C8F74", VA = "0x23C8F74", Slot = "20")]
		public bool IsTouchingByTouchId(int touchId)
		{
			return default;
		}

		[Token(Token = "0x60013D8")]
		[Address(RVA = "0x23C9108", Offset = "0x23C9108", VA = "0x23C9108", Slot = "6")]
		internal void PwSVyxiNOmkyuuXUHWyuymUyabog(UpdateLoopType P_0)
		{
		}

		[Token(Token = "0x60013D9")]
		[Address(RVA = "0x23C9200", Offset = "0x23C9200", VA = "0x23C9200", Slot = "5")]
		internal void EJfWkXMMYTRfEHNEnCEaDzBnFICoA(IControllerExtensionSource P_0)
		{
		}

		[Token(Token = "0x60013DA")]
		[Address(RVA = "0x23C92B8", Offset = "0x23C92B8", VA = "0x23C92B8", Slot = "7")]
		internal Controller.Extension vpHGhDFXfrFPnKJBKRFCgbudEJvBB()
		{
			return null;
		}

		[Token(Token = "0x60013DB")]
		[Address(RVA = "0x23C914C", Offset = "0x23C914C", VA = "0x23C914C")]
		private void RkjJWtCPffqNHKYZiSpumVKUPDFy()
		{
		}

		[Token(Token = "0x60013DC")]
		[Address(RVA = "0x23C7D98", Offset = "0x23C7D98", VA = "0x23C7D98")]
		private void uLJgIUZWcYRvIJfnwylMTtjINIBA(DualShock4MotorType P_0, float P_1, float P_2)
		{
		}
	}
}
