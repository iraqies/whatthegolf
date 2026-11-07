using System.Linq.Expressions;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000055")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x183014", Offset = "0x183014")]
	[Attribute(Name = "NullableAttribute", RVA = "0x183014", Offset = "0x183014")]
	internal class NoThrowExpressionVisitor : ExpressionVisitor
	{
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly object ErrorResult;

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x231C54C", Offset = "0x231C54C", VA = "0x231C54C", Slot = "7")]
		protected override Expression VisitConditional(ConditionalExpression node)
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x231C65C", Offset = "0x231C65C", VA = "0x231C65C")]
		public NoThrowExpressionVisitor()
		{
		}
	}
}
