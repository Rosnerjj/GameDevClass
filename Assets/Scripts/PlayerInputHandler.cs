using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] SpaceShip playerShip;

    // Start is called before the first frame update
    void Start()
    {
        //Time.fixedDeltaTime = 1/60;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space)){
            playerShip.LaunchWithShip();
        }

        playerShip.AimShip(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    void FixedUpdate(){
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movement += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement += new Vector3(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(1, 0, 0);
        }

        playerShip.Move(movement);
    }


    public SpaceShip GetPlayerShip()    {
        return playerShip;
    }
}
