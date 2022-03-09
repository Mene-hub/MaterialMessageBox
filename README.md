# MaterialMessageBox

### MaterialMessageBox works on .Net Core and .Net Framework

# How it works?

### **add it in you project**

1. this Library works with MaterialDesign, so you need to install [THIS](https://www.nuget.org/packages/MaterialDesignThemes/4.4.0-ci94) package from NuGet
2. download the .dll file from the releases ([direct download](https://github.com/Mene-hub/MaterialMessageBox/releases/download/library/CusomMessageBox.dll))
3. open your project in VisualStudio and add it as a reference ([how to do it](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-create-and-remove-project-dependencies?view=vs-2022))
4. `using CusomMessageBox;`

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

H**ow use it**

`MaterialMessageBox` will use the same Theme you chosed in `App.xaml`

![untitled](https://user-images.githubusercontent.com/72011313/157473461-247b3060-d935-4919-a152-b556bb189aff.png)


`MaterialMessageBox` has only one Method with more signatures

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
![Untitled 1](https://user-images.githubusercontent.com/72011313/157473490-b626ec04-de8c-4f23-8bf8-bc64f21fd634.png)

