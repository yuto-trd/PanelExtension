# PanelExtension

[![Nuget](https://img.shields.io/nuget/vpre/PanelExtension?label=PanelExtension%20%28nuget%29)](https://www.nuget.org/packages/PanelExtension/)

This library adds HorizontalGridLayout, a layout that automatically wraps and stretches.
![Git](https://raw.githubusercontent.com/indigo-san/PanelExtension/main/Images/sample.gif)

## Usage
1. Download the PanelExtension package and add it to your project.
2. Set HorizontalGridLayout from C#/XAML to ItemsRepeater.Layout.
``` xaml
<!-- MainWindow.axaml -->
<ScrollViewer Grid.Row="2" HorizontalScrollBarVisibility="Disabled">
    <ItemsRepeater x:Name="repeater" Margin="8">
        <ItemsRepeater.ItemTemplate>
            <DataTemplate>
                <Border Padding="8"
                        HorizontalAlignment="Stretch"
                        Background="{Binding ColorBrush}"
                        BorderBrush="Gray"
                        BorderThickness="2">
                    <TextBlock Text="{Binding ColorHexValue}" />
                </Border>
            </DataTemplate>
        </ItemsRepeater.ItemTemplate>
    </ItemsRepeater>
</ScrollViewer>
```
``` cs
// MainWindow.axaml.cs
repeater.Layout = new HorizontalGridLayout()
{
    // Set the minimum width of the item.
    MinItemWidth = 240,
    
    // Spaces to be inserted between rows/columns
    RowSpacing = 8,
    ColumnSpacing = 8,
    
    // If you want to limit the number of columns.
    // MaxColumns = 5
};
```

**IMPORTANT:**  
If the parent element of ItemsRepeater is a ScrollViewer, then
HorizontalScrollBarVisibility property must be Disabled.
