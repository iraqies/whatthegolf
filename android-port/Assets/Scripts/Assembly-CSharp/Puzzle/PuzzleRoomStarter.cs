using System.Collections.Generic;
using CameraStack;
using Chronos;
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

		public bool useStaticCamera = true;

		public bool isActive;

		public Vector2 GetStartPoint => (startPoint != null) ? ((Vector2)startPoint.position) : lastPointOfEntry;

		public bool HasInitialized { get; private set; }

		public override void OnPrePlayOrPreCompile()
		{
			base.OnPrePlayOrPreCompile();
			camBehavior = GetComponentInChildren<CBOverworldRoomStatic>();
		}

		private void Awake()
		{
			col = GetComponent<Collider2D>();
			if (camBehavior != null && col != null)
			{
				camBehavior.SetOrthoSize(Mathf.Ceil(col.bounds.extents.y) + 1f);
			}
			timedObjectsInArea = new List<ITimedPuzzleObject>();
			allPuzzleObjects = new List<PuzzleObjectBase>();
			Transform[] componentsInChildren = GetComponentsInChildren<Transform>(true);
			if (componentsInChildren == null)
			{
				return;
			}
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				Transform transform = componentsInChildren[i];
				if (transform == null)
				{
					continue;
				}
				PuzzleObjectBase component = transform.GetComponent<PuzzleObjectBase>();
				if (component != null)
				{
					allPuzzleObjects.Add(component);
				}
				ITimedPuzzleObject component2 = transform.GetComponent<ITimedPuzzleObject>();
				if (component2 != null)
				{
					timedObjectsInArea.Add(component2);
				}
			}
		}

		private void Update()
		{
			if (!isActive || !Input.GetKeyDown(KeyCode.R))
			{
				return;
			}
			if (allPuzzleObjects != null)
			{
				for (int i = 0; i < allPuzzleObjects.Count; i++)
				{
					if (allPuzzleObjects[i] != null)
					{
						allPuzzleObjects[i].ResetObject();
					}
				}
			}
			if (overworldBall != null)
			{
				if (overworldBall.rigidBody != null)
				{
					overworldBall.rigidBody.velocity = Vector2.zero;
				}
				Vector2 getStartPoint = GetStartPoint;
				overworldBall.transform.position = new Vector3(getStartPoint.x, getStartPoint.y, 0f);
			}
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (HasInitialized || collision == null)
			{
				return;
			}
			if (cam == null)
			{
				cam = Object.FindObjectOfType<OverworldCamera>();
			}
			OverworldBall2D component = collision.GetComponent<OverworldBall2D>();
			if (component == null)
			{
				return;
			}
			overworldBall = component;
			if (overworldBall.rigidBody != null)
			{
				overworldBall.rigidBody.sharedMaterial = ballMaterialInPuzzle;
			}
			lastPointOfEntry = overworldBall.transform.position;
			if (camBehavior != null && useStaticCamera && cam != null)
			{
				cam.OnRoomEnter(camBehavior);
			}
			LocalClock component2 = overworldBall.GetComponent<LocalClock>();
			if (component2 != null && timedObjectsInArea != null)
			{
				for (int i = 0; i < timedObjectsInArea.Count; i++)
				{
					timedObjectsInArea[i]?.SetClock(component2);
				}
			}
			isActive = true;
			if (allPuzzleObjects != null)
			{
				for (int j = 0; j < allPuzzleObjects.Count; j++)
				{
					if (allPuzzleObjects[j] != null)
					{
						allPuzzleObjects[j].isBallInArea = true;
						allPuzzleObjects[j].OnBallEnter(overworldBall);
					}
				}
			}
			HasInitialized = true;
		}

		private void OnTriggerExit2D(Collider2D collision)
		{
			if (collision == null)
			{
				return;
			}
			OverworldBall2D component = collision.GetComponent<OverworldBall2D>();
			if (component == null)
			{
				return;
			}
			if (cam != null)
			{
				cam.OnRoomExit();
			}
			if (component.rigidBody != null)
			{
				component.rigidBody.sharedMaterial = originalMaterial;
			}
			if (allPuzzleObjects != null)
			{
				for (int i = 0; i < allPuzzleObjects.Count; i++)
				{
					if (allPuzzleObjects[i] != null)
					{
						allPuzzleObjects[i].isBallInArea = false;
						allPuzzleObjects[i].OnBallLeave();
					}
				}
			}
			HasInitialized = false;
			isActive = false;
		}
	}
}
