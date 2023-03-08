using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject tumbleBall;
    public GameObject mouse; 
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject tumbleweed = Instantiate(tumbleBall, tumbleBall.transform.position, Quaternion.identity);
            tumbleBall.transform.position = new Vector3(Random.value, 17f, Random.value);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
