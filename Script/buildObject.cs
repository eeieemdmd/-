using UnityEngine;

public class buildObject : MonoBehaviour
{
   public TowerBuild towerBuild;
    private GameObject currentPlant; // 현재 설치된 건물

    void Start()
    {
        towerBuild = GameObject.Find("towerManager").GetComponent<TowerBuild>();
    }

    void OnMouseDown()
    {
        // 영역 클릭 시 건물 배치
        if (towerBuild != null)
        {
             if (currentPlant != null)
            {
               
                Destroy(currentPlant);
            }
           currentPlant = towerBuild.PlacePlant(transform.position);
        }
    }
}
