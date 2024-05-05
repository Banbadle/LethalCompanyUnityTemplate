using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PREFAB : MonoBehaviour
{   
    [SerializeField]
    GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        AssetBundle assetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/lethalextras");
        GameObject prefab = assetBundle.LoadAsset<GameObject>(
            $"Assets/LethalExtras/buyable/placeable/medstation/MedstationContainer.prefab");

        GameObject.Instantiate(prefab);
        foreach (MonoBehaviour  m in prefab.GetComponents<MonoBehaviour>()){
            Debug.Log(m.GetType().Name);
        }
        
        Debug.Log("DONE");
    }
}
