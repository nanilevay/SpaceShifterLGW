using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void Mover(Transform Player)
    {
        Player.position = new Vector3(Player.position.x +
                    Camera.main.transform.forward.x * Time.deltaTime,
                    Player.position.y, Player.position.z +
                    Camera.main.transform.forward.z * Time.deltaTime);
    }
}
