# MaterialMessageBox

### MaterialMessageBox works on .Net Core and .Net Framework

# How it works?

### **add it in you project**

1. this Library works with MaterialDesign, so you need to install [THIS](https://www.nuget.org/packages/MaterialDesignThemes/4.4.0-ci94) package from NuGet
2. download the .dll file from the releases ([direct download](https://github.com/Mene-hub/MaterialMessageBox/releases/download/library/CusomMessageBox.dll))
3. open your project in VisualStudio and add it as a reference ([how to do it](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-create-and-remove-project-dependencies?view=vs-2022))
4. `usingCustomMessageBox;`

### **Documentation**

```csharp
//for a custom message
public static MessageBoxResult Show(string messageBoxText);

//for a custom message and custom title
public static MessageBoxResult Show(string messageBoxText, string caption);

//for a custom message, title and MaterialDesign button
public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button);

//for a custom message, title, MaterialDesign button and a custom icons
public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon);

//for a custom message, title, MaterialDesign button, custom icons and default result when you close the Box
public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult);
```

**MessageBoxButton**

all supported buttons type:

- `MessageBoxButton.OK;`
- `MessageBoxButton.OKCancel;`
- `MessageBoxButton.YesNo;`
- `MessageBoxButton.YesNoCancel;`

**MessageBoxIcon**

all supported Icons type:

- `MessageBoxImage.Error;`
- `MessageBoxImage.Information;`
- `MessageBoxImage.Question;`
- `MessageBoxImage.Warning;`
- `MessageBoxImage.None;`

**MessageBoxResult**

all supported Result type:

- `MessageBoxResult.OK;`
- `MessageBoxResult.Cancel;`
- `MessageBoxResult.Yes;`
- `MessageBoxResult.No;`
- `MessageBoxResult.None;`

**How use it**

`MaterialMessageBox` will use the same Theme you chosed in `App.xaml`

```xml
<Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.dark.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.DeepPurple.xaml" />
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
```

`MaterialMessageBox` `.Show()` method

**some exaples**

```csharp
MaterialMessageBox.Show("Some Text", "Costum Title", MessageBoxButton.YesNoCancel, MessageBoxImage.Information);

MaterialMessageBox.Show("Other text", "my title", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

if(MaterialMessageBox.Show(obj.ToString(), "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
{
	MaterialMessageBox.Show(man.name, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
}

MaterialMessageBox.Show(e.message, "Message", MessageBoxButton.OK, MessageBoxImage.None, MessageBoxResult.OK);
```

![image](https://user-images.githubusercontent.com/72011313/157635155-7344b643-8fef-4d6a-a372-54cfd19c2f7f.png)

### costumized Buttons, Box background and Box foreground

**color proprieties**

```csharp
//for change the Box background color
public static Color backgroundColor;

//for change the Box text color
public static Color foregroundColor;

//for change the background color of any different buttons
public static Color OKButtonColor;
public static Color CancelButtonColor;
public static Color NoButtonColor;
public static Color YesButtonColor;

//for change the text color of any different buttons
public static Color OKButtonForegroundColor;
public static Color CancelButtonForegroundColor;
public static Color NoButtonForegroundColor;
public static Color YesButtonForegroundColor;

//for change the color of the visible icon
public static Color iconColor;
```

**color methods**

```csharp
//for reset allBox colors
public static void resercolors();

//for reset only one color, this works with all propreties
MaterialMessageBox.OKButtonColor = new Color();
```

**how to set colors**

```csharp
//from Hex color
MaterialMessageBox.YesButtonColor = (Color)ColorConverter.ConvertFromString(string HexCode);

//from red greem and blue value
MaterialMessageBox.NoButtonColor = Color.fromRgb(byte r, byte g, byte b);
```

**example**

```csharp
MaterialMessageBox.OKButtonColor = (Color)ColorConverter.ConvertFromString("#00CE52");
MaterialMessageBox.YesButtonColor = (Color)ColorConverter.ConvertFromString("#00CE52");
MaterialMessageBox.NoButtonColor = (Color)ColorConverter.ConvertFromString("#00CE52");
MaterialMessageBox.CancelButtonColor = (Color)ColorConverter.ConvertFromString("#00CE52");
MaterialMessageBox.iconColor = (Color)ColorConverter.ConvertFromString("#00AB44");
MaterialMessageBox.backgroundColor = (Color)ColorConverter.ConvertFromString("#ffffff");
MaterialMessageBox.foregroundColor = (Color)ColorConverter.ConvertFromString("#000000");
```
