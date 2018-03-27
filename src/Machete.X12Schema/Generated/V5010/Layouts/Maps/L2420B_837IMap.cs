﻿namespace Machete.X12Schema.V5010.Maps
{
    using X12;
    using X12.Configuration;


    public class L2420B_837IMap :
        X12LayoutMap<L2420B_837I, X12Entity>
    {
        public L2420B_837IMap()
        {
            Id = "2420B";
            Name = "Other Operating Physician Name";
            
            Segment(x => x.Physician, 0);
            Segment(x => x.SecondaryIdentification, 1);
        }
    }
}