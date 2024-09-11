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
            Debug.LogError("ʧ�ܼ���AssetBundle");
            return;
        }
        var go = ab.LoadAsset<GameObject>("Cube");//����Ԥ�������ּ���
        Instantiate(go);
        Object[] objs = ab.LoadAllAssets();//��������AssetBundle��Դ
        foreach (var obj in objs)
        {
            Instantiate(obj);
        }
    }
}
