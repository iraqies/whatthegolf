using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x2001168")]
	public class FallbackJoystickIdentificationDemo : MonoBehaviour
	{
		[Token(Token = "0x4005C05")]
		private const float windowWidth = 250f;

		[Token(Token = "0x4005C06")]
		private const float windowHeight = 250f;

		[Token(Token = "0x4005C07")]
		private const float inputDelay = 1f;

		[Token(Token = "0x4005C08")]
		[FieldOffset(Offset = "0x18")]
		private bool identifyRequired;

		[Token(Token = "0x4005C09")]
		[FieldOffset(Offset = "0x20")]
		private Queue<Joystick> joysticksToIdentify;

		[Token(Token = "0x4005C0A")]
		[FieldOffset(Offset = "0x28")]
		private float nextInputAllowedTime;

		[Token(Token = "0x4005C0B")]
		[FieldOffset(Offset = "0x30")]
		private GUIStyle style;

		[Token(Token = "0x6004F7D")]
		[Address(RVA = "0x145D43C", Offset = "0x145D43C", VA = "0x145D43C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004F7E")]
		[Address(RVA = "0x145D6AC", Offset = "0x145D6AC", VA = "0x145D6AC")]
		private void JoystickConnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6004F7F")]
		[Address(RVA = "0x145D6B0", Offset = "0x145D6B0", VA = "0x145D6B0")]
		private void JoystickDisconnected(ControllerStatusChangedEventArgs args)
		{
		}

		[Token(Token = "0x6004F80")]
		[Address(RVA = "0x145D590", Offset = "0x145D590", VA = "0x145D590")]
		public void IdentifyAllJoysticks()
		{
		}

		[Token(Token = "0x6004F81")]
		[Address(RVA = "0x145D6C0", Offset = "0x145D6C0", VA = "0x145D6C0")]
		private void SetInputDelay()
		{
		}

		[Token(Token = "0x6004F82")]
		[Address(RVA = "0x145D6F0", Offset = "0x145D6F0", VA = "0x145D6F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6004F83")]
		[Address(RVA = "0x145D9F4", Offset = "0x145D9F4", VA = "0x145D9F4")]
		private void DrawDialogWindow(int windowId)
		{
		}

		[Token(Token = "0x6004F84")]
		[Address(RVA = "0x145D6B4", Offset = "0x145D6B4", VA = "0x145D6B4")]
		private void Reset()
		{
		}

		[Token(Token = "0x6004F85")]
		[Address(RVA = "0x145DD8C", Offset = "0x145DD8C", VA = "0x145DD8C")]
		public FallbackJoystickIdentificationDemo()
		{
		}
	}
}
