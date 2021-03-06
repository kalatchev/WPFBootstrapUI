﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WPFBootstrapUI.Controls
{
    [TemplatePart(Name = "Container", Type = typeof(Grid))]
    [TemplatePart(Name = "OutterBorder", Type = typeof(Border))]
    [TemplatePart(Name = "InnerBorder", Type = typeof(Border))]
    [TemplatePart(Name = "Popup", Type = typeof(Popup))]
    [TemplatePart(Name = "PopupContainer", Type = typeof(Grid))]
    public class PopOver : ButtonBase
    {
        private const string PopupName = "Popup";

        private Popup _popup;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _popup = GetTemplateChild(PopupName) as Popup;
        }

        protected override void OnClick()
        {
            base.OnClick();

            IsClicked ^= true;
        }
        
        public string PopOverText
        {
            get { return (string)GetValue(PopOverTextProperty); }
            set { SetValue(PopOverTextProperty, value); }
        }
        public static readonly DependencyProperty PopOverTextProperty =
            DependencyProperty.Register("PopOverText", typeof(string), typeof(PopOver), new PropertyMetadata(string.Empty));


        public PlacementMode PopupPlacement
        {
            get { return (PlacementMode)GetValue(PopupPlacementProperty); }
            set { SetValue(PopupPlacementProperty, value); }
        }
                public static readonly DependencyProperty PopupPlacementProperty =
            DependencyProperty.Register("PopupPlacement", typeof(PlacementMode), typeof(PopOver), new PropertyMetadata(PlacementMode.Bottom));

        public bool IsClicked
        {
            get { return (bool)GetValue(IsClickedProperty); }
            set { SetValue(IsClickedProperty, value); }
        }

        public static readonly DependencyProperty IsClickedProperty =
            DependencyProperty.Register("IsClicked", typeof(bool), typeof(PopOver), new PropertyMetadata(false));
    }
}
