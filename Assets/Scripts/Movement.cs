using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed=7f;

    NavMeshAgent player;

    public int score = 0;

    private AudioSource click;
    private CollisionDetector Cd;
    private GameManager gm;

    void Start()
    {
        player = GetComponent<NavMeshAgent>();
        Cd = GetComponent<CollisionDetector>();
        click = GetComponent<AudioSource>();
        gm = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
    }

    void Update()
    {
         if (Input.GetMouseButtonDown(0))
      {
          RaycastHit hit;

          if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit,float.PositiveInfinity))
          {
                if (hit.collider.gameObject.CompareTag("Map") || hit.collider.gameObject.CompareTag("finishBox"))
                {
                    player.destination = hit.point;
                    player.speed = speed;
                }
                else if (hit.collider.gameObject.CompareTag("But1"))
                {
                    player.destination = new Vector3(-7, 32, -15);        // kullanýcý butona týkladýgýnda butona basabilecek mesafeye gelmesini istedik.
                    player.speed = speed;
                    print("butona týkladýn");
                    Cd.isTouch = true;
                }
                else if (hit.collider.gameObject.CompareTag("But2"))
                {
                    player.destination = new Vector3(23, 52, 40);
                    player.speed = speed;
                    print("butona týkladýn");
                    Cd.isTouch = true;
                }
                else if (hit.collider.gameObject.CompareTag("Firefly")) // Nerede olursa olsun eðer ateþvöceðine týkladýysa ateþböceði kaybolsun score artsýn
                {
                    score++;
                    click.Play();
                    hit.collider.gameObject.SetActive(false);
                    gm.slotFill(score - 1);
                }
          }
      }

    }

}
