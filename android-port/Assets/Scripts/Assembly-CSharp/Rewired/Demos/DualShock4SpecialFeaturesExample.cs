using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.ControllerExtensions;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x2001164")]
	public class DualShock4SpecialFeaturesExample : MonoBehaviour
	{
		[Token(Token = "0x2001165")]
		private class Touch
		{
			[Token(Token = "0x4005BF9")]
			[FieldOffset(Offset = "0x10")]
			public GameObject go;

			[Token(Token = "0x4005BFA")]
			[FieldOffset(Offset = "0x18")]
			public int touchId;

			[Token(Token = "0x6004F74")]
			[Address(RVA = "0x179DE50", Offset = "0x179DE50", VA = "0x179DE50")]
			public Touch()
			{
			}
		}

		[Token(Token = "0x2001166")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47E6C", Offset = "0x47E6C")]
		private sealed class _003C_003Ec__DisplayClass20_0
		{
			[Token(Token = "0x4005BFB")]
			[FieldOffset(Offset = "0x10")]
			public int touchId;

			[Token(Token = "0x6004F75")]
			[Address(RVA = "0x179DE24", Offset = "0x179DE24", VA = "0x179DE24")]
			public _003C_003Ec__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6004F76")]
			[Address(RVA = "0x179DE2C", Offset = "0x179DE2C", VA = "0x179DE2C")]
			internal bool _003CHandleTouchpad_003Eb__0(Touch x)
			{
				return default;
			}
		}

		[Token(Token = "0x4005BF0")]
		private const int maxTouches = 2;

		[Token(Token = "0x4005BF1")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		[Token(Token = "0x4005BF2")]
		[FieldOffset(Offset = "0x20")]
		public Transform touchpadTransform;

		[Token(Token = "0x4005BF3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject lightObject;

		[Token(Token = "0x4005BF4")]
		[FieldOffset(Offset = "0x30")]
		public Transform accelerometerTransform;

		[Token(Token = "0x4005BF5")]
		[FieldOffset(Offset = "0x38")]
		private List<Touch> touches;

		[Token(Token = "0x4005BF6")]
		[FieldOffset(Offset = "0x40")]
		private Queue<Touch> unusedTouches;

		[Token(Token = "0x4005BF7")]
		[FieldOffset(Offset = "0x48")]
		private bool isFlashing;

		[Token(Token = "0x4005BF8")]
		[FieldOffset(Offset = "0x50")]
		private GUIStyle textStyle;

		[Token(Token = "0x1700088D")]
		private Player player
		{
			[Token(Token = "0x6004F68")]
			[Address(RVA = "0x14372E8", Offset = "0x14372E8", VA = "0x14372E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F69")]
		[Address(RVA = "0x1437364", Offset = "0x1437364", VA = "0x1437364")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004F6A")]
		[Address(RVA = "0x143758C", Offset = "0x143758C", VA = "0x143758C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F6B")]
		[Address(RVA = "0x143892C", Offset = "0x143892C", VA = "0x143892C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6004F6C")]
		[Address(RVA = "0x1438640", Offset = "0x1438640", VA = "0x1438640")]
		private void ResetOrientation()
		{
		}

		[Token(Token = "0x6004F6D")]
		[Address(RVA = "0x1438454", Offset = "0x1438454", VA = "0x1438454")]
		private void SetRandomLightColor()
		{
		}

		[Token(Token = "0x6004F6E")]
		[Address(RVA = "0x1438848", Offset = "0x1438848", VA = "0x1438848")]
		private void StartLightFlash()
		{
		}

		[Token(Token = "0x6004F6F")]
		[Address(RVA = "0x143876C", Offset = "0x143876C", VA = "0x143876C")]
		private void StopLightFlash()
		{
		}

		[Token(Token = "0x6004F70")]
		[Address(RVA = "0x1437BAC", Offset = "0x1437BAC", VA = "0x1437BAC")]
		private IDualShock4Extension GetFirstDS4(Player player)
		{
			return null;
		}

		[Token(Token = "0x6004F71")]
		[Address(RVA = "0x1437368", Offset = "0x1437368", VA = "0x1437368")]
		private void InitializeTouchObjects()
		{
		}

		[Token(Token = "0x6004F72")]
		[Address(RVA = "0x1437F10", Offset = "0x1437F10", VA = "0x1437F10")]
		private void HandleTouchpad(IDualShock4Extension ds4)
		{
		}

		[Token(Token = "0x6004F73")]
		[Address(RVA = "0x143934C", Offset = "0x143934C", VA = "0x143934C")]
		public DualShock4SpecialFeaturesExample()
		{
		}
	}
}
