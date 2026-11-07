using Chronos;
using UnityEngine;

public class SetTimelineScale : MonoBehaviour
{
	public string timeline;

	public static float scale;

	private Clock clock;

	private float maxScale;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
