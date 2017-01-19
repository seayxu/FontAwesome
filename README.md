# FontAwesomeNet
Font-Awesome-4.7.0 for Windows Forms and WPF

[![AppVeyor build status](https://img.shields.io/appveyor/ci/seayxu/fontawesome.svg?label=appveyor&style=flat-square)](https://ci.appveyor.com/project/seayxu/fontawesome/) [![NuGet](https://img.shields.io/nuget/v/FontAwesomeNet.svg?label=nuget&style=flat-square)](https://www.nuget.org/packages/FontAwesomeNet/) [![MyGet](https://img.shields.io/myget/seay/v/FontAwesomeNet.svg?label=myget&style=flat-square)](https://www.myget.org/Package/Details/seay?packageType=nuget&packageId=FontAwesomeNet)

![sample application][sample]

# 开发环境

Windows 10 + Visual Studio 2013 + .NetFramework 3.5

# 功能

* 将 FontAwesome 图标生成图片和 Icon 图标

# 使用

> 可以在 Windows Forms 和 WPF 程序中使用。

1. 安装 Font-Awesome-4.7.0 字体：[fontawesome-webfont-4.7.0.ttf][fontdl]，官网是：[http://fontawesome.io][fa] 。

2. 添加 FontAwesomeNet 引用，命名空间是：**FontAwesomeNet**。

3. 示例

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