// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// REF_I12_PATIENT_VISIT (GroupMap) - 
    /// </summary>
    public class REF_I12_PATIENT_VISITMap :
        HL7V26LayoutMap<REF_I12_PATIENT_VISIT>
    {
        public REF_I12_PATIENT_VISITMap()
        {
            Segment(x => x.PV1, 0, x => x.Required = true);
            Segment(x => x.PV2, 1);
        }
    }
}