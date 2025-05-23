using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Task_SongInfoUIManager : MonoBehaviour
{
    public TMP_Text NumberText;  // Text를 TMP_Text로 변경
    public TMP_Text gameText;
    public TMP_Text songTitleText;
    public TMP_Text artistText;
    public TMP_Text inGameLevelText;
    public TMP_Text bpmText;

    public void UpdateSongInfo(int songNumber, string gameTitle, string songTitle, string artist, string inGameLevel, string displayBPM)
    {
        // UI 텍스트에 값 설정, 양식을 수정할 땐 여기서!
        // ----------------------------------------------------------------
        NumberText.text = $"No.{songNumber}";
        gameText.text = $"수록 : {gameTitle}";
        songTitleText.text = $"곡명 : {songTitle}";
        artistText.text = $"제작자 : {artist}";
        inGameLevelText.text = $"비고 : {inGameLevel}";
        bpmText.text = $"BPM : {displayBPM}";
        // ----------------------------------------------------------------
    }
}
