using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Unmask_InfoUIManager : MonoBehaviour
{
    public TMP_Text NumberText;
    public TMP_Text ComposerNameText;
    public TMP_Text GenreText;
    public TMP_Text SongTitleText;
    public TMP_Text MissionsText;
    public RawImage Thumbnail;
    public RawImage IdentityImage;

    public void UpdateSongInfo
        (int songNumber, string ComposerName, string Genre, string SongTitle, string Missions,
        Texture2D ThumbnailTexture, Texture2D identityTexture)
    {
        // UI �ؽ�Ʈ�� �� ����, ����� ������ �� ���⼭!
        // ----------------------------------------------------------------
        NumberText.text = $"������ȣ {songNumber}��";
        ComposerNameText.text = $"{ComposerName}";
        GenreText.text = $"[{Genre}]";
        SongTitleText.text = $"{SongTitle}";
        MissionsText.text = $"�̼� : {Missions}";
        // ----------------------------------------------------------------

        // ����� �̹��� ���� (���� ��� ��Ȱ��ȭ)
        if (ThumbnailTexture != null)
        {
            Thumbnail.texture = ThumbnailTexture;
            Thumbnail.color = Color.white;

            // ũ�⸦ ���� �ؽ�ó�� �°� ����
            Thumbnail.rectTransform.sizeDelta = new Vector2(ThumbnailTexture.width, ThumbnailTexture.height);

            // ���� ����� AspectRatioFitter ����
            AspectRatioFitter Thumbnailfitter = Thumbnail.GetComponent<AspectRatioFitter>();
            if (Thumbnailfitter != null)
            {
                Thumbnailfitter.aspectMode = AspectRatioFitter.AspectMode.FitInParent;
                Thumbnailfitter.aspectRatio = (float)ThumbnailTexture.width / ThumbnailTexture.height;
            }
            else
            {
                Debug.LogWarning("AspectRatioFitter�� RawImage�� �پ����� ����!");
            }
        }
        else
        {
            Thumbnail.texture = null;
            Thumbnail.color = new Color(1, 1, 1, 0); // ���� ó��
        }

        //����� �̹��� ���� (���� ��� ��Ȱ��ȭ)
        if (identityTexture != null)
        {
            IdentityImage.texture = identityTexture;
            IdentityImage.color = Color.white;

            // ���� ����� AspectRatioFitter ����
            AspectRatioFitter IdentityFitter = IdentityImage.GetComponent<AspectRatioFitter>();
            if (IdentityFitter != null)
            {
                IdentityFitter.aspectMode = AspectRatioFitter.AspectMode.FitInParent;
                IdentityFitter.aspectRatio = (float)identityTexture.width / identityTexture.height;
            }
            else
            {
                Debug.LogWarning("AspectRatioFitter�� IdentityImage�� �پ����� ����!");
            }
        }
        else
        {
            IdentityImage.texture = null;
            IdentityImage.color = new Color(1, 1, 1, 0); // ����ó��
        }
    }
}
