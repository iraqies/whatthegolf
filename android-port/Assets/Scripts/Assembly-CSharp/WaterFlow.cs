using UnityEngine;

public class WaterFlow : MonoBehaviour
{
	[SerializeField]
	private float speedRatio;

	[SerializeField]
	private Bounds bounds;

	private WaterFlowParticle[] particles;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
