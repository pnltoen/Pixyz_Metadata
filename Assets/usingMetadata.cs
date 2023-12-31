using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pixyz.UnitySDK.Components;

public class usingMetadata : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Metadata metadata = gameObject.GetComponent<Metadata>();
        ToAllChilds(transform);
    }

    void ToAllChilds(Transform parent)
    {
        for (int i = 0; i < parent.childCount; i++)
        {
            Metadata metadata = parent.GetChild(i).gameObject.GetComponent<Metadata>();
            if (metadata != null)
            {
                metadata.addOrSetProperty("Author", "pnltoen");
            }
            /*string name = metadata.getProperty("PartNumber");
            if (name != null)
            {
                Debug.Log(name);
            }*/
            //GameObject child = parent.GetChild(i).gameObject;
            ToAllChilds(parent.GetChild(i));
        }
    }
}
