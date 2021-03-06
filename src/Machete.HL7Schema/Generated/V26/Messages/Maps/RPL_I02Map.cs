// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// RPL_I02 (MessageMap) - 
    /// </summary>
    public class RPL_I02Map :
        HL7V26LayoutMap<RPL_I02>
    {
        public RPL_I02Map()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Layout(x => x.Provider, 4, x => x.Required = true);
            Segment(x => x.NTE, 5);
            Segment(x => x.DSP, 6);
            Segment(x => x.DSC, 7);
        }
    }
}