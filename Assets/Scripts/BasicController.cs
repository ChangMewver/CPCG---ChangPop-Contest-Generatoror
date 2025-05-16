using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class BasicController : MonoBehaviour
{
    //�� �̵���
    private int currentSongIndex = 0;
    private List<string> songList = new List<string>();

    //���� �Ѿ�� ���� �ڵ�. ��ư�� �־� ���
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    void Update()
    {
        HandleCursorVisibility(); // Ŀ�� ó��

        //    KeyInput();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "MainScene")
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("MainScene");
            }
        }
    }

    void HandleCursorVisibility()
    {
        bool isMainScene = SceneManager.GetActiveScene().name == "MainScene";

        if (isMainScene)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    //void KeyInput()
    //{
    //    // Ű �Է��� ���� ��, Ű����� Ʈ�� �̵� ����
    //    if (Input.GetKeyDown(KeyCode.LeftArrow)) JumpToSong(currentSongIndex - 1);
    //    if (Input.GetKeyDown(KeyCode.RightArrow)) JumpToSong(currentSongIndex + 1);
    //    if (Input.GetKeyDown(KeyCode.Q)) JumpToSong(currentSongIndex - 10);
    //    if (Input.GetKeyDown(KeyCode.W)) JumpToSong(currentSongIndex + 10);
    //    if (Input.GetKeyDown(KeyCode.Z)) JumpToSong(0);
    //}


    //void JumpToSong(int index)
    //{
    //    // ��ȿ�� �ε������� Ȯ��
    //    currentSongIndex = Mathf.Clamp(index, 0, songList.Count - 1);
    //    Debug.Log($"���� ��: {songList[currentSongIndex]}"); // �� ���� ��� (����)
    //}
}


