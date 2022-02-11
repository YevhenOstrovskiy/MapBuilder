using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace MapBuilder
{
    public class SignatureSteps
    {
        public static string SignatureMap = "1. 2 floor, 2 section\n" +
                                            "2. 4 floor, 1 section\n" +
                                            "3. 2 floor, 1 section\n" +
                                            "4. 5 floor, 2 section";
        
        public static void GetSignatureSteps()
        {
            var regexF = Regex.Matches(SignatureMap, @"(\d+)\s*floor")
                            .Cast<Match>()
                            .Select(m => m.Value)
                            .ToArray();
            var newFloor = regexF.Select(x => x.Replace("floor", string.Empty)).ToArray();
            int[] floors = newFloor.Select(int.Parse).ToArray();
            foreach (var m in floors)
            {
                Console.WriteLine(m);
            }


            var regexS = Regex.Matches(SignatureMap, @"(\d+)\s*section")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
            var newSection = regexS.Select(x => x.Replace("section", string.Empty)).ToArray();
            int[] sections = newSection.Select(int.Parse).ToArray();
            foreach (var m in sections)
            {
                Console.WriteLine(m);
            }


            IEnumerable<SignStep> signatureMap = new SignStep[4];
            ref var someData = ref signatureMap;
            foreach (SignStep signatureStep in signatureMap)
            {
                signatureStep.SetValues(floors, sections);
                signatureMap.ToList().Add(signatureStep);
                Console.WriteLine($"Floor = {signatureStep.Floor}, Section = {signatureStep.Section}");


            }

        } 

    }
}
