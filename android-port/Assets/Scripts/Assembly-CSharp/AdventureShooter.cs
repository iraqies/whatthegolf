using System;
using System.Collections.Generic;
using System.Linq;
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

	private int choiceIndex = -1;

	private void Start()
	{
		if (MainText != null)
		{
			textTyper = MainText.GetComponent<TextTyper>();
			if (textTyper != null && textTyper.PrintCompleted != null)
			{
				textTyper.PrintCompleted.AddListener(PrintCompleted);
			}
		}
		if (DialogueTree != null && DialogueTree.childCount > 0)
		{
			SetCurrentRoom(DialogueTree.GetChild(0));
		}
	}

	private void PrintCompleted()
	{
		if (Choices != null && currentRoom != null)
		{
			for (int i = 0; i < Choices.Count; i++)
			{
				if (Choices[i] == null)
					continue;
				Choices[i].SetActive(i < currentRoom.childCount);
				if (Choices[i].activeSelf)
				{
					Text choiceText = Choices[i].GetComponentInChildren<Text>();
					if (choiceText != null)
					{
						choiceText.text = currentRoom.GetChild(i).name;
					}
				}
			}

			if (currentRoom.childCount == 0 && Choices.Count > 0 && Choices[0] != null)
			{
				Choices[0].SetActive(true);
				Text endText = Choices[0].GetComponentInChildren<Text>();
				if (endText != null)
				{
					endText.text = "End";
				}
				winOnShot = true;
			}
		}
		hasFinishedPrinting = true;
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (Choices == null)
			return;

		int activeCount = Choices.Count(c => c != null && c.activeSelf);
		if (activeCount == 0)
			return;

		if (boost.magnitude < 0.6f)
		{
			if (MainText != null && MainText.text != null)
			{
				int lastIdx = MainText.text.LastIndexOf(">", StringComparison.Ordinal);
				if (lastIdx >= 0)
				{
					MainText.text = MainText.text.Remove(lastIdx) + ">";
				}
			}
			choiceIndex = -1;
			return;
		}

		float angle = Vector2.SignedAngle(new Vector2(boost.x, boost.y), Vector2.up);
		float step = 180f / activeCount;
		int idx = Mathf.FloorToInt((angle + 90f) / step);
		if (hasFinishedPrinting && idx >= 0 && currentRoom != null && idx < currentRoom.childCount && idx != choiceIndex)
		{
			if (MainText != null && MainText.text != null)
			{
				int lastIdx2 = MainText.text.LastIndexOf(">", StringComparison.Ordinal);
				if (lastIdx2 >= 0)
				{
					MainText.text = MainText.text.Remove(lastIdx2);
				}
			}
			choiceIndex = idx;
			if (textTyper != null)
			{
				textTyper.TypeText("> " + currentRoom.GetChild(idx).name + "\n", -1f);
			}
			hasFinishedPrinting = false;
		}
	}

	public override void OnCancel()
	{
		base.OnCancel();
		choiceIndex = -1;
	}

	public override void OnShoot(Vector3 boost)
	{
		if (boost.magnitude < 0.6f)
		{
			choiceIndex = -1;
			return;
		}

		base.OnShoot(boost);
		if (winOnShot)
		{
			if (Level.Instance != null && Level.Instance.Goal != null)
			{
				Level.Instance.Goal.Complete("HACKED!");
			}
		}
		else if (choiceIndex >= 0 && currentRoom != null && choiceIndex < currentRoom.childCount)
		{
			if (MainText != null)
			{
				MainText.text += "\n";
			}
			SetCurrentRoom(currentRoom.GetChild(choiceIndex));
			choiceIndex = -1;
		}

		if (Choices != null)
		{
			foreach (GameObject c in Choices)
			{
				if (c != null)
				{
					c.transform.localScale = Vector3.one;
					c.SetActive(false);
				}
			}
		}
	}

	private void Update()
	{
		if (Choices == null)
			return;

		for (int i = 0; i < Choices.Count; i++)
		{
			if (Choices[i] == null)
				continue;
			Vector3 targetScale = (i == choiceIndex) ? (Vector3.one * 1.2f) : Vector3.one;
			Choices[i].transform.localScale = Vector3.MoveTowards(Choices[i].transform.localScale, targetScale, Time.deltaTime * 30f);
		}
	}

	private void SetCurrentRoom(Transform room)
	{
		if (room == null)
			return;

		if (room.name != "Start")
		{
			if (MainText != null)
			{
				MainText.text = "<color=#ffffff44>" + MainText.text + "\n";
				if (currentRoom == null)
				{
					string added = "\n> " + room.name + "\n";
					MainText.text += added;
				}
			}
		}

		Text roomText = room.GetComponent<Text>();
		if (roomText != null && textTyper != null)
		{
			textTyper.TypeText(roomText.text + "\n\n>", 0.02f);
		}
		currentRoom = room;
	}

	private void OnDrawGizmos()
	{
		if (DialogueTree != null && DialogueTree.childCount > 0)
		{
			DrawRoomConnections(DialogueTree.GetChild(0));
		}
	}

	private void DrawRoomConnections(Transform room)
	{
		if (room == null)
			return;

		foreach (Transform child in room)
		{
			if (child != null)
			{
				Gizmos.DrawLine(room.position, child.position);
				DrawRoomConnections(child);
			}
		}
	}
}
