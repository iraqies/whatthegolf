using System.Collections.Generic;
using UnityEngine;

public class CullWhenHidden : GolfBehaviour
{
	public bool disableAllScriptsWhenCull;

	public bool isCullingRigids;

	public MonoBehaviour[] disableSpecificScripts;

	public List<MonoBehaviour> currentDisableSpecificScripts;

	public bool disableAnimations;

	public bool disablePaticles;

	public bool disableAudioSources;

	public bool disableSprites;

	private bool isVisible;

	[SerializeField]
	private Rigidbody2D[] rigids;

	public InvisibleCullingObject cullingObject;

	[SerializeField]
	private AudioSource[] audiosources;

	[SerializeField]
	private Animator[] animators;

	[SerializeField]
	private ParticleSystem[] particles;

	[SerializeField]
	private SortByY[] sorties;

	[SerializeField]
	private LineRenderer[] lineRenders;

	private bool isSectionVisible;

	public override void OnPrePlayOrPreCompile()
	{
	}

	public void Init()
	{
	}

	public void OnVisible()
	{
	}

	public void OnInvisible()
	{
	}

	public void UpdateState()
	{
	}

	public void OnSectionInvisible()
	{
	}

	public void OnSectionVisible()
	{
	}
}
