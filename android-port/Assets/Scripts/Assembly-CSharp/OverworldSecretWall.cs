using System.Collections;
using CameraStack;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OverworldSecretWall : MonoBehaviour
{
	public enum ButtonType
	{
		fromAbove = 0
	}

	public Transform bounds;

	public Tile groundTile;

	public ButtonType orientation;

	public GameObject fromTop;

	private bool isOpen;

	private GridFiller filler;

	private readonly string saveFormat;

	private OverworldCamera camera;

	public void Init(GridFiller gridFiller)
	{
	}

	private void Open(bool instant)
	{
	}

	private IEnumerator OpenRoutine(bool instant)
	{
		return null;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
