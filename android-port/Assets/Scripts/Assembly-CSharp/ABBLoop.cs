using System.Collections.Generic;
using UnityEngine;

public class ABBLoop : MonoBehaviour
{
	[SerializeField]
	private AudioSource start;

	[SerializeField]
	private List<AudioSource> loop;

	[SerializeField]
	private float firstTransitionTime;

	[SerializeField]
	private float loopTransitionTime;

	private bool isLooping;

	private int currentIndex;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
