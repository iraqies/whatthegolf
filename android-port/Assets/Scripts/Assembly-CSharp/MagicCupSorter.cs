using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class MagicCupSorter : MonoBehaviour
{
	public List<Transform> ShowPositions;

	public List<Transform> HidePositions;

	public List<MagicCup> MagicCups;

	public int Iterations;

	public float Speed;

	public float MoveRange = 5f;

	private bool routineRunning;

	private IEnumerator Start()
	{
		GolfBallController ball = Object.FindObjectOfType<GolfBallController>();
		if (ball != null)
		{
			ball.enabled = false;
			Rigidbody component = ball.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = true;
			}
		}
		routineRunning = true;
		if (MagicCups != null && ShowPositions != null)
		{
			for (int i = 0; i < MagicCups.Count && i < ShowPositions.Count; i++)
			{
				if (MagicCups[i] != null && ShowPositions[i] != null)
				{
					MagicCups[i].transform.position = ShowPositions[i].position;
					MagicCups[i].transform.rotation = ShowPositions[i].rotation;
				}
			}
		}
		yield return new WaitForSecondsRealtime(1f);
		if (MagicCups != null)
		{
			foreach (MagicCup magicCup in MagicCups)
			{
				yield return StartCoroutine(ToggleCup(magicCup, false));
			}
		}
		yield return StartCoroutine(SortRoutine());
		routineRunning = false;
		if (ball != null)
		{
			ball.enabled = true;
			Rigidbody component2 = ball.GetComponent<Rigidbody>();
			if (component2 != null)
			{
				component2.isKinematic = false;
			}
		}
	}

	private IEnumerator SortRoutine()
	{
		for (int i = 0; i < Iterations; i++)
		{
			yield return StartCoroutine(SingleSortRoutine());
		}
	}

	private IEnumerator SingleSortRoutine()
	{
		if (MagicCups == null || MagicCups.Count < 2 || HidePositions == null)
		{
			yield break;
		}
		int idxA = Random.Range(0, MagicCups.Count);
		int idxB;
		if (idxA == 0)
		{
			idxB = Random.Range(1, MagicCups.Count);
		}
		else if (idxA == MagicCups.Count - 1)
		{
			idxB = Random.Range(0, MagicCups.Count - 2);
		}
		else if (Random.value > 0.5f)
		{
			idxB = Random.Range(idxA + 1, MagicCups.Count);
		}
		else
		{
			idxB = Random.Range(0, idxA);
		}
		float sign = Mathf.Sign(idxB - idxA);
		float dirA = ((Random.value > 0.5f) ? (0f - sign) : sign);
		float dirB = 0f - dirA;
		Transform startA = HidePositions[idxA];
		Transform startB = HidePositions[idxB];
		Vector3 midPos = startB.position + (startA.position - startB.position) * 0.5f;
		yield return StartCoroutine(pTween.To(Speed, delegate(float t)
		{
			if (MagicCups != null && idxA < MagicCups.Count && idxB < MagicCups.Count && startA != null && startB != null)
			{
				float t2 = Mathf.SmoothStep(0f, 1f, t);
				Vector3 p1 = new Vector3(midPos.x, midPos.y, midPos.z + dirA * MoveRange);
				MagicCups[idxA].Move(TweenFunctions.Bezier(startA.position, p1, startB.position, t2));
				Vector3 p2 = new Vector3(midPos.x, midPos.y, midPos.z + dirB * MoveRange);
				MagicCups[idxB].Move(TweenFunctions.Bezier(startB.position, p2, startA.position, t2));
			}
		}));
		MagicCup value = MagicCups[idxA];
		MagicCups[idxA] = MagicCups[idxB];
		MagicCups[idxB] = value;
	}

	public void TryShow(MagicCup cupHit)
	{
		if (!routineRunning)
		{
			StartCoroutine(ToggleCup(cupHit, true));
		}
	}

	private IEnumerator ToggleCup(MagicCup cupHit, bool showContents)
	{
		routineRunning = true;
		int idx = ((MagicCups != null) ? MagicCups.IndexOf(cupHit) : (-1));
		if (idx < 0 || ShowPositions == null || HidePositions == null || idx >= ShowPositions.Count || idx >= HidePositions.Count)
		{
			routineRunning = false;
			yield break;
		}
		Transform fromTr = (showContents ? HidePositions[idx] : ShowPositions[idx]);
		Transform toTr = (showContents ? ShowPositions[idx] : HidePositions[idx]);
		yield return new WaitForSeconds(0.3f);
		if (showContents && MagicCups[idx] != null)
		{
			MagicCups[idx].ShowContents();
		}
		yield return StartCoroutine(pTween.To(0.25f, delegate(float t)
		{
			if (MagicCups != null && idx < MagicCups.Count && MagicCups[idx] != null && fromTr != null && toTr != null)
			{
				float num = TweenFunctions.EaseIn(t);
				MagicCups[idx].Move(Vector3.Lerp(fromTr.position, toTr.position, Mathf.Clamp01(num)));
				MagicCups[idx].Rotate(Quaternion.Lerp(fromTr.rotation, toTr.rotation, num));
			}
		}));
		yield return null;
		if (!showContents && MagicCups[idx] != null)
		{
			MagicCups[idx].HideContents();
		}
		routineRunning = false;
	}
}
