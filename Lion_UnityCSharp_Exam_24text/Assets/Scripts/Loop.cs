using UnityEngine;
using UnityEngine.UI;

public class Loop : MonoBehaviour
{


    [Header("方塊")]
    public GameObject cube;

    private void Start()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= i ; j++)
            {
                Vector3 pos = new Vector3(i * 1, j * 1, 25);
                Instantiate(cube, pos, Quaternion.identity);
            }
            
        }
        
    }



}
