using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bait : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject tail;
    public Vector2 pos;
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        tail = Resources.Load<GameObject>("Prefabs/tail");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Khi controller cube ăn bait thì tăng thêm một tail
        if(other.tag == "ControllerCube")
        {
            //Lấy vị trí của node đuôi
            pos = gameManager.currentNode.position;
            GameObject tl = Instantiate(tail, pos, Quaternion.identity);
            //xét target node cho tail mới được sinh ra
            tl.GetComponent<TailBehaviour>().targetNode = gameManager.currentNode;
            //Xét lại vị trí node cuối là node mới được sinh ra
            gameManager.currentNode = tl.transform;
            Destroy(gameObject);
        }
    }
}
