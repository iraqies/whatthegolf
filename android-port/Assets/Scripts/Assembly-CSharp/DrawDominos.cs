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

	public float stepDetail;

	private float t;

	public List<GameObject> dominos;

	private int[] controlIndex;

	private int[] endIndex;

	public AnimationCurve dominoScale;

	public bool resetOnOutOfBounds;

	public Transform endTransform;

	private float detail;

	public static float boxY;

	public bool followDomino;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Start()
	{
	}

	private float DetermineLength()
	{
		return 0f;
	}

	private void OnDrawGizmos()
	{
	}

	private void UpdateIndexes()
	{
	}
}
