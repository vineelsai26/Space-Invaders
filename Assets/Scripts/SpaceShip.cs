using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShip : MonoBehaviour
{
    public GameObject bullet;
    private float time;
    private float lastTime = 0;
    public float timeInterval;

    private void Update()
    {
        time = Time.time;
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && time - lastTime > timeInterval)
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = new Vector3(transform.position.x, -17, 0);
            Destroy(newBullet, 5);
            lastTime = time;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-3, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(3, 0, 0);
        }
    }
}
