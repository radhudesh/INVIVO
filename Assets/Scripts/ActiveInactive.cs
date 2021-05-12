using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ActiveInactive : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Cube4;
    public GameObject Cube5;
    public Material red;
    public Material green;

   
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 1"))
        {
           switch(GameManager.Instance.SelectionScene1)
            {
                case 1:
                    onCLickCube1();
                    break
                        ;
                case 2:
                    onCLickCube2();
                    break
                        ;
                case 3:
                    onCLickCube3();
                    break
                        ;
                case 4:
                    onCLickCube4();
                    break
                        ;
                case 5:
                    onCLickCube5();
                    break
                        ;
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 2"))
        {
            switch (GameManager.Instance.SelectionScene2)
            {
                case 1:
                    onCLickCube1();
                    break
                        ;
                case 2:
                    onCLickCube2();
                    break
                        ;
                case 3:
                    onCLickCube3();
                    break
                        ;
                case 4:
                    onCLickCube4();
                    break
                        ;
                case 5:
                    onCLickCube5();
                    break
                        ;
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 3"))
        {
            switch (GameManager.Instance.SelectionScene3)
            {
                case 1:
                    onCLickCube1();
                    break
                        ;
                case 2:
                    onCLickCube2();
                    break
                        ;
                case 3:
                    onCLickCube3();
                    break
                        ;
                case 4:
                    onCLickCube4();
                    break
                        ;
                case 5:
                    onCLickCube5();
                    break
                        ;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.name == "Cube1")
                {
                    onCLickCube1();
                }
                else if (hit.collider.name == "Cube2")
                {
                    onCLickCube2();
                }
                else if (hit.collider.name == "Cube3")
                {
                    onCLickCube3();
                }
                else if (hit.collider.name == "Cube4")
                {
                    onCLickCube4();
                }
                else if (hit.collider.name == "Cube5")
                {
                    onCLickCube5();
                }
            }
        }
    }

    void onCLickCube1()
    {
        Cube1.GetComponent<MeshRenderer>().material = green;
        Cube2.GetComponent<MeshRenderer>().material = red;
        Cube3.GetComponent<MeshRenderer>().material = red;
        Cube4.GetComponent<MeshRenderer>().material = red;
        Cube5.GetComponent<MeshRenderer>().material = red;
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 1"))
        {
        GameManager.Instance.SelectionScene1 = 1;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 2"))
        {
            GameManager.Instance.SelectionScene2 = 1;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 3"))
        {
            GameManager.Instance.SelectionScene3 = 1;
        }
    }
    void onCLickCube2()
    {
        Cube1.GetComponent<MeshRenderer>().material = red;
        Cube2.GetComponent<MeshRenderer>().material = green;
        Cube3.GetComponent<MeshRenderer>().material = red;
        Cube4.GetComponent<MeshRenderer>().material = red;
        Cube5.GetComponent<MeshRenderer>().material = red;
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 1"))
        {
            GameManager.Instance.SelectionScene1 = 2;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 2"))
        {
            GameManager.Instance.SelectionScene2 = 2;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 3"))
        {
            GameManager.Instance.SelectionScene3 = 2;
        }
    }
    void onCLickCube3()
    {
        Cube1.GetComponent<MeshRenderer>().material = red;
        Cube2.GetComponent<MeshRenderer>().material = red;
        Cube3.GetComponent<MeshRenderer>().material = green;
        Cube4.GetComponent<MeshRenderer>().material = red;
        Cube5.GetComponent<MeshRenderer>().material = red;
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 1"))
        {
            GameManager.Instance.SelectionScene1 = 3;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 2"))
        {
            GameManager.Instance.SelectionScene2 = 3;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 3"))
        {
            GameManager.Instance.SelectionScene3 = 3;
        }
    }
    void onCLickCube4()
    {
        Cube1.GetComponent<MeshRenderer>().material = red;
        Cube2.GetComponent<MeshRenderer>().material = red;
        Cube3.GetComponent<MeshRenderer>().material = red;
        Cube4.GetComponent<MeshRenderer>().material = green;
        Cube5.GetComponent<MeshRenderer>().material = red;
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 1"))
        {
            GameManager.Instance.SelectionScene1 = 4;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 2"))
        {
            GameManager.Instance.SelectionScene2 = 4;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 3"))
        {
            GameManager.Instance.SelectionScene3 = 4;
        }
    }
    void onCLickCube5()
    {
        Cube1.GetComponent<MeshRenderer>().material = red;
        Cube2.GetComponent<MeshRenderer>().material = red;
        Cube3.GetComponent<MeshRenderer>().material = red;
        Cube4.GetComponent<MeshRenderer>().material = red;
        Cube5.GetComponent<MeshRenderer>().material = green;
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 1"))
        {
            GameManager.Instance.SelectionScene1 = 5;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 2"))
        {
            GameManager.Instance.SelectionScene2 = 5;
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Content Scene 3"))
        {
            GameManager.Instance.SelectionScene3 = 5;
        }
    }
}


