using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    //POSITIONS
    Vector3[] positionArray = new [] { new Vector3(-40, 63, 35),  //ANA MAP DEÐERLERÝ
                                       new Vector3(-75, 64, -3.5f),
                                       new Vector3(-50, 67, -80),
                                       new Vector3(50, 70, -85),
                                       new Vector3(55, 75, 40),
                                       new Vector3(75, 87, 55)}; 

    //ROTATIONS
    Vector3[] rotationArray = new[] { new Vector3(21, 140, 0), // ANA MAP DEÐERLERÝ
                                      new Vector3(21, 90, 0), 
                                      new Vector3(21, 45, 0), 
                                      new Vector3(21, -30, 0), 
                                      new Vector3(21, -145, 0),
                                      new Vector3(21, -90, 0)};

    Vector3[] positionArray1 = new[] { new Vector3(-42, 70, 45), // LEVEL 1 DEÐERLERÝ
                                       new Vector3(-50, 70, 10),
                                       new Vector3(55, 70, -25),
                                       new Vector3(70, 80, 20),
                                       new Vector3(50, 70, 50),
                                       new Vector3(-8, 75, 70)};

    //ROTATIONS
    Vector3[] rotationArray1 = new[] { new Vector3(21, 120, 0),  // LEVEL 1 DEÐERLERÝ
                                      new Vector3(21, 90, 0),                                 
                                      new Vector3(21, -51, 0),
                                      new Vector3(21, -90, 0),
                                      new Vector3(21, -120, 0),
                                      new Vector3(21, -200, 0)};

    Vector3[] positionArray2 = new[] { new Vector3(-45, 75, 78), // LEVEL 2 DEÐERLERÝ
                                       new Vector3(-80, 80, 0),
                                       new Vector3(-60, 85, -60),
                                       new Vector3(60, 90, -65),
                                       new Vector3(60, 85, 0),
                                       new Vector3(45, 85, 65)};

    //ROTATIONS
    Vector3[] rotationArray2 = new[] { new Vector3(21, 145, 0),  // LEVEL 2 DEÐERLERÝ
                                      new Vector3(21, 90, 0),
                                      new Vector3(21, 45, 0),
                                      new Vector3(21, -45, 0),
                                      new Vector3(21, -90, 0),
                                      new Vector3(21, -135, 0)};

    Vector3[] positionArray3 = new[] { new Vector3(-5, 85, -65), // LEVEL 3 DEÐERLERÝ          
                                       new Vector3(75, 85, 0),
                                       new Vector3(50, 65, 25),
                                       new Vector3(20, 65, 60),
                                       new Vector3(-75, 85, 45),
                                       new Vector3(-65, 85, -45)};

    //ROTATIONS
    Vector3[] rotationArray3 = new[] { new Vector3(21, 0, 0),  // LEVEL 3 DEÐERLERÝ
                                      new Vector3(21, -90, 0),
                                      new Vector3(21, -120, 0),
                                      new Vector3(21, -145, 0),
                                      new Vector3(21, -225, 0),
                                      new Vector3(21, -320, 0)};

    public int index =0, index1 =0, index2 =0, index3 =0;
    Vector3 refpos,refpos1;
    [SerializeField] float rotSpeed;
    private void LateUpdate()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0) //ANA MAP
        {
            transform.position = Vector3.SmoothDamp(transform.position, positionArray[index], ref refpos,0.6f);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rotationArray[index]), rotSpeed * Time.deltaTime);

        }
        else if (SceneManager.GetActiveScene().buildIndex == 1)
        {
          
            transform.position = Vector3.SmoothDamp(transform.position, positionArray1[index1], ref refpos1,0.6f);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rotationArray1[index1]), rotSpeed * Time.deltaTime);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            transform.position = Vector3.SmoothDamp(transform.position, positionArray2[index2], ref refpos, 0.6f);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rotationArray2[index2]), rotSpeed * Time.deltaTime);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            transform.position = Vector3.SmoothDamp(transform.position, positionArray3[index3], ref refpos, 0.6f);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rotationArray3[index3]), rotSpeed * Time.deltaTime);
        }
       
    }


}
