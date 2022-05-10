---
title: ArchitectJobStateResponse
---
## ININ.PureCloudApi.Model.ArchitectJobStateResponse

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Flow** | [**AddressableEntityRef**](AddressableEntityRef.html) | Flow created from the Architect Job | [optional] |
| **Status** | **string** | Status of the Architect Job | [optional] |
| **Command** | **string** | The command executed by the Architect Job | [optional] |
| **Messages** | [**List&lt;ArchitectJobMessage&gt;**](ArchitectJobMessage.html) | Warnings and Errors messages of the Architect Job | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}

