using System.Collections.Generic;
using System.IO;
using UnityEditor;

public static class MenuItems
{
   [MenuItem("Dalak/ExportSolution")]
   static void ExportSolution()
   {
      string fileName = $"Assets/MySolutions.unitypackage";
      AssetDatabase.ExportPackage(new []{"Assets/Task0","Assets/Task1"},fileName, ExportPackageOptions.Recurse);
      AssetDatabase.ImportAsset(fileName);
      AssetDatabase.Refresh();
   }
}
