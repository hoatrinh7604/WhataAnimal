using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentController : MonoBehaviour
{
    [SerializeField] GameObject buttonNumberPreFab;
    [SerializeField] Transform content;

    [SerializeField] GameObject[] animals;

    private List<int> list;

    public void SpawButton(List<int> arr)
    {
        ClearContent();

        for(int i = 0; i < 5; i++)
        {
            GameObject item = new GameObject();
            item = Instantiate(animals[arr[i]], Vector3.zero, Quaternion.identity, content);

            item.transform.localPosition = Vector3.zero;
        }
    }

    private void ClearContent()
    {
        for(int i = 0; i < content.childCount; i++)
        {
            Destroy(content.GetChild(i).gameObject);
        }
    }
}
