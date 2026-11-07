using System.Collections;
using UnityEngine;

public abstract class BaseTransitionEffect : MonoBehaviour
{
	public abstract IEnumerator Begin();

	public abstract IEnumerator End(float overrideTransitionDuration = 0f);

	public virtual void Init()
	{
	}

	public virtual void PreBegin(Color? color)
	{
	}

	public virtual void CleanUp()
	{
	}

	public virtual void InstantTransitionCover(Color? color)
	{
	}
}
