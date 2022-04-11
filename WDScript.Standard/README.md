<a id="markdown-markdown-header-目录" name="markdown-header-目录"></a>
# 目录
<!-- TOC -->

- [目录](#markdown-header-目录)
- [什么是 WDScript](#markdown-header-什么是-wdscript)

<!-- /TOC -->

<a id="markdown-markdown-header-什么是-wdscript" name="markdown-header-什么是-wdscript"></a>
# 什么是 WDScript
WDScript 是一个简洁的脚本语言, 混合解释和编译型, 提供跨平台的统一能力, 支持面向对象的设计模式



# 基础对象
WDScript 规定了一种基础类, 即 `Object` 类, 所有类均默认派生自此类

同时规定了六种主要类, 分别是 `Integer` , `Float` , `String` , `List` , `Expression` , `Action`

即整形类, 浮点类, 字符串类, 列表类, 表达式类, 行动语句类

# 运行原理及基础规定
## 关于标识符
所有的变量常量名, 类名, 函数名都属于标识符

标识符允许包含大小写英文字母, 数字, 下划线以及 Utf-8 编码字符


## 关于语句
语句是解释器直接操作的对象, 有几种类型
* Action.Assign : 赋值语句
* Action.FuncCall : 函数调用


