using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] Enemys;
    public float moveTime;

 

    public int count;
    public int OrignCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawner(){
        Instantiate(Enemys[0], new Vector3(85f, 5f, 0f), Quaternion.identity);
        if (count > 0)
        {
            --count;
            Invoke(nameof(Spawner), moveTime);
        }
    }
}
