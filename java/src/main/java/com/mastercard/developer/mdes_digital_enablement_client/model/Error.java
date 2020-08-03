/*
 * MDES for Merchants
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously. <br> __Authentication__ Mastercard uses OAuth 1.0a with body hash extension for authenticating the API clients. This requires every request that you send to  Mastercard to be signed with an RSA private key. A private-public RSA key pair must be generated consisting of: <br> 1 . A private key for the OAuth signature for API requests. It is recommended to keep the private key in a password-protected or hardware keystore. <br> 2. A public key is shared with Mastercard during the project setup process through either a certificate signing request (CSR) or the API Key Generator. Mastercard will use the public key to verify the OAuth signature that is provided on every API call.<br>  An OAUTH1.0a signer library is available on [GitHub](https://github.com/Mastercard/oauth1-signer-java) <br>  __Encryption__<br>  All communications between Issuer web service and the Mastercard gateway is encrypted using TLS. <br> __Additional Encryption of Sensitive Data__ In addition to the OAuth authentication, when using MDES Digital Enablement Service, any PCI sensitive and all account holder Personally Identifiable Information (PII) data must be encrypted. This requirement applies to the API fields containing encryptedData. Sensitive data is encrypted using a symmetric session (one-time-use) key. The symmetric session key is then wrapped with an RSA Public Key supplied by Mastercard during API setup phase (the Customer Encryption Key). <br>  Java Client Encryption Library available on [GitHub](https://github.com/Mastercard/client-encryption-java) 
 *
 * The version of the OpenAPI document: 1.2.9
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package com.mastercard.developer.mdes_digital_enablement_client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * Only returned in the event of an error condition.
 */
@ApiModel(description = "Only returned in the event of an error condition.")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-08-03T11:33:09.091673-04:00[America/New_York]")
public class Error {
  public static final String SERIALIZED_NAME_SOURCE = "source";
  @SerializedName(SERIALIZED_NAME_SOURCE)
  private String source;

  public static final String SERIALIZED_NAME_ERROR_CODE = "errorCode";
  @SerializedName(SERIALIZED_NAME_ERROR_CODE)
  private String errorCode;

  public static final String SERIALIZED_NAME_DESCRIPTION = "description";
  @SerializedName(SERIALIZED_NAME_DESCRIPTION)
  private String description;

  public static final String SERIALIZED_NAME_REASON_CODE = "reasonCode";
  @SerializedName(SERIALIZED_NAME_REASON_CODE)
  private String reasonCode;

  public static final String SERIALIZED_NAME_RECOVERABLE = "recoverable";
  @SerializedName(SERIALIZED_NAME_RECOVERABLE)
  private Boolean recoverable;


  public Error source(String source) {
    
    this.source = source;
    return this;
  }

   /**
   * An element used to indicate the source of the issue causing this error. Must be one of   * &#39;MDES&#39;  * &#39;INPUT&#39;&lt;br&gt; __Max Length: 32__ 
   * @return source
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "An element used to indicate the source of the issue causing this error. Must be one of   * 'MDES'  * 'INPUT'<br> __Max Length: 32__ ")

  public String getSource() {
    return source;
  }


  public void setSource(String source) {
    this.source = source;
  }


  public Error errorCode(String errorCode) {
    
    this.errorCode = errorCode;
    return this;
  }

   /**
   * An error code generated by the gateway if the error occurs before reaching the MDES application.    __Max Length: 100__ 
   * @return errorCode
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "An error code generated by the gateway if the error occurs before reaching the MDES application.    __Max Length: 100__ ")

  public String getErrorCode() {
    return errorCode;
  }


  public void setErrorCode(String errorCode) {
    this.errorCode = errorCode;
  }


  public Error description(String description) {
    
    this.description = description;
    return this;
  }

   /**
   * Description of the reason the operation failed. See API Response Errors &lt;br&gt; __Max Length: 256__ 
   * @return description
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "Description of the reason the operation failed. See API Response Errors <br> __Max Length: 256__ ")

  public String getDescription() {
    return description;
  }


  public void setDescription(String description) {
    this.description = description;
  }


  public Error reasonCode(String reasonCode) {
    
    this.reasonCode = reasonCode;
    return this;
  }

   /**
   * A reason code for the error that has occurred.&lt;br&gt; __Max Length: 100__ 
   * @return reasonCode
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "A reason code for the error that has occurred.<br> __Max Length: 100__ ")

  public String getReasonCode() {
    return reasonCode;
  }


  public void setReasonCode(String reasonCode) {
    this.reasonCode = reasonCode;
  }


  public Error recoverable(Boolean recoverable) {
    
    this.recoverable = recoverable;
    return this;
  }

   /**
   * Generated by the gateway to indicate if the request could presented again for processing. Either \&quot;TRUE\&quot; or \&quot;FALSE\&quot; 
   * @return recoverable
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "true", value = "Generated by the gateway to indicate if the request could presented again for processing. Either \"TRUE\" or \"FALSE\" ")

  public Boolean getRecoverable() {
    return recoverable;
  }


  public void setRecoverable(Boolean recoverable) {
    this.recoverable = recoverable;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Error error = (Error) o;
    return Objects.equals(this.source, error.source) &&
        Objects.equals(this.errorCode, error.errorCode) &&
        Objects.equals(this.description, error.description) &&
        Objects.equals(this.reasonCode, error.reasonCode) &&
        Objects.equals(this.recoverable, error.recoverable);
  }

  @Override
  public int hashCode() {
    return Objects.hash(source, errorCode, description, reasonCode, recoverable);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Error {\n");
    sb.append("    source: ").append(toIndentedString(source)).append("\n");
    sb.append("    errorCode: ").append(toIndentedString(errorCode)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    reasonCode: ").append(toIndentedString(reasonCode)).append("\n");
    sb.append("    recoverable: ").append(toIndentedString(recoverable)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

