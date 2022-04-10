<p align="center">
<pre align="center">
  /\\\              /\\\  /\\\\\\\\\\\\         /\\\\\\\\\\\                                                                       
  \/\\\             \/\\\ \/\\\////////\\\     /\\\/////////\\\                                                                    
   \/\\\             \/\\\ \/\\\      \//\\\   \//\\\      \///                              /\\\   /\\\\\\\\\     /\\\            
    \//\\\    /\\\    /\\\  \/\\\       \/\\\    \////\\\            /\\\\\\\\  /\\/\\\\\\\  \///   /\\\/////\\\ /\\\\\\\\\\\      
      \//\\\  /\\\\\  /\\\   \/\\\       \/\\\       \////\\\       /\\\//////  \/\\\/////\\\  /\\\ \/\\\\\\\\\\ \////\\\////      
        \//\\\/\\\/\\\/\\\    \/\\\       \/\\\          \////\\\   /\\\         \/\\\   \///  \/\\\ \/\\\//////     \/\\\         
          \//\\\\\\//\\\\\     \/\\\       /\\\    /\\\      \//\\\ \//\\\        \/\\\         \/\\\ \/\\\           \/\\\ /\\    
            \//\\\  \//\\\      \/\\\\\\\\\\\\/    \///\\\\\\\\\\\/   \///\\\\\\\\ \/\\\         \/\\\ \/\\\           \//\\\\\    
              \///    \///       \////////////        \///////////       \////////  \///          \///  \///             \/////    
</pre>
</p>

<p align="center">
  <a href="./LICENSE"><img src="https://img.shields.io/github/license/Catrol-org/WDScript?style=for-the-badge"></img></a>
  <a href=""><img src="https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white"></img></a>
  <a href=""><img src="https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black"></img></a>
  <a href=""><img src="https://img.shields.io/badge/mac%20os-000000?style=for-the-badge&logo=macos&logoColor=F0F0F0"></img></a>
</p>

<p align="center">
  🌐 <a href="#markdown-header-wdscript-🎉-简体中文文档">中文</a> | <a href="#markdown-header-wdscript-🎉-english-docs">English</a> 🌐
  <br>
</p>

<a id="markdown-markdown-header-toc-目录" name="markdown-header-toc-目录"></a>
# Toc 目录
<!-- TOC -->

- [Toc 目录](#markdown-header-toc-目录)
- [🎉 WDScript 简体中文文档](#markdown-header-🎉-wdscript-简体中文文档)
    - [🔰 Demo 示范 - 快速入门](#markdown-header-🔰-demo-示范-快速入门)
- [🎉 WDScript English Docs](#markdown-header-🎉-wdscript-english-docs)

<!-- /TOC -->


<a id="markdown-markdown-header-🎉-wdscript-简体中文文档" name="markdown-header-🎉-wdscript-简体中文文档"></a>
# 🎉 WDScript 简体中文文档

<a id="markdown-markdown-header-🔰-demo-示范-快速入门" name="markdown-header-🔰-demo-示范-快速入门"></a>
## 🔰 Demo 示范 - 快速入门
```js
Function Main(List<String> args){                                   ##  应用程序主入口点
    state a = 114;                                                  ##  声明一个变量并赋初值
    saved b = 514;                                                  ##  声明一个常量并赋初值

    var c = 1919;                                                   ##  声明一个变量并赋初值
    [dynamic] var d = 810;                                          ##  声明一个变量并赋初值
    [consist] var e = 666;                                          ##  声明一个常量并赋初值

    if(a + b > c, () => Console.WriteLine("a + b > c"));            ##  if(){}
    if(a + b < c, () => {                                           ##  if(){}else{}
        Console.WriteLine("a + b < c");
    }, () => {
        Console.WriteLine("a + b >= c");
    });
    if(a + b = c,                                                   ##  if(){}else if{}...
        () => Console.WriteLine("a + b = c"),
        {
            { a - b > c, () => Console.WriteLine("a - b > c") },
            { a - b < c, () => Console.WriteLine("a - b < c") }
        }
    );
    if(a + b = c,                                                   ##  if(){}else if{}...else{}
        () => Console.WriteLine("a + b = c"),
        {
            { a - b > c, () => Console.WriteLine("a - b > c") },
            { a - b < c, () => Console.WriteLine("a - b < c") }
        },
        () => Console.WriteLine("Else ...")
    );

    for(() => var i = 0, i < 10, () => ++ i, () =>                  ##  for(,,){}
        Console.WriteLine(i)
    );
    for(var i = 0, i < 10, ++ i, () =>                              ##  for(,,){}
        Console.WriteLine(i)
    );

    for(var i = 1, i < 10, ++ i, () => {
        for(var j = 1, j < 10, ++ j, () =>
            Console.Write($"{i} x {j} = {i * j}\t")
        );
        Console.WriteLine();
    });

    for(i<0:9>, () => {
        for(j<i:9>, Console.Write($"{i} x {j} = {i * j}\t"));
        Console.WriteLine();
    });

    var do_i = 0;
    do(() => ++ i, do_i < 10);                                      ##  do{}while()

    while(do_i >= 0, -- do_i);                                      ##  while(){}


}
```




<a id="markdown-markdown-header-🎉-wdscript-english-docs" name="markdown-header-🎉-wdscript-english-docs"></a>
# 🎉 WDScript English Docs



