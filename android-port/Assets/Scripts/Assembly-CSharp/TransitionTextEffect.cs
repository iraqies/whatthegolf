using System.Collections;
using UnityEngine;

public abstract class TransitionTextEffect : MonoBehaviour
{
	public abstract bool IsBusy { get; }

	public abstract void Initialize();

	public abstract void Prepare(string text = null, bool onTheSide = false);

	public abstract IEnumerator Show(float transitionInDuration);

	public abstract IEnumerator Hide(float transitionOutDuration);
}
