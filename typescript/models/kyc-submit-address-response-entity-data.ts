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
import { KycSubmitAddressResponseEntityDataApplicant } from './kyc-submit-address-response-entity-data-applicant';
// May contain unused imports in some cases
// @ts-ignore
import { KycSubmitAddressResponseEntityDataNeighbor } from './kyc-submit-address-response-entity-data-neighbor';

/**
 * 
 * @export
 * @interface KycSubmitAddressResponseEntityData
 */
export interface KycSubmitAddressResponseEntityData {
    /**
     * 
     * @type {KycSubmitAddressResponseEntityDataApplicant}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'applicant'?: KycSubmitAddressResponseEntityDataApplicant;
    /**
     * 
     * @type {string}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'lattitude'?: string;
    /**
     * 
     * @type {string}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'longitude'?: string;
    /**
     * 
     * @type {Array<string>}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'photos'?: Array<string>;
    /**
     * 
     * @type {KycSubmitAddressResponseEntityDataNeighbor}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'neighbor'?: KycSubmitAddressResponseEntityDataNeighbor;
    /**
     * 
     * @type {string}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'status'?: string;
    /**
     * 
     * @type {string}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'city'?: string;
    /**
     * 
     * @type {string}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'street'?: string;
    /**
     * 
     * @type {string}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'lga'?: string;
    /**
     * 
     * @type {string}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'state'?: string;
    /**
     * 
     * @type {string}
     * @memberof KycSubmitAddressResponseEntityData
     */
    'country'?: string;
}

