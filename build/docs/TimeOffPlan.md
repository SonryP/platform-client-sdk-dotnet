---
title: TimeOffPlan
---
## ININ.PureCloudApi.Model.TimeOffPlan

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of this time off plan. | [optional] |
| **ActivityCodeIds** | **List&lt;string&gt;** | The set of activity code IDs associated with this time off plan. | [optional] |
| **TimeOffLimits** | [**List&lt;TimeOffLimitReference&gt;**](TimeOffLimitReference.html) | The set of time off limit IDs associated with this time off plan. | [optional] |
| **AutoApprovalRule** | **string** | Auto approval rule for this time off plan | [optional] |
| **DaysBeforeStartToExpireFromWaitlist** | **int?** | The number of days before the time off request start date for when the request will be expired from the waitlist. | [optional] |
| **Active** | **bool?** | Whether this time off plan is currently being used by agents. | [optional] |
| **Metadata** | [**WfmVersionedEntityMetadata**](WfmVersionedEntityMetadata.html) | Version metadata for the time off plan. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


