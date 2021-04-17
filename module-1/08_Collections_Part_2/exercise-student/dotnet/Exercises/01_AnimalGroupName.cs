using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            // creating dictionary to hold values
            Dictionary<string, string> groupNameDict = new Dictionary<string, string>();

            // adding keys & values
            groupNameDict["Rhino"] = "Crash";
            groupNameDict["Giraffe"] = "Tower";
            groupNameDict["Elephant"] = "Herd";
            groupNameDict["Lion"] = "Pride";
            groupNameDict["Crow"] = "Murder";
            groupNameDict["Pigeon"] = "Kit";
            groupNameDict["Flamingo"] = "Pat";
            groupNameDict["Deer"] = "Herd";
            groupNameDict["Dog"] = "Pack";
            groupNameDict["Crocodile"] = "Float";

            // creating response
            string response = "unknown";

            // variable for case and logic to set response to value or unknown

            foreach (KeyValuePair<string, string> groupName in groupNameDict)
            {
                string check = groupName.Key;
                if (animalName != null && check.ToLower() == animalName.ToLower())
                {
                    response = groupName.Value;
                    break;
                }
            }

            return response;
        }
    }
}
