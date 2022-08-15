
# Org.OpenAPITools.Model.CCProject

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectId** | **string** | The ID of the project. This is auto-generated upon project creation and cannot currently be changed.  | 
**Name** | **string** | The name of the project. This is shown to your users and should identify your company or organization.  | 
**Description** | **string** | The description of your project / company.  | [optional] 
**Webhook** | **string** | A URL that identifies where we should make an API request to notify you of a new payment (e.g., api.myproject.com/crypto_payments/webhook). Learn more [here](#tag/CC-Webhook/operation/getCCWebhook).  | [optional] 
**Website** | **string** | The website of your project / company.  | [optional] 
**DiscordWebhook** | **string** | A Discord webhook. We will send a message to this channel to notify of payment. Learn more [here]().  | [optional] 
**LogoUrl** | **string** | A URL of your logo.  | [optional] 
**CustomerIdToCollect** | [**CCProjectCreateRequestCustomerIdToCollect**](CCProjectCreateRequestCustomerIdToCollect.md) |  | [optional] 
**SuccessUrl** | **string** | Where to redirect customers after payment. If not supplied, customers will be redirected to checkout.blockchainapi.com/me to view their subscriptions.  | [optional] 
**PayoutMethod** | [**CCProjectCreateRequestPayoutMethod**](CCProjectCreateRequestPayoutMethod.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

