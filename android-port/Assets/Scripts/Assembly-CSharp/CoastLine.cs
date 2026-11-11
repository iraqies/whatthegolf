using System;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class CoastLine : MonoBehaviour
{
	[Serializable]
	public class LineContainer
	{
		public LineRenderer Line;

		public List<Vector3> Points = new List<Vector3>();

		public List<Vector3> Directions = new List<Vector3>();

		public Color StartColor;

		public Color EndColor;
	}

	public float Distance = 1f;

	public float Spacing = 0.5f;

	public bool ConnectEndAndStart;

	public AnimationCurve PositionEvaluation = AnimationCurve.Linear(0f, 0f, 1f, 1f);

	public AnimationCurve AlphaEvaluation = AnimationCurve.Linear(0f, 1f, 1f, 0f);

	public int Count = 2;

	public float TimeDuration = 3f;

	public int CornerVertices = 2;

	private LineRenderer originalLineRenderer;

	private List<LineContainer> copies = new List<LineContainer>();

	private void Awake()
	{
		originalLineRenderer = GetComponent<LineRenderer>();
		if (originalLineRenderer == null)
		{
			return;
		}
		Vector3[] origPositions = new Vector3[originalLineRenderer.positionCount];
		originalLineRenderer.GetPositions(origPositions);
		copies = new List<LineContainer>();
		for (int i = 0; i < Count; i++)
		{
			LineContainer container = new LineContainer();
			GameObject go = new GameObject("CoastLine Copy " + i);
			go.transform.SetParent(transform, false);
			LineRenderer lr = go.AddComponent<LineRenderer>();
			lr.sharedMaterial = originalLineRenderer.sharedMaterial;
			lr.widthMultiplier = originalLineRenderer.widthMultiplier;
			lr.widthCurve = originalLineRenderer.widthCurve;
			lr.colorGradient = originalLineRenderer.colorGradient;
			lr.numCapVertices = originalLineRenderer.numCapVertices;
			lr.alignment = originalLineRenderer.alignment;
			lr.textureMode = originalLineRenderer.textureMode;
			lr.sortingLayerID = originalLineRenderer.sortingLayerID;
			lr.sortingOrder = originalLineRenderer.sortingOrder;
			lr.useWorldSpace = originalLineRenderer.useWorldSpace;
			lr.loop = ConnectEndAndStart;
			lr.numCornerVertices = CornerVertices;

			container.Line = lr;
			container.StartColor = lr.startColor;
			container.EndColor = lr.endColor;
			container.Points = new List<Vector3>(origPositions);
			container.Directions = new List<Vector3>(origPositions.Length);
			for (int j = 0; j < origPositions.Length; j++)
			{
				Vector3 prev = origPositions[(j - 1 + origPositions.Length) % origPositions.Length];
				Vector3 next = origPositions[(j + 1) % origPositions.Length];
				Vector3 tangent = (next - prev).normalized;
				Vector3 normal = new Vector3(-tangent.z, 0f, tangent.x).normalized;
				container.Directions.Add(normal);
			}
			lr.positionCount = origPositions.Length;
			lr.SetPositions(origPositions);
			copies.Add(container);
		}
		originalLineRenderer.enabled = false;
	}

	private void Update()
	{
		if (copies == null || copies.Count == 0 || TimeDuration <= 0.001f)
		{
			return;
		}
		for (int i = 0; i < copies.Count; i++)
		{
			LineContainer c = copies[i];
			if (c == null || c.Line == null)
			{
				continue;
			}
			float phase = ((Time.time + i * (TimeDuration / Mathf.Max(1, copies.Count))) % TimeDuration) / TimeDuration;
			float posEval = PositionEvaluation != null ? PositionEvaluation.Evaluate(phase) : phase;
			float alphaEval = AlphaEvaluation != null ? AlphaEvaluation.Evaluate(phase) : 1f - phase;
			float offsetDist = posEval * Distance + i * Spacing;
			for (int j = 0; j < c.Points.Count; j++)
			{
				c.Line.SetPosition(j, c.Points[j] + c.Directions[j] * offsetDist);
			}
			Color sc = c.StartColor;
			sc.a = alphaEval;
			Color ec = c.EndColor;
			ec.a = alphaEval;
			c.Line.startColor = sc;
			c.Line.endColor = ec;
		}
	}
}
