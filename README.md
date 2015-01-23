# Unity3DRuntimeDebug

#运行时调试信息
  RuntimeDebug可以在安卓，iOS等所有平台应用运行时显示调试信息。(Unity3D RuntimeDebug can show debug information in Android , iOS , and all of the platform.)

#如果你想要使用它就必须进行初始化。(If you want to use it , you must init it like this.)
  Reporter.Init();

#它还可以显示自定义的吊事信息，像玩家Id或名字等。(It have debug information can show in reporter like player Id or player name.)
  你需要继承ReporterMessageReceiver，它有4个时间可以重写。(you need inheritance ReporterMessageReceiver. It have 4 events , so if you want to use you can override it.)
  void OnPreStart()
  void OnHideReporter()
  void OnShowReporter()
  OnLog( Reporter.Log log )

#在ReporterMessageReceiver里，有一个reporter实例引用，你可以使用它来设置调试信息。(In the ReporterMessageReceiver, it have        reporter instance. You can use it to set debug information.)
  reporter.UserData = "Put user date here like his account to know which user is playing on this device"

![github](https://github.com/luzexi/Unity3DRuntimeDebug/blob/master/demoImg.png "img")
