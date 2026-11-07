using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CompletionLeaderboard : MonoBehaviour
{
	public bool doHide;

	public GameObject leaderboard;

	public Image background;

	public GameObject achievementsButton;

	public float transitionTime;

	public int outDy;

	private Vector3 inPos;

	private Vector3 outPos;

	private Color inColor;

	private Color outColor;

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	public IEnumerator TransitionIn()
	{
		return null;
	}

	public IEnumerator CoTransOutAndDisable()
	{
		return null;
	}

	public void TransOutAndDisable()
	{
	}

	private void Update()
	{
	}
}
