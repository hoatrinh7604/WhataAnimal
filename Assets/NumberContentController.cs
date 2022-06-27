using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberContentController : MonoBehaviour
{
    [SerializeField] GameObject[] shadowPrefab;
    [SerializeField] Transform content;
    [SerializeField] List<GameObject> list = new List<GameObject>();
    [SerializeField] TextMeshProUGUI nameAnimal;

    public void Spaw(int index, string name)
    {
        //ClearContent();
        //list.Clear();
        //list = new List<GameObject>();

        //GameObject item = Instantiate(shadowPrefab[index], Vector3.zero, Quaternion.identity, content);
        //item.transform.localPosition = Vector3.zero;
        //list.Add(item);
        nameAnimal.text = name;
    }

    public void UpdateInfo(int index, int value)
    {
        list[index].GetComponent<ShowNumberController>().SetInfo(value);
    }

    private void ClearContent()
    {
        for (int i = 0; i < content.childCount; i++)
        {
            Destroy(content.GetChild(i).gameObject);
        }
    }
}
