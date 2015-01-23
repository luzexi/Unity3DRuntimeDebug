# Unity3DRuntimeDebug
Unity3D RuntimeDebug can show debug information in Android , iOS , and all of the platform.
RuntimeDebug可以在安卓，iOS等所有平台应用运行时显示调试信息。

#If you want to use it , you must init it like this.
#如果你想要使用它就必须进行初始化。
Reporter.Init();

#It have debug information can show in reporter like player Id or player name.
#它还可以显示自定义的吊事信息，像玩家Id或名字等。
you need inheritance ReporterMessageReceiver. It have 4 events , so if you want to use you can override it.
你需要继承ReporterMessageReceiver，它有4个时间可以重写。
-void OnPreStart()
-void OnHideReporter()
-void OnShowReporter()
-OnLog( Reporter.Log log )

In the ReporterMessageReceiver, it have reporter instance. You can use it to set debug information.
在ReporterMessageReceiver里，有一个reporter实例引用，你可以使用它来设置调试信息。
reporter.UserData = "Put user date here like his account to know which user is playing on this device"

