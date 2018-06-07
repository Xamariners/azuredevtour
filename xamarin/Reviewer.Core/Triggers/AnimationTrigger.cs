using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PhotoTour.Core.Triggers
{
    public class AnimationTrigger : TriggerAction<VisualElement>
    {
        public bool IsMakeVisible { set; get; }
        public double TranslateX { set; get; }
        public double TranslateY { set; get; }
        public string EasingType { get; set; }

        protected async override void Invoke(VisualElement sender)
        {
            if (IsMakeVisible)
            {
                sender.IsVisible = true;
                sender.FadeTo(1, 250, GetEasing(EasingType));
            }
            else
            {
                sender.FadeTo(0, 300, GetEasing(EasingType));
            }

            var result = await sender.TranslateTo(TranslateX, TranslateY, Convert.ToUInt32(250), GetEasing(EasingType));

            if (!IsMakeVisible)
            {
                Task.Delay(600);
                //sender.IsVisible = false;
            }
        }

        private Easing GetEasing(string easingType)
        {
            switch (easingType)
            {
                case nameof(Easing.BounceIn):
                    return Easing.BounceIn;
                case nameof(Easing.BounceOut):
                    return Easing.BounceOut;
                case nameof(Easing.CubicIn):
                    return Easing.CubicIn;
                case nameof(Easing.CubicInOut):
                    return Easing.CubicInOut;
                case nameof(Easing.CubicOut):
                    return Easing.CubicOut;
                case nameof(Easing.Linear):
                    return Easing.Linear;
                case nameof(Easing.SinIn):
                    return Easing.SinIn;
                case nameof(Easing.SinInOut):
                    return Easing.SinInOut;
                case nameof(Easing.SinOut):
                    return Easing.SinOut;
                case nameof(Easing.SpringIn):
                    return Easing.SpringIn;
                case nameof(Easing.SpringOut):
                    return Easing.SpringOut;
            }

            return null;
        }
    }
}
