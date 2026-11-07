using UnityEngine;

public class LevelDotsUI : MonoBehaviour
{
	public int currentDotIndex;

	public Color inactiveColor;

	public Color activeColor;

	public float blinkFrequency;

	public float width;

	public LevelDot levelDotTemplate;

	private LevelDot[] dots;

	public void Initialize(int dotCount)
	{
	}

	private void Update()
	{
	}
}
