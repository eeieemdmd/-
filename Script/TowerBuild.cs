using UnityEngine;
using System.Collections.Generic;
public class TowerBuild : MonoBehaviour
{
public GameObject[] plantPrefabs;
    private GameObject selectedPlant; 
    private bool isPlacing; 

    private List<GameObject> placementAreas = new List<GameObject>(); 

    void Start()
    {
        // PlacementArea 태그를 가진 모든 오브젝트를 리스트에 저장
        foreach (GameObject area in GameObject.FindGameObjectsWithTag("BuildArea"))
        {
            placementAreas.Add(area);
            area.SetActive(false); // 시작 시 모든 배치 영역 비활성화
        }
    }

    // 선택된 건물 설정
    public void SelectPlant(int index)
    {
        selectedPlant = plantPrefabs[index];
        ShowPlacementAreas(true); // 배치 영역 활성화
        isPlacing = true;
    }

    // 배치 영역 활성화/비활성화
    private void ShowPlacementAreas(bool show)
    {
        foreach (GameObject area in placementAreas)
        {
            area.SetActive(show);
        }
    }

    // 영역 클릭 시 건물 배치
    public GameObject PlacePlant(Vector3 position)
    {
        if (selectedPlant != null && isPlacing)
    {
        GameObject newPlant = Instantiate(selectedPlant, position, Quaternion.identity); // 새로운 건물 생성
        ShowPlacementAreas(false); // 배치 영역 숨기기
        selectedPlant = null; // 선택 해제
        isPlacing = false;
        return newPlant; // 생성된 건물 반환
    }
    return null; // 배치 실패 시 null 반환
    }
}
