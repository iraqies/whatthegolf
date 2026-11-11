using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SphericalGrayscaleEffect : MonoBehaviour
{
	public List<MultiplayerConfiguration.PlayerInfo> Positions = new List<MultiplayerConfiguration.PlayerInfo>();

	public List<float> Radii = new List<float>();

	public float MoveSpeed = 1f;

	public float NoiseScale = 1f;

	public float Intensity = 1f;

	public float OutlineSize = 2f;

	public float Offset;

	public Material material;

	private string[] shaderNamesPositions = new string[] { "_Position1", "_Position2" };

	private string[] shaderNamesRadius = new string[] { "_Radius1", "_Radius2" };

	private string[] shaderNamesColors = new string[] { "_Color1", "_Color2" };

	private void Awake()
	{
		Shader s = Shader.Find("Hidden/SphericalGrayscale");
		if (s != null)
		{
			material = new Material(s);
		}
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (material == null)
		{
			Graphics.Blit(source, destination);
			return;
		}
		material.SetFloat("_Intensity", Intensity);
		material.SetFloat("_NoiseScale", NoiseScale);
		material.SetFloat("_OutlineSize", OutlineSize);
		material.SetFloat("_Offset", Offset);
		if (Positions != null && Radii != null)
		{
			int count = Mathf.Min(Positions.Count, Radii.Count, shaderNamesPositions.Length);
			for (int i = 0; i < count; i++)
			{
				MultiplayerConfiguration.PlayerInfo p = Positions[i];
				if (p != null && p.Controllers != null && p.Controllers.Count > 0 && p.Controllers[0] != null && p.Cam != null && p.Cam.MainCamera != null)
				{
					Vector3 sp = p.Cam.MainCamera.WorldToScreenPoint(p.Controllers[0].transform.position);
					material.SetVector(shaderNamesPositions[i], sp);
				}
				material.SetFloat(shaderNamesRadius[i], Radii[i]);
				if (p != null && p.Avatar != null)
				{
					material.SetColor(shaderNamesColors[i], p.Avatar.BaseColor);
				}
			}
		}
		Graphics.Blit(source, destination, material);
	}

	public void AddOffset(float offset)
	{
		Offset += offset;
	}

	private void OnDestroy()
	{
		if (material != null)
		{
			Object.DestroyImmediate(material);
		}
	}
}
