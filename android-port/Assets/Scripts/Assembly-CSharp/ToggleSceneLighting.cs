using System.Collections.Generic;
using Core;
using UnityEngine;

public class ToggleSceneLighting : MonoBehaviour
{
	public GolfBallController Controller;

	public Camera MainCamera;

	public Color CameraOffColor;

	public Light DirectionalLight;

	public float LightOffIntensity;

	public List<AudioClip> ToggleClips;

	private float lightOnIntensity;

	private Color cameraOnColor;

	private bool lightState;

	private void Start()
	{
	}

	public void Toggle(bool lightOn)
	{
	}
}
