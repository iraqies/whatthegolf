using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FPSIndicator : MonoBehaviour
{
	public Image Indicator;

	public Canvas Canvas;

	public TextMeshProUGUI fpsText;

	private float deltaTime;

	private float holdTimer;

	private float frameCount;

	private float dt;

	private float fps;

	private float updateRate;

	private void Update()
	{
	}

	private bool CheckFps(float fps, int from, int to, Color color)
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void EnableIndicator()
	{
	}

	public void DisableIndicator()
	{
	}

	public void SetActiveIndicator(bool enable)
	{
	}
}
