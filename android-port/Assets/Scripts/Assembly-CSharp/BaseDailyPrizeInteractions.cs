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
		if (dailyAnimalScript == null)
		{
			dailyAnimalScript = GetComponentInParent<DailyPrize>();
		}
		if (dailyAnimalScript != null)
		{
			dailyAnimalScript.OnUnpack += OnUnpack;
			dailyAnimalScript.OnUnpackImmidiate += OnUnpackImmidiate;
			dailyAnimalScript.OnAimNotWrapped += OnAimNotWrapped;
			dailyAnimalScript.OnAimWrapped += OnAimWrapped;
			dailyAnimalScript.OnShootNotWrapped += OnShootNotWrapped;
			dailyAnimalScript.OnShootWrapped += OnShootWrapped;
			dailyAnimalScript.OnLoseFocus += OnLoseFocus;
			dailyAnimalScript.OnGetFocus += OnGetFocus;
		}
	}

	private void OnDestroy()
	{
		if (dailyAnimalScript != null)
		{
			dailyAnimalScript.OnUnpack -= OnUnpack;
			dailyAnimalScript.OnUnpackImmidiate -= OnUnpackImmidiate;
			dailyAnimalScript.OnAimNotWrapped -= OnAimNotWrapped;
			dailyAnimalScript.OnAimWrapped -= OnAimWrapped;
			dailyAnimalScript.OnShootNotWrapped -= OnShootNotWrapped;
			dailyAnimalScript.OnShootWrapped -= OnShootWrapped;
			dailyAnimalScript.OnLoseFocus -= OnLoseFocus;
			dailyAnimalScript.OnGetFocus -= OnGetFocus;
		}
	}
}
