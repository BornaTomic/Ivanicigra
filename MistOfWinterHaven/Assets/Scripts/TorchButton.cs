using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchButton : MonoBehaviour
{
    public static bool isTorch = false;
    public GameObject torch;
    public GameObject border1;
    GameObject player;
    GameObject canvas2;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        canvas2 = GameObject.FindGameObjectWithTag("Kanvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetTorch()
    {
        if (!SwordButton.isSword)
        {
            var obje = Instantiate(torch, new Vector3(player.transform.position.x, player.transform.position.y, 0), Quaternion.identity) as GameObject;
            var obje2 = Instantiate(border1, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity) as GameObject;
            obje.transform.parent = player.transform;
            obje2.transform.SetParent(canvas2.transform);
            isTorch = true;
        }
    }
}
