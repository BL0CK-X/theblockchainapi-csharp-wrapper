
# Org.OpenAPITools.Model.Endpoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectId** | **string** | The ID of the project. This is auto-generated upon project creation and cannot currently be changed.  | 
**_Version** | **string** | The project version under which the endpoint exists  | 
**Path** | **string** | The path of the endpoint  | 
**OperationId** | **string** | The operation ID of the endpoint.  | 
**ReadableName** | **string** | The name of the endpoint formatted in a readable way (e.g., Get Endpoint Metadata).  | 
**Summary** | **string** | The summary of the endpoint to be displayed in the sidebar on the left of the mini-API&#39;s documentation  | [optional] 
**Description** | **string** | A description of what the endpoint does. This will be shown in the mini-API documentation.  | [optional] 
**Credits** | **decimal** | The price of the endpoint. Valid values are integers from 1 to 100.  | 
**GroupName** | **string** | The name of the group of endpoints that the endpoint comes from  | [optional] 
**InputSpecification** | [**List&lt;ParameterSpecification&gt;**](ParameterSpecification.md) | A list of dictionaries. Each dictionary describes one parameter for the input, including the name, type, required boolean, and description values of that parameter. | 
**InputExamples** | **Object** | An example of the JSON input that a user might send. Limited to one example currently.  | 
**OutputSpecification** | [**List&lt;ParameterSpecification&gt;**](ParameterSpecification.md) | A list of dictionaries. Each dictionary describes one parameter for the input, including the name, type, required boolean, and description values of that parameter. | 
**OutputExamples** | **Object** | An example of the JSON output that a user might send. Limited to one example currently.  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

