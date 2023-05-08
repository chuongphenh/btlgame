using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


using static System.Net.Mime.MediaTypeNames;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;  // GameObject chứa hộp thoại tạm dừng

    public bool GameisPaused = false;  // Trạng thái tạm dừng trò chơi
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;  // Tạm dừng thời gian trong trò chơ
        GameisPaused = true;  // Cập nhật trạng thái tạm dừng
        pauseMenu.SetActive(true);  // Hiển thị hộp thoại tạm dừng
    }
    public void Resume()
    {
        Time.timeScale = 1f;  // Tiếp tục thời gian trong trò chơi
        GameisPaused = false;  // Cập nhật trạng thái không tạm dừng
        pauseMenu.SetActive(false);  // Ẩn hộp thoại tạm dừng
    }

    public void Quit()
    {
     }
    

    
}
