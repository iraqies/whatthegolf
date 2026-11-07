using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
	[Token(Token = "0x2000290")]
	public static class SimpleWorkflowServiceActionIdentifiers
	{
		[Token(Token = "0x4000C19")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ActionIdentifier AllSimpleWorkflowServiceActions;

		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ActionIdentifier CancelTimer;

		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ActionIdentifier CancelWorkflowExecution;

		[Token(Token = "0x4000C1C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ActionIdentifier CompleteWorkflowExecution;

		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ActionIdentifier ContinueAsNewWorkflowExecution;

		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ActionIdentifier CountClosedWorkflowExecutions;

		[Token(Token = "0x4000C1F")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ActionIdentifier CountOpenWorkflowExecutions;

		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ActionIdentifier CountPendingActivityTasks;

		[Token(Token = "0x4000C21")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ActionIdentifier CountPendingDecisionTasks;

		[Token(Token = "0x4000C22")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ActionIdentifier DeprecateActivityType;

		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x50")]
		public static readonly ActionIdentifier DeprecateDomain;

		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x58")]
		public static readonly ActionIdentifier DeprecateWorkflowType;

		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x60")]
		public static readonly ActionIdentifier DescribeActivityType;

		[Token(Token = "0x4000C26")]
		[FieldOffset(Offset = "0x68")]
		public static readonly ActionIdentifier DescribeDomain;

		[Token(Token = "0x4000C27")]
		[FieldOffset(Offset = "0x70")]
		public static readonly ActionIdentifier DescribeWorkflowExecution;

		[Token(Token = "0x4000C28")]
		[FieldOffset(Offset = "0x78")]
		public static readonly ActionIdentifier DescribeWorkflowType;

		[Token(Token = "0x4000C29")]
		[FieldOffset(Offset = "0x80")]
		public static readonly ActionIdentifier FailWorkflowExecution;

		[Token(Token = "0x4000C2A")]
		[FieldOffset(Offset = "0x88")]
		public static readonly ActionIdentifier GetWorkflowExecutionHistory;

		[Token(Token = "0x4000C2B")]
		[FieldOffset(Offset = "0x90")]
		public static readonly ActionIdentifier ListActivityTypes;

		[Token(Token = "0x4000C2C")]
		[FieldOffset(Offset = "0x98")]
		public static readonly ActionIdentifier ListClosedWorkflowExecutions;

		[Token(Token = "0x4000C2D")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly ActionIdentifier ListDomains;

		[Token(Token = "0x4000C2E")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly ActionIdentifier ListOpenWorkflowExecutions;

		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly ActionIdentifier ListWorkflowTypes;

		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly ActionIdentifier PollForActivityTask;

		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly ActionIdentifier PollForDecisionTask;

		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly ActionIdentifier RecordActivityTaskHeartbeat;

		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly ActionIdentifier RecordMarker;

		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly ActionIdentifier RegisterActivityType;

		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly ActionIdentifier RegisterDomain;

		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly ActionIdentifier RegisterWorkflowType;

		[Token(Token = "0x4000C37")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly ActionIdentifier RequestCancelActivityTask;

		[Token(Token = "0x4000C38")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly ActionIdentifier RequestCancelExternalWorkflowExecution;

		[Token(Token = "0x4000C39")]
		[FieldOffset(Offset = "0x100")]
		public static readonly ActionIdentifier RequestCancelWorkflowExecution;

		[Token(Token = "0x4000C3A")]
		[FieldOffset(Offset = "0x108")]
		public static readonly ActionIdentifier RespondActivityTaskCanceled;

		[Token(Token = "0x4000C3B")]
		[FieldOffset(Offset = "0x110")]
		public static readonly ActionIdentifier RespondActivityTaskCompleted;

		[Token(Token = "0x4000C3C")]
		[FieldOffset(Offset = "0x118")]
		public static readonly ActionIdentifier RespondActivityTaskFailed;

		[Token(Token = "0x4000C3D")]
		[FieldOffset(Offset = "0x120")]
		public static readonly ActionIdentifier RespondDecisionTaskCompleted;

		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0x128")]
		public static readonly ActionIdentifier ScheduleActivityTask;

		[Token(Token = "0x4000C3F")]
		[FieldOffset(Offset = "0x130")]
		public static readonly ActionIdentifier SignalExternalWorkflowExecution;

		[Token(Token = "0x4000C40")]
		[FieldOffset(Offset = "0x138")]
		public static readonly ActionIdentifier SignalWorkflowExecution;

		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0x140")]
		public static readonly ActionIdentifier StartChildWorkflowExecution;

		[Token(Token = "0x4000C42")]
		[FieldOffset(Offset = "0x148")]
		public static readonly ActionIdentifier StartTimer;

		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0x150")]
		public static readonly ActionIdentifier StartWorkflowExecution;

		[Token(Token = "0x4000C44")]
		[FieldOffset(Offset = "0x158")]
		public static readonly ActionIdentifier TerminateWorkflowExecution;
	}
}
