using System;
using System.Collections.Generic;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	internal sealed class RenderSystem : BaseSystem
	{
		private static Dictionary<RenderEvent, List<IRequireRender>> s_Consumers;

		private static RenderTextureDescriptor s_Descriptor;

		public static Action<RenderTexture> OnScreenshotRequest;

		[RuntimeInitializeOnLoadMethod]
		private static void InitOnLoad()
		{
		}

		public static void QueueDrawsAtEvent(RenderEvent renderEvent, bool isScreenshot)
		{
		}

		public static Texture2D TakeScreenshot()
		{
			return null;
		}

		public override void Init()
		{
		}

		public override void Update()
		{
		}

		public override void Dispose()
		{
		}

		public static void Register(RenderEvent renderEvent, IRequireRender consumer)
		{
		}

		public static void Unregister(RenderEvent renderEvent, IRequireRender consumer)
		{
		}
	}
}
