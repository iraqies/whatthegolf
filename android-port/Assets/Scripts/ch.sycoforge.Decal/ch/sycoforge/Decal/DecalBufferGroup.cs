using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace ch.sycoforge.Decal
{
	internal class DecalBufferGroup
	{
		public RenderTargetIdentifier[] RenderTargets;

		public RenderTargetIdentifier[] RenderTargetsHDR;

		public HashSet<EasyDecal> Decals;

		public DeferredFlags Flags;

		public int PassIndex;

		public RenderTargetIdentifier[] GetTargets(Camera camera)
		{
			return null;
		}

		public static int GetPassIndex(DeferredFlags flags)
		{
			return 0;
		}

		public static RenderTargetIdentifier[] GetRenderTargets(DeferredFlags flags, bool hdr)
		{
			return null;
		}

		private static BuiltinRenderTextureType FlagToTarget(DeferredFlags flag)
		{
			return BuiltinRenderTextureType.None;
		}
	}
}
