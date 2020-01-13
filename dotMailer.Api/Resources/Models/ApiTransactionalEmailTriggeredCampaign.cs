using System.Collections.Generic;

namespace dotdigital.Api.Resources.Models
{
    public class ApiTransactionalEmailTriggeredCampaign
    {
        public StringList ToAddresses
        { get; set; }

        public StringList CCAddresses
        { get; set; }

        public StringList BCCAddresses
        { get; set; }

        public int CampaignId
        { get; set; }

        public List<ApiTransactionalEmailTriggeredCampaignPersonalisationValue> PersonalizationValues
        { get; set; }
    }
}
