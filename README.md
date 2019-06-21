# RotativaPrintPDF
使用Rotativa打印/下载PDF


## 可适用的业务场景
* 合同生成

* 在线预览PDF

* 将动态html生成PDF或者图片


## 来历

一个asp.net mvc 的项目，在找下载PDF插件的时候，在huget 上面看到了一个叫 Rotativa 的东西 （nuget链接：https://www.nuget.org/packages/Rotativa/1.7.4-rc）。

比较尴尬的是，该插件对asp.net mvc  的版本有要求，刚好我自己项目.net framework的版本是4.5.2 asp.net mvc 版本是 4.0.20710  它就不支持，奇葩的是mvc 3  和 mvc 5  它都支持，甚至连最新的.net core 都支持。该项目在github也开源了，地址为：https://github.com/webgio/Rotativa

于是我下载Rotativa的源代码，将项目的.net framework 版本降级到了
