using UnityEngine;

public abstract class JsonManager : MonoBehaviour
{
    protected void LoadJson<T>(string fileName, ref T destination, bool isResource)
    {
        //Resources are static data like definitions while others are dynamic like game data 
        if (isResource)
            JsonHelper.LoadJsonResource<T>(ref destination, CreatePath(fileName));
        else
            JsonHelper.LoadJson<T>(ref destination, CreatePath(fileName));
    }

    protected void SaveJson<T>(string fileName, T source)
    {
        JsonHelper.SaveJson<T>(source, CreatePath(fileName));
    }

    protected abstract string CreatePath(string fileName);
}
