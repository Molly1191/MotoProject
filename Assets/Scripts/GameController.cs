using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    Text fruitCountTxt;

    #region Singleton Quickversion
    private static GameController instance;
    public static GameController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameController>();
            }
            return instance;
        }
    }
    public static void bajs() { }
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateFruitCountTxt(int amount)
    {
        fruitCountTxt.text = $"Fruits Collected: {amount}";
    }
}
