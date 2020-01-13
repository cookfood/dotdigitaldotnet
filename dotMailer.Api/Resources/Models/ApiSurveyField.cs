using System.Collections.Generic;
using dotdigital.Api.Resources.Enums;

namespace dotdigital.Api.Resources.Models
{
	public class ApiSurveyField
	{
		public int Id
		{ get; set; }

		public string Type
		{ get; set; }

		public string Text
		{ get; set; }

		public bool IsRequired
		{ get; set; }

		public string DefaultValue
		{ get; set; }

		public string Mode
		{ get; set; }

		public ApiSurveyQuestionChoiceList Choices
		{ get; set; }

		public ApiSurveyFieldList SubFields
		{ get; set; }

		public bool HasOtherOption
		{ get; set; }

		public int OtherOptionChoiceId
		{ get; set; }

		public int OtherOptionSubFieldId
		{ get; set; }

		public int OtherOptionTextFieldId
		{ get; set; }

		public bool IsAssignedToContactDataField
		{ get; set; }

		public string AssignedContactDataFieldName
		{ get; set; }

		public ApiAssignedContactDataExistsAction AssignedContactDataExistsAction
		{ get; set; }
	}
}
