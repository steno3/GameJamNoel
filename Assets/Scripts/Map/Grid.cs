using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject[] gridPrefabs;
    public int size = 20;
    Cell[,] map;
    void Start(){
        map=new Cell[size,size];
        for(int i=0;i<size;i++){
            for(int j=0;j<size;j++){
                map[i,j]=new Cell();
                if (i==0 || j==0 || i==size-1 || j==size-1){
                    map[i,j].isEdge=true;
                }
            }
        }
        map[size/2,size/2].isSpawn=true;

        GenerateMap(map);
    }



    void GenerateMap(Cell[,] map) {
        for(int x=0;x<size;x++){
            for(int y=0;y<size;y++){
                if (map[x,y].isSpawn){
                    GameObject grid = Instantiate(gridPrefabs[0], transform);
                    grid.transform.position = new Vector3(x*20, y*20, 0);
                }
                else {
                GameObject prefab = gridPrefabs[Random.Range(1,gridPrefabs.Length)];
                GameObject grid = Instantiate(prefab, transform);
                grid.transform.position = new Vector3(x*20, y*20, 0);
                }
            }
        }
    }
}
