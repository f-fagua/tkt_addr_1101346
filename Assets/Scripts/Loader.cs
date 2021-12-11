using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

public class Loader : MonoBehaviour
{
    [SerializeField] private string m_BrokenAsset;
    // Start is called before the first frame update
    void Start()
    {
        Addressables.LoadAssetAsync<Material>(m_BrokenAsset);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
