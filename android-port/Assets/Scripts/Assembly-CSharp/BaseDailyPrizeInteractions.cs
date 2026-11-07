using UnityEngine;

public class BaseDailyPrizeInteractions : MonoBehaviour
{
	[SerializeField]
	protected DailyPrize dailyAnimalScript;

	public bool ExecuteOnShoot;

	public bool ExecuteOnAim;

	public virtual void OnUnpack(Vector3 b)
	{
	}

	public virtual void OnUnpackImmidiate(Vector3 b)
	{
	}

	public virtual void OnAimNotWrapped(Vector3 b)
	{
	}

	public virtual void OnAimWrapped(Vector3 b)
	{
	}

	public virtual void OnShootNotWrapped(Vector3 b)
	{
	}

	public virtual void OnShootWrapped(Vector3 b)
	{
	}

	public virtual void OnLoseFocus()
	{
	}

	public virtual void OnGetFocus()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
