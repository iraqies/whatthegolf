using UnityEngine;

[ExecuteInEditMode]
public class SteppedHeightFogEffect : MonoBehaviour
{
	private Shader shader;

	private Material material;

	public float fogStartHeight = -200f;

	public float fogStopHeight = 80f;

	public int stepPower = 85;

	public bool useCameraClearColor = true;

	public Color fogColor;

	public bool skyMask = true;

	private void SetMaterialValues()
	{
		if (material == null)
		{
			return;
		}
		material.SetFloat("_FogMinHeight", fogStartHeight);
		material.SetFloat("_FogMaxHeight", fogStopHeight);
		Color c = fogColor;
		if (useCameraClearColor)
		{
			Camera cam = GetComponent<Camera>();
			if (cam != null)
			{
				c = cam.backgroundColor;
			}
		}
		material.SetColor("_FogColor", c);
		material.SetInt("_StepStrength", stepPower);
		if (skyMask)
		{
			material.EnableKeyword("_SKYMASK_ON");
		}
		else
		{
			material.DisableKeyword("_SKYMASK_ON");
		}
	}

	private void Start()
	{
		CreateMaterial();
		SetMaterialValues();
	}

	private void CreateMaterial()
	{
		shader = Shader.Find("WhatTheGolf/Stepped Height Fog");
		if (shader != null)
		{
			material = new Material(shader);
		}
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (material != null)
		{
			Graphics.Blit(source, destination, material);
		}
		else
		{
			Graphics.Blit(source, destination);
		}
	}

	private void OnValidate()
	{
		if (material == null)
		{
			CreateMaterial();
		}
		SetMaterialValues();
	}
}
