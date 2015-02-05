# Unity3DRuntimeDebug

#运行时调试信息
  RuntimeDebug可以在安卓，iOS等所有平台应用运行时显示调试信息。(Unity3D RuntimeDebug can show debug information in Android , iOS , and all of the platform.)

### 如果你想要使用它就必须进行初始化。(If you want to use it , you must init it like this.)
    Reporter.Init();

### 如何显示调试信息画面？(How to show the debug ui panel)
    用手指或者鼠标在屏幕上旋转n圈就可以调出调试画面(You need to put your finger on the screen and move around and move around and move around , then it will be show.)
    为什么是n圈呢？为了排除不是项目中其他操作而误被调的。(Why must to move around so much times? Because it must to sure it is not for other operation.)

扩展功能
----------------
### 它还可以显示自定义的调试信息，像玩家Id或名字等。(It have debug information can show in reporter like player Id or player name.)
    你需要继承ReporterMessageReceiver，它有4个事件可以重载。(you need inheritance ReporterMessageReceiver. It have 4 events , so if you want to use you can override it.)
    void OnPreStart()
    void OnHideReporter()
    void OnShowReporter()
    void OnLog( Reporter.Log log )

### 在ReporterMessageReceiver里，有一个reporter实例引用，你可以使用它来设置调试信息。(In the ReporterMessageReceiver, it have reporter instance. You can use it to set debug information.)
    reporter.UserData = "Put user date here like his account to know which user is playing on this device"

![github](https://github.com/luzexi/Unity3DRuntimeDebug/blob/master/demoImg.jpg "img")

Welcome to my blog : http://www.luzexi.com
