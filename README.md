# FontAwesomeNet
Font-Awesome-4.7.0 for Windows Forms and WPF

[![Build status](https://ci.appveyor.com/api/projects/status/7ys5urml957liad5?svg=true)](https://ci.appveyor.com/project/seayxu/fontawesome)

![sample application][sample]

# 开发环境

Windows 10 + Visual Studio 2013 + .NetFramework 3.5

# 功能

* 生成图片和 Icon 图标

# 示例

1. 安装 Font-Awesome-4.7.0 字体：[fontawesome-webfont-4.7.0.ttf][fontdl]，官网是：http://fontawesome.io 。

2. 添加 FontAwesomeNet 引用。

3. 使用

``` cs
// defalut:
Bitmap bmp = FontAwesome.GetImage(0xf188);
Icon ico = FontAwesome.GetIcon(0xf188);
//custom:
FontAwesome.IconSize = 128;//change icon size
FontAwesome.ForeColer = Color.Purple;//change icon forecolor
Bitmap bmp = FontAwesome.GetImage(0xf188);
Icon ico = FontAwesome.GetIcon(0xf188);
```

# 协议

[MIT License](https://github.com/seayxu/FontAwesome/blob/master/LICENSE)

*如有问题,欢迎指出*

[sample]:./assets/sample.jpg
[fontdl]:https://github.com/FortAwesome/Font-Awesome/raw/v4.7.0/fonts/fontawesome-webfont.ttf