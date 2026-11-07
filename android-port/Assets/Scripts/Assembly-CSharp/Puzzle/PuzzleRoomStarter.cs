using System.Collections.Generic;
using CameraStack;
using UnityEngine;

namespace Puzzle
{
	public class PuzzleRoomStarter : GolfBehaviour
	{
		private Collider2D col;

		private List<ITimedPuzzleObject> timedObjectsInArea;

		private List<PuzzleObjectBase> allPuzzleObjects;

		private OverworldCamera cam;

		private OverworldBall2D overworldBall;

		[SerializeField]
		private CBOverworldRoomStatic camBehavior;

		private Vector2 lastPointOfEntry;

		public Transform startPoint;

		public PhysicsMaterial2D originalMaterial;

		public PhysicsMaterial2D ballMaterialInPuzzle;

		public bool useStaticCamera;

		public bool isActive;

		public Vector2 GetStartPoint => default;

		public bool HasInitialized { get; private set; }

		public override void OnPrePlayOrPreCompile()
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		private void OnTriggerExit2D(Collider2D collision)
		{
		}
	}
}
