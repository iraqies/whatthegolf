using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class TomatoController : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem SplatSystem;

	[SerializeField]
	private ClipSettingsCollection SplatClip;

	[SerializeField]
	private List<MeshRenderer> renders;

	[SerializeField]
	private bool CanFail;

	[SerializeField]
	private bool CanWin;

	private void OnCollisionEnter(Collision other)
	{
	}

	private void Win()
	{
	}

	private void Fail()
	{
	}

	private void Splat()
	{
	}

	private IEnumerator Die()
	{
		return null;
	}
}
