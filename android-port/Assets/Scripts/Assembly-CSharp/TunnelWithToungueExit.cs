using System.Collections;
using Audio;
using UnityEngine;

public class TunnelWithToungueExit : MonoBehaviour
{
	[SerializeField]
	private ShortcutTunnel _tunnel;

	[SerializeField]
	private ShortcutTunnelEntry _otherEntryEnd;

	[SerializeField]
	private ShortcutTunnelEntry _entryEndWithTounge;

	[SerializeField]
	private ClipSettingsCollection _exitAudio;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private AnimationCurve _curve;

	[SerializeField]
	private float _duration = 0.4f;

	[SerializeField]
	private Transform _end;

	private static readonly int Spit = Animator.StringToHash("Spit");

	private bool no;

	private bool isExiting;

	private void Start()
	{
		if (_tunnel != null)
		{
			_tunnel.OnBallExitTunnel -= TunnelOnOnBallExitTunnel;
			_tunnel.OnBallExitTunnel += TunnelOnOnBallExitTunnel;
			_tunnel.OnMovementUpdate -= TunnelOnOnMovementUpdate;
			_tunnel.OnMovementUpdate += TunnelOnOnMovementUpdate;
		}
		if (_otherEntryEnd != null)
		{
			_otherEntryEnd.OnEntered -= OtherEntryOnOnEntered;
			_otherEntryEnd.OnEntered += OtherEntryOnOnEntered;
		}
		if (_entryEndWithTounge != null)
		{
			_entryEndWithTounge.OnEntered -= EntryEndWithToungeOnOnEntered;
			_entryEndWithTounge.OnEntered += EntryEndWithToungeOnOnEntered;
		}
	}

	private void EntryEndWithToungeOnOnEntered(ShortcutTunnelEntry arg1, ShortcutTunnelTraversable arg2)
	{
		no = true;
	}

	private void OtherEntryOnOnEntered(ShortcutTunnelEntry arg1, ShortcutTunnelTraversable arg2)
	{
		no = false;
	}

	private void TunnelOnOnMovementUpdate(float obj)
	{
		if (!no && obj <= 0.15f && !isExiting)
		{
			PlayAudio();
		}
	}

	private void TunnelOnOnBallExitTunnel(ShortcutTunnel obj)
	{
		if (!no && !isExiting && gameObject.activeInHierarchy)
		{
			StartCoroutine(Exit());
		}
	}

	private IEnumerator Exit()
	{
		if (isExiting) yield break;
		isExiting = true;
		var cols = GetComponentsInChildren<Collider2D>();
		if (cols != null)
		{
			for (int i = 0; i < cols.Length; i++)
				if (cols[i] != null) cols[i].enabled = false;
		}
		if (_animator != null)
			_animator.SetTrigger(Spit);

		var ball = OverworldBallManager.Instance != null ? OverworldBallManager.Instance.Ball : null;
		Rigidbody2D rb = ball != null ? ball.rigidBody : null;
		if (rb != null)
			rb.isKinematic = true;

		Vector3 startPos = transform.position;
		float dur = _duration > 0.01f ? _duration : 0.4f;
		yield return StartCoroutine(pTween.To(dur, 0f, 1f, t =>
		{
			float eval = (_curve != null && _curve.length > 0) ? _curve.Evaluate(t) : t;
			if (ball != null && _end != null)
				ball.transform.position = Vector3.Lerp(startPos, _end.position, eval);
		}));

		if (rb != null)
			rb.isKinematic = false;
		if (cols != null)
		{
			for (int i = 0; i < cols.Length; i++)
				if (cols[i] != null) cols[i].enabled = true;
		}
		if (_animator != null)
			_animator.ResetTrigger(Spit);
		isExiting = false;
	}

	private void PlayAudio()
	{
		if (_exitAudio != null)
			_exitAudio.Play(transform.position);
	}
}
