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
	private readonly string saveFormat = "SECRET_WALL_{0}";
	private OverworldCamera camera;

	public void Init(GridFiller gridFiller)
	{
		if (Camera.main != null)
			camera = Camera.main.gameObject.GetComponentInParent<OverworldCamera>();
		filler = gridFiller;
		if (bounds != null)
			bounds.gameObject.SetActive(false);

		if (filler != null && filler.groundMap != null)
		{
			Vector3Int cell = filler.groundMap.WorldToCell(transform.position);
			Vector3 world = filler.groundMap.CellToWorld(cell);
			Vector3 cs = filler.groundMap.cellSize;
			transform.position = new Vector3(world.x + cs.x * 0.5f, world.y + cs.x * 0.5f, world.z);
		}

		if (orientation == ButtonType.fromAbove && fromTop != null)
			fromTop.SetActive(true);

		if (filler != null && filler.groundMap != null)
		{
			Vector3Int cell = filler.groundMap.WorldToCell(transform.position);
			string key = string.Format(saveFormat, cell);
			if (SaveGame.GetValue(key, false))
			{
				isOpen = true;
				StartCoroutine(OpenRoutine(true));
			}
		}
	}

	private void Open(bool instant)
	{
		if (!instant && isOpen) return;
		StartCoroutine(OpenRoutine(instant));
	}

	private IEnumerator OpenRoutine(bool instant)
	{
		if (!instant && camera != null)
			camera.Shake(0.2f, 20f, 3f);

		if (filler == null || filler.groundMap == null)
		{
			if (fromTop != null) fromTop.SetActive(false);
			gameObject.SetActive(false);
			yield break;
		}

		Vector3Int startCell = filler.groundMap.WorldToCell(transform.position);
		if (fromTop != null)
			fromTop.SetActive(false);

		bool startedCarving = false;
		int curY = startCell.y;
		Tilemap curGround = filler.currentGroundMap;

		while (curY > startCell.y - 150)
		{
			int x = startCell.x;
			Vector3Int centerPos = new Vector3Int(x, curY, 0);
			Vector3Int leftPos = new Vector3Int(x - 1, curY, 0);
			Vector3Int rightPos = new Vector3Int(x + 1, curY, 0);

			if (startedCarving && curGround != null && curGround.HasTile(centerPos))
			{
				if (filler.tileMaps != null && filler.tileMaps.Count > 0)
				{
					var tmData = filler.tileMaps[0];
					if (filler.innerCornerBottomLeft != null)
						filler.innerCornerBottomLeft.SetTile(new Vector3Int(x - 1, curY + 1, 0), tmData.borderRoundBottomRight);
					if (filler.innerCornerBottomRight != null)
						filler.innerCornerBottomRight.SetTile(new Vector3Int(x + 1, curY + 1, 0), tmData.borderRoundBottomLeft);
				}
				break;
			}

			if (curGround != null)
				curGround.SetTile(centerPos, groundTile);
			if (filler.tileMaps != null && filler.tileMaps.Count > 0)
			{
				var tmData = filler.tileMaps[0];
				if (filler.leftBorder != null)
					filler.leftBorder.SetTile(leftPos, tmData.borderSideLeft);
				if (filler.rightBorder != null)
					filler.rightBorder.SetTile(rightPos, tmData.borderSideRight);
			}
			if (filler.topBorder != null)
				filler.topBorder.SetTile(centerPos, null);
			if (filler.bottomBorder != null)
				filler.bottomBorder.SetTile(centerPos, null);
			if (filler.bottomCornerLeftBorder != null)
				filler.bottomCornerLeftBorder.SetTile(leftPos, null);
			if (filler.bottomCornerRightBorder != null)
				filler.bottomCornerRightBorder.SetTile(rightPos, null);

			startedCarving = true;
			if (!instant)
				yield return new WaitForSecondsRealtime(0.03f);
			curY--;
		}

		gameObject.SetActive(false);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.gameObject == null) return;
		var ball = collision.gameObject.GetComponent<OverworldBall2D>();
		if (ball == null || !ball.CheckUseInteractiveThing())
			return;

		if (filler != null && filler.groundMap != null)
		{
			Vector3Int cell = filler.groundMap.WorldToCell(transform.position);
			string key = string.Format(saveFormat, cell);
			SaveGame.SetValue(key, true, false);
			SaveGame.Save(false);
		}
		if (!isOpen)
			StartCoroutine(OpenRoutine(false));

		var rb = ball.GetComponent<Rigidbody2D>();
		if (rb != null)
		{
			Vector2 bounce = (Vector2.up + rb.velocity.normalized) * rb.velocity.magnitude;
			rb.velocity = bounce * 0.16f;
		}
	}

	private void OnDrawGizmosSelected()
	{
	}
}
