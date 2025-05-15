using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Prod_InfoUIManager : MonoBehaviour
{
    public TMP_Text NumberText;
    public TMP_Text ComposerNameText;
    public TMP_Text GenreText;
    public TMP_Text MissionsText;
    public TMP_Text CommentsText;
    public RawImage Thumbnail;

    public void UpdateSongInfo
        (int songNumber, string ComposerName, string Genre, string Missions, string Comment,
        Texture2D ThumbnailTexture)
    {
        // UI �ؽ�Ʈ�� �� ����, ����� ������ �� ���⼭!
        // ----------------------------------------------------------------
        NumberText.text = $"������ȣ {songNumber}��";
        ComposerNameText.text = $": {ComposerName}";
        GenreText.text = $"{Genre} �ι�";
        MissionsText.text = $"�̼� : {Missions}";
        CommentsText.text = $"���� �� ���� : \n{Comment}";
        // ----------------------------------------------------------------

        // �̹��� ���� (���� ��� ��Ȱ��ȭ)
        if (ThumbnailTexture != null)
        {
            Thumbnail.texture = ThumbnailTexture;
            Thumbnail.gameObject.SetActive(true);

            // ũ�⸦ ���� �ؽ�ó�� �°� ����
            Thumbnail.rectTransform.sizeDelta = new Vector2(ThumbnailTexture.width, ThumbnailTexture.height);

            // ���� ����� AspectRatioFitter ����
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
}
