namespace Apple.Core.Runtime
{
	public delegate void SuccessCallback();
	public delegate void SuccessCallback<TResponse>(TResponse response);
}
