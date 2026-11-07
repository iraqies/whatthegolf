using System;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

namespace Challenges
{
	public class ChallengeGhostRecorder : Challenge
	{
		[Serializable]
		public class GhostData
		{
			public float time;

			public Vector3 position;

			public Quaternion rotation;

			public GhostData()
			{
			}

			public GhostData(float time, Transform transform)
			{
			}

			public static GhostData Lerp(GhostData data1, GhostData data2, float t)
			{
				return null;
			}
		}

		public List<GhostData> ghostDataList;

		public Transform ghostObject;

		private bool _isStarted;

		private float _timer;

		private float _nextTime;

		public float recordInterval;

		private GolfBallController _controller;

		public bool recordGhostData;

		private int _currentData;

		private GhostData _currentGhostData;

		private GhostData _nextGhostData;

		private bool _countingDown;

		private int _countTime;

		private bool _failed;

		private Vector3 _moveDelta;

		private Vector3 _oldPosition;

		private StopwatchSFX stopwatchSFX;

		public float sheepSpeed;

		[SerializeField]
		private float sheepHeightY;

		[SerializeField]
		private Rigidbody ghostRigid;

		[SerializeField]
		private bool usePhysicsToMove;

		protected override void Activate()
		{
		}

		protected override void ChallengeUpdate()
		{
		}

		private void Tick()
		{
		}

		public override void OnLevelComplete(Level.CompletedState completedState)
		{
		}

		private void RecordData()
		{
		}

		public override string GetDescription()
		{
			return null;
		}

		public override string GetWinMessageID()
		{
			return null;
		}
	}
}
