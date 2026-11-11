using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
	public Vector2 BoardSize = new Vector2(8f, 8f);

	public Vector2 CellSize = new Vector2(2f, 2f);

	public float CellPadding = 0.1f;

	public Dictionary<Vector2, ChessPiece> BoardCells;

	public bool Test;

	public Transform Hand;

	public Transform PlayerHand;

	public Transform SmashHand;

	public Transform PlayerBasket;

	public Transform ComputerBasket;

	public ParticleSystem MoveParticles;

	public bool AlwaysChooseWinningMove;

	public bool LockKingIfPlayerCanTakeHim;

	public float MoveSpeed = 4f;

	public RandomAudioClips DiscardEndSFX;

	public RandomAudioClips DiscardStartClips;

	public RandomAudioClips MoveClips;

	private List<ChessPiece> chessPieces;

	private GolfBallController controller;

	private ChessPiece playerPiece;

	private GolfBallShooterExperimental shooter;

	private bool levelHasBeenCompleted;

	private bool gameOver;

	private void Start()
	{
		BoardCells = new Dictionary<Vector2, ChessPiece>();
		chessPieces = new List<ChessPiece>(GetComponentsInChildren<ChessPiece>());
		for (int i = 0; i < chessPieces.Count; i++)
		{
			ChessPiece p = chessPieces[i];
			if (p == null)
			{
				continue;
			}
			p.ChessBoard = this;
			BoardCells[p.CurrentCell] = p;
			if (p.GetComponent<GolfBallController>() != null)
			{
				playerPiece = p;
				controller = p.GetComponent<GolfBallController>();
				shooter = p.GetComponent<GolfBallShooterExperimental>();
			}
		}
		if (controller == null)
		{
			controller = Object.FindObjectOfType<GolfBallController>();
		}
		if (controller != null)
		{
			controller.OnAimUpdate += ControllerOnOnAimUpdate;
			controller.OnShoot += Controller_OnShoot;
		}
		if (Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.OnComplete += InstanceOnOnLevelComplete;
		}
	}

	private void InstanceOnOnLevelComplete(Level.CompletedState s)
	{
		levelHasBeenCompleted = true;
		gameOver = true;
	}

	private void ControllerOnOnAimUpdate(Vector3 boost, bool isCancelled)
	{
		if (boost.magnitude >= 0.1f && (GetCellFromBoost(boost) - Vector2.zero).sqrMagnitude >= 1E-10f)
		{
			Vector3 vector = CellToWorldPos(GetCellFromBoost(boost) + playerPiece.CurrentCell);
			MoveParticles.transform.position = vector;
			playerPiece.transform.rotation = Quaternion.RotateTowards(playerPiece.transform.rotation, Quaternion.LookRotation(new Vector3(vector.x - playerPiece.transform.position.x, 0f, vector.z - playerPiece.transform.position.z)), Time.deltaTime * 500f);
		}
		else
		{
			MoveParticles.transform.position = new Vector3(-100f, 100f, 100f);
		}
	}

	private void Controller_OnShoot(Vector3 boost)
	{
		if (gameOver || levelHasBeenCompleted || playerPiece == null)
		{
			return;
		}
		Vector2 dest = GetCellFromBoost(boost);
		StartCoroutine(StartMovingPlayer(dest));
	}

	private Vector2 GetCellFromBoost(Vector3 boost)
	{
		if (playerPiece == null)
		{
			return Vector2.zero;
		}
		Vector2 step = new Vector2(Mathf.Round(boost.x * 2f), Mathf.Round(boost.z * 2f));
		Vector2 target = playerPiece.CurrentCell + step;
		target.x = Mathf.Clamp(target.x, 0f, Mathf.Max(0f, BoardSize.x - 1f));
		target.y = Mathf.Clamp(target.y, 0f, Mathf.Max(0f, BoardSize.y - 1f));
		return target;
	}

	private void Update()
	{
		if (Test)
		{
			Test = false;
			StartCoroutine(StartMoving());
		}
	}

	private IEnumerator StartMoving()
	{
		if (gameOver || levelHasBeenCompleted || chessPieces == null)
		{
			yield break;
		}
		List<ChessPiece> aiPieces = new List<ChessPiece>();
		for (int i = 0; i < chessPieces.Count; i++)
		{
			ChessPiece p = chessPieces[i];
			if (p != null && p.gameObject.activeInHierarchy && p != playerPiece)
			{
				aiPieces.Add(p);
			}
		}
		if (aiPieces.Count > 0)
		{
			ChessPiece chosen = aiPieces[Random.Range(0, aiPieces.Count)];
			Vector2 move = chosen.GetRandomMove();
			if (move != chosen.CurrentCell)
			{
				yield return StartCoroutine(MoveHandToPiece(chosen.transform, false));
				yield return StartCoroutine(chosen.DoMove(move));
			}
		}
	}

	private IEnumerator StartMovingPlayer(Vector2 dest)
	{
		if (playerPiece == null)
		{
			yield break;
		}
		yield return StartCoroutine(MoveHandToPiece(playerPiece.transform, true));
		yield return StartCoroutine(playerPiece.DoMove(dest));
		if (!levelHasBeenCompleted && !gameOver)
		{
			yield return StartCoroutine(StartMoving());
		}
	}

	public void RestartLevel()
	{
		if (Level.HasInstance && Level.Instance != null)
		{
			Level.Instance.Fail(true);
		}
	}

	public bool IsCellFree(Vector2 pos, Transform owner, bool canClaimPiece = true)
	{
		if (pos.x < 0f || pos.y < 0f || pos.x >= BoardSize.x || pos.y >= BoardSize.y)
		{
			return false;
		}
		ChessPiece p = GetPieceAt(pos);
		if (p == null)
		{
			return true;
		}
		return canClaimPiece && p.OwnerHand != owner;
	}

	public ChessPiece GetPieceAt(Vector2 pos)
	{
		if (BoardCells != null && BoardCells.TryGetValue(pos, out ChessPiece p) && p != null && p.gameObject.activeInHierarchy)
		{
			return p;
		}
		return null;
	}

	public void RegisterDiscard(Vector2 pieceAt)
	{
		if (BoardCells != null && BoardCells.TryGetValue(pieceAt, out ChessPiece p))
		{
			BoardCells.Remove(pieceAt);
			if (p == playerPiece)
			{
				gameOver = true;
				RestartLevel();
			}
		}
	}

	public void PlayMoveSFX(Vector3 pos)
	{
		if (MoveClips != null)
		{
			AudioManager.PlaySFX(MoveClips, pos);
		}
		if (MoveParticles != null)
		{
			MoveParticles.transform.position = pos;
			MoveParticles.Play();
		}
	}

	public void PlayDiscardStartSFX(Vector3 pos)
	{
		if (DiscardStartClips != null)
		{
			AudioManager.PlaySFX(DiscardStartClips, pos);
		}
	}

	public void PlayDiscardEndSFX(Vector3 pos)
	{
		if (DiscardEndSFX != null)
		{
			AudioManager.PlaySFX(DiscardEndSFX, pos);
		}
	}

	public bool RegisterMove(Vector3 from, Vector3 to, ChessPiece p)
	{
		Vector2 fromCell = new Vector2(from.x, from.y);
		Vector2 toCell = new Vector2(to.x, to.y);
		if (BoardCells != null)
		{
			if (BoardCells.TryGetValue(fromCell, out ChessPiece cur) && cur == p)
			{
				BoardCells.Remove(fromCell);
			}
			BoardCells[toCell] = p;
		}
		return true;
	}

	public Vector3 CellToWorldPos(Vector2 cell)
	{
		float x = (cell.x - (BoardSize.x - 1f) * 0.5f) * (CellSize.x + CellPadding);
		float z = (cell.y - (BoardSize.y - 1f) * 0.5f) * (CellSize.y + CellPadding);
		return transform.TransformPoint(new Vector3(x, 0f, z));
	}

	public IEnumerator MoveHandToPiece(Transform p, bool isPlayerHand)
	{
		Transform hand = isPlayerHand ? PlayerHand : Hand;
		if (hand == null || p == null)
		{
			yield break;
		}
		Vector3 start = hand.position;
		Vector3 end = p.position + Vector3.up * 1.5f;
		float t = 0f;
		while (t < 0.2f)
		{
			t += Time.deltaTime;
			hand.position = Vector3.Lerp(start, end, t / 0.2f);
			yield return null;
		}
		hand.position = end;
	}

	private void OnDrawGizmosSelected()
	{
		if (BoardCells == null)
		{
			return;
		}
		for (int i = 0; (float)i < BoardSize.y; i++)
		{
			for (int j = 0; (float)j < BoardSize.x; j++)
			{
				Gizmos.color = ((BoardCells[new Vector2(j, i)] != null) ? Color.green : Color.red);
				Gizmos.DrawWireCube(CellToWorldPos(new Vector2(j, i)), new Vector3(CellSize.x, 1f, CellSize.y));
			}
		}
	}
}
