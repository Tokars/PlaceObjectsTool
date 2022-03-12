using UnityEngine;

[System.Serializable]
public class LocalToolCache
{
    [SerializeField] private Transform parent = default;
    [SerializeField] private GameObject prefab = null;

    public LocalToolCache(Transform parent, GameObject prefab)
    {
        this.parent = parent;
        this.prefab = prefab;
    }
    
    public bool IsEmpty()
    {
        return parent != default && prefab != null;
    }

    public Transform Parent => parent;
    public GameObject Prefab => prefab;
}