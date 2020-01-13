using System;
using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiSurvey
	{
		public int Id
		{ get; set; }

		public string Name
		{ get; set; }

		public string Url
		{ get; set; }

		public DateTime DateSurveyCreated
		{ get; set; }

		public DateTime DateSurveyModified
		{ get; set; }

		public ApiSurveyState State
		{ get; set; }

		public DateTime? FirstActiveDate
		{ get; set; }

		public DateTime? LastInactiveDate
		{ get; set; }

		public DateTime? ScheduledStartDate
		{ get; set; }

		public DateTime? ScheduledEndDate
		{ get; set; }

		public ApiSurveyConfirmationMode ConfirmationMode
		{ get; set; }

		public ApiSurveySubmissionMode SubmissionMode
		{ get; set; }

		public int FieldCount
		{ get; set; }

		public bool NotifyCreatorOnResponse
		{ get; set; }

		public ApiRespondentNotificationType RespondentNotificationType
		{ get; set; }

		public int? RespondentNotificationCampaignId
		{ get; set; }

		public bool IsAssignedToAddressBook
		{ get; set; }

		public ApiSurveyAssignedAddressBookTarget AssignedAddressBookTarget
		{ get; set; }

		public int? AssignedSpecificAddressBookId
		{ get; set; }

		public DateTime? FirstResponseDate
		{ get; set; }

		public DateTime? LastResponseDate
		{ get; set; }

		public int TotalCompleteResponses
		{ get; set; }

		public int TotalCompleteResponsesInLastDay
		{ get; set; }

		public int TotalCompleteResponsesInLastWeek
		{ get; set; }

		public int TotalIncompleteResponses
		{ get; set; }

		public int TotalViews
		{ get; set; }

		public int TotalBounces
		{ get; set; }

		public int? TimeToCompleteMax
		{ get; set; }

		public int? TimeToCompleteMin
		{ get; set; }

		public int? TimeToCompleteTotal
		{ get; set; }

		public int SourceDirectTotal
		{ get; set; }

		public int SourceEmailTotal
		{ get; set; }

		public int SourceEmbeddedTotal
		{ get; set; }

		public int SourcePopoverTotal
		{ get; set; }

		public int SourceFacebookTotal
		{ get; set; }

		public int SourceTwitterTotal
		{ get; set; }

		public int SourceGooglePlusTotal
		{ get; set; }

		public int SourceOtherTotal
		{ get; set; }
	}
}
