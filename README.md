# MaterialMessageBox

### MaterialMessageBox works on .Net Core and .Net Framework

# How it works?

### **add it in you project**

1. this Library works with MaterialDesign, so you need to install [THIS](https://www.nuget.org/packages/MaterialDesignThemes/4.4.0-ci94) package from NuGet
2. download the .dll file from the releases ([direct download](https://github.com/Mene-hub/MaterialMessageBox/releases/download/library/CusomMessageBox.dll))
3. open your project in VisualStudio and add it as a reference ([how to do it](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-create-and-remove-project-dependencies?view=vs-2022))
4. `using CustomMessageBox;`

### **Documentation**

```csharp
//style setter for MessageBox
public static MessageBoxStyle Style;

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
                <ResourceDictionary Source="pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.**dark**.xaml" />
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

### costumized Buttons, Box background and Box foreground

**MessageBoxStyle properties**

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

//for change the buttons position
public HorizontalAlignment buttonsAlignment;
```

**MessageBoxStyle methods**

```csharp
//empty constructor
public MessageBoxStyle();

//contractor with default style
public MessageBoxStyle(DefaultBoxStyle style);

//for set the default value for that component
MaterialMessageBox.OKButtonColor = new Color();
```

**DefaultBoxStyle** `enum`

- `Default`
- `lightDark`
- `allWhite`

```csharp
public enum DefaultBoxStyle
{
	Default,
	lightDark,
	allWhite
}
```

**how to use it**

```csharp
MessageBoxStyle myStyle = new MessageBoxStyle();
//or
MessageBoxStyle myDefaultStyle = new MessageBoxStyle(DefaultBoxStyle.Default);

//from Hex Value
myStyle.YesButtonColor = (Color)ColorConverter.ConvertFromString(string HexCode);

//from red green and blue value
myStyle.NoButtonColor = Color.fromRgb(byte r, byte g, byte b);

//for set the button alignment
myStyle.buttonsAlignment = HorizontalAlignment.Right;

//for set the MessageBox Style
MaterialMessageBox.Style = myStyle;
```

**examples**

```csharp
MessageBoxStyle myStyle = new MessageBoxStyle();

myStyle.backgroundColor = Color.fromRgb(255, 255, 255);
myStyle.foregroundColor = Color.fromRgb(0, 0, 0);

myStyle.OKButtonColor = (Color)ColorConverter.ConvertFromString("#00CE52");
myStyle.YesButtonColor = (Color)ColorConverter.ConvertFromString("#00CE52");
myStyle.NoButtonColor = (Color)ColorConverter.ConvertFromString("#00CE52");
myStyle.CancelButtonColor = (Color)ColorConverter.ConvertFromString("#00CE52");

myStyle.OKButtonForegroundColor = (Color)ColorConverter.ConvertFromString("#ffffff");
myStyle.YesButtonForegroundColor = (Color)ColorConverter.ConvertFromString("#ffffff");
myStyle.NoButtonForegroundColor = (Color)ColorConverter.ConvertFromString("#ffffff");
myStyle.CancelButtonForegroundColor = (Color)ColorConverter.ConvertFromString("#ffffff");

myStyle .iconColor = (Color)ColorConverter.ConvertFromString("#00AB44");

myStyle.buttonsAlignment = HorizontalAlignment.Right;

MaterialMessageBox.Style = myStyle;
```

### Results

**Material Design** `DefaultBoxStyle.Default` *light* **Style**

![default white](https://user-images.githubusercontent.com/72011313/157749498-1bd90cc7-c4fb-4b3e-a920-350058263d4b.png)

**Material Design** `DefaultBoxStyle.Default` *dark* **Style**

![default black](https://user-images.githubusercontent.com/72011313/157749536-ef4aef24-fbea-4538-a676-9c2f004be281.png)

`faultBoxStyle.allWhite`

![allWhite](https://user-images.githubusercontent.com/72011313/157749568-edcaca18-1edc-442f-9f6e-0fb2404dad63.png)

`faultBoxStyle.lightDark`

![lightDark](https://user-images.githubusercontent.com/72011313/157749633-54312d01-903e-4b6f-9b1b-f90fba34b6e5.png)
