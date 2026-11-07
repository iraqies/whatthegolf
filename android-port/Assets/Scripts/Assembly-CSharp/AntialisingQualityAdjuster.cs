using Core;
using UnityEngine;

public class AntialisingQualityAdjuster : MonoBehaviour
{
	private float _startTime;

	private float _endTime;

	private int _startFrameCount;

	private bool _started;

	private const float MEASURE_DURATION = 2f;

	private const float MEASURE_DELAY = 2f;

	private const string QUALITY_MEASURED_KEY = "QUALITY_MEASURED";

	public void Init()
	{
	}

	public void OnLevelStarted(LevelData level)
	{
	}

	public void OnLevelEnded()
	{
	}

	private void Update()
	{
	}

	private void Deactivate()
	{
	}

	private void LowerAntialisingIfNecessary(float fps)
	{
	}
}
