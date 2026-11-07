using System.Collections;

public class MoveOnInterval : FlagMover
{
	public float wait;

	public bool startOnAwake;

	public bool Moving { get; set; }

	protected override void Init()
	{
	}

	private IEnumerator MoveRoutine()
	{
		return null;
	}
}
