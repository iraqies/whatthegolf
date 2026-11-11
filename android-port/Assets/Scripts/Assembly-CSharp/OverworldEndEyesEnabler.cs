using System.Collections;
using System.Linq;
using Audio;
using UnityEngine;

public class OverworldEndEyesEnabler : MonoBehaviour
{
	public InvisibleCullingObject culling;

	public Transform eyes;

	public OverworldBumper[] hitEyes;

	public Collider2D col;

	public ClipSettingsCollection FirstHitSFX;

	public ClipSettingsCollection enableSFX;

	public uint wwiseTrigger;

	private OverworldBumper[] allEyes;

	private void Start()
	{
		col = GetComponent<Collider2D>();
		InvisibleCullingObject invisibleCullingObject = culling;
		invisibleCullingObject.OnInvisible = (InvisibleCullingObject.OnVisibleDelegate)System.Delegate.Combine(invisibleCullingObject.OnInvisible, new InvisibleCullingObject.OnVisibleDelegate(Reset));
		allEyes = (from e in eyes.GetComponentsInChildren<OverworldBumper>()
			orderby 0f - Vector3.Distance(e.transform.position, base.transform.position)
			select e).ToArray();
		Reset();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		col.isTrigger = true;
		OverworldBumper overworldBumper = hitEyes[0];
		float num = float.PositiveInfinity;
		for (int i = 0; i < hitEyes.Length; i++)
		{
			OverworldBumper overworldBumper2 = hitEyes[i];
			float num2 = Vector3.Distance(overworldBumper2.transform.position, collision.contacts[0].point);
			if (num2 < num)
			{
				num = num2;
				overworldBumper = overworldBumper2;
			}
		}
		overworldBumper.gameObject.SetActive(true);
		overworldBumper.Bump();
		FirstHitSFX.Play(base.transform.position, 1f, 1f);
		enableSFX.Play(AudioManager.Instance.sfx, base.transform.position, 0.25f);
		AudioManager.Instance.music.PostTrigger(wwiseTrigger);
		Rigidbody2D rigid = OverworldBallManager.Instance.ball.rigid;
		Vector3 normalized = (rigid.transform.position - overworldBumper.transform.position).normalized;
		rigid.AddForce(normalized * 100f, ForceMode2D.Impulse);
		StartCoroutine(ShowEyes());
	}

	private IEnumerator ShowEyes()
	{
		yield return null;
		int waitBatch = 4;
		int count = 1;
		OverworldBumper[] array = allEyes;
		foreach (OverworldBumper eye in array)
		{
			eye.gameObject.SetActive(true);
			Vector3 targetScale = eye.transform.localScale;
			Vector3 startScale = new Vector3(eye.transform.localScale.x, 0f, eye.transform.localScale.z);
			eye.transform.localScale = Vector3.zero;
			float num = Random.Range(0f, 0.2f);
			StartCoroutine(pTween.To(num + 0.25f, delegate(float t)
			{
				eye.transform.localScale = Vector3.LerpUnclamped(startScale, targetScale, Mathf.Clamp01(TweenFunctions.SmoothStep(t)));
			}));
			if (count > waitBatch)
			{
				yield return new WaitForSeconds(0.185f);
				count = 0;
				waitBatch++;
			}
			eye.EnableEye();
			count++;
		}
	}

	public void Reset()
	{
		col.isTrigger = false;
		for (int i = 0; i < hitEyes.Length; i++)
		{
			hitEyes[i].gameObject.SetActive(false);
		}
		foreach (Transform eye in eyes)
		{
			eye.gameObject.SetActive(false);
		}
	}
}
