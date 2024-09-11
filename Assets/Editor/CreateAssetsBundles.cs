using System.IO;
using UnityEditor;

public class CreateAssetBundles
{
    [MenuItem("Assets/Bulid AssetBundles")]
    static void BuildAssetBundles()
    {
        string dir = "AssetBundles";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        //文件路径、打包选项、打包平台
        BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}