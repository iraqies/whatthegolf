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
	private float _duration;

	[SerializeField]
	private Transform _end;

	private static readonly int Spit;

	private bool no;

	private bool isExiting;

	private void Start()
	{
	}

	private void EntryEndWithToungeOnOnEntered(ShortcutTunnelEntry arg1, ShortcutTunnelTraversable arg2)
	{
	}

	private void OtherEntryOnOnEntered(ShortcutTunnelEntry arg1, ShortcutTunnelTraversable arg2)
	{
	}

	private void TunnelOnOnMovementUpdate(float obj)
	{
	}

	private void TunnelOnOnBallExitTunnel(ShortcutTunnel obj)
	{
	}

	private IEnumerator Exit()
	{
		return null;
	}

	private void PlayAudio()
	{
	}
}
