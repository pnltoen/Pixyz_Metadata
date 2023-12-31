using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pixyz.UnitySDK.Components;

public class usingMetadata : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Metadata metadata = gameObject.GetComponent<Metadata>();

    }

    void ToAllChilds(Transform parent)
    {
        for (int i = 0; i < parent.childCount; i++)
        {
            GameObject child = parent.GetChild(i).gameObject;
            Debug.Log(child);
            ToAllChilds(parent.GetChild(i));
        }
    }
}
