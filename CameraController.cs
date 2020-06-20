using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Player player;
    private Vector3 lastPosition;
    private float distance;
    private float distanceY;
    // Start is called before the first frame update
    void Start()
    {
      player = FindObjectOfType<Player>(); // get last position of player
      lastPosition = player.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        distance = player.transform.position.x - lastPosition.x;
        distanceY = player.transform.position.y - lastPosition.y;
        transform.position= new Vector3(
            transform.position.x + distance,
            transform.position.y + distanceY,
            transform.position.z
        );
        lastPosition = player.transform.position;
    }
}
