using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows;

namespace WpfApplication1
{
    class CategortItemControl
    {
        private StackPanel _rootPanel = new StackPanel();
        private Label _contentLabel = new Label();
        private Image _separationLine = new Image();
        private string _categoryContent = string.Empty;
        public static readonly DependencyProperty CategortContentProperty = DependencyProperty.Register
            ("CategortContent", typeof(string), typeof(CategortItemControl));
        public string CategortContent
        {
            get;
            set;
        }
        public CategortItemControl()
        {
            this._rootPanel.Orientation = Orientation.Vertical;
            this._rootPanel.Children.Add(_contentLabel);
            this._rootPanel.Children.Add(_separationLine);
            Binding binding = new Binding();
            binding.Path = new PropertyPath(CategortContentProperty);
            binding.Source = this;
            _contentLabel.SetBinding(Label.ContentProperty, binding);
        }
    }
}
