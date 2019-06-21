# RotativaPrintPDF
使用Rotativa打印/下载PDF


## 可适用的业务场景
* 合同生成

* 在线预览PDF

* 将动态html生成PDF或者图片


## 来历

一个asp.net mvc 的项目，在找下载PDF插件的时候，在nuget 上面看到了一个叫 Rotativa 的东西 （nuget链接：https://www.nuget.org/packages/Rotativa/1.7.4-rc）。

比较尴尬的是，该插件对asp.net mvc  的版本有要求，刚好我自己项目.net framework的版本是4.5.2 并且 asp.net mvc 版本是 4.0.20710 。 Rotativa就不支持，奇葩的是mvc 3  和 mvc 5  它都支持，甚至连最新的.net core 都支持。该项目在github也开源了，地址为：https://github.com/webgio/Rotativa

于是我下载Rotativa的源代码，将项目的.net framework 版本降级到了4.5.2  同时引用的mvc 版本也改成了4.0.20710 。 然后重新编译运行， 居然可以正常的编译通过，简单写了一个demo  居然可以正常下载。

最后， 将这个编译后的dll 单独引用到了我的项目中。


## 使用方法

* 引入Rotativa.dll   ，  将Rotativa需要的插件放到根目录的Rotativa文件夹中。
* RotativaDemoController中的DownloadPDF这个action 为和业务交互的Action，由业务方调用，DownloadPDF再调用实际需要打印和下载的视图PdfTemplate，具体的内容在PdfTemplate中生成。
* 需要注意的是  return new Rotativa.RouteAsPdf("Pdf", new { orderId = orderId }) { FileName = "pdfFileName.pdf" };   实际上是发起了一个对PdfTemplate这个Action 的一个请求，所以在DownloadPDF中可以获取到客户端浏览器的Cookie信息，而在PdfTemplate中确不可以。
* 同理，若在PdfTemplate中需要返回给View 的  model  中需要当前登录的sessin 中的信息的时候，需要提前在DownloadPDF中获取，以请求参数的形式传递到PdfTemplate中。
* 我尝试过在DownloadPDF中获取所有我需要在PdfTemplate视图中显示的内容，组装成一个实体对象，然后序列化为字符串传递给PdfTemplate， 可是失败了，提示找不到该路由。

