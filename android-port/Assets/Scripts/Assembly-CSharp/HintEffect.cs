using CameraStack;
using UnityEngine;

public class HintEffect : MonoBehaviour
{
	[SerializeField]
	private TrailRenderer trailTemplate;

	[SerializeField]
	private AudioClip sound;

	private TrailRenderer[] trails;

	private OverworldCamera camera;

	private static HintEffect instance;

	public static HintEffect Instance => null;

	public void Play(Vector3 centerPosition, Vector3[] outerPositions)
	{
	}

	private void Expand(int size)
	{
	}

	public static void Initialize(OverworldCamera camera)
	{
	}
}
