using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instance;   // 유일성 보장
    public static Managers Instance { get { return s_instance; } }   // 유일한 매니저를 갖고옴

    InputManager _input = new InputManager();
    ResourceManager _resource = new ResourceManager();
    public static InputManager Input { get { return Instance._input;}}
    public static ResourceManager Resource { get { return Instance._resource;}}

    private void Awake()
    {
        Init();
    }

    private void Update()
    {
        Input.OnUpdate();
    }

    // 초기화
    private static void Init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");   // Find -> 성능적으로 좋지 않아 이후 수정 필요
            if(go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
    }
}
