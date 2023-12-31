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
                    grid.transform.position = new Vector3(x*20-size*10, y*20-(size+1)*10, 0);
                }
                else if (x==0 && y==0) {
                    GameObject grid = Instantiate(gridPrefabs[1], transform);
                    grid.transform.position = new Vector3(x*20-size*10, y*20-(size+1)*10, 0);
                }
                else if (x==0 && y==size-1) {
                    GameObject grid = Instantiate(gridPrefabs[1], transform);
                    grid.transform.position = new Vector3(x*20-size*10, y*20-(size+1)*10, 0);
                }
                else if (x==size-1 && y==0) {
                    GameObject grid = Instantiate(gridPrefabs[1], transform);
                    grid.transform.position = new Vector3(x*20-size*10, y*20-(size+1)*10, 0);
                }
                else if (x==size-1 && y==size-1) {
                    GameObject grid = Instantiate(gridPrefabs[1], transform);
                    grid.transform.position = new Vector3(x*20-size*10, y*20-(size+1)*10, 0);
                }
                else if (x==0) {
                    GameObject grid = Instantiate(gridPrefabs[5], transform);
                    grid.transform.position = new Vector3(x*20-size*10, y*20-(size+1)*10, 0);
                }
                else if (x==size-1) {
                    GameObject grid = Instantiate(gridPrefabs[3], transform);
                    grid.transform.position = new Vector3(x*20-size*10, y*20-(size+1)*10, 0);
                }
                else if (y==0) {
                    GameObject grid = Instantiate(gridPrefabs[4], transform);
                    grid.transform.position = new Vector3(x*20-size*10, y*20-(size+1)*10, 0);
                }
                else if (y==size-1) {
                    GameObject grid = Instantiate(gridPrefabs[2], transform);
                    grid.transform.position = new Vector3(x*20-size*10, y*20-(size+1)*10, 0);
                }
                else {
                GameObject prefab = gridPrefabs[Random.Range(6,gridPrefabs.Length)];
                GameObject grid = Instantiate(prefab, transform);
                grid.transform.position = new Vector3(x*20-size*10, y*20-(size+1)*10, 0);
                }
            }
        }
    }
}
