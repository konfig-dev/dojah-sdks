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
 * GetSsnitResponseEntity
 */
@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class GetSsnitResponseEntity {
  public static final String SERIALIZED_NAME_CARD_SERIAL = "card_serial";
  @SerializedName(SERIALIZED_NAME_CARD_SERIAL)
  private String cardSerial;

  public static final String SERIALIZED_NAME_DATE_OF_BIRTH = "date_of_birth";
  @SerializedName(SERIALIZED_NAME_DATE_OF_BIRTH)
  private String dateOfBirth;

  public static final String SERIALIZED_NAME_FULL_NAME = "full_name";
  @SerializedName(SERIALIZED_NAME_FULL_NAME)
  private String fullName;

  public static final String SERIALIZED_NAME_GENDER = "gender";
  @SerializedName(SERIALIZED_NAME_GENDER)
  private String gender;

  public static final String SERIALIZED_NAME_ID = "id";
  @SerializedName(SERIALIZED_NAME_ID)
  private String id;

  public static final String SERIALIZED_NAME_IS_DATE_OF_BIRTH_MATCH = "is_date_of_birth_match";
  @SerializedName(SERIALIZED_NAME_IS_DATE_OF_BIRTH_MATCH)
  private Boolean isDateOfBirthMatch;

  public static final String SERIALIZED_NAME_IS_FULL_NAME_MATCH = "is_full_name_match";
  @SerializedName(SERIALIZED_NAME_IS_FULL_NAME_MATCH)
  private Boolean isFullNameMatch;

  public static final String SERIALIZED_NAME_PICTURE = "picture";
  @SerializedName(SERIALIZED_NAME_PICTURE)
  private String picture;

  public static final String SERIALIZED_NAME_STATUS = "status";
  @SerializedName(SERIALIZED_NAME_STATUS)
  private Double status;

  public GetSsnitResponseEntity() {
  }

  public GetSsnitResponseEntity cardSerial(String cardSerial) {

    
    
    
    
    this.cardSerial = cardSerial;
    return this;
  }

   /**
   * Get cardSerial
   * @return cardSerial
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "R1970200019702", value = "")

  public String getCardSerial() {
    return cardSerial;
  }


  public void setCardSerial(String cardSerial) {

    
    
    
    this.cardSerial = cardSerial;
  }


  public GetSsnitResponseEntity dateOfBirth(String dateOfBirth) {

    
    
    
    
    this.dateOfBirth = dateOfBirth;
    return this;
  }

   /**
   * Get dateOfBirth
   * @return dateOfBirth
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "1980-02-03", value = "")

  public String getDateOfBirth() {
    return dateOfBirth;
  }


  public void setDateOfBirth(String dateOfBirth) {

    
    
    
    this.dateOfBirth = dateOfBirth;
  }


  public GetSsnitResponseEntity fullName(String fullName) {

    
    
    
    
    this.fullName = fullName;
    return this;
  }

   /**
   * Get fullName
   * @return fullName
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "John Doe", value = "")

  public String getFullName() {
    return fullName;
  }


  public void setFullName(String fullName) {

    
    
    
    this.fullName = fullName;
  }


  public GetSsnitResponseEntity gender(String gender) {

    
    
    
    
    this.gender = gender;
    return this;
  }

   /**
   * Get gender
   * @return gender
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "MALE", value = "")

  public String getGender() {
    return gender;
  }


  public void setGender(String gender) {

    
    
    
    this.gender = gender;
  }


  public GetSsnitResponseEntity id(String id) {

    
    
    
    
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "C000000000000", value = "")

  public String getId() {
    return id;
  }


  public void setId(String id) {

    
    
    
    this.id = id;
  }


  public GetSsnitResponseEntity isDateOfBirthMatch(Boolean isDateOfBirthMatch) {

    
    
    
    
    this.isDateOfBirthMatch = isDateOfBirthMatch;
    return this;
  }

   /**
   * Get isDateOfBirthMatch
   * @return isDateOfBirthMatch
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "true", value = "")

  public Boolean getIsDateOfBirthMatch() {
    return isDateOfBirthMatch;
  }


  public void setIsDateOfBirthMatch(Boolean isDateOfBirthMatch) {

    
    
    
    this.isDateOfBirthMatch = isDateOfBirthMatch;
  }


  public GetSsnitResponseEntity isFullNameMatch(Boolean isFullNameMatch) {

    
    
    
    
    this.isFullNameMatch = isFullNameMatch;
    return this;
  }

   /**
   * Get isFullNameMatch
   * @return isFullNameMatch
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "true", value = "")

  public Boolean getIsFullNameMatch() {
    return isFullNameMatch;
  }


  public void setIsFullNameMatch(Boolean isFullNameMatch) {

    
    
    
    this.isFullNameMatch = isFullNameMatch;
  }


  public GetSsnitResponseEntity picture(String picture) {

    
    
    
    
    this.picture = picture;
    return this;
  }

   /**
   * Get picture
   * @return picture
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "<base64 encoded image>", value = "")

  public String getPicture() {
    return picture;
  }


  public void setPicture(String picture) {

    
    
    
    this.picture = picture;
  }


  public GetSsnitResponseEntity status(Double status) {

    
    
    
    
    this.status = status;
    return this;
  }

  public GetSsnitResponseEntity status(Integer status) {

    
    
    
    
    this.status = status.doubleValue();
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "200", value = "")

  public Double getStatus() {
    return status;
  }


  public void setStatus(Double status) {

    
    
    
    this.status = status;
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
   * @return the GetSsnitResponseEntity instance itself
   */
  public GetSsnitResponseEntity putAdditionalProperty(String key, Object value) {
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
    GetSsnitResponseEntity getSsnitResponseEntity = (GetSsnitResponseEntity) o;
    return Objects.equals(this.cardSerial, getSsnitResponseEntity.cardSerial) &&
        Objects.equals(this.dateOfBirth, getSsnitResponseEntity.dateOfBirth) &&
        Objects.equals(this.fullName, getSsnitResponseEntity.fullName) &&
        Objects.equals(this.gender, getSsnitResponseEntity.gender) &&
        Objects.equals(this.id, getSsnitResponseEntity.id) &&
        Objects.equals(this.isDateOfBirthMatch, getSsnitResponseEntity.isDateOfBirthMatch) &&
        Objects.equals(this.isFullNameMatch, getSsnitResponseEntity.isFullNameMatch) &&
        Objects.equals(this.picture, getSsnitResponseEntity.picture) &&
        Objects.equals(this.status, getSsnitResponseEntity.status)&&
        Objects.equals(this.additionalProperties, getSsnitResponseEntity.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cardSerial, dateOfBirth, fullName, gender, id, isDateOfBirthMatch, isFullNameMatch, picture, status, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GetSsnitResponseEntity {\n");
    sb.append("    cardSerial: ").append(toIndentedString(cardSerial)).append("\n");
    sb.append("    dateOfBirth: ").append(toIndentedString(dateOfBirth)).append("\n");
    sb.append("    fullName: ").append(toIndentedString(fullName)).append("\n");
    sb.append("    gender: ").append(toIndentedString(gender)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    isDateOfBirthMatch: ").append(toIndentedString(isDateOfBirthMatch)).append("\n");
    sb.append("    isFullNameMatch: ").append(toIndentedString(isFullNameMatch)).append("\n");
    sb.append("    picture: ").append(toIndentedString(picture)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
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
    openapiFields.add("card_serial");
    openapiFields.add("date_of_birth");
    openapiFields.add("full_name");
    openapiFields.add("gender");
    openapiFields.add("id");
    openapiFields.add("is_date_of_birth_match");
    openapiFields.add("is_full_name_match");
    openapiFields.add("picture");
    openapiFields.add("status");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to GetSsnitResponseEntity
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!GetSsnitResponseEntity.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in GetSsnitResponseEntity is not found in the empty JSON string", GetSsnitResponseEntity.openapiRequiredFields.toString()));
        }
      }
      if ((jsonObj.get("card_serial") != null && !jsonObj.get("card_serial").isJsonNull()) && !jsonObj.get("card_serial").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `card_serial` to be a primitive type in the JSON string but got `%s`", jsonObj.get("card_serial").toString()));
      }
      if ((jsonObj.get("date_of_birth") != null && !jsonObj.get("date_of_birth").isJsonNull()) && !jsonObj.get("date_of_birth").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `date_of_birth` to be a primitive type in the JSON string but got `%s`", jsonObj.get("date_of_birth").toString()));
      }
      if ((jsonObj.get("full_name") != null && !jsonObj.get("full_name").isJsonNull()) && !jsonObj.get("full_name").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `full_name` to be a primitive type in the JSON string but got `%s`", jsonObj.get("full_name").toString()));
      }
      if ((jsonObj.get("gender") != null && !jsonObj.get("gender").isJsonNull()) && !jsonObj.get("gender").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `gender` to be a primitive type in the JSON string but got `%s`", jsonObj.get("gender").toString()));
      }
      if ((jsonObj.get("id") != null && !jsonObj.get("id").isJsonNull()) && !jsonObj.get("id").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `id` to be a primitive type in the JSON string but got `%s`", jsonObj.get("id").toString()));
      }
      if ((jsonObj.get("picture") != null && !jsonObj.get("picture").isJsonNull()) && !jsonObj.get("picture").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `picture` to be a primitive type in the JSON string but got `%s`", jsonObj.get("picture").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!GetSsnitResponseEntity.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'GetSsnitResponseEntity' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<GetSsnitResponseEntity> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(GetSsnitResponseEntity.class));

       return (TypeAdapter<T>) new TypeAdapter<GetSsnitResponseEntity>() {
           @Override
           public void write(JsonWriter out, GetSsnitResponseEntity value) throws IOException {
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
           public GetSsnitResponseEntity read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             // store additional fields in the deserialized instance
             GetSsnitResponseEntity instance = thisAdapter.fromJsonTree(jsonObj);
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
  * Create an instance of GetSsnitResponseEntity given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of GetSsnitResponseEntity
  * @throws IOException if the JSON string is invalid with respect to GetSsnitResponseEntity
  */
  public static GetSsnitResponseEntity fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, GetSsnitResponseEntity.class);
  }

 /**
  * Convert an instance of GetSsnitResponseEntity to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

