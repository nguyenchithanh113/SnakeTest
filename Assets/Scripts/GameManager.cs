using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //Vi tri hien tai cua chuot
    public Vector2 mousePos;
    //Vi tri controllerCube
    public GameObject controllerCube;
    //Load prefab bait
    public GameObject bait;
    //vi tri bait sẽ được sinh ngẫu nhiên
    public Transform baitPos;
    //Node ở đuôi
    public Transform currentNode;
    public int numberOfBait=20;
    //Tốc đọ di chuyển của tail
    public float speed=6;
    void Start()
    {
        controllerCube = GameObject.FindGameObjectWithTag("ControllerCube");
        currentNode = GameObject.FindGameObjectWithTag("HeadNode").transform;
        bait = Resources.Load<GameObject>("Prefabs/Bait");
        BaitGenerator();
    }

    // Update is called once per frame
    void Update()
    {
        ControllerCubeMouseMovement();
    }
    //di chuyen controller cube theo pos của chuột
    void ControllerCubeMouseMovement()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.x = Mathf.Clamp(mousePos.x, -26, 26);
        mousePos.y = Mathf.Clamp(mousePos.y, -14, 14);
        controllerCube.transform.position = mousePos;
    }
    //Sinh bait ngẫu nhiên
    public void BaitGenerator()
    {
        for(int i = 0; i < numberOfBait; i++)
        {
            int x = Random.Range(-26, 26);
            int y = Random.Range(-14, 14);
            Instantiate(bait, new Vector2(x, y), Quaternion.identity);
        }
        
    }

}
