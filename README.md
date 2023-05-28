# Json Manager for Unity
This package consists of two parts and uses the Newtonsoft Json Package. 

To install this 3rd-Party Package, open your Package Manager, hit the "+" and select "Add package from git URL ...". There you can type in *com.unity.nuget.newtonsoft-json* and press "Add".

You can then simply download the single [package file](Json.unitypackage) and drop it into your project to import everything you need without cloning this whole repository. 

## Helper Class
On the one hand it consists of a Helper Class (JsonHelper), which takes over the serialization and deserialization of json files. This Helper Class can be used both at runtime and in the editor. For deserialization, a distinction is made between resources, i.e. static data, which are defined by the developer, and dynamic data, which reflect the state of the application.

## Manager Classes
On the other hand the package provides two Manager Classes, which encapsulate the use of the Helper Class just mentioned again, in order to facilitate the access to a multiplicity of static and dynamic data. These are the classes "Definitions" (static data) and "DataManager" (dynamic data). Since static data tends to be very specific, I've simply marked the places to be customized and provided an example within a comment. For dynamic data, however, there are two commonly encountered data containers, one for the game state and one for the game settings. For this reason, I have added these directly to the package and marked in the Manager Classe where adjustments may need to be made regarding file names and paths, as well as where additional containers can be added.

## Contact
As a developer, you never stop learning. Therefore, I am always open to constructive criticism and suggestions for improvement. Feel free to contact me via [LinkedIn](https://www.linkedin.com/in/christian-h%C3%B6rath-0ba068201/) or by [email](mailto:hoerath.christian@gmail.com).
