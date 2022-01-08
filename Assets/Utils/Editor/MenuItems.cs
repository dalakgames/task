using System.Collections.Generic;
using System.IO;
using UnityEditor;

public static class MenuItems
{
   [MenuItem("Dalak/ExportSolution")]
   static void ExportSolution()
   {
      List<string> paths = new List<string>();
      paths.AddRange(Directory.GetDirectories("Assets/Task0"));
      paths.AddRange(Directory.GetDirectories("Assets/Task1"));

      string fileName = $"Assets/MySolutions.unitypackage";
      AssetDatabase.ExportPackage(paths.ToArray(),fileName, ExportPackageOptions.Recurse);
      AssetDatabase.ImportAsset(fileName);
      AssetDatabase.Refresh();
   }
}
