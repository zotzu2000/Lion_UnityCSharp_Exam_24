using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIcon : MonoBehaviour
{
    public GameObject[] Item;
    private void Start()
    {
        Instantiate(Item[Random.Range(0,10)], transform.position, transform.rotation);
    }
}
