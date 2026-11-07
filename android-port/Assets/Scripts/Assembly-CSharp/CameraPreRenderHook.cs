using UnityEngine;
using UnityEngine.Events;

public class CameraPreRenderHook : MonoBehaviour
{
	public UnityAction onPrerender;

	private void OnPreRender()
	{
	}
}
