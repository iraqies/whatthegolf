using Il2CppDummyDll;
using UnityEngine;

namespace StylizedWater
{
	[Token(Token = "0x20000CE")]
	public class StylizedWaterRenderer : Object
	{
		[Token(Token = "0x20000CF")]
		public class RendererSettings
		{
			[Token(Token = "0x4000457")]
			[FieldOffset(Offset = "0x10")]
			public LayerMask renderLayer;

			[Token(Token = "0x4000458")]
			[FieldOffset(Offset = "0x14")]
			public int renderTexureSize;

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x13563FC", Offset = "0x13563FC", VA = "0x13563FC")]
			public RendererSettings()
			{
			}
		}

		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x0")]
		private static bool debug;

		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x18")]
		private RendererSettings settings;

		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x20")]
		private GameObject targetObject;

		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 targetSize;

		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 targetCenterPosition;

		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture _rt;

		[Token(Token = "0x4000454")]
		private const int CLIP_PLANE_PADDING = 20;

		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x8")]
		private static Material _intersectionMaskMat;

		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x10")]
		private static Material _opacityMaskMat;

		[Token(Token = "0x170000CB")]
		private RenderTexture rt
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x1400F48", Offset = "0x1400F48", VA = "0x1400F48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x13FF404", Offset = "0x13FF404", VA = "0x13FF404")]
		public void SetupMaskRenderer(RendererSettings settings, MeshRenderer r, out Camera renderCam, out Vector4 targetMeshInfo)
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x140102C", Offset = "0x140102C", VA = "0x140102C")]
		private Vector4 GetMeshInfo(MeshRenderer r)
		{
			return default;
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1401558", Offset = "0x1401558", VA = "0x1401558")]
		private Camera SetupRenderCam()
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x14017D8", Offset = "0x14017D8", VA = "0x14017D8")]
		private RenderTexture RenderCamToTexture(Camera renderCam)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x13FF388", Offset = "0x13FF388", VA = "0x13FF388")]
		public StylizedWaterRenderer()
		{
		}
	}
}
