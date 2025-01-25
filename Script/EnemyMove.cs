using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyMove : MonoBehaviour
{


    public NavMeshAgent agent;
    public GameObject[] point = new GameObject[10];
    public EnemySpawner spawner;
    private int M1 =1;

void Awake(){
  spawner = GameObject.Find(nameof(EnemySpawner)).GetComponent<EnemySpawner>();
  GameObject par = GameObject.Find("Enemys");
  gameObject.transform.SetParent(par.transform);
    for(int i =0; i<10; i++){
        string objectName = i.ToString();
        point[i] = GameObject.Find(objectName);
    }
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Move1();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Move2(){
        switch (M1){
                case 1:
                agent.SetDestination(point[1].transform.position);
                break;
                case 2:
                agent.SetDestination(point[8].transform.position);
                break;
                 case 3:
                agent.SetDestination(point[7].transform.position);
                break;
                 case 4:
                agent.SetDestination(point[6].transform.position);
                break;
                 case 5:
                agent.SetDestination(point[5].transform.position);
                break;
                 case 6:
                agent.SetDestination(point[4].transform.position);
                break;
                 case 7:
                agent.SetDestination(point[3].transform.position);
                break;
                 case 8:
                agent.SetDestination(point[2].transform.position);
                break;
                 case 9:
                agent.SetDestination(point[1].transform.position);
                break;
                  case 10:
                agent.SetDestination(point[8].transform.position);
                break;
                 case 11:
                agent.SetDestination(point[7].transform.position);
                break;
                 case 12:
                agent.SetDestination(point[6].transform.position);
                break;
                 case 13:
                agent.SetDestination(point[5].transform.position);
                break;
                 case 14:
                agent.SetDestination(point[4].transform.position);
                break;
                 case 15:
                agent.SetDestination(point[3].transform.position);
                break;
                 case 16:
                agent.SetDestination(point[2].transform.position);
                break;
                case 17:
                agent.SetDestination(point[1].transform.position);
                break;
                  case 18:
                agent.SetDestination(point[8].transform.position);
                break;
                 case 19:
                agent.SetDestination(point[7].transform.position);
                break;
                 case 20:
                agent.SetDestination(point[6].transform.position);
                break;
                 case 21:
                agent.SetDestination(point[5].transform.position);
                break;
                 case 22:
                agent.SetDestination(point[9].transform.position);
                break;
                

                default:
                Destroy(gameObject);
                break;
            }
            
            M1++;
            Invoke(nameof(Move2), spawner.moveTime);
        
    }
    public void Move1(){
            switch (M1){
                case 1:
                agent.SetDestination(point[1].transform.position);
                break;
                 case 2:
                agent.SetDestination(point[2].transform.position);
                break;
                 case 3:
                agent.SetDestination(point[3].transform.position);
                break;
                 case 4:
                agent.SetDestination(point[4].transform.position);
                break;
                 case 5:
                agent.SetDestination(point[5].transform.position);
                break;
                 case 6:
                agent.SetDestination(point[6].transform.position);
                break;
                 case 7:
                agent.SetDestination(point[7].transform.position);
                break;
                 case 8:
                agent.SetDestination(point[8].transform.position);
                break;
                 case 9:
                agent.SetDestination(point[1].transform.position);
                break;
                 case 10:
                 agent.SetDestination(point[2].transform.position);
                break;
                 case 11:
                 agent.SetDestination(point[3].transform.position);
                break;
                 case 12:
                 agent.SetDestination(point[4].transform.position);
                break;
                 case 13:
                 agent.SetDestination(point[5].transform.position);
                break;
                 case 14:
                 agent.SetDestination(point[9].transform.position);
                break;
                default:
                Destroy(gameObject);
                break;
            }
            
            M1++;
            Invoke(nameof(Move1), spawner.moveTime);
        
    }
}
