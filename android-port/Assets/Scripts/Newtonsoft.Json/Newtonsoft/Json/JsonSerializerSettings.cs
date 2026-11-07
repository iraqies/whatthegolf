using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	public class JsonSerializerSettings
	{
		internal static readonly StreamingContext DefaultContext;

		internal static readonly CultureInfo DefaultCulture;

		internal Formatting? _formatting;

		internal DateFormatHandling? _dateFormatHandling;

		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		internal DateParseHandling? _dateParseHandling;

		internal FloatFormatHandling? _floatFormatHandling;

		internal FloatParseHandling? _floatParseHandling;

		internal StringEscapeHandling? _stringEscapeHandling;

		internal CultureInfo _culture;

		internal bool? _checkAdditionalContent;

		internal int? _maxDepth;

		internal bool _maxDepthSet;

		internal string _dateFormatString;

		internal bool _dateFormatStringSet;

		internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling;

		internal DefaultValueHandling? _defaultValueHandling;

		internal PreserveReferencesHandling? _preserveReferencesHandling;

		internal NullValueHandling? _nullValueHandling;

		internal ObjectCreationHandling? _objectCreationHandling;

		internal MissingMemberHandling? _missingMemberHandling;

		internal ReferenceLoopHandling? _referenceLoopHandling;

		internal StreamingContext? _context;

		internal ConstructorHandling? _constructorHandling;

		internal TypeNameHandling? _typeNameHandling;

		internal MetadataPropertyHandling? _metadataPropertyHandling;

		public ReferenceLoopHandling ReferenceLoopHandling => ReferenceLoopHandling.Error;

		public MissingMemberHandling MissingMemberHandling => MissingMemberHandling.Ignore;

		public ObjectCreationHandling ObjectCreationHandling => ObjectCreationHandling.Auto;

		public NullValueHandling NullValueHandling => NullValueHandling.Include;

		public DefaultValueHandling DefaultValueHandling => DefaultValueHandling.Include;

		public IList<JsonConverter> Converters { get; }

		public PreserveReferencesHandling PreserveReferencesHandling => PreserveReferencesHandling.None;

		public TypeNameHandling TypeNameHandling => TypeNameHandling.None;

		public MetadataPropertyHandling MetadataPropertyHandling => MetadataPropertyHandling.Default;

		public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling => TypeNameAssemblyFormatHandling.Simple;

		public ConstructorHandling ConstructorHandling => ConstructorHandling.Default;

		public IContractResolver ContractResolver { get; }

		public IEqualityComparer EqualityComparer { get; }

		public Func<IReferenceResolver> ReferenceResolverProvider { get; }

		public ITraceWriter TraceWriter { get; }

		public ISerializationBinder SerializationBinder { get; }

		public EventHandler<ErrorEventArgs> Error { get; }

		public StreamingContext Context => default;

		static JsonSerializerSettings()
		{
		}
	}
}
