using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
	[Serializable]
	public class MovementType
	{
		public Vector2 Movement;

		public int Steps;
	}

	public List<MovementType> Movement;

	public Vector2 CurrentCell;

	public Transform OwnerHand;

	public ChessBoard ChessBoard;

	public bool Test;

	public ParticleSystem SmashParticles;

	private Rigidbody rigid;

	private Collider collider;

	private PerlinShake shake;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		collider = GetComponent<Collider>();
		shake = GetComponent<PerlinShake>();
	}

	private void Update()
	{
	}

	public Vector2 GetRandomMove()
	{
		List<Vector2> moves = GetValidMoves();
		if (moves == null || moves.Count == 0)
		{
			return CurrentCell;
		}
		return moves[UnityEngine.Random.Range(0, moves.Count)];
	}

	public virtual List<Vector2> GetValidMoves()
	{
		List<Vector2> valid = new List<Vector2>();
		if (ChessBoard == null || Movement == null)
		{
			return valid;
		}
		for (int i = 0; i < Movement.Count; i++)
		{
			MovementType mt = Movement[i];
			if (mt == null)
			{
				continue;
			}
			int maxSteps = Mathf.Max(1, mt.Steps);
			for (int s = 1; s <= maxSteps; s++)
			{
				Vector2 candidate = CurrentCell + mt.Movement * s;
				if (ChessBoard.IsCellFree(candidate, OwnerHand, true))
				{
					valid.Add(candidate);
					if (ChessBoard.GetPieceAt(candidate) != null)
					{
						break;
					}
				}
				else
				{
					break;
				}
			}
		}
		return valid;
	}

	public virtual IEnumerator DoMove(Vector2 dest)
	{
		if (ChessBoard == null)
		{
			yield break;
		}
		yield return StartCoroutine(TryDiscardPiece(dest));
		Vector3 startPos = transform.position;
		Vector3 endPos = ChessBoard.CellToWorldPos(dest);
		endPos.y = startPos.y;
		ChessBoard.RegisterMove(CurrentCell, dest, this);
		CurrentCell = dest;
		float duration = Mathf.Max(0.15f, 1f / Mathf.Max(1f, ChessBoard.MoveSpeed));
		float t = 0f;
		while (t < duration)
		{
			t += Time.deltaTime;
			float n = Mathf.Clamp01(t / duration);
			Vector3 pos = Vector3.Lerp(startPos, endPos, n);
			pos.y += Mathf.Sin(n * Mathf.PI) * 1.5f;
			transform.position = pos;
			yield return null;
		}
		transform.position = endPos;
		ChessBoard.PlayMoveSFX(endPos);
		if (SmashParticles != null)
		{
			SmashParticles.Play();
		}
	}

	public IEnumerator DiscardPiece()
	{
		if (ChessBoard != null)
		{
			ChessBoard.PlayDiscardStartSFX(transform.position);
		}
		if (rigid != null)
		{
			rigid.isKinematic = false;
			rigid.AddForce(Vector3.up * 8f + UnityEngine.Random.insideUnitSphere * 4f, ForceMode.VelocityChange);
		}
		yield return new WaitForSeconds(0.5f);
		if (ChessBoard != null)
		{
			ChessBoard.PlayDiscardEndSFX(transform.position);
		}
		gameObject.SetActive(false);
	}

	private IEnumerator TryDiscardPiece(Vector2 coord)
	{
		if (ChessBoard == null)
		{
			yield break;
		}
		ChessPiece existing = ChessBoard.GetPieceAt(coord);
		if (existing != null && existing != this)
		{
			ChessBoard.RegisterDiscard(coord);
			yield return StartCoroutine(existing.DiscardPiece());
		}
	}
}
