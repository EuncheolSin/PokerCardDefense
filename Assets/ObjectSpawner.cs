using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;
    private void Awake()
    {
        //Instantiate(boxPrefab,new Vector3(3,3,0), Quaternion.identity);
        //Instantiate(boxPrefab,new Vector3(-1,-2,0), Quaternion.identity);
        Quaternion rotation = Quaternion.Euler(0,0,45);

        GameObject clone = Instantiate(boxPrefab, Vector3.zero, rotation);
        clone.name = "Box001";
        clone.GetComponent<SpriteRenderer>().color = Color.black;
        clone.transform.position = new Vector3(2,1,0);
        clone.transform.localScale = new Vector3(3,2,1);
    }
}
