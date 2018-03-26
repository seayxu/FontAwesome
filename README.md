# FontAwesomeNet
Font-Awesome for .NET(Windows Forms and WPF)

[![AppVeyor build status](https://img.shields.io/appveyor/ci/seayxu/fontawesome.svg?label=appveyor&style=flat-square)](https://ci.appveyor.com/project/seayxu/fontawesome/) [![NuGet](https://img.shields.io/nuget/v/FontAwesomeNet.svg?label=nuget&style=flat-square)](https://www.nuget.org/packages/FontAwesomeNet/) [![MyGet](https://img.shields.io/myget/seay/v/FontAwesomeNet.svg?label=myget&style=flat-square)](https://www.myget.org/Package/Details/seay?packageType=nuget&packageId=FontAwesomeNet)
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fseayxu%2FFontAwesome.svg?type=shield)](https://app.fossa.io/projects/git%2Bgithub.com%2Fseayxu%2FFontAwesome?ref=badge_shield)

![sample application][sample]

# 开发环境

Windows 10 + Visual Studio 2013 + .NetFramework 3.5

# 功能

* 将 FontAwesome 图标生成图片和 Icon 图标

# 使用

> 可以在 Windows Forms 和 WPF 程序中使用。

- 添加类库，可以通过 nuget 安装。
```
PM Install-Package FontAwesomeNet
```

- 添加 FontAwesomeNet 命名空间：**FontAwesomeNet**。

- 示例

``` cs
// get FontAwesome icon class names(type is Dictionary<string, int>)
string[] names = FontAwesome.TypeDict.Select(v => v.Key).ToArray();

// use FontAwesome icon class name get FontAwesome icon Unicode value
int val = FontAwesome.TypeDict["fa-heart"];//0xf004

// defalut:
Bitmap bmp = FontAwesome.GetImage(val);//0xf004
Icon ico = FontAwesome.GetIcon(val);//0xf004

// custom:
FontAwesome.IconSize = 128;//change icon size
FontAwesome.ForeColer = Color.Purple;//change icon forecolor
Bitmap bmp = FontAwesome.GetImage(val);//0xf004
Icon ico = FontAwesome.GetIcon(val);//0xf004
```

# 协议

[MIT License](https://github.com/seayxu/FontAwesome/blob/master/LICENSE)

*如有问题，欢迎指出。*

[fa]:http://fontawesome.io
[sample]:https://github.com/seayxu/FontAwesome/raw/master/assets/sample.jpg
[fontdl]:https://github.com/FortAwesome/Font-Awesome/raw/v4.7.0/fonts/fontawesome-webfont.ttf

## License
[![FOSSA Status](https://app.fossa.io/api/projects/git%2Bgithub.com%2Fseayxu%2FFontAwesome.svg?type=large)](https://app.fossa.io/projects/git%2Bgithub.com%2Fseayxu%2FFontAwesome?ref=badge_large)