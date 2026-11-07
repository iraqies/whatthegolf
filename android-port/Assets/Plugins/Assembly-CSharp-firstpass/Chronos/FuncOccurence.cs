using Il2CppDummyDll;

namespace Chronos
{
	[Token(Token = "0x200029F")]
	internal sealed class FuncOccurence<T> : Occurrence
	{
		[Token(Token = "0x4001131")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37304", Offset = "0x37304")]
		private ForwardFunc<T> forward__BackingField;

		[Token(Token = "0x4001132")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37314", Offset = "0x37314")]
		private BackwardFunc<T> backward__BackingField;

		[Token(Token = "0x4001133")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37324", Offset = "0x37324")]
		private T transfer__BackingField;

		[Token(Token = "0x17000217")]
		private ForwardFunc<T> forward
		{
			[Token(Token = "0x600114D")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B82C", Offset = "0x3B82C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600114E")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B83C", Offset = "0x3B83C")]
			set
			{
			}
		}

		[Token(Token = "0x17000218")]
		private BackwardFunc<T> backward
		{
			[Token(Token = "0x600114F")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B84C", Offset = "0x3B84C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001150")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B85C", Offset = "0x3B85C")]
			set
			{
			}
		}

		[Token(Token = "0x17000219")]
		private T transfer
		{
			[Token(Token = "0x6001151")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B86C", Offset = "0x3B86C")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6001152")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B87C", Offset = "0x3B87C")]
			set
			{
			}
		}

		[Token(Token = "0x6001153")]
		public FuncOccurence(ForwardFunc<T> forward, BackwardFunc<T> backward)
		{
		}

		[Token(Token = "0x6001154")]
		public override void Forward()
		{
		}

		[Token(Token = "0x6001155")]
		public override void Backward()
		{
		}
	}
}
