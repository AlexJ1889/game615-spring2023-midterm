using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectScript : MonoBehaviour
{

    int hatCount = 0;
    public TMP_Text scoreText;
    public TMP_Text endText; 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            hatCount++;
            scoreText.text = hatCount.ToString();
            
        }
    }
}
