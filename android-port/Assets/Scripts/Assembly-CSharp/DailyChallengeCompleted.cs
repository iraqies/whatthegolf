using System.Collections;
using Audio;
using TMPro;
using UnityEngine;

public class DailyChallengeCompleted : MonoBehaviour
{
	public TextMeshProUGUI StrokesText;

	public TextMeshProUGUI RankText;

	public bool closing;

	public ClipSettingsCollection completeSFX;

	public ParticleSystem completeParticles;

	public void Show(int strokes, bool scoreOk)
	{
	}

	private void OnDeepLinkActivated()
	{
	}

	private IEnumerator ShowParticles()
	{
		return null;
	}

	public IEnumerator WaitForClose()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public void Close()
	{
	}
}
