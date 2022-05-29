using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    private int fruitCapacity = 5;
    private int currentFruitAmount;
    private int basketSize = 5;
    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //om other är en mogen frukt
        if (other.gameObject.CompareTag("Fruit"))
        {
            currentFruitAmount++;
            Debug.Log(currentFruitAmount);
            //other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            GameController.Instance.updateFruitCountTxt(currentFruitAmount);
        }

    }
}
