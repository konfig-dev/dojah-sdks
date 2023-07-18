/*
 * DOJAH Publilc APIs
 * Use Dojah to verify, onboard and manage user identity across Africa!
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */


package com.konfigthis.dojah.client.model;

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

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import org.apache.commons.lang3.StringUtils;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;

import com.konfigthis.dojah.client.JSON;

/**
 * FraudScreenUserResponseEntityIpCheckResultIpDetails
 */
@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class FraudScreenUserResponseEntityIpCheckResultIpDetails {
  public static final String SERIALIZED_NAME_REVERSE_DNS = "reverse_dns";
  @SerializedName(SERIALIZED_NAME_REVERSE_DNS)
  private String reverseDns;

  public static final String SERIALIZED_NAME_CONTINENT_CODE = "continent_code";
  @SerializedName(SERIALIZED_NAME_CONTINENT_CODE)
  private String continentCode;

  public static final String SERIALIZED_NAME_CONTINENT_NAME = "continent_name";
  @SerializedName(SERIALIZED_NAME_CONTINENT_NAME)
  private String continentName;

  public static final String SERIALIZED_NAME_COUNTRY_CODE = "country_code";
  @SerializedName(SERIALIZED_NAME_COUNTRY_CODE)
  private String countryCode;

  public static final String SERIALIZED_NAME_COUNTRY_NAME = "country_name";
  @SerializedName(SERIALIZED_NAME_COUNTRY_NAME)
  private String countryName;

  public static final String SERIALIZED_NAME_COUNTRY_CURRENCY = "country_currency";
  @SerializedName(SERIALIZED_NAME_COUNTRY_CURRENCY)
  private String countryCurrency;

  public static final String SERIALIZED_NAME_COUNTRY_CALLING_CODE = "country_calling_code";
  @SerializedName(SERIALIZED_NAME_COUNTRY_CALLING_CODE)
  private String countryCallingCode;

  public static final String SERIALIZED_NAME_REGION_NAME = "region_name";
  @SerializedName(SERIALIZED_NAME_REGION_NAME)
  private String regionName;

  public static final String SERIALIZED_NAME_CITY_NAME = "city_name";
  @SerializedName(SERIALIZED_NAME_CITY_NAME)
  private String cityName;

  public static final String SERIALIZED_NAME_LATITUDE = "latitude";
  @SerializedName(SERIALIZED_NAME_LATITUDE)
  private Double latitude;

  public static final String SERIALIZED_NAME_LONGITUDE = "longitude";
  @SerializedName(SERIALIZED_NAME_LONGITUDE)
  private Double longitude;

  public static final String SERIALIZED_NAME_ISP = "isp";
  @SerializedName(SERIALIZED_NAME_ISP)
  private String isp;

  public static final String SERIALIZED_NAME_ASN = "asn";
  @SerializedName(SERIALIZED_NAME_ASN)
  private String asn;

  public FraudScreenUserResponseEntityIpCheckResultIpDetails() {
  }

  public FraudScreenUserResponseEntityIpCheckResultIpDetails reverseDns(String reverseDns) {

    
    
    
    
    this.reverseDns = reverseDns;
    return this;
  }

   /**
   * Get reverseDns
   * @return reverseDns
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "crawl-66-249-76-187.googlebot.com", value = "")

  public String getReverseDns() {
    return reverseDns;
  }


  public void setReverseDns(String reverseDns) {

    
    
    
    this.reverseDns = reverseDns;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails continentCode(String continentCode) {

    
    
    
    
    this.continentCode = continentCode;
    return this;
  }

   /**
   * Get continentCode
   * @return continentCode
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "NA", value = "")

  public String getContinentCode() {
    return continentCode;
  }


  public void setContinentCode(String continentCode) {

    
    
    
    this.continentCode = continentCode;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails continentName(String continentName) {

    
    
    
    
    this.continentName = continentName;
    return this;
  }

   /**
   * Get continentName
   * @return continentName
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "North America", value = "")

  public String getContinentName() {
    return continentName;
  }


  public void setContinentName(String continentName) {

    
    
    
    this.continentName = continentName;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails countryCode(String countryCode) {

    
    
    
    
    this.countryCode = countryCode;
    return this;
  }

   /**
   * Get countryCode
   * @return countryCode
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "US", value = "")

  public String getCountryCode() {
    return countryCode;
  }


  public void setCountryCode(String countryCode) {

    
    
    
    this.countryCode = countryCode;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails countryName(String countryName) {

    
    
    
    
    this.countryName = countryName;
    return this;
  }

   /**
   * Get countryName
   * @return countryName
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "United States of America", value = "")

  public String getCountryName() {
    return countryName;
  }


  public void setCountryName(String countryName) {

    
    
    
    this.countryName = countryName;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails countryCurrency(String countryCurrency) {

    
    
    
    
    this.countryCurrency = countryCurrency;
    return this;
  }

   /**
   * Get countryCurrency
   * @return countryCurrency
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "USD", value = "")

  public String getCountryCurrency() {
    return countryCurrency;
  }


  public void setCountryCurrency(String countryCurrency) {

    
    
    
    this.countryCurrency = countryCurrency;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails countryCallingCode(String countryCallingCode) {

    
    
    
    
    this.countryCallingCode = countryCallingCode;
    return this;
  }

   /**
   * Get countryCallingCode
   * @return countryCallingCode
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "1", value = "")

  public String getCountryCallingCode() {
    return countryCallingCode;
  }


  public void setCountryCallingCode(String countryCallingCode) {

    
    
    
    this.countryCallingCode = countryCallingCode;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails regionName(String regionName) {

    
    
    
    
    this.regionName = regionName;
    return this;
  }

   /**
   * Get regionName
   * @return regionName
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "California", value = "")

  public String getRegionName() {
    return regionName;
  }


  public void setRegionName(String regionName) {

    
    
    
    this.regionName = regionName;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails cityName(String cityName) {

    
    
    
    
    this.cityName = cityName;
    return this;
  }

   /**
   * Get cityName
   * @return cityName
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "Mountain View", value = "")

  public String getCityName() {
    return cityName;
  }


  public void setCityName(String cityName) {

    
    
    
    this.cityName = cityName;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails latitude(Double latitude) {

    
    
    
    
    this.latitude = latitude;
    return this;
  }

  public FraudScreenUserResponseEntityIpCheckResultIpDetails latitude(Integer latitude) {

    
    
    
    
    this.latitude = latitude.doubleValue();
    return this;
  }

   /**
   * Get latitude
   * @return latitude
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "37.40599060058594", value = "")

  public Double getLatitude() {
    return latitude;
  }


  public void setLatitude(Double latitude) {

    
    
    
    this.latitude = latitude;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails longitude(Double longitude) {

    
    
    
    
    this.longitude = longitude;
    return this;
  }

  public FraudScreenUserResponseEntityIpCheckResultIpDetails longitude(Integer longitude) {

    
    
    
    
    this.longitude = longitude.doubleValue();
    return this;
  }

   /**
   * Get longitude
   * @return longitude
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "-122.0785140991211", value = "")

  public Double getLongitude() {
    return longitude;
  }


  public void setLongitude(Double longitude) {

    
    
    
    this.longitude = longitude;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails isp(String isp) {

    
    
    
    
    this.isp = isp;
    return this;
  }

   /**
   * Get isp
   * @return isp
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "Google LLC", value = "")

  public String getIsp() {
    return isp;
  }


  public void setIsp(String isp) {

    
    
    
    this.isp = isp;
  }


  public FraudScreenUserResponseEntityIpCheckResultIpDetails asn(String asn) {

    
    
    
    
    this.asn = asn;
    return this;
  }

   /**
   * Get asn
   * @return asn
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "AS15169", value = "")

  public String getAsn() {
    return asn;
  }


  public void setAsn(String asn) {

    
    
    
    this.asn = asn;
  }

  /**
   * A container for additional, undeclared properties.
   * This is a holder for any undeclared properties as specified with
   * the 'additionalProperties' keyword in the OAS document.
   */
  private Map<String, Object> additionalProperties;

  /**
   * Set the additional (undeclared) property with the specified name and value.
   * If the property does not already exist, create it otherwise replace it.
   *
   * @param key name of the property
   * @param value value of the property
   * @return the FraudScreenUserResponseEntityIpCheckResultIpDetails instance itself
   */
  public FraudScreenUserResponseEntityIpCheckResultIpDetails putAdditionalProperty(String key, Object value) {
    if (this.additionalProperties == null) {
        this.additionalProperties = new HashMap<String, Object>();
    }
    this.additionalProperties.put(key, value);
    return this;
  }

  /**
   * Return the additional (undeclared) property.
   *
   * @return a map of objects
   */
  public Map<String, Object> getAdditionalProperties() {
    return additionalProperties;
  }

  /**
   * Return the additional (undeclared) property with the specified name.
   *
   * @param key name of the property
   * @return an object
   */
  public Object getAdditionalProperty(String key) {
    if (this.additionalProperties == null) {
        return null;
    }
    return this.additionalProperties.get(key);
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FraudScreenUserResponseEntityIpCheckResultIpDetails fraudScreenUserResponseEntityIpCheckResultIpDetails = (FraudScreenUserResponseEntityIpCheckResultIpDetails) o;
    return Objects.equals(this.reverseDns, fraudScreenUserResponseEntityIpCheckResultIpDetails.reverseDns) &&
        Objects.equals(this.continentCode, fraudScreenUserResponseEntityIpCheckResultIpDetails.continentCode) &&
        Objects.equals(this.continentName, fraudScreenUserResponseEntityIpCheckResultIpDetails.continentName) &&
        Objects.equals(this.countryCode, fraudScreenUserResponseEntityIpCheckResultIpDetails.countryCode) &&
        Objects.equals(this.countryName, fraudScreenUserResponseEntityIpCheckResultIpDetails.countryName) &&
        Objects.equals(this.countryCurrency, fraudScreenUserResponseEntityIpCheckResultIpDetails.countryCurrency) &&
        Objects.equals(this.countryCallingCode, fraudScreenUserResponseEntityIpCheckResultIpDetails.countryCallingCode) &&
        Objects.equals(this.regionName, fraudScreenUserResponseEntityIpCheckResultIpDetails.regionName) &&
        Objects.equals(this.cityName, fraudScreenUserResponseEntityIpCheckResultIpDetails.cityName) &&
        Objects.equals(this.latitude, fraudScreenUserResponseEntityIpCheckResultIpDetails.latitude) &&
        Objects.equals(this.longitude, fraudScreenUserResponseEntityIpCheckResultIpDetails.longitude) &&
        Objects.equals(this.isp, fraudScreenUserResponseEntityIpCheckResultIpDetails.isp) &&
        Objects.equals(this.asn, fraudScreenUserResponseEntityIpCheckResultIpDetails.asn)&&
        Objects.equals(this.additionalProperties, fraudScreenUserResponseEntityIpCheckResultIpDetails.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(reverseDns, continentCode, continentName, countryCode, countryName, countryCurrency, countryCallingCode, regionName, cityName, latitude, longitude, isp, asn, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FraudScreenUserResponseEntityIpCheckResultIpDetails {\n");
    sb.append("    reverseDns: ").append(toIndentedString(reverseDns)).append("\n");
    sb.append("    continentCode: ").append(toIndentedString(continentCode)).append("\n");
    sb.append("    continentName: ").append(toIndentedString(continentName)).append("\n");
    sb.append("    countryCode: ").append(toIndentedString(countryCode)).append("\n");
    sb.append("    countryName: ").append(toIndentedString(countryName)).append("\n");
    sb.append("    countryCurrency: ").append(toIndentedString(countryCurrency)).append("\n");
    sb.append("    countryCallingCode: ").append(toIndentedString(countryCallingCode)).append("\n");
    sb.append("    regionName: ").append(toIndentedString(regionName)).append("\n");
    sb.append("    cityName: ").append(toIndentedString(cityName)).append("\n");
    sb.append("    latitude: ").append(toIndentedString(latitude)).append("\n");
    sb.append("    longitude: ").append(toIndentedString(longitude)).append("\n");
    sb.append("    isp: ").append(toIndentedString(isp)).append("\n");
    sb.append("    asn: ").append(toIndentedString(asn)).append("\n");
    sb.append("    additionalProperties: ").append(toIndentedString(additionalProperties)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("reverse_dns");
    openapiFields.add("continent_code");
    openapiFields.add("continent_name");
    openapiFields.add("country_code");
    openapiFields.add("country_name");
    openapiFields.add("country_currency");
    openapiFields.add("country_calling_code");
    openapiFields.add("region_name");
    openapiFields.add("city_name");
    openapiFields.add("latitude");
    openapiFields.add("longitude");
    openapiFields.add("isp");
    openapiFields.add("asn");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to FraudScreenUserResponseEntityIpCheckResultIpDetails
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!FraudScreenUserResponseEntityIpCheckResultIpDetails.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in FraudScreenUserResponseEntityIpCheckResultIpDetails is not found in the empty JSON string", FraudScreenUserResponseEntityIpCheckResultIpDetails.openapiRequiredFields.toString()));
        }
      }
      if ((jsonObj.get("reverse_dns") != null && !jsonObj.get("reverse_dns").isJsonNull()) && !jsonObj.get("reverse_dns").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `reverse_dns` to be a primitive type in the JSON string but got `%s`", jsonObj.get("reverse_dns").toString()));
      }
      if ((jsonObj.get("continent_code") != null && !jsonObj.get("continent_code").isJsonNull()) && !jsonObj.get("continent_code").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `continent_code` to be a primitive type in the JSON string but got `%s`", jsonObj.get("continent_code").toString()));
      }
      if ((jsonObj.get("continent_name") != null && !jsonObj.get("continent_name").isJsonNull()) && !jsonObj.get("continent_name").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `continent_name` to be a primitive type in the JSON string but got `%s`", jsonObj.get("continent_name").toString()));
      }
      if ((jsonObj.get("country_code") != null && !jsonObj.get("country_code").isJsonNull()) && !jsonObj.get("country_code").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `country_code` to be a primitive type in the JSON string but got `%s`", jsonObj.get("country_code").toString()));
      }
      if ((jsonObj.get("country_name") != null && !jsonObj.get("country_name").isJsonNull()) && !jsonObj.get("country_name").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `country_name` to be a primitive type in the JSON string but got `%s`", jsonObj.get("country_name").toString()));
      }
      if ((jsonObj.get("country_currency") != null && !jsonObj.get("country_currency").isJsonNull()) && !jsonObj.get("country_currency").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `country_currency` to be a primitive type in the JSON string but got `%s`", jsonObj.get("country_currency").toString()));
      }
      if ((jsonObj.get("country_calling_code") != null && !jsonObj.get("country_calling_code").isJsonNull()) && !jsonObj.get("country_calling_code").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `country_calling_code` to be a primitive type in the JSON string but got `%s`", jsonObj.get("country_calling_code").toString()));
      }
      if ((jsonObj.get("region_name") != null && !jsonObj.get("region_name").isJsonNull()) && !jsonObj.get("region_name").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `region_name` to be a primitive type in the JSON string but got `%s`", jsonObj.get("region_name").toString()));
      }
      if ((jsonObj.get("city_name") != null && !jsonObj.get("city_name").isJsonNull()) && !jsonObj.get("city_name").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `city_name` to be a primitive type in the JSON string but got `%s`", jsonObj.get("city_name").toString()));
      }
      if ((jsonObj.get("isp") != null && !jsonObj.get("isp").isJsonNull()) && !jsonObj.get("isp").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `isp` to be a primitive type in the JSON string but got `%s`", jsonObj.get("isp").toString()));
      }
      if ((jsonObj.get("asn") != null && !jsonObj.get("asn").isJsonNull()) && !jsonObj.get("asn").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `asn` to be a primitive type in the JSON string but got `%s`", jsonObj.get("asn").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!FraudScreenUserResponseEntityIpCheckResultIpDetails.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'FraudScreenUserResponseEntityIpCheckResultIpDetails' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<FraudScreenUserResponseEntityIpCheckResultIpDetails> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(FraudScreenUserResponseEntityIpCheckResultIpDetails.class));

       return (TypeAdapter<T>) new TypeAdapter<FraudScreenUserResponseEntityIpCheckResultIpDetails>() {
           @Override
           public void write(JsonWriter out, FraudScreenUserResponseEntityIpCheckResultIpDetails value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             obj.remove("additionalProperties");
             // serialize additonal properties
             if (value.getAdditionalProperties() != null) {
               for (Map.Entry<String, Object> entry : value.getAdditionalProperties().entrySet()) {
                 if (entry.getValue() instanceof String)
                   obj.addProperty(entry.getKey(), (String) entry.getValue());
                 else if (entry.getValue() instanceof Number)
                   obj.addProperty(entry.getKey(), (Number) entry.getValue());
                 else if (entry.getValue() instanceof Boolean)
                   obj.addProperty(entry.getKey(), (Boolean) entry.getValue());
                 else if (entry.getValue() instanceof Character)
                   obj.addProperty(entry.getKey(), (Character) entry.getValue());
                 else {
                   obj.add(entry.getKey(), gson.toJsonTree(entry.getValue()).getAsJsonObject());
                 }
               }
             }
             elementAdapter.write(out, obj);
           }

           @Override
           public FraudScreenUserResponseEntityIpCheckResultIpDetails read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             // store additional fields in the deserialized instance
             FraudScreenUserResponseEntityIpCheckResultIpDetails instance = thisAdapter.fromJsonTree(jsonObj);
             for (Map.Entry<String, JsonElement> entry : jsonObj.entrySet()) {
               if (!openapiFields.contains(entry.getKey())) {
                 if (entry.getValue().isJsonPrimitive()) { // primitive type
                   if (entry.getValue().getAsJsonPrimitive().isString())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsString());
                   else if (entry.getValue().getAsJsonPrimitive().isNumber())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsNumber());
                   else if (entry.getValue().getAsJsonPrimitive().isBoolean())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsBoolean());
                   else
                     throw new IllegalArgumentException(String.format("The field `%s` has unknown primitive type. Value: %s", entry.getKey(), entry.getValue().toString()));
                 } else if (entry.getValue().isJsonArray()) {
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), List.class));
                 } else { // JSON object
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), HashMap.class));
                 }
               }
             }
             return instance;
           }

       }.nullSafe();
    }
  }

 /**
  * Create an instance of FraudScreenUserResponseEntityIpCheckResultIpDetails given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of FraudScreenUserResponseEntityIpCheckResultIpDetails
  * @throws IOException if the JSON string is invalid with respect to FraudScreenUserResponseEntityIpCheckResultIpDetails
  */
  public static FraudScreenUserResponseEntityIpCheckResultIpDetails fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, FraudScreenUserResponseEntityIpCheckResultIpDetails.class);
  }

 /**
  * Convert an instance of FraudScreenUserResponseEntityIpCheckResultIpDetails to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

