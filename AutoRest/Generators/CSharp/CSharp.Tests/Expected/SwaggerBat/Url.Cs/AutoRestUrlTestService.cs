namespace Fixtures.SwaggerBatUrl
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Models;

    /// <summary>
    /// Test Infrastructure for AutoRest
    /// </summary>
    public partial class AutoRestUrlTestService : ServiceClient<AutoRestUrlTestService>, IAutoRestUrlTestService
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }        

        /// <summary>
        /// A string value 'globalItemStringPath' that appears in the path
        /// </summary>
        public string GlobalStringPath { get; set; }

        /// <summary>
        /// should contain value null
        /// </summary>
        public string GlobalStringQuery { get; set; }

        public virtual IPaths Paths { get; private set; }

        public virtual IQueries Queries { get; private set; }

        public virtual IPathItems PathItems { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AutoRestUrlTestService class.
        /// </summary>
        public AutoRestUrlTestService() : base()
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestUrlTestService class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AutoRestUrlTestService(params DelegatingHandler[] handlers) : base(handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestUrlTestService class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AutoRestUrlTestService(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestUrlTestService class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AutoRestUrlTestService(Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.Initialize();
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestUrlTestService class.
        /// </summary>
        /// <param name='globalStringPath'>
        /// Required. A string value 'globalItemStringPath' that appears in the path
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AutoRestUrlTestService(string globalStringPath, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (globalStringPath == null)
            {
                throw new ArgumentNullException("globalStringPath");
            }
            this.GlobalStringPath = globalStringPath;
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the AutoRestUrlTestService class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='globalStringPath'>
        /// Required. A string value 'globalItemStringPath' that appears in the path
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public AutoRestUrlTestService(Uri baseUri, string globalStringPath, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (globalStringPath == null)
            {
                throw new ArgumentNullException("globalStringPath");
            }
            this.BaseUri = baseUri;
            this.GlobalStringPath = globalStringPath;
        }

        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            this.Paths = new Paths(this);
            this.Queries = new Queries(this);
            this.PathItems = new PathItems(this);
            this.BaseUri = new Uri("http://localhost");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver()
            };
            DeserializationSettings = new JsonSerializerSettings{
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver()
            };
        }    
    }
}
