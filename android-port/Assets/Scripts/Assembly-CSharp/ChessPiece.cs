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
	}

	private void Update()
	{
	}

	public Vector2 GetRandomMove()
	{
		return default;
	}

	public virtual List<Vector2> GetValidMoves()
	{
		return null;
	}

	public virtual IEnumerator DoMove(Vector2 dest)
	{
		return null;
	}

	public IEnumerator DiscardPiece()
	{
		return null;
	}

	private IEnumerator TryDiscardPiece(Vector2 coord)
	{
		return null;
	}
}
