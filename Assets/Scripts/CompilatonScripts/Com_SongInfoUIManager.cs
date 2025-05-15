using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Com_SongInfoUIManager : MonoBehaviour
{
    public TMP_Text NumberText;
    public TMP_Text ComposerNameText;
    public TMP_Text SongTitleText;
    public TMP_Text GenreText;
    public TMP_Text MissionsText;
    public TMP_Text CommentsText;
    public RawImage Thumbnail;

    public void UpdateSongInfo
        (int songNumber, string ComposerName, string songTitle, string Genre, string Missions, string Comment,
        Texture2D ThumbnailTexture)
    {
        // UI �ؽ�Ʈ�� �� ����, ����� ������ �� ���⼭!
        // ----------------------------------------------------------------
        NumberText.text = $"DJ NO.{songNumber}";
        ComposerNameText.text = $": {ComposerName}";
        SongTitleText.text = $"{songTitle}";
        GenreText.text = $"[{Genre}]";
        MissionsText.text = $"���� : {Missions}";
        CommentsText.text = $"��Ƽ��Ʈ �ڸ�Ʈ\n\n{Comment}";
        // ----------------------------------------------------------------

        // �̹��� ���� (���� ��� ��Ȱ��ȭ)
        if (ThumbnailTexture != null)
        {
            Thumbnail.texture = ThumbnailTexture;
            Thumbnail.gameObject.SetActive(true);

            // ũ�⸦ ���� �ؽ�ó�� �°� ����
            Thumbnail.rectTransform.sizeDelta = new Vector2(ThumbnailTexture.width, ThumbnailTexture.height);

            // ���� ���� ����
            AspectRatioFitter fitter = Thumbnail.GetComponent<AspectRatioFitter>();
            if (fitter != null)
            {
                fitter.aspectMode = AspectRatioFitter.AspectMode.FitInParent;
                fitter.aspectRatio = (float)ThumbnailTexture.width / ThumbnailTexture.height;
            }
            else
            {
                Debug.LogWarning("AspectRatioFitter�� RawImage�� �پ����� ����!");
            }
        }
        else
        {
            Thumbnail.gameObject.SetActive(false); // �̹����� ������ ����
        }
    }

    public void ShowUI()
    {
        gameObject.SetActive(true);
    }

    public void HideUI()
    {
        gameObject.SetActive(false);
    }
}
