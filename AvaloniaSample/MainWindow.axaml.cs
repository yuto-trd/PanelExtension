using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

using PanelExntension;

using System.Collections.Generic;

namespace AvaloniaSample;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        repeater.Layout = new HorizontalGridLayout()
        {
            MinItemWidth = 240,
            RowSpacing = 8,
            ColumnSpacing = 8,
        };

        repeater.Items = CreateColorItems();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private static List<ColorItem> CreateColorItems()
    {
        var list = new List<ColorItem>
        {
            new ColorItem(Color.FromArgb(255, 255, 185, 0)),
            new ColorItem(Color.FromArgb(255, 231, 72, 86)),
            new ColorItem(Color.FromArgb(255, 0, 120, 215)),
            new ColorItem(Color.FromArgb(255, 0, 153, 188)),
            new ColorItem(Color.FromArgb(255, 122, 117, 116)),
            new ColorItem(Color.FromArgb(255, 118, 118, 118)),
            new ColorItem(Color.FromArgb(255, 255, 141, 0)),
            new ColorItem(Color.FromArgb(255, 232, 17, 35)),
            new ColorItem(Color.FromArgb(255, 0, 99, 177)),
            new ColorItem(Color.FromArgb(255, 45, 125, 154)),
            new ColorItem(Color.FromArgb(255, 93, 90, 88)),
            new ColorItem(Color.FromArgb(255, 76, 74, 72)),
            new ColorItem(Color.FromArgb(255, 247, 99, 12)),
            new ColorItem(Color.FromArgb(255, 234, 0, 94)),
            new ColorItem(Color.FromArgb(255, 142, 140, 216)),
            new ColorItem(Color.FromArgb(255, 0, 183, 195)),
            new ColorItem(Color.FromArgb(255, 104, 118, 138)),
            new ColorItem(Color.FromArgb(255, 105, 121, 126)),
            new ColorItem(Color.FromArgb(255, 202, 80, 16)),
            new ColorItem(Color.FromArgb(255, 195, 0, 82)),
            new ColorItem(Color.FromArgb(255, 107, 105, 214)),
            new ColorItem(Color.FromArgb(255, 3, 131, 135)),
            new ColorItem(Color.FromArgb(255, 81, 92, 107)),
            new ColorItem(Color.FromArgb(255, 74, 84, 89)),
            new ColorItem(Color.FromArgb(255, 218, 59, 1)),
            new ColorItem(Color.FromArgb(255, 227, 0, 140)),
            new ColorItem(Color.FromArgb(255, 135, 100, 184)),
            new ColorItem(Color.FromArgb(255, 0, 178, 148)),
            new ColorItem(Color.FromArgb(255, 86, 124, 115)),
            new ColorItem(Color.FromArgb(255, 100, 124, 100)),
            new ColorItem(Color.FromArgb(255, 239, 105, 80)),
            new ColorItem(Color.FromArgb(255, 191, 0, 119)),
            new ColorItem(Color.FromArgb(255, 116, 77, 169)),
            new ColorItem(Color.FromArgb(255, 1, 133, 116)),
            new ColorItem(Color.FromArgb(255, 72, 104, 96)),
            new ColorItem(Color.FromArgb(255, 82, 94, 84)),
            new ColorItem(Color.FromArgb(255, 209, 52, 56)),
            new ColorItem(Color.FromArgb(255, 194, 57, 179)),
            new ColorItem(Color.FromArgb(255, 177, 70, 194)),
            new ColorItem(Color.FromArgb(255, 0, 204, 106)),
            new ColorItem(Color.FromArgb(255, 73, 130, 5)),
            new ColorItem(Color.FromArgb(255, 132, 117, 69)),
            new ColorItem(Color.FromArgb(255, 255, 67, 67)),
            new ColorItem(Color.FromArgb(255, 154, 0, 137)),
            new ColorItem(Color.FromArgb(255, 136, 23, 152)),
            new ColorItem(Color.FromArgb(255, 16, 137, 62)),
            new ColorItem(Color.FromArgb(255, 16, 124, 16)),
            new ColorItem(Color.FromArgb(255, 126, 115, 95))
        };

        return list;
    }
}

public class ColorItem
{
    public Color Color { get; private set; }

    public SolidColorBrush ColorBrush => new(Color);

    public string ColorHexValue => Color.ToString()[3..].ToUpperInvariant();

    public ColorItem(Color color)
    {
        Color = color;
    }
}
