---
title: Conversation
---
## ININ.PureCloudApi.Model.Conversation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **ExternalTag** | **string** | The external tag associated with the conversation. | [optional] |
| **StartTime** | **DateTime?** | The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | |
| **EndTime** | **DateTime?** | The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Address** | **string** | The address of the conversation as seen from an external participant. For phone calls this will be the DNIS for inbound calls and the ANI for outbound calls. For other media types this will be the address of the destination participant for inbound and the address of the initiating participant for outbound. | [optional] |
| **Participants** | [**List&lt;Participant&gt;**](Participant.html) | The list of all participants in the conversation. | |
| **ConversationIds** | **List&lt;string&gt;** | A list of conversations to merge into this conversation to create a conference. This field is null except when being used to create a conference. | [optional] |
| **MaxParticipants** | **int?** | If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference. | [optional] |
| **RecordingState** | **string** | On update, &#39;paused&#39; initiates a secure pause, &#39;active&#39; resumes any paused recordings; otherwise indicates state of conversation recording. | [optional] |
| **State** | **string** | The conversation&#39;s state | [optional] |
| **Divisions** | [**List&lt;ConversationDivisionMembership&gt;**](ConversationDivisionMembership.html) | Identifiers of divisions associated with this conversation | [optional] |
| **RecentTransfers** | [**List&lt;TransferResponse&gt;**](TransferResponse.html) | The list of the most recent 20 transfer commands applied to this conversation. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


