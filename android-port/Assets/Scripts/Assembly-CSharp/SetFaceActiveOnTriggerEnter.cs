using System.Collections;
using Audio;
using UnityEngine;

public class SetFaceActiveOnTriggerEnter : MonoBehaviour
{
	[SerializeField]
	private GameObject _face;

	[SerializeField]
	private bool _playAudio;

	[SerializeField]
	private ClipSettingsCollection _sfx;

	private bool _playSfx;

	private void Start()
	{
		StartCoroutine(StartCR());
	}

	private IEnumerator StartCR()
	{
		_playSfx = false;
		yield return new WaitForSeconds(0.5f);
		_playSfx = true;
	}

	private void OnEnable()
	{
		StartCoroutine(StartCR());
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other != null && other.gameObject != null && other.gameObject.CompareTag("ObjectOfInterest"))
		{
			if (_face != null)
			{
				_face.SetActive(value: true);
			}
			if (_playAudio && _playSfx && _sfx != null)
			{
				_sfx.Play(base.transform.position);
			}
		}
	}
}
