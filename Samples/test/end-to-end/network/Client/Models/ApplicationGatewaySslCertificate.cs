// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace applicationGateway.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SSL certificates of an application gateway.
    /// </summary>
    [JsonTransformation]
    public partial class ApplicationGatewaySslCertificate : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewaySslCertificate
        /// class.
        /// </summary>
        public ApplicationGatewaySslCertificate()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewaySslCertificate
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="data">Base-64 encoded pfx certificate. Only applicable
        /// in PUT Request.</param>
        /// <param name="password">Password for the pfx file specified in data.
        /// Only applicable in PUT request.</param>
        /// <param name="publicCertData">Base-64 encoded Public cert data
        /// corresponding to pfx specified in data. Only applicable in GET
        /// request.</param>
        /// <param name="provisioningState">Provisioning state of the SSL
        /// certificate resource Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ApplicationGatewaySslCertificate(string id = default(string), string data = default(string), string password = default(string), string publicCertData = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            Data = data;
            Password = password;
            PublicCertData = publicCertData;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets base-64 encoded pfx certificate. Only applicable in
        /// PUT Request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.data")]
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets password for the pfx file specified in data. Only
        /// applicable in PUT request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets base-64 encoded Public cert data corresponding to pfx
        /// specified in data. Only applicable in GET request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicCertData")]
        public string PublicCertData { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the SSL certificate resource
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
