# CyberSource.Model.RiskV1AuthenticationExemptionsPost201ResponseConsumerAuthenticationInformationStrongAuthentication
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcquirerReferenceFraudRateThresholdExceeded** | **bool?** | Indicates if the Acquirer has exceeded the RFR for 180 consecutive days. (E.g. “true” if has exceeded, “false” otherwise).  | [optional] 
**IssuerReferenceFraudRateThresholdExceeded** | **bool?** | Indicates if the Issuer has exceeded the RFR for 180 consecutive days. (E.g. “True” if has exceeded, “False” otherwise).  | [optional] 
**IssuerReferenceFraudRateExceeded** | **bool?** | Indicates if the Issuer’s RFR exceeds the allowable level based on the amount in the request (E.g. “true” if has exceeded, “false” otherwise).  | [optional] 
**TotalAmountValueExceeded** | **bool?** | Indicates if the request amount has exceeded the maximum ETV rate. (E.g. “true” if exceeded, “false” otherwise).  | [optional] 
**EeaDomesticInd** | **bool?** | Indicates if the input qualifies as an EEA domestic transaction where both the Acquirer Country and Issuer Country are located in the EEA. (E.g. “1” if transaction qualifies, “0” otherwise).  | [optional] 
**AcquirerReferenceFraudRateExceeded** | **bool?** | Indicates if the Acquirer’s Reference Fraud Rate (RFR) exceeds the allowable level based on the amount in the request (E.g. “True” if has exceeded, “False” otherwise).  | [optional] 
**RiskAttributesPresent** | **bool?** | Risk Attribute Indicator based on required elements from Articles 2 &amp; 18 of the European Banking Authority (EBA) Guidelines (E.g. “True” if risk attributes present, “False” otherwise).  | [optional] 
**AuthenticationExemptionsId** | **string** | CYBS generated UUID used to identify the transaction. Note: 36 with hashes.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

