namespace Amazon.Runtime.Internal.Transform
{
	public interface IErrorResponseUnmarshaller<TUnmarshaller, TUnmarshalleContext> : IUnmarshaller<TUnmarshaller, TUnmarshalleContext>
	{
		TUnmarshaller Unmarshall(TUnmarshalleContext input, ErrorResponse errorResponse);
	}
}
