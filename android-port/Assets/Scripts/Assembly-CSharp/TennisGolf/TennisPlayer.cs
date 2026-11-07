using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TennisGolf
{
	public class TennisPlayer : MonoBehaviour
	{
		public Rigidbody TennisBall;

		public Transform TennisCourt;

		public Transform CenterOfOtherSide;

		public float CourtSize;

		public List<GameObject> PlayerTrophies;

		public List<GameObject> OpponentTrophies;

		public GameObject FlagObject;

		public float ShotAngle;

		public float JumpHeight;

		public float JumpDuration;

		private TennisBall ball;

		private float enableCollisionTimer;

		private Rigidbody rigid;

		private Vector3 lastDirection;

		private Transform model;

		private void Awake()
		{
		}

		private void OnAimUpdate(Vector3 boost, bool b)
		{
		}

		private void Update()
		{
		}

		private IEnumerator DelayedWin()
		{
			return null;
		}

		public void OnPlayerWon()
		{
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		private IEnumerator ModelJump()
		{
			return null;
		}
	}
}
