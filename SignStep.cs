using System;
using System.Collections.Generic;


namespace MapBuilder
{
    public struct SignStep 
    {
        
        public int Floor { get; set; }
        public int Section { get; set; }
        public IEnumerable<SignStep> signatureMap { get; set; }



        public SignStep(int floor, int section) : this()
        {
            floor = Floor;
            section = Section;
        }

        public void SetValues (int[] floors, int[] sections)
        {
            foreach (var floor in floors)
            {
                Floor = floor;
            }
            foreach (var section in sections)
            {
                Section = section;
            }
        }
    }
}
