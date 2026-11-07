using UnityEngine;

namespace Puzzle
{
	public class LazerJoint : MonoBehaviour
	{
		public LineRenderer line;

		public float width;

		public LayerMask layerMask;

		public float length;

		public ParticleSystem particles;

		public bool emit;

		private Vector3 emitDirection;

		private float nextBallhit;

		private Vector3 emitPosition;

		private PuzzleSwitchLaser laserSwitch;

		public SimplePortal enterPortal;

		public SimplePortal exitPortal;

		public void Init(Vector3 startpos, Quaternion rotation, SimplePortal enterPortal = null)
		{
		}

		private void Update()
		{
		}

		public void SetJointEmission(bool emit)
		{
		}

		private void FixedUpdate()
		{
		}

		private void HandleHit(RaycastHit2D hit)
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
