using UnityEngine;
using UnityEngine.Events;

public class GolfSnakeController : MonoBehaviour
{
	public GameObject prefab;

	public float childAppearSpeed;

	public AnimationCurve curveSpawnChildren;

	public int maxChildren;

	public UnityEvent OnMaxChildren;

	public UnityEvent OnChildSpawned;

	private FollowTransformUtility followTransformUtility;

	private bool maxedOut;

	public void Update()
	{
	}

	public void AddMember(float numberOfChildren)
	{
	}
}
