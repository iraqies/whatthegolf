using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotForStore : MonoBehaviour
{
	public string KeyToTake;

	public bool saveLayers;

	public bool useShadowPlaneForLayers;

	public float shadowPlaneHeight;

	public float shadowOpacity;

	public bool useCustomDepthLayer;

	public GameObject depthLayer;

	public bool useClearBackground;

	public int layersOnRuntime;

	private MeshRenderer m_ShadowPlaneRenderer;

	private Material m_ShadowPlaneMaterial;

	private const float kShadowPlaneScale = 1000f;

	[SerializeField]
	private Shader m_ShadowPlaneShader;

	private bool m_ShadowPlaneValid => false;

	private IEnumerator Start()
	{
		return null;
	}

	private List<GameObject> GetRoots()
	{
		return null;
	}

	private void TakeScreenShot()
	{
	}

	private void CreateShadowPlane()
	{
	}

	private void CleanupShadowPlane()
	{
	}
}
