using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFromFileExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AssetBundle ab = AssetBundle.LoadFromFile("AssetBundles/scene/wall.unity");
        if (ab == null)
        {
            Debug.LogError("失败加载AssetBundle");
            return;
        }
        var go = ab.LoadAsset<GameObject>("Cube");//根据预制体名字加载
        Instantiate(go);
        Object[] objs = ab.LoadAllAssets();//加载所有AssetBundle资源
        foreach (var obj in objs)
        {
            Instantiate(obj);
        }
    }
}
