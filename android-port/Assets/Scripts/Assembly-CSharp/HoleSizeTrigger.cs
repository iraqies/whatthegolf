using UnityEngine;
using UnityEngine.Events;

public class HoleSizeTrigger : MonoBehaviour
{
	public float holeSizeTreshold;

	public GameObject holeObject;

	public GameObject fenceBorder;

	public float fenceResizeScale;

	public UnityEvent OnHoleBig;

	private void Update()
	{
	}
}
