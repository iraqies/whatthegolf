using System.Collections.Generic;
using Core;
using RedBlueGames.Tools.TextTyper;
using UnityEngine;
using UnityEngine.UI;

public class AdventureShooter : GolfBall2DShooterBase
{
	public Transform DialogueTree;

	public Text MainText;

	public List<GameObject> Choices;

	private Transform currentRoom;

	private bool winOnShot;

	private TextTyper textTyper;

	private bool hasFinishedPrinting;

	private int choiceIndex;

	private void Start()
	{
	}

	private void PrintCompleted()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void Update()
	{
	}

	private void SetCurrentRoom(Transform room)
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void DrawRoomConnections(Transform room)
	{
	}
}
