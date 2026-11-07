using UnityEngine;

public class SetHoleColor : MonoBehaviour
{
	public enum HoleColorEnum
	{
		FreezerArea = 0,
		SnowArea = 1,
		GrassArea = 2,
		GolfGreenGrass = 3,
		GreenTiles = 4
	}

	public SpriteRenderer holeSprite;

	public HoleColorEnum holeColor;

	private void Awake()
	{
	}

	private void SetColor(string str)
	{
	}
}
