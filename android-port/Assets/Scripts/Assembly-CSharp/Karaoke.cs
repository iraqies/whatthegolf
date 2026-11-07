using System.Collections;
using Core;
using UnityEngine;

public class Karaoke : MonoBehaviour
{
	[SerializeField]
	private uint startState;

	[SerializeField]
	private float endX;

	[SerializeField]
	private float boundsY;

	[SerializeField]
	private KaraokeWord[] words;

	[SerializeField]
	private GolfGoal golfGoal;

	[SerializeField]
	private AudioSource loopAudioSource;

	[SerializeField]
	private GolfBallController golfBallController;

	[SerializeField]
	private Karaoke2DShooter ball;

	private Transform ballTransform;

	private Level level;

	private bool wasGrounded;

	private bool hasShot;

	private KaraokeWord activeWord;

	private MusicManager music;

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private KaraokeWord FindWord(float x)
	{
		return null;
	}
}
