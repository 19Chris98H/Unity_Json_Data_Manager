using UnityEngine;

public class DataManager : JsonManager
{
    //List the fields for each dynamic data container 
    //By using custom editors you can monitor the data at runtime 
    [HideInInspector] public GameSave gameSave;
    [HideInInspector] public OptionSettings optionSettings;

    public void LoadData()
    {
        //Load each dynamic data file
        //Adjust file names here
        LoadJson<GameSave>("GameSave", ref gameSave, false);
        LoadJson<OptionSettings>("OptionSettings", ref optionSettings, false);
    }

    public void ResetGameSave()
    {
        gameSave = new GameSave();
        SaveGameSave();
    }

    public void SaveSettings()
    {
        //Adjust file name here
        SaveJson<OptionSettings>("OptionSettings", optionSettings);
    }

    public void SaveGameSave()
    {
        //Adjust file name here
        SaveJson<GameSave>("GameSave", gameSave);
    }

    protected override string CreatePath(string fileName)
    {
        //Adjust dynamic data path here
        return Application.persistentDataPath + "/Data/" + fileName + ".json";
    }
}
