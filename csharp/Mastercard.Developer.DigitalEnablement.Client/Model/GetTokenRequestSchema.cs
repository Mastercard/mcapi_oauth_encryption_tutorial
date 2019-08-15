/* 
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.  
 *
 * The version of the OpenAPI document: 1.2.7
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Mastercard.Developer.DigitalEnablement.Client.Client.OpenAPIDateConverter;

namespace Mastercard.Developer.DigitalEnablement.Client.Model
{
    /// <summary>
    /// GetTokenRequestSchema
    /// </summary>
    [DataContract]
    public partial class GetTokenRequestSchema :  IEquatable<GetTokenRequestSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenRequestSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTokenRequestSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenRequestSchema" /> class.
        /// </summary>
        /// <param name="responseHost">The host that originated the request. Future calls in the same conversation may be routed to this host. .</param>
        /// <param name="requestId">Unique identifier for the request.  (required).</param>
        /// <param name="paymentAppInstanceId">Identifier for the specific Mobile Payment App instance, unique across a given Wallet Identifier. This value cannot be changed after digitization. This field is alphanumeric and additionally web-safe base64 characters per RFC 4648 (minus \&quot;-\&quot;, underscore \&quot;_\&quot;) up to a maximum length of 48, &#x3D; should not be URL encoded. Conditional - not applicable for server-based tokens but required otherwise.     __Max Length:48__ .</param>
        /// <param name="tokenUniqueReference">The specific Token to be queried.     __Max Length:64__   (required).</param>
        /// <param name="includeTokenDetail">Flag to indicate if the encrypted token should be returned.     __Max Length:5__  .</param>
        public GetTokenRequestSchema(string responseHost = default(string), string requestId = default(string), string paymentAppInstanceId = default(string), string tokenUniqueReference = default(string), string includeTokenDetail = default(string))
        {
            // to ensure "requestId" is required (not null)
            if (requestId == null)
            {
                throw new InvalidDataException("requestId is a required property for GetTokenRequestSchema and cannot be null");
            }
            else
            {
                this.RequestId = requestId;
            }
            
            // to ensure "tokenUniqueReference" is required (not null)
            if (tokenUniqueReference == null)
            {
                throw new InvalidDataException("tokenUniqueReference is a required property for GetTokenRequestSchema and cannot be null");
            }
            else
            {
                this.TokenUniqueReference = tokenUniqueReference;
            }
            
            this.ResponseHost = responseHost;
            this.PaymentAppInstanceId = paymentAppInstanceId;
            this.IncludeTokenDetail = includeTokenDetail;
        }
        
        /// <summary>
        /// The host that originated the request. Future calls in the same conversation may be routed to this host. 
        /// </summary>
        /// <value>The host that originated the request. Future calls in the same conversation may be routed to this host. </value>
        [DataMember(Name="responseHost", EmitDefaultValue=false)]
        public string ResponseHost { get; set; }

        /// <summary>
        /// Unique identifier for the request. 
        /// </summary>
        /// <value>Unique identifier for the request. </value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Identifier for the specific Mobile Payment App instance, unique across a given Wallet Identifier. This value cannot be changed after digitization. This field is alphanumeric and additionally web-safe base64 characters per RFC 4648 (minus \&quot;-\&quot;, underscore \&quot;_\&quot;) up to a maximum length of 48, &#x3D; should not be URL encoded. Conditional - not applicable for server-based tokens but required otherwise.     __Max Length:48__ 
        /// </summary>
        /// <value>Identifier for the specific Mobile Payment App instance, unique across a given Wallet Identifier. This value cannot be changed after digitization. This field is alphanumeric and additionally web-safe base64 characters per RFC 4648 (minus \&quot;-\&quot;, underscore \&quot;_\&quot;) up to a maximum length of 48, &#x3D; should not be URL encoded. Conditional - not applicable for server-based tokens but required otherwise.     __Max Length:48__ </value>
        [DataMember(Name="paymentAppInstanceId", EmitDefaultValue=false)]
        public string PaymentAppInstanceId { get; set; }

        /// <summary>
        /// The specific Token to be queried.     __Max Length:64__  
        /// </summary>
        /// <value>The specific Token to be queried.     __Max Length:64__  </value>
        [DataMember(Name="tokenUniqueReference", EmitDefaultValue=false)]
        public string TokenUniqueReference { get; set; }

        /// <summary>
        /// Flag to indicate if the encrypted token should be returned.     __Max Length:5__  
        /// </summary>
        /// <value>Flag to indicate if the encrypted token should be returned.     __Max Length:5__  </value>
        [DataMember(Name="includeTokenDetail", EmitDefaultValue=false)]
        public string IncludeTokenDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTokenRequestSchema {\n");
            sb.Append("  ResponseHost: ").Append(ResponseHost).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  PaymentAppInstanceId: ").Append(PaymentAppInstanceId).Append("\n");
            sb.Append("  TokenUniqueReference: ").Append(TokenUniqueReference).Append("\n");
            sb.Append("  IncludeTokenDetail: ").Append(IncludeTokenDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetTokenRequestSchema);
        }

        /// <summary>
        /// Returns true if GetTokenRequestSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTokenRequestSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTokenRequestSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseHost == input.ResponseHost ||
                    (this.ResponseHost != null &&
                    this.ResponseHost.Equals(input.ResponseHost))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.PaymentAppInstanceId == input.PaymentAppInstanceId ||
                    (this.PaymentAppInstanceId != null &&
                    this.PaymentAppInstanceId.Equals(input.PaymentAppInstanceId))
                ) && 
                (
                    this.TokenUniqueReference == input.TokenUniqueReference ||
                    (this.TokenUniqueReference != null &&
                    this.TokenUniqueReference.Equals(input.TokenUniqueReference))
                ) && 
                (
                    this.IncludeTokenDetail == input.IncludeTokenDetail ||
                    (this.IncludeTokenDetail != null &&
                    this.IncludeTokenDetail.Equals(input.IncludeTokenDetail))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResponseHost != null)
                    hashCode = hashCode * 59 + this.ResponseHost.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.PaymentAppInstanceId != null)
                    hashCode = hashCode * 59 + this.PaymentAppInstanceId.GetHashCode();
                if (this.TokenUniqueReference != null)
                    hashCode = hashCode * 59 + this.TokenUniqueReference.GetHashCode();
                if (this.IncludeTokenDetail != null)
                    hashCode = hashCode * 59 + this.IncludeTokenDetail.GetHashCode();
                return hashCode;
            }
        }
    }

}