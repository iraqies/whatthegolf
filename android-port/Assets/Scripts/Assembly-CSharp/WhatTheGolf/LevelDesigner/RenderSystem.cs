using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001258")]
	internal sealed class RenderSystem : BaseSystem
	{
		[Token(Token = "0x40062C0")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<RenderEvent, List<IRequireRender>> s_Consumers;

		[Token(Token = "0x40062C1")]
		[FieldOffset(Offset = "0x8")]
		private static RenderTextureDescriptor s_Descriptor;

		[Token(Token = "0x40062C2")]
		[FieldOffset(Offset = "0x40")]
		public static Action<RenderTexture> OnScreenshotRequest;

		[Token(Token = "0x6005493")]
		[Address(RVA = "0x1648C34", Offset = "0x1648C34", VA = "0x1648C34")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x713D4", Offset = "0x713D4")]
		private static void InitOnLoad()
		{
		}

		[Token(Token = "0x6005494")]
		[Address(RVA = "0x1648D1C", Offset = "0x1648D1C", VA = "0x1648D1C")]
		public static void QueueDrawsAtEvent(RenderEvent renderEvent, bool isScreenshot)
		{
		}

		[Token(Token = "0x6005495")]
		[Address(RVA = "0x1648EAC", Offset = "0x1648EAC", VA = "0x1648EAC")]
		public static Texture2D TakeScreenshot()
		{
			return null;
		}

		[Token(Token = "0x6005496")]
		[Address(RVA = "0x1648F7C", Offset = "0x1648F7C", VA = "0x1648F7C", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005497")]
		[Address(RVA = "0x1648F80", Offset = "0x1648F80", VA = "0x1648F80", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6005498")]
		[Address(RVA = "0x1648F84", Offset = "0x1648F84", VA = "0x1648F84", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005499")]
		[Address(RVA = "0x1648FD0", Offset = "0x1648FD0", VA = "0x1648FD0")]
		public static void Register(RenderEvent renderEvent, IRequireRender consumer)
		{
		}

		[Token(Token = "0x600549A")]
		[Address(RVA = "0x1649130", Offset = "0x1649130", VA = "0x1649130")]
		public static void Unregister(RenderEvent renderEvent, IRequireRender consumer)
		{
		}

		[Token(Token = "0x600549B")]
		[Address(RVA = "0x164921C", Offset = "0x164921C", VA = "0x164921C")]
		public RenderSystem()
		{
		}
	}
}
