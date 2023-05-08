using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Audio;


public class SettingMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public AudioMixer audioMixer;
    public GameObject Setting;
    // Start is called before the first frame update
    public void Pause()
    {
        pauseMenu.SetActive(false);  // Ẩn hộp thoại tạm dừng

        Setting.SetActive(true);  // Hiển thị hộp thoại tạm dừng
    }
    public void Resume()
    {


        Setting.SetActive(false);  // Ẩn hộp thoại tạm dừng
        pauseMenu.SetActive(true);  // Hiển thị hộp thoại tạm dừng
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

}
