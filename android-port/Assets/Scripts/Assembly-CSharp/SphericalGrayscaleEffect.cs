using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SphericalGrayscaleEffect : MonoBehaviour
{
	public List<MultiplayerConfiguration.PlayerInfo> Positions;

	public List<float> Radii;

	public float MoveSpeed;

	public float NoiseScale;

	public float Intensity;

	public float OutlineSize;

	public float Offset;

	public Material material;

	private string[] shaderNamesPositions;

	private string[] shaderNamesRadius;

	private string[] shaderNamesColors;

	private void Awake()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	public void AddOffset(float offset)
	{
	}

	private void OnDestroy()
	{
	}
}
