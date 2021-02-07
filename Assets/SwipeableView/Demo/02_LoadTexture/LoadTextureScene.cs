using System.Linq;
using UnityEngine;

namespace SwipeableView
{
    public class LoadTextureScene : MonoBehaviour
    {
        [SerializeField]
        private UISwipeableViewLoadTexture swipeableView = default;

        private static readonly string[] _imageUrls =
        {
            "https://cdn.discordapp.com/attachments/732405970692735066/807839120331636796/terrabellalogoq.PNG",
            "https://cdn.discordapp.com/attachments/732405970692735066/807843568534290432/unknown.png",
            "https://cdn.discordapp.com/attachments/732405970692735066/807842554707705896/secondfarm.PNG",
            "https://cdn.discordapp.com/attachments/732405970692735066/807844172761268244/unknown.png",
            "https://cdn.discordapp.com/attachments/732405970692735066/807846212845699152/unknown.png",
        };

        void Start()
        {
            var data = _imageUrls
                .Select(imageUrl => new LoadTextureCardData
                {
                    url = imageUrl
                })
                .ToList();

            swipeableView.UpdateData(data);
        }

        public void OnClickLike()
        {
            if (swipeableView.IsAutoSwiping) return;
            swipeableView.AutoSwipe(SwipeDirection.Right);
        }

        public void OnClickNope()
        {
            if (swipeableView.IsAutoSwiping) return;
            swipeableView.AutoSwipe(SwipeDirection.Left);
        }
    }
}