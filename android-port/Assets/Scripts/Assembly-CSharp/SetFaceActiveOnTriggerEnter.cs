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
	}

	private IEnumerator StartCR()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
