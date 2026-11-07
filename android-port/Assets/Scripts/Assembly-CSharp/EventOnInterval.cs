using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class EventOnInterval : MonoBehaviour
{
	public Vector2 duration = new Vector2(2f, 2f);
	public Vector2 offset;
	private float d;
	private float o;
	public UnityEvent _event = new UnityEvent();

	private void Start()
	{
		StartCoroutine(MainCR());
	}

	private IEnumerator CR()
	{
		yield return MainCR();
	}

	private IEnumerator MainCR()
	{
		o = Random.Range(offset.x, Mathf.Max(offset.x, offset.y));
		if (o > 0f) yield return new WaitForSeconds(o);
		while (enabled && gameObject.activeInHierarchy)
		{
			d = Mathf.Max(0.1f, Random.Range(duration.x, Mathf.Max(duration.x, duration.y)));
			yield return new WaitForSeconds(d);
			_event?.Invoke();
		}
	}

	private void OnDisable() => StopAllCoroutines();
	private void OnDestroy() => StopAllCoroutines();
}
