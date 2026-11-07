using UnityEngine;

public abstract class FlagMover : MonoBehaviour
{
	protected IFlagMovable movable;

	private void Awake()
	{
	}

	protected virtual void Init()
	{
	}
}
