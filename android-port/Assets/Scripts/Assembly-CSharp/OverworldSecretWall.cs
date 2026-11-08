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
	private readonly string saveFormat = "secret_{0}";
	private OverworldCamera camera;

	public void Init(GridFiller gridFiller)
	{
		filler = gridFiller;
		if (bounds != null)
			bounds.gameObject.SetActive(false);
		if (fromTop != null)
			fromTop.SetActive(true);
	}

	private void Open(bool instant)
	{
		if (isOpen) return;
		isOpen = true;
		if (fromTop != null)
			fromTop.SetActive(false);
	}

	private IEnumerator OpenRoutine(bool instant)
	{
		Open(instant);
		yield break;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && collision.gameObject.GetComponentInParent<OverworldBall2D>() != null)
			Open(false);
	}

	private void OnDrawGizmosSelected()
	{
	}
}
