/*
 * DOJAH APIs
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
 * GetAccountAnalysisResponseEntityAccountBreakdown
 */
@javax.annotation.Generated(value = "Generated by https://konfigthis.com")
public class GetAccountAnalysisResponseEntityAccountBreakdown {
  public static final String SERIALIZED_NAME_TOTAL_CREDIT_ENTRY = "TotalCreditEntry";
  @SerializedName(SERIALIZED_NAME_TOTAL_CREDIT_ENTRY)
  private Double totalCreditEntry;

  public static final String SERIALIZED_NAME_TOTAL_DEBIT_MADE = "TotalDebitMade";
  @SerializedName(SERIALIZED_NAME_TOTAL_DEBIT_MADE)
  private Double totalDebitMade;

  public static final String SERIALIZED_NAME_AVERAGE_MONTHLY_BALANCE = "averageMonthlyBalance";
  @SerializedName(SERIALIZED_NAME_AVERAGE_MONTHLY_BALANCE)
  private Double averageMonthlyBalance;

  public static final String SERIALIZED_NAME_AVERAGE_MONTHLY_CREDITS = "averageMonthlyCredits";
  @SerializedName(SERIALIZED_NAME_AVERAGE_MONTHLY_CREDITS)
  private Double averageMonthlyCredits;

  public static final String SERIALIZED_NAME_AVERAGE_MONTHLY_DEBITS = "averageMonthlyDebits";
  @SerializedName(SERIALIZED_NAME_AVERAGE_MONTHLY_DEBITS)
  private Double averageMonthlyDebits;

  public static final String SERIALIZED_NAME_AVERAGE_WEEKLY_BALANCE = "averageWeeklyBalance";
  @SerializedName(SERIALIZED_NAME_AVERAGE_WEEKLY_BALANCE)
  private Double averageWeeklyBalance;

  public static final String SERIALIZED_NAME_AVERAGE_WEEKLY_CREDITS = "averageWeeklyCredits";
  @SerializedName(SERIALIZED_NAME_AVERAGE_WEEKLY_CREDITS)
  private Double averageWeeklyCredits;

  public static final String SERIALIZED_NAME_AVERAGE_WEEKLY_DEBITS = "averageWeeklyDebits";
  @SerializedName(SERIALIZED_NAME_AVERAGE_WEEKLY_DEBITS)
  private Double averageWeeklyDebits;

  public static final String SERIALIZED_NAME_CLOSING_BALANCE = "closingBalance";
  @SerializedName(SERIALIZED_NAME_CLOSING_BALANCE)
  private Double closingBalance;

  public static final String SERIALIZED_NAME_FIRST_DATE_IN_STATEMENT = "firstDateInStatement";
  @SerializedName(SERIALIZED_NAME_FIRST_DATE_IN_STATEMENT)
  private String firstDateInStatement;

  public static final String SERIALIZED_NAME_LAST_DATE_IN_STATEMENT = "lastDateInStatement";
  @SerializedName(SERIALIZED_NAME_LAST_DATE_IN_STATEMENT)
  private String lastDateInStatement;

  public static final String SERIALIZED_NAME_NUMBER_OF_TRANSACTING_MONTHS = "numberOfTransactingMonths";
  @SerializedName(SERIALIZED_NAME_NUMBER_OF_TRANSACTING_MONTHS)
  private Double numberOfTransactingMonths;

  public static final String SERIALIZED_NAME_PERIOD_IN_STATEMENT = "periodInStatement";
  @SerializedName(SERIALIZED_NAME_PERIOD_IN_STATEMENT)
  private String periodInStatement;

  public static final String SERIALIZED_NAME_YEAR_IN_STATEMENT = "yearInStatement";
  @SerializedName(SERIALIZED_NAME_YEAR_IN_STATEMENT)
  private String yearInStatement;

  public GetAccountAnalysisResponseEntityAccountBreakdown() {
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown totalCreditEntry(Double totalCreditEntry) {

    
    
    
    
    this.totalCreditEntry = totalCreditEntry;
    return this;
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown totalCreditEntry(Integer totalCreditEntry) {

    
    
    
    
    this.totalCreditEntry = totalCreditEntry.doubleValue();
    return this;
  }

   /**
   * Get totalCreditEntry
   * @return totalCreditEntry
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "306935.75", value = "")

  public Double getTotalCreditEntry() {
    return totalCreditEntry;
  }


  public void setTotalCreditEntry(Double totalCreditEntry) {

    
    
    
    this.totalCreditEntry = totalCreditEntry;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown totalDebitMade(Double totalDebitMade) {

    
    
    
    
    this.totalDebitMade = totalDebitMade;
    return this;
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown totalDebitMade(Integer totalDebitMade) {

    
    
    
    
    this.totalDebitMade = totalDebitMade.doubleValue();
    return this;
  }

   /**
   * Get totalDebitMade
   * @return totalDebitMade
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "321986.57", value = "")

  public Double getTotalDebitMade() {
    return totalDebitMade;
  }


  public void setTotalDebitMade(Double totalDebitMade) {

    
    
    
    this.totalDebitMade = totalDebitMade;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown averageMonthlyBalance(Double averageMonthlyBalance) {

    
    
    
    
    this.averageMonthlyBalance = averageMonthlyBalance;
    return this;
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown averageMonthlyBalance(Integer averageMonthlyBalance) {

    
    
    
    
    this.averageMonthlyBalance = averageMonthlyBalance.doubleValue();
    return this;
  }

   /**
   * Get averageMonthlyBalance
   * @return averageMonthlyBalance
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "0", value = "")

  public Double getAverageMonthlyBalance() {
    return averageMonthlyBalance;
  }


  public void setAverageMonthlyBalance(Double averageMonthlyBalance) {

    
    
    
    this.averageMonthlyBalance = averageMonthlyBalance;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown averageMonthlyCredits(Double averageMonthlyCredits) {

    
    
    
    
    this.averageMonthlyCredits = averageMonthlyCredits;
    return this;
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown averageMonthlyCredits(Integer averageMonthlyCredits) {

    
    
    
    
    this.averageMonthlyCredits = averageMonthlyCredits.doubleValue();
    return this;
  }

   /**
   * Get averageMonthlyCredits
   * @return averageMonthlyCredits
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "25577.98", value = "")

  public Double getAverageMonthlyCredits() {
    return averageMonthlyCredits;
  }


  public void setAverageMonthlyCredits(Double averageMonthlyCredits) {

    
    
    
    this.averageMonthlyCredits = averageMonthlyCredits;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown averageMonthlyDebits(Double averageMonthlyDebits) {

    
    
    
    
    this.averageMonthlyDebits = averageMonthlyDebits;
    return this;
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown averageMonthlyDebits(Integer averageMonthlyDebits) {

    
    
    
    
    this.averageMonthlyDebits = averageMonthlyDebits.doubleValue();
    return this;
  }

   /**
   * Get averageMonthlyDebits
   * @return averageMonthlyDebits
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "20124.16", value = "")

  public Double getAverageMonthlyDebits() {
    return averageMonthlyDebits;
  }


  public void setAverageMonthlyDebits(Double averageMonthlyDebits) {

    
    
    
    this.averageMonthlyDebits = averageMonthlyDebits;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown averageWeeklyBalance(Double averageWeeklyBalance) {

    
    
    
    
    this.averageWeeklyBalance = averageWeeklyBalance;
    return this;
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown averageWeeklyBalance(Integer averageWeeklyBalance) {

    
    
    
    
    this.averageWeeklyBalance = averageWeeklyBalance.doubleValue();
    return this;
  }

   /**
   * Get averageWeeklyBalance
   * @return averageWeeklyBalance
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "0", value = "")

  public Double getAverageWeeklyBalance() {
    return averageWeeklyBalance;
  }


  public void setAverageWeeklyBalance(Double averageWeeklyBalance) {

    
    
    
    this.averageWeeklyBalance = averageWeeklyBalance;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown averageWeeklyCredits(Double averageWeeklyCredits) {

    
    
    
    
    this.averageWeeklyCredits = averageWeeklyCredits;
    return this;
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown averageWeeklyCredits(Integer averageWeeklyCredits) {

    
    
    
    
    this.averageWeeklyCredits = averageWeeklyCredits.doubleValue();
    return this;
  }

   /**
   * Get averageWeeklyCredits
   * @return averageWeeklyCredits
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "6530.55", value = "")

  public Double getAverageWeeklyCredits() {
    return averageWeeklyCredits;
  }


  public void setAverageWeeklyCredits(Double averageWeeklyCredits) {

    
    
    
    this.averageWeeklyCredits = averageWeeklyCredits;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown averageWeeklyDebits(Double averageWeeklyDebits) {

    
    
    
    
    this.averageWeeklyDebits = averageWeeklyDebits;
    return this;
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown averageWeeklyDebits(Integer averageWeeklyDebits) {

    
    
    
    
    this.averageWeeklyDebits = averageWeeklyDebits.doubleValue();
    return this;
  }

   /**
   * Get averageWeeklyDebits
   * @return averageWeeklyDebits
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "5031.04", value = "")

  public Double getAverageWeeklyDebits() {
    return averageWeeklyDebits;
  }


  public void setAverageWeeklyDebits(Double averageWeeklyDebits) {

    
    
    
    this.averageWeeklyDebits = averageWeeklyDebits;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown closingBalance(Double closingBalance) {

    
    
    
    
    this.closingBalance = closingBalance;
    return this;
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown closingBalance(Integer closingBalance) {

    
    
    
    
    this.closingBalance = closingBalance.doubleValue();
    return this;
  }

   /**
   * Get closingBalance
   * @return closingBalance
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "0", value = "")

  public Double getClosingBalance() {
    return closingBalance;
  }


  public void setClosingBalance(Double closingBalance) {

    
    
    
    this.closingBalance = closingBalance;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown firstDateInStatement(String firstDateInStatement) {

    
    
    
    
    this.firstDateInStatement = firstDateInStatement;
    return this;
  }

   /**
   * Get firstDateInStatement
   * @return firstDateInStatement
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "2021-04-12", value = "")

  public String getFirstDateInStatement() {
    return firstDateInStatement;
  }


  public void setFirstDateInStatement(String firstDateInStatement) {

    
    
    
    this.firstDateInStatement = firstDateInStatement;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown lastDateInStatement(String lastDateInStatement) {

    
    
    
    
    this.lastDateInStatement = lastDateInStatement;
    return this;
  }

   /**
   * Get lastDateInStatement
   * @return lastDateInStatement
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "2022-07-03", value = "")

  public String getLastDateInStatement() {
    return lastDateInStatement;
  }


  public void setLastDateInStatement(String lastDateInStatement) {

    
    
    
    this.lastDateInStatement = lastDateInStatement;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown numberOfTransactingMonths(Double numberOfTransactingMonths) {

    
    
    
    
    this.numberOfTransactingMonths = numberOfTransactingMonths;
    return this;
  }

  public GetAccountAnalysisResponseEntityAccountBreakdown numberOfTransactingMonths(Integer numberOfTransactingMonths) {

    
    
    
    
    this.numberOfTransactingMonths = numberOfTransactingMonths.doubleValue();
    return this;
  }

   /**
   * Get numberOfTransactingMonths
   * @return numberOfTransactingMonths
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "6", value = "")

  public Double getNumberOfTransactingMonths() {
    return numberOfTransactingMonths;
  }


  public void setNumberOfTransactingMonths(Double numberOfTransactingMonths) {

    
    
    
    this.numberOfTransactingMonths = numberOfTransactingMonths;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown periodInStatement(String periodInStatement) {

    
    
    
    
    this.periodInStatement = periodInStatement;
    return this;
  }

   /**
   * Get periodInStatement
   * @return periodInStatement
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "April - July", value = "")

  public String getPeriodInStatement() {
    return periodInStatement;
  }


  public void setPeriodInStatement(String periodInStatement) {

    
    
    
    this.periodInStatement = periodInStatement;
  }


  public GetAccountAnalysisResponseEntityAccountBreakdown yearInStatement(String yearInStatement) {

    
    
    
    
    this.yearInStatement = yearInStatement;
    return this;
  }

   /**
   * Get yearInStatement
   * @return yearInStatement
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(example = "2021, 2022", value = "")

  public String getYearInStatement() {
    return yearInStatement;
  }


  public void setYearInStatement(String yearInStatement) {

    
    
    
    this.yearInStatement = yearInStatement;
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
   * @return the GetAccountAnalysisResponseEntityAccountBreakdown instance itself
   */
  public GetAccountAnalysisResponseEntityAccountBreakdown putAdditionalProperty(String key, Object value) {
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
    GetAccountAnalysisResponseEntityAccountBreakdown getAccountAnalysisResponseEntityAccountBreakdown = (GetAccountAnalysisResponseEntityAccountBreakdown) o;
    return Objects.equals(this.totalCreditEntry, getAccountAnalysisResponseEntityAccountBreakdown.totalCreditEntry) &&
        Objects.equals(this.totalDebitMade, getAccountAnalysisResponseEntityAccountBreakdown.totalDebitMade) &&
        Objects.equals(this.averageMonthlyBalance, getAccountAnalysisResponseEntityAccountBreakdown.averageMonthlyBalance) &&
        Objects.equals(this.averageMonthlyCredits, getAccountAnalysisResponseEntityAccountBreakdown.averageMonthlyCredits) &&
        Objects.equals(this.averageMonthlyDebits, getAccountAnalysisResponseEntityAccountBreakdown.averageMonthlyDebits) &&
        Objects.equals(this.averageWeeklyBalance, getAccountAnalysisResponseEntityAccountBreakdown.averageWeeklyBalance) &&
        Objects.equals(this.averageWeeklyCredits, getAccountAnalysisResponseEntityAccountBreakdown.averageWeeklyCredits) &&
        Objects.equals(this.averageWeeklyDebits, getAccountAnalysisResponseEntityAccountBreakdown.averageWeeklyDebits) &&
        Objects.equals(this.closingBalance, getAccountAnalysisResponseEntityAccountBreakdown.closingBalance) &&
        Objects.equals(this.firstDateInStatement, getAccountAnalysisResponseEntityAccountBreakdown.firstDateInStatement) &&
        Objects.equals(this.lastDateInStatement, getAccountAnalysisResponseEntityAccountBreakdown.lastDateInStatement) &&
        Objects.equals(this.numberOfTransactingMonths, getAccountAnalysisResponseEntityAccountBreakdown.numberOfTransactingMonths) &&
        Objects.equals(this.periodInStatement, getAccountAnalysisResponseEntityAccountBreakdown.periodInStatement) &&
        Objects.equals(this.yearInStatement, getAccountAnalysisResponseEntityAccountBreakdown.yearInStatement)&&
        Objects.equals(this.additionalProperties, getAccountAnalysisResponseEntityAccountBreakdown.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(totalCreditEntry, totalDebitMade, averageMonthlyBalance, averageMonthlyCredits, averageMonthlyDebits, averageWeeklyBalance, averageWeeklyCredits, averageWeeklyDebits, closingBalance, firstDateInStatement, lastDateInStatement, numberOfTransactingMonths, periodInStatement, yearInStatement, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GetAccountAnalysisResponseEntityAccountBreakdown {\n");
    sb.append("    totalCreditEntry: ").append(toIndentedString(totalCreditEntry)).append("\n");
    sb.append("    totalDebitMade: ").append(toIndentedString(totalDebitMade)).append("\n");
    sb.append("    averageMonthlyBalance: ").append(toIndentedString(averageMonthlyBalance)).append("\n");
    sb.append("    averageMonthlyCredits: ").append(toIndentedString(averageMonthlyCredits)).append("\n");
    sb.append("    averageMonthlyDebits: ").append(toIndentedString(averageMonthlyDebits)).append("\n");
    sb.append("    averageWeeklyBalance: ").append(toIndentedString(averageWeeklyBalance)).append("\n");
    sb.append("    averageWeeklyCredits: ").append(toIndentedString(averageWeeklyCredits)).append("\n");
    sb.append("    averageWeeklyDebits: ").append(toIndentedString(averageWeeklyDebits)).append("\n");
    sb.append("    closingBalance: ").append(toIndentedString(closingBalance)).append("\n");
    sb.append("    firstDateInStatement: ").append(toIndentedString(firstDateInStatement)).append("\n");
    sb.append("    lastDateInStatement: ").append(toIndentedString(lastDateInStatement)).append("\n");
    sb.append("    numberOfTransactingMonths: ").append(toIndentedString(numberOfTransactingMonths)).append("\n");
    sb.append("    periodInStatement: ").append(toIndentedString(periodInStatement)).append("\n");
    sb.append("    yearInStatement: ").append(toIndentedString(yearInStatement)).append("\n");
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
    openapiFields.add("TotalCreditEntry");
    openapiFields.add("TotalDebitMade");
    openapiFields.add("averageMonthlyBalance");
    openapiFields.add("averageMonthlyCredits");
    openapiFields.add("averageMonthlyDebits");
    openapiFields.add("averageWeeklyBalance");
    openapiFields.add("averageWeeklyCredits");
    openapiFields.add("averageWeeklyDebits");
    openapiFields.add("closingBalance");
    openapiFields.add("firstDateInStatement");
    openapiFields.add("lastDateInStatement");
    openapiFields.add("numberOfTransactingMonths");
    openapiFields.add("periodInStatement");
    openapiFields.add("yearInStatement");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

 /**
  * Validates the JSON Object and throws an exception if issues found
  *
  * @param jsonObj JSON Object
  * @throws IOException if the JSON Object is invalid with respect to GetAccountAnalysisResponseEntityAccountBreakdown
  */
  public static void validateJsonObject(JsonObject jsonObj) throws IOException {
      if (jsonObj == null) {
        if (!GetAccountAnalysisResponseEntityAccountBreakdown.openapiRequiredFields.isEmpty()) { // has required fields but JSON object is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in GetAccountAnalysisResponseEntityAccountBreakdown is not found in the empty JSON string", GetAccountAnalysisResponseEntityAccountBreakdown.openapiRequiredFields.toString()));
        }
      }
      if ((jsonObj.get("firstDateInStatement") != null && !jsonObj.get("firstDateInStatement").isJsonNull()) && !jsonObj.get("firstDateInStatement").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `firstDateInStatement` to be a primitive type in the JSON string but got `%s`", jsonObj.get("firstDateInStatement").toString()));
      }
      if ((jsonObj.get("lastDateInStatement") != null && !jsonObj.get("lastDateInStatement").isJsonNull()) && !jsonObj.get("lastDateInStatement").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `lastDateInStatement` to be a primitive type in the JSON string but got `%s`", jsonObj.get("lastDateInStatement").toString()));
      }
      if ((jsonObj.get("periodInStatement") != null && !jsonObj.get("periodInStatement").isJsonNull()) && !jsonObj.get("periodInStatement").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `periodInStatement` to be a primitive type in the JSON string but got `%s`", jsonObj.get("periodInStatement").toString()));
      }
      if ((jsonObj.get("yearInStatement") != null && !jsonObj.get("yearInStatement").isJsonNull()) && !jsonObj.get("yearInStatement").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `yearInStatement` to be a primitive type in the JSON string but got `%s`", jsonObj.get("yearInStatement").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!GetAccountAnalysisResponseEntityAccountBreakdown.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'GetAccountAnalysisResponseEntityAccountBreakdown' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<GetAccountAnalysisResponseEntityAccountBreakdown> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(GetAccountAnalysisResponseEntityAccountBreakdown.class));

       return (TypeAdapter<T>) new TypeAdapter<GetAccountAnalysisResponseEntityAccountBreakdown>() {
           @Override
           public void write(JsonWriter out, GetAccountAnalysisResponseEntityAccountBreakdown value) throws IOException {
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
           public GetAccountAnalysisResponseEntityAccountBreakdown read(JsonReader in) throws IOException {
             JsonObject jsonObj = elementAdapter.read(in).getAsJsonObject();
             validateJsonObject(jsonObj);
             // store additional fields in the deserialized instance
             GetAccountAnalysisResponseEntityAccountBreakdown instance = thisAdapter.fromJsonTree(jsonObj);
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
  * Create an instance of GetAccountAnalysisResponseEntityAccountBreakdown given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of GetAccountAnalysisResponseEntityAccountBreakdown
  * @throws IOException if the JSON string is invalid with respect to GetAccountAnalysisResponseEntityAccountBreakdown
  */
  public static GetAccountAnalysisResponseEntityAccountBreakdown fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, GetAccountAnalysisResponseEntityAccountBreakdown.class);
  }

 /**
  * Convert an instance of GetAccountAnalysisResponseEntityAccountBreakdown to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

