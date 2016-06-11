using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Reflection;

public class Plg
{
    internal List<string> list_plugMsg = new List<string>();
    public volatile List<Thread> list_plugThread;
    public Assembly asm;

    struct pluginParam
    {
        public int num;
        public string s_path;
    }

    public Plg()
    {

        //Запуск плагинов

        System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"plugin/");// папка с файлами 

        List<string> list_dirDll = new List<string>();

        foreach (System.IO.FileInfo file in dir.GetFiles("*.dll"))
        {
            list_dirDll.Add(file.FullName);
        }

        list_plugThread = new List<Thread>();
        pluginParam plugParamForThreads = new pluginParam();

        for (int i = 0; i < list_dirDll.Count; i++)
        {
            list_plugMsg.Add("");
            list_plugThread.Add(new Thread(PlugThread));
            plugParamForThreads.num = i;
            plugParamForThreads.s_path = list_dirDll[i];
            list_plugThread[i].Start(plugParamForThreads);
        }

    }

    private void PlugThread(object obj)
    {
		pluginParam param = new pluginParam();
		param = (pluginParam)obj;
		var pluginAssembly = Assembly.LoadFile(param.s_path);
		var pluginType = pluginAssembly.GetTypes().Where 
            (t => typeof(IPlugin.IPlugin).IsAssignableFrom(t)).Single();
		IPlugin.IPlugin plugin = 
            (IPlugin.IPlugin)pluginType.GetConstructor(new Type[0]).Invoke(null);
        plugin.MainPlug(ref list_plugMsg, param.num);
    }

}
