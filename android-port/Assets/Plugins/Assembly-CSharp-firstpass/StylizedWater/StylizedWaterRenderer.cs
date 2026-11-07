using UnityEngine;

namespace StylizedWater
{
	public class StylizedWaterRenderer : Object
	{
		public class RendererSettings
		{
			public LayerMask renderLayer;

			public int renderTexureSize;
		}

		private static bool debug;

		private RendererSettings settings;

		private GameObject targetObject;

		private Vector3 targetSize;

		private Vector3 targetCenterPosition;

		private RenderTexture _rt;

		private const int CLIP_PLANE_PADDING = 20;

		private static Material _intersectionMaskMat;

		private static Material _opacityMaskMat;

		private RenderTexture rt => null;

		public void SetupMaskRenderer(RendererSettings settings, MeshRenderer r, out Camera renderCam, out Vector4 targetMeshInfo)
		{
			renderCam = null;
			targetMeshInfo = default;
		}

		private Vector4 GetMeshInfo(MeshRenderer r)
		{
			return default;
		}

		private Camera SetupRenderCam()
		{
			return null;
		}

		private RenderTexture RenderCamToTexture(Camera renderCam)
		{
			return null;
		}
	}
}
