using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Layout;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Rendering.Composition;
using Avalonia.Rendering.Composition.Animations;
using Avalonia.VisualTree;

using PanelExntension.Avalonia;

using System;
using System.Collections.Generic;

namespace AvaloniaSample;

public partial class MainWindow : Window
{
    private readonly HorizontalGridLayout _layout;

    public MainWindow()
    {
        InitializeComponent();
        repeater.Layout = _layout = new HorizontalGridLayout()
        {
            MinItemWidth = 240,
            RowSpacing = 8,
            ColumnSpacing = 8,
        };

        repeater.Items = CreateColorItems();

        combobox.GetObservable(SelectingItemsControl.SelectedIndexProperty)
            .Subscribe(OnComboBoxSelectedIndexChanged);
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void OnComboBoxSelectedIndexChanged(int obj)
    {
        //switch (obj)
        //{
        //    case 0:
        //        _layout.Orientation = Orientation.Horizontal;
        //        break;
        //    case 1:
        //        _layout.Orientation = Orientation.Vertical;
        //        break;
        //    default:
        //        break;
        //}
    }

    private List<ColorItem> CreateColorItems()
    {
        var list = new List<ColorItem>();

        list.Add(new ColorItem(Color.FromArgb(255, 255, 185, 0)));
        list.Add(new ColorItem(Color.FromArgb(255, 231, 72, 86)));
        list.Add(new ColorItem(Color.FromArgb(255, 0, 120, 215)));
        list.Add(new ColorItem(Color.FromArgb(255, 0, 153, 188)));
        list.Add(new ColorItem(Color.FromArgb(255, 122, 117, 116)));
        list.Add(new ColorItem(Color.FromArgb(255, 118, 118, 118)));
        list.Add(new ColorItem(Color.FromArgb(255, 255, 141, 0)));
        list.Add(new ColorItem(Color.FromArgb(255, 232, 17, 35)));
        list.Add(new ColorItem(Color.FromArgb(255, 0, 99, 177)));
        list.Add(new ColorItem(Color.FromArgb(255, 45, 125, 154)));
        list.Add(new ColorItem(Color.FromArgb(255, 93, 90, 88)));
        list.Add(new ColorItem(Color.FromArgb(255, 76, 74, 72)));
        list.Add(new ColorItem(Color.FromArgb(255, 247, 99, 12)));
        list.Add(new ColorItem(Color.FromArgb(255, 234, 0, 94)));
        list.Add(new ColorItem(Color.FromArgb(255, 142, 140, 216)));
        list.Add(new ColorItem(Color.FromArgb(255, 0, 183, 195)));
        list.Add(new ColorItem(Color.FromArgb(255, 104, 118, 138)));
        list.Add(new ColorItem(Color.FromArgb(255, 105, 121, 126)));
        list.Add(new ColorItem(Color.FromArgb(255, 202, 80, 16)));
        list.Add(new ColorItem(Color.FromArgb(255, 195, 0, 82)));
        list.Add(new ColorItem(Color.FromArgb(255, 107, 105, 214)));
        list.Add(new ColorItem(Color.FromArgb(255, 3, 131, 135)));
        list.Add(new ColorItem(Color.FromArgb(255, 81, 92, 107)));
        list.Add(new ColorItem(Color.FromArgb(255, 74, 84, 89)));
        list.Add(new ColorItem(Color.FromArgb(255, 218, 59, 1)));
        list.Add(new ColorItem(Color.FromArgb(255, 227, 0, 140)));
        list.Add(new ColorItem(Color.FromArgb(255, 135, 100, 184)));
        list.Add(new ColorItem(Color.FromArgb(255, 0, 178, 148)));
        list.Add(new ColorItem(Color.FromArgb(255, 86, 124, 115)));
        list.Add(new ColorItem(Color.FromArgb(255, 100, 124, 100)));
        list.Add(new ColorItem(Color.FromArgb(255, 239, 105, 80)));
        list.Add(new ColorItem(Color.FromArgb(255, 191, 0, 119)));
        list.Add(new ColorItem(Color.FromArgb(255, 116, 77, 169)));
        list.Add(new ColorItem(Color.FromArgb(255, 1, 133, 116)));
        list.Add(new ColorItem(Color.FromArgb(255, 72, 104, 96)));
        list.Add(new ColorItem(Color.FromArgb(255, 82, 94, 84)));
        list.Add(new ColorItem(Color.FromArgb(255, 209, 52, 56)));
        list.Add(new ColorItem(Color.FromArgb(255, 194, 57, 179)));
        list.Add(new ColorItem(Color.FromArgb(255, 177, 70, 194)));
        list.Add(new ColorItem(Color.FromArgb(255, 0, 204, 106)));
        list.Add(new ColorItem(Color.FromArgb(255, 73, 130, 5)));
        list.Add(new ColorItem(Color.FromArgb(255, 132, 117, 69)));
        list.Add(new ColorItem(Color.FromArgb(255, 255, 67, 67)));
        list.Add(new ColorItem(Color.FromArgb(255, 154, 0, 137)));
        list.Add(new ColorItem(Color.FromArgb(255, 136, 23, 152)));
        list.Add(new ColorItem(Color.FromArgb(255, 16, 137, 62)));
        list.Add(new ColorItem(Color.FromArgb(255, 16, 124, 16)));
        list.Add(new ColorItem(Color.FromArgb(255, 126, 115, 95)));

        return list;
    }
}

public class ColorItem
{
    public Color Color { get; private set; }

    public SolidColorBrush ColorBrush
    {
        get { return new SolidColorBrush(Color); }
    }

    public string ColorHexValue
    {
        get { return Color.ToString().Substring(3).ToUpperInvariant(); }
    }

    public ColorItem(Color color)
    {
        Color = color;
    }
}