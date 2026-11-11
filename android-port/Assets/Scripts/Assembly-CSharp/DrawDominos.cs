using System.Collections.Generic;
using UnityEngine;

public class DrawDominos : MonoBehaviour
{
	private Transform start;

	private Transform end;

	private Transform control;

	public Transform[] drawingPoints;

	public GameObject brush;

	private float totalLength;

	private float currentLength;

	public float stepDetail = 0.5f;

	private float t;

	public List<GameObject> dominos = new List<GameObject>();

	private int[] controlIndex;

	private int[] endIndex;

	public AnimationCurve dominoScale = AnimationCurve.Linear(0f, 1f, 1f, 1f);

	public bool resetOnOutOfBounds = true;

	public Transform endTransform;

	private float detail = 0.05f;

	public static float boxY = 1f;

	public bool followDomino = true;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		boxY = 0f;
	}

	private void Start()
	{
		if (drawingPoints == null || drawingPoints.Length == 0 || brush == null)
		{
			return;
		}
		dominos = new List<GameObject>();
		UpdateIndexes();
		start = transform;
		totalLength = 0f;
		int segCount = controlIndex != null && endIndex != null ? Mathf.Min(controlIndex.Length, endIndex.Length) : 0;
		for (int i = 0; i < segCount; i++)
		{
			int cIdx = controlIndex[i];
			int eIdx = endIndex[i];
			if (cIdx >= 0 && cIdx < drawingPoints.Length && eIdx >= 0 && eIdx < drawingPoints.Length)
			{
				control = drawingPoints[cIdx];
				end = drawingPoints[eIdx];
				totalLength += DetermineLength();
				start = end;
			}
		}
		start = transform;
		currentLength = 0f;
		for (int i = 0; i < segCount; i++)
		{
			int cIdx = controlIndex[i];
			int eIdx = endIndex[i];
			if (cIdx < 0 || cIdx >= drawingPoints.Length || eIdx < 0 || eIdx >= drawingPoints.Length)
			{
				continue;
			}
			control = drawingPoints[cIdx];
			end = drawingPoints[eIdx];
			float segLen = DetermineLength();
			if (segLen <= 0.001f)
			{
				start = end;
				continue;
			}
			detail = Mathf.Max(0.01f, stepDetail / segLen);
			while (t <= 1f)
			{
				currentLength += stepDetail;
				float normLen = totalLength > 0.001f ? Mathf.Clamp01(currentLength / totalLength) : 0f;
				float scaleVal = dominoScale != null && dominoScale.length > 0 ? dominoScale.Evaluate(normLen) : 1f;
				Vector3 pos = TweenFunctions.Bezier(start.position, control.position, end.position, t);
				Vector3 lookPos = TweenFunctions.Bezier(start.position, control.position, end.position, Mathf.Min(1f, t + detail));
				GameObject dom = Object.Instantiate(brush, pos, Quaternion.identity, transform);
				dom.transform.localScale *= scaleVal;
				if ((lookPos - pos).sqrMagnitude > 0.00001f)
				{
					dom.transform.LookAt(lookPos);
				}
				Vector3 adjustedPos = dom.transform.position;
				adjustedPos.y += boxY * dom.transform.localScale.y * 0.5f;
				dom.transform.position = adjustedPos;
				dominos.Add(dom);
				DominoBehavior beh = dom.GetComponent<DominoBehavior>();
				if (beh != null)
				{
					beh.dominoIndex = dominos.Count;
					beh.followMe = followDomino;
					beh.enabled = true;
				}
				Rigidbody rb = dom.GetComponent<Rigidbody>();
				if (rb != null)
				{
					rb.mass = Mathf.Max(0.1f, rb.mass * scaleVal);
				}
				t += detail;
			}
			t -= 1f;
			start = end;
		}
		if (endTransform == null && drawingPoints.Length > 0)
		{
			endTransform = drawingPoints[drawingPoints.Length - 1];
		}
	}

	private float DetermineLength()
	{
		if (start == null || control == null || end == null)
		{
			return 0f;
		}
		float len = 0f;
		for (int i = 0; i < 10; i++)
		{
			Vector3 p0 = TweenFunctions.Bezier(start.position, control.position, end.position, i / 10f);
			Vector3 p1 = TweenFunctions.Bezier(start.position, control.position, end.position, (i + 1) / 10f);
			len += Vector3.Distance(p0, p1);
		}
		return len;
	}

	private void OnDrawGizmos()
	{
	}

	private void UpdateIndexes()
	{
		if (drawingPoints == null || drawingPoints.Length == 0)
		{
			controlIndex = new int[0];
			endIndex = new int[0];
			return;
		}
		int count = drawingPoints.Length / 2;
		controlIndex = new int[count];
		endIndex = new int[count];
		for (int i = 0; i < count; i++)
		{
			controlIndex[i] = i * 2;
			endIndex[i] = i * 2 + 1;
		}
	}
}
