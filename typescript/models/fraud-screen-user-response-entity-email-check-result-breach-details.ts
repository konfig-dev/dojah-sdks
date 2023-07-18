/* tslint:disable */
/* eslint-disable */
/**
 * DOJAH Publilc APIs
 * Use Dojah to verify, onboard and manage user identity across Africa!
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This file is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */

// May contain unused imports in some cases
// @ts-ignore
import { FraudScreenUserResponseEntityEmailCheckResultBreachDetailsBreachesInner } from './fraud-screen-user-response-entity-email-check-result-breach-details-breaches-inner';

/**
 * 
 * @export
 * @interface FraudScreenUserResponseEntityEmailCheckResultBreachDetails
 */
export interface FraudScreenUserResponseEntityEmailCheckResultBreachDetails {
    /**
     * 
     * @type {boolean}
     * @memberof FraudScreenUserResponseEntityEmailCheckResultBreachDetails
     */
    'haveibeenpwned_listed'?: boolean;
    /**
     * 
     * @type {number}
     * @memberof FraudScreenUserResponseEntityEmailCheckResultBreachDetails
     */
    'number_of_breaches'?: number;
    /**
     * 
     * @type {string}
     * @memberof FraudScreenUserResponseEntityEmailCheckResultBreachDetails
     */
    'first_breach'?: string;
    /**
     * 
     * @type {Array<FraudScreenUserResponseEntityEmailCheckResultBreachDetailsBreachesInner>}
     * @memberof FraudScreenUserResponseEntityEmailCheckResultBreachDetails
     */
    'breaches'?: Array<FraudScreenUserResponseEntityEmailCheckResultBreachDetailsBreachesInner>;
}

