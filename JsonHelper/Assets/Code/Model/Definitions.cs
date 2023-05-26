using System.Collections.Generic;

public class Definitions : JsonManager
{
    //List the fields for each definition file like: 
    //public Dictionary<string, LevelDefinition> LEVEL_DEFINITIONS;

    public void LoadDefinitions()
    {
        //Load each definition like:
        //LoadJson<Dictionary<string, LevelDefinition>>("LevelDefinitions", ref LEVEL_DEFINITIONS, true);
    }

    protected override string CreatePath(string fileName)
    {
        //Adjust static data path here
        return "Definitions/" + fileName;
    }
}
