using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailBehaviour : MonoBehaviour
{
    //Node mà sẽ follow theo
    public Transform targetNode;
    public GameManager gameManager;
    [SerializeField]
    public float speed = 1;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }
    //Di chuyển đến node target
    public void Follow()
    {
        if(Vector2.Distance(transform.position, targetNode.position) > 1f)
        {
            transform.position = Vector2.Lerp(transform.position, targetNode.position, Time.deltaTime*gameManager.speed);
            //transform.position = Vector2.MoveTowards(transform.position, targetNode.position, Time.deltaTime * gameManager.speed);
        }
    }

}
