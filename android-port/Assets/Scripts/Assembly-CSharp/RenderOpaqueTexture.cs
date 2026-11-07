using UnityEngine;
using UnityEngine.Rendering;

public class RenderOpaqueTexture : MonoBehaviour
{
	private Camera m_Camera;

	private CommandBuffer m_CommandBuffer;

	public Camera camera => null;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}
}
