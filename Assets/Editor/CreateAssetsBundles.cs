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
        //�ļ�·�������ѡ����ƽ̨
        BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}