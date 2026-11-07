using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Selectables;

namespace WhatTheGolf.LevelDesigner.Managers
{
	public sealed class SelectableManager : BaseManager, IRequireSerialization, IRequireEvents<GameStateEvent>, IRequireEvents, IRequireEvents<PlayEvent>
	{
		private CameraManager m_CameraManager;

		private GizmoManager m_GizmoManager;

		[SerializeField]
		private GameObject m_DeleteParticles;

		private bool m_Initialized;

		private WhatTheGolf.LevelDesigner.Selectables.Ball m_Ball;

		private Goal m_Goal;

		private List<Selectable> m_Selectables;

		private Selectable m_CurrentSelection;

		private Dictionary<Selectable, (Vector3, Quaternion, CollisionDetectionMode, bool, RigidbodyInterpolation)> m_SelectableStates;

		private Color32 m_GizmoColor;

		private bool isResetting;

		private float transitionDuration;

		public CameraManager cameraManager => null;

		public GizmoManager gizmoManager => null;

		public WhatTheGolf.LevelDesigner.Selectables.Ball ball => null;

		public Goal goal => null;

		public Selectable currentSelection => null;

		public List<Selectable> selectables => null;

		public override void Init()
		{
		}

		private void Update()
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		public void OnEvent(PlayEvent evt)
		{
		}

		public void Load(LevelContentData levelData)
		{
		}

		public void Save(LevelContentData levelData)
		{
		}

		private void StoreSelectableState(Selectable selectable)
		{
		}

		public void HandleOutOfBounds(string message)
		{
		}

		private IEnumerator ResetLevel()
		{
			return null;
		}

		private IEnumerator WaitThen(float wait, Action action)
		{
			return null;
		}

		public void OnHitFlag(string message)
		{
		}

		public void HandleOutOfBounds()
		{
		}

		public void SetBall(int ballID)
		{
		}

		public void SetBall(BallDefinition ballDefinition)
		{
		}

		public Selectable CreateSelectable(int elementId, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		public Selectable CreateSelectable(SelectableDefinition selectableDefinition, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		private Selectable CreateSelectable(SelectableDefinition selectableDefinition, Vector3 position, Quaternion rotation, Guid guid)
		{
			return null;
		}

		public void ReplaceSelectedSelectable(int newElementId)
		{
		}

		public void ReplaceSelectable(int newElementId, Selectable selectable)
		{
		}

		public void DeleteSelectable(Selectable selectable, Action onComplete = null)
		{
		}

		private IEnumerator WaitForReturn(GameObject obj)
		{
			return null;
		}

		public void SetSelection(Selectable selectable)
		{
		}

		public void DeleteSelection()
		{
		}

		public bool IsWithinRadiusOfSelectable(Vector3 position, float radius)
		{
			return false;
		}
	}
}
