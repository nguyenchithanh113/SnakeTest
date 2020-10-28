using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateButton : MonoBehaviour
{
    public GameManager gameManager;
    public Button button;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        button = transform.GetComponent<Button>();
        button.onClick.AddListener(gameManager.BaitGenerator);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
