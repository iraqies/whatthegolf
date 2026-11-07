using System.Collections.Generic;
using UnityEngine;

namespace Triband.Splines
{
	[ExecuteInEditMode]
	public sealed class SplineSpawner : MonoBehaviour
	{
		private enum ObjectSource
		{
			Array = 0,
			StartCap = 1,
			EndCap = 2
		}

		public delegate void OnUpdateDelegate();

		[SerializeField]
		private Spline m_Spline;

		[SerializeField]
		private SplineSpawnerSettings m_Settings;

		[SerializeField]
		private List<GameObject> m_Objects;

		private const string kEditorSettingsKey = "Triband.Splines.SplineSpawnerEditorSettings";
		private const float kMinDistance = 0.1f;

		private bool m_IsDirty;
		private List<(SplineValue, float)> m_EvaluationCache;

		public OnUpdateDelegate onSpawnerUpdated;

		public SplineSpawnerSettings Settings => m_Settings;

		public Spline spline
		{
			get => m_Spline != null ? m_Spline : GetComponent<Spline>();
			set => m_Spline = value;
		}

		private void OnEnable()
		{
			if (m_Spline == null) m_Spline = GetComponent<Spline>();
		}

		private void OnDisable() { }
		private void SubscribeToSplineEvents() { }
		private void UnsubscribeToSplineEvents() { }
		public void Reset() { }
		private void Update() { }
		public void Evaluate() { }
		internal void SetDirty() => m_IsDirty = true;
		internal void OnSplineChanged() { }
		private void EvaluateSplineCount() { }
		private void EvaluateSplineLength() { }
		private void SpawnOrGetObject(SplineValue value, float t, int count, int seed, ObjectSource objectSource) { }
		private Vector3 GetPosition(SplineValue value, float t, int seed) => value.position;
		private Quaternion GetRotation(SplineValue value, float t, int index, int seed) => value.rotation;
		private Vector3 GetScale(SplineValue value, float t, int seed) => Vector3.one;
		private float GetStartOffset() => 0f;
		private float GetEndOffset() => 0f;
	}
}
