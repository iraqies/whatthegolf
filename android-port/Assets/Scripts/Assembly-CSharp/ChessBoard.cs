using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
	public Vector2 BoardSize;

	public Vector2 CellSize;

	public float CellPadding;

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

	public float MoveSpeed;

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
	}

	private void InstanceOnOnLevelComplete(Level.CompletedState s)
	{
	}

	private void ControllerOnOnAimUpdate(Vector3 boost, bool isCancelled)
	{
	}

	private void Controller_OnShoot(Vector3 boost)
	{
	}

	private Vector2 GetCellFromBoost(Vector3 boost)
	{
		return default;
	}

	private void Update()
	{
	}

	private IEnumerator StartMoving()
	{
		return null;
	}

	private IEnumerator StartMovingPlayer(Vector2 dest)
	{
		return null;
	}

	public void RestartLevel()
	{
	}

	public bool IsCellFree(Vector2 pos, Transform owner, bool canClaimPiece = true)
	{
		return false;
	}

	public ChessPiece GetPieceAt(Vector2 pos)
	{
		return null;
	}

	public void RegisterDiscard(Vector2 pieceAt)
	{
	}

	public void PlayMoveSFX(Vector3 pos)
	{
	}

	public void PlayDiscardStartSFX(Vector3 pos)
	{
	}

	public void PlayDiscardEndSFX(Vector3 pos)
	{
	}

	public bool RegisterMove(Vector3 from, Vector3 to, ChessPiece p)
	{
		return false;
	}

	public Vector3 CellToWorldPos(Vector2 cell)
	{
		return default;
	}

	public IEnumerator MoveHandToPiece(Transform p, bool isPlayerHand)
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
