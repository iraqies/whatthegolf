using UnityEngine;

public class PortalPackage
{
	private readonly Vector3 EntryPoint;

	public SimplePortal From { get; }

	public SimplePortal To { get; }

	public SimplePortal EntryPortal => From;

	public SimplePortal ExitPortal => To;

	public SimplePortal otherPortal => To;

	public PortalPackage(SimplePortal from, SimplePortal to, Vector3 entryPoint)
	{
		From = from;
		To = to;
		EntryPoint = entryPoint;
	}
}
